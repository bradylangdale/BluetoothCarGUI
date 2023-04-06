
namespace BluetoothCarGUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.serialPorts = new System.Windows.Forms.ComboBox();
            this.serialConnect = new System.Windows.Forms.Button();
            this.port = new System.Windows.Forms.Label();
            this.periodicTick = new System.Windows.Forms.Timer(this.components);
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.dataLayout = new System.Windows.Forms.TableLayoutPanel();
            this.imageDisplay = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.dataLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.InfoText;
            this.panel1.Controls.Add(this.serialPorts);
            this.panel1.Controls.Add(this.serialConnect);
            this.panel1.Controls.Add(this.port);
            this.panel1.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, -4);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 47);
            this.panel1.TabIndex = 0;
            // 
            // serialPorts
            // 
            this.serialPorts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.serialPorts.FormattingEnabled = true;
            this.serialPorts.Location = new System.Drawing.Point(68, 14);
            this.serialPorts.Name = "serialPorts";
            this.serialPorts.Size = new System.Drawing.Size(69, 22);
            this.serialPorts.TabIndex = 8;
            // 
            // serialConnect
            // 
            this.serialConnect.Location = new System.Drawing.Point(143, 14);
            this.serialConnect.Name = "serialConnect";
            this.serialConnect.Size = new System.Drawing.Size(72, 23);
            this.serialConnect.TabIndex = 1;
            this.serialConnect.Text = "Connect";
            this.serialConnect.UseVisualStyleBackColor = true;
            this.serialConnect.Click += new System.EventHandler(this.serialConnect_Click);
            // 
            // port
            // 
            this.port.AutoSize = true;
            this.port.ForeColor = System.Drawing.SystemColors.Control;
            this.port.Location = new System.Drawing.Point(3, 19);
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(59, 14);
            this.port.TabIndex = 2;
            this.port.Text = "Serial Port";
            // 
            // periodicTick
            // 
            this.periodicTick.Enabled = true;
            this.periodicTick.Interval = 500;
            this.periodicTick.Tick += new System.EventHandler(this.tick);
            // 
            // serialPort
            // 
            this.serialPort.BaudRate = 115200;
            this.serialPort.DiscardNull = true;
            this.serialPort.ReadBufferSize = 100000;
            this.serialPort.ReadTimeout = 0;
            this.serialPort.RtsEnable = true;
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.receivedData);
            // 
            // dataLayout
            // 
            this.dataLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataLayout.BackColor = System.Drawing.Color.White;
            this.dataLayout.ColumnCount = 1;
            this.dataLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.31799F));
            this.dataLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.68201F));
            this.dataLayout.Controls.Add(this.imageDisplay, 0, 0);
            this.dataLayout.Location = new System.Drawing.Point(0, 42);
            this.dataLayout.Name = "dataLayout";
            this.dataLayout.RowCount = 1;
            this.dataLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.96721F));
            this.dataLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.03279F));
            this.dataLayout.Size = new System.Drawing.Size(1067, 582);
            this.dataLayout.TabIndex = 2;
            // 
            // imageDisplay
            // 
            this.imageDisplay.BackColor = System.Drawing.Color.DimGray;
            this.dataLayout.SetColumnSpan(this.imageDisplay, 2);
            this.imageDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageDisplay.Location = new System.Drawing.Point(1, 1);
            this.imageDisplay.Margin = new System.Windows.Forms.Padding(1);
            this.imageDisplay.Name = "imageDisplay";
            this.imageDisplay.Size = new System.Drawing.Size(1065, 580);
            this.imageDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageDisplay.TabIndex = 2;
            this.imageDisplay.TabStop = false;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1065, 624);
            this.Controls.Add(this.dataLayout);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Bluetooth Car GUI";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWindow_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyUp);
            this.Leave += new System.EventHandler(this.MainWindow_Leave);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.dataLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageDisplay)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label port;
        private System.Windows.Forms.Button serialConnect;
        private System.Windows.Forms.Timer periodicTick;
        private System.Windows.Forms.ComboBox serialPorts;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.TableLayoutPanel dataLayout;
        private System.Windows.Forms.PictureBox imageDisplay;
    }
}
