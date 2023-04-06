using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.IO.Ports;
using System.Drawing;
using System.Text;

namespace BluetoothCarGUI
{
    public partial class Form1 : Form
    {
        [DllImport("DwmApi")]
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, int[] attrValue, int attrSize);

        protected override void OnHandleCreated(EventArgs e)
        {
            if (DwmSetWindowAttribute(Handle, 19, new[] { 1 }, 4) != 0)
                DwmSetWindowAttribute(Handle, 20, new[] { 1 }, 4);
        }

        int state = 0;
        int frames = 0;

        public Form1()
        {
            InitializeComponent();

            serialPort.Encoding = Encoding.GetEncoding("ISO-8859-1");
        }

        private bool updatePorts()
        {
            string[] ports = SerialPort.GetPortNames();
            for (int i = 0; i < SerialPort.GetPortNames().Length; i++)
            {
                if (!serialPorts.Items.Contains(ports[i]))
                    return true;
            }
            return false;
        }

        private void tick(object sender, EventArgs e)
        {
            if (!serialPort.IsOpen)
            {
                if (updatePorts())
                {
                    serialPorts.Items.Clear();

                    foreach (string p in SerialPort.GetPortNames())
                    {
                        serialPorts.Items.Add(p);
                    }
                }
                return;
            }
        }

        private void serialConnect_Click(object sender, EventArgs e)
        {
            if (!serialPort.IsOpen)
            {
                serialPort.PortName = serialPorts.SelectedItem.ToString();
                serialPort.Open();
                serialConnect.Text = "Disconnect";
            }
            else
            {
                serialPort.Close();
                serialConnect.Text = "Connect";
            }
        }

        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            serialPort.Close();
        }

        private void MainWindow_Leave(object sender, EventArgs e)
        {
            serialPort.Close();
        }

        string video_buf = "";
        private void receivedData(object sender, SerialDataReceivedEventArgs e)
        {
            string input = serialPort.ReadExisting();
            video_buf += input;

            if (video_buf.Contains("VFM") && video_buf.Contains("VED"))
            {
                state += 1;
                int start = video_buf.IndexOf("VFM");
                int end = video_buf.IndexOf("VED", start);
                if (end == -1)
                    return;

                string img = video_buf.Substring(start + 3, (end - start) - 3);
                video_buf = video_buf.Substring(end);

                byte[] bytes = new byte[serialPort.Encoding.GetByteCount(img)];
                bytes = serialPort.Encoding.GetBytes(img);

                try
                {
                    imageDisplay.Image = (Bitmap)(new ImageConverter()).ConvertFrom(bytes);
                    frames += 1;
                }
                catch (Exception) { Console.WriteLine("Bad jpeg packet."); }
            }

            if (video_buf.Length > 20000)
                video_buf = "";
        }

        private void keyUp(object sender, KeyEventArgs e)
        {
            serialPort.Write("s");
        }

        private void keyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    serialPort.Write("f");
                    break;
                case Keys.S:
                    serialPort.Write("b");
                    break;
                case Keys.A:
                    serialPort.Write("l");
                    break;
                case Keys.D:
                    serialPort.Write("r");
                    break;
            }
        }
    }
}