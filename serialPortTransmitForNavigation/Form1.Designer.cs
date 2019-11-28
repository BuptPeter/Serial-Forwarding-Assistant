namespace serialPortTransmitForNavigation
{
    partial class SerialPortForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cBox_handShakeCom1 = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btn_openOrCloseCom1 = new System.Windows.Forms.Button();
            this.lab_statusCom1 = new System.Windows.Forms.Label();
            this.cBox_stopBitsCom1 = new System.Windows.Forms.ComboBox();
            this.cBox_parityCom1 = new System.Windows.Forms.ComboBox();
            this.cBox_dataBitsCom1 = new System.Windows.Forms.ComboBox();
            this.cBox_baudRateCom1 = new System.Windows.Forms.ComboBox();
            this.cBox_portNameCom1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox_showCom1 = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.listBox_showCom2 = new System.Windows.Forms.ListBox();
            this.btn_OpenOrCloseTransmit = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cBox_handShakeCom2 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_openOrCloseCom2 = new System.Windows.Forms.Button();
            this.lab_statusCom2 = new System.Windows.Forms.Label();
            this.cBox_stopBitsCom2 = new System.Windows.Forms.ComboBox();
            this.cBox_parityCom2 = new System.Windows.Forms.ComboBox();
            this.cBox_dataBitsCom2 = new System.Windows.Forms.ComboBox();
            this.cBox_baudRateCom2 = new System.Windows.Forms.ComboBox();
            this.cBox_portNameCom2 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tBox_send = new System.Windows.Forms.TextBox();
            this.btn_sendToCom1 = new System.Windows.Forms.Button();
            this.btn_sendToCom2 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "端  口：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cBox_handShakeCom1);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.btn_openOrCloseCom1);
            this.groupBox1.Controls.Add(this.lab_statusCom1);
            this.groupBox1.Controls.Add(this.cBox_stopBitsCom1);
            this.groupBox1.Controls.Add(this.cBox_parityCom1);
            this.groupBox1.Controls.Add(this.cBox_dataBitsCom1);
            this.groupBox1.Controls.Add(this.cBox_baudRateCom1);
            this.groupBox1.Controls.Add(this.cBox_portNameCom1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(201, 204);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "数据接收串口1";
            // 
            // cBox_handShakeCom1
            // 
            this.cBox_handShakeCom1.FormattingEnabled = true;
            this.cBox_handShakeCom1.Items.AddRange(new object[] {
            "None",
            "XOnXOff",
            "RTS",
            "RTSXOnXOff"});
            this.cBox_handShakeCom1.Location = new System.Drawing.Point(74, 144);
            this.cBox_handShakeCom1.Name = "cBox_handShakeCom1";
            this.cBox_handShakeCom1.Size = new System.Drawing.Size(105, 20);
            this.cBox_handShakeCom1.TabIndex = 11;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(15, 147);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 12);
            this.label14.TabIndex = 10;
            this.label14.Text = "流控制：";
            // 
            // btn_openOrCloseCom1
            // 
            this.btn_openOrCloseCom1.Location = new System.Drawing.Point(104, 171);
            this.btn_openOrCloseCom1.Name = "btn_openOrCloseCom1";
            this.btn_openOrCloseCom1.Size = new System.Drawing.Size(75, 23);
            this.btn_openOrCloseCom1.TabIndex = 2;
            this.btn_openOrCloseCom1.Text = "打开串口";
            this.btn_openOrCloseCom1.UseVisualStyleBackColor = true;
            this.btn_openOrCloseCom1.Click += new System.EventHandler(this.btn_openOrCloseCom1_Click);
            // 
            // lab_statusCom1
            // 
            this.lab_statusCom1.AutoSize = true;
            this.lab_statusCom1.Location = new System.Drawing.Point(62, 176);
            this.lab_statusCom1.Name = "lab_statusCom1";
            this.lab_statusCom1.Size = new System.Drawing.Size(29, 12);
            this.lab_statusCom1.TabIndex = 2;
            this.lab_statusCom1.Text = "关闭";
            // 
            // cBox_stopBitsCom1
            // 
            this.cBox_stopBitsCom1.FormattingEnabled = true;
            this.cBox_stopBitsCom1.Items.AddRange(new object[] {
            "0",
            "1",
            "1.5",
            "2"});
            this.cBox_stopBitsCom1.Location = new System.Drawing.Point(74, 120);
            this.cBox_stopBitsCom1.Name = "cBox_stopBitsCom1";
            this.cBox_stopBitsCom1.Size = new System.Drawing.Size(105, 20);
            this.cBox_stopBitsCom1.TabIndex = 9;
            // 
            // cBox_parityCom1
            // 
            this.cBox_parityCom1.FormattingEnabled = true;
            this.cBox_parityCom1.Items.AddRange(new object[] {
            "无",
            "奇校验",
            "偶校验",
            "Mark",
            "Space"});
            this.cBox_parityCom1.Location = new System.Drawing.Point(74, 96);
            this.cBox_parityCom1.Name = "cBox_parityCom1";
            this.cBox_parityCom1.Size = new System.Drawing.Size(105, 20);
            this.cBox_parityCom1.TabIndex = 8;
            // 
            // cBox_dataBitsCom1
            // 
            this.cBox_dataBitsCom1.FormattingEnabled = true;
            this.cBox_dataBitsCom1.Items.AddRange(new object[] {
            "6",
            "7",
            "8"});
            this.cBox_dataBitsCom1.Location = new System.Drawing.Point(74, 73);
            this.cBox_dataBitsCom1.Name = "cBox_dataBitsCom1";
            this.cBox_dataBitsCom1.Size = new System.Drawing.Size(105, 20);
            this.cBox_dataBitsCom1.TabIndex = 7;
            // 
            // cBox_baudRateCom1
            // 
            this.cBox_baudRateCom1.FormattingEnabled = true;
            this.cBox_baudRateCom1.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "38400",
            "56000",
            "57600"});
            this.cBox_baudRateCom1.Location = new System.Drawing.Point(74, 49);
            this.cBox_baudRateCom1.Name = "cBox_baudRateCom1";
            this.cBox_baudRateCom1.Size = new System.Drawing.Size(105, 20);
            this.cBox_baudRateCom1.TabIndex = 6;
            // 
            // cBox_portNameCom1
            // 
            this.cBox_portNameCom1.FormattingEnabled = true;
            this.cBox_portNameCom1.Location = new System.Drawing.Point(74, 27);
            this.cBox_portNameCom1.Name = "cBox_portNameCom1";
            this.cBox_portNameCom1.Size = new System.Drawing.Size(105, 20);
            this.cBox_portNameCom1.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "状态：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "停止位：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "校验位：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "数据位：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "波特率：";
            // 
            // listBox_showCom1
            // 
            this.listBox_showCom1.FormattingEnabled = true;
            this.listBox_showCom1.ItemHeight = 12;
            this.listBox_showCom1.Location = new System.Drawing.Point(6, 20);
            this.listBox_showCom1.Name = "listBox_showCom1";
            this.listBox_showCom1.Size = new System.Drawing.Size(849, 172);
            this.listBox_showCom1.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBox_showCom1);
            this.groupBox2.Location = new System.Drawing.Point(233, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(861, 204);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "串口1数据区";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.listBox_showCom2);
            this.groupBox4.Location = new System.Drawing.Point(239, 252);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(849, 201);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "串口2数据区";
            // 
            // listBox_showCom2
            // 
            this.listBox_showCom2.FormattingEnabled = true;
            this.listBox_showCom2.ItemHeight = 12;
            this.listBox_showCom2.Location = new System.Drawing.Point(6, 20);
            this.listBox_showCom2.Name = "listBox_showCom2";
            this.listBox_showCom2.Size = new System.Drawing.Size(837, 172);
            this.listBox_showCom2.TabIndex = 2;
            // 
            // btn_OpenOrCloseTransmit
            // 
            this.btn_OpenOrCloseTransmit.Location = new System.Drawing.Point(527, 223);
            this.btn_OpenOrCloseTransmit.Name = "btn_OpenOrCloseTransmit";
            this.btn_OpenOrCloseTransmit.Size = new System.Drawing.Size(79, 23);
            this.btn_OpenOrCloseTransmit.TabIndex = 8;
            this.btn_OpenOrCloseTransmit.Text = "关闭";
            this.btn_OpenOrCloseTransmit.UseVisualStyleBackColor = true;
            this.btn_OpenOrCloseTransmit.Click += new System.EventHandler(this.btn_OpenOrCloseTransmit_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cBox_handShakeCom2);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.btn_openOrCloseCom2);
            this.groupBox3.Controls.Add(this.lab_statusCom2);
            this.groupBox3.Controls.Add(this.cBox_stopBitsCom2);
            this.groupBox3.Controls.Add(this.cBox_parityCom2);
            this.groupBox3.Controls.Add(this.cBox_dataBitsCom2);
            this.groupBox3.Controls.Add(this.cBox_baudRateCom2);
            this.groupBox3.Controls.Add(this.cBox_portNameCom2);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Location = new System.Drawing.Point(12, 249);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(201, 204);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "数据接收串口2";
            // 
            // cBox_handShakeCom2
            // 
            this.cBox_handShakeCom2.FormattingEnabled = true;
            this.cBox_handShakeCom2.Items.AddRange(new object[] {
            "None",
            "XOnXOff",
            "RTS",
            "RTSXOnXOff"});
            this.cBox_handShakeCom2.Location = new System.Drawing.Point(74, 144);
            this.cBox_handShakeCom2.Name = "cBox_handShakeCom2";
            this.cBox_handShakeCom2.Size = new System.Drawing.Size(105, 20);
            this.cBox_handShakeCom2.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 10;
            this.label7.Text = "流控制：";
            // 
            // btn_openOrCloseCom2
            // 
            this.btn_openOrCloseCom2.Location = new System.Drawing.Point(104, 171);
            this.btn_openOrCloseCom2.Name = "btn_openOrCloseCom2";
            this.btn_openOrCloseCom2.Size = new System.Drawing.Size(75, 23);
            this.btn_openOrCloseCom2.TabIndex = 2;
            this.btn_openOrCloseCom2.Text = "打开串口";
            this.btn_openOrCloseCom2.UseVisualStyleBackColor = true;
            this.btn_openOrCloseCom2.Click += new System.EventHandler(this.btn_openOrCloseCom2_Click);
            // 
            // lab_statusCom2
            // 
            this.lab_statusCom2.AutoSize = true;
            this.lab_statusCom2.Location = new System.Drawing.Point(62, 176);
            this.lab_statusCom2.Name = "lab_statusCom2";
            this.lab_statusCom2.Size = new System.Drawing.Size(29, 12);
            this.lab_statusCom2.TabIndex = 2;
            this.lab_statusCom2.Text = "关闭";
            // 
            // cBox_stopBitsCom2
            // 
            this.cBox_stopBitsCom2.FormattingEnabled = true;
            this.cBox_stopBitsCom2.Items.AddRange(new object[] {
            "0",
            "1",
            "1.5",
            "2"});
            this.cBox_stopBitsCom2.Location = new System.Drawing.Point(74, 120);
            this.cBox_stopBitsCom2.Name = "cBox_stopBitsCom2";
            this.cBox_stopBitsCom2.Size = new System.Drawing.Size(105, 20);
            this.cBox_stopBitsCom2.TabIndex = 9;
            // 
            // cBox_parityCom2
            // 
            this.cBox_parityCom2.FormattingEnabled = true;
            this.cBox_parityCom2.Items.AddRange(new object[] {
            "无",
            "奇校验",
            "偶校验",
            "Mark",
            "Space"});
            this.cBox_parityCom2.Location = new System.Drawing.Point(74, 96);
            this.cBox_parityCom2.Name = "cBox_parityCom2";
            this.cBox_parityCom2.Size = new System.Drawing.Size(105, 20);
            this.cBox_parityCom2.TabIndex = 8;
            // 
            // cBox_dataBitsCom2
            // 
            this.cBox_dataBitsCom2.FormattingEnabled = true;
            this.cBox_dataBitsCom2.Items.AddRange(new object[] {
            "6",
            "7",
            "8"});
            this.cBox_dataBitsCom2.Location = new System.Drawing.Point(74, 73);
            this.cBox_dataBitsCom2.Name = "cBox_dataBitsCom2";
            this.cBox_dataBitsCom2.Size = new System.Drawing.Size(105, 20);
            this.cBox_dataBitsCom2.TabIndex = 7;
            // 
            // cBox_baudRateCom2
            // 
            this.cBox_baudRateCom2.FormattingEnabled = true;
            this.cBox_baudRateCom2.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "38400",
            "56000",
            "57600"});
            this.cBox_baudRateCom2.Location = new System.Drawing.Point(74, 49);
            this.cBox_baudRateCom2.Name = "cBox_baudRateCom2";
            this.cBox_baudRateCom2.Size = new System.Drawing.Size(105, 20);
            this.cBox_baudRateCom2.TabIndex = 6;
            // 
            // cBox_portNameCom2
            // 
            this.cBox_portNameCom2.FormattingEnabled = true;
            this.cBox_portNameCom2.Location = new System.Drawing.Point(74, 27);
            this.cBox_portNameCom2.Name = "cBox_portNameCom2";
            this.cBox_portNameCom2.Size = new System.Drawing.Size(105, 20);
            this.cBox_portNameCom2.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 176);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 5;
            this.label9.Text = "状态：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 123);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 4;
            this.label10.Text = "停止位：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 99);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 3;
            this.label11.Text = "校验位：";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 76);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 2;
            this.label12.Text = "数据位：";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 52);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 12);
            this.label13.TabIndex = 1;
            this.label13.Text = "波特率：";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(15, 30);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 12);
            this.label15.TabIndex = 0;
            this.label15.Text = "端  口：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(432, 228);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 12);
            this.label8.TabIndex = 10;
            this.label8.Text = "是否转发数据：";
            // 
            // tBox_send
            // 
            this.tBox_send.Location = new System.Drawing.Point(17, 20);
            this.tBox_send.Name = "tBox_send";
            this.tBox_send.Size = new System.Drawing.Size(850, 21);
            this.tBox_send.TabIndex = 11;
            // 
            // btn_sendToCom1
            // 
            this.btn_sendToCom1.Location = new System.Drawing.Point(873, 20);
            this.btn_sendToCom1.Name = "btn_sendToCom1";
            this.btn_sendToCom1.Size = new System.Drawing.Size(93, 23);
            this.btn_sendToCom1.TabIndex = 12;
            this.btn_sendToCom1.Text = "发送到串口1";
            this.btn_sendToCom1.UseVisualStyleBackColor = true;
            this.btn_sendToCom1.Click += new System.EventHandler(this.btn_sendToCom1_Click);
            // 
            // btn_sendToCom2
            // 
            this.btn_sendToCom2.Location = new System.Drawing.Point(972, 20);
            this.btn_sendToCom2.Name = "btn_sendToCom2";
            this.btn_sendToCom2.Size = new System.Drawing.Size(92, 23);
            this.btn_sendToCom2.TabIndex = 13;
            this.btn_sendToCom2.Text = "发送到串口2";
            this.btn_sendToCom2.UseVisualStyleBackColor = true;
            this.btn_sendToCom2.Click += new System.EventHandler(this.btn_sendToCom2_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tBox_send);
            this.groupBox5.Controls.Add(this.btn_sendToCom2);
            this.groupBox5.Controls.Add(this.btn_sendToCom1);
            this.groupBox5.Location = new System.Drawing.Point(12, 457);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1070, 65);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "往串口转发数据";
            // 
            // SerialPortForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 534);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btn_OpenOrCloseTransmit);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "SerialPortForm";
            this.Text = "串口转发工具";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SerialPortForm_FormClosed);
            this.Load += new System.EventHandler(this.SerialPortForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_openOrCloseCom1;
        private System.Windows.Forms.Label lab_statusCom1;
        private System.Windows.Forms.ComboBox cBox_stopBitsCom1;
        private System.Windows.Forms.ComboBox cBox_parityCom1;
        private System.Windows.Forms.ComboBox cBox_dataBitsCom1;
        private System.Windows.Forms.ComboBox cBox_baudRateCom1;
        private System.Windows.Forms.ComboBox cBox_portNameCom1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox_showCom1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox listBox_showCom2;
        private System.Windows.Forms.ComboBox cBox_handShakeCom1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btn_OpenOrCloseTransmit;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cBox_handShakeCom2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_openOrCloseCom2;
        private System.Windows.Forms.Label lab_statusCom2;
        private System.Windows.Forms.ComboBox cBox_stopBitsCom2;
        private System.Windows.Forms.ComboBox cBox_parityCom2;
        private System.Windows.Forms.ComboBox cBox_dataBitsCom2;
        private System.Windows.Forms.ComboBox cBox_baudRateCom2;
        private System.Windows.Forms.ComboBox cBox_portNameCom2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tBox_send;
        private System.Windows.Forms.Button btn_sendToCom1;
        private System.Windows.Forms.Button btn_sendToCom2;
        private System.Windows.Forms.GroupBox groupBox5;
    }
}

