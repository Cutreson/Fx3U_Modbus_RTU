namespace Fx3U_Modbus
{
    partial class GUI_Communication_Test
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboReadCoilDeviceType = new System.Windows.Forms.ComboBox();
            this.txtReadCoidDeviceAddress = new System.Windows.Forms.TextBox();
            this.txtReadCoilValue = new System.Windows.Forms.TextBox();
            this.btnReadSingleCoil = new System.Windows.Forms.Button();
            this.btnReadRegister = new System.Windows.Forms.Button();
            this.txtReadRegisterlValue = new System.Windows.Forms.TextBox();
            this.txtReadRegisterDeviceAddress = new System.Windows.Forms.TextBox();
            this.cboReadRegisterDeviceType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnwriteSingleCoil = new System.Windows.Forms.Button();
            this.txtWriteCoidDeviceAddress = new System.Windows.Forms.TextBox();
            this.cboWriteCoilDeviceType = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cboWriteCoilValue = new System.Windows.Forms.ComboBox();
            this.btnWriteRegister = new System.Windows.Forms.Button();
            this.txtWriteRegisterDeviceAddress = new System.Windows.Forms.TextBox();
            this.cboWriteRegisterDeviceType = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtWriteRegisterlValue = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(366, 147);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Read single coil";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(302, 192);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "Device type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(302, 235);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 34);
            this.label3.TabIndex = 2;
            this.label3.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(302, 278);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 34);
            this.label4.TabIndex = 3;
            this.label4.Text = "Value";
            // 
            // cboReadCoilDeviceType
            // 
            this.cboReadCoilDeviceType.Font = new System.Drawing.Font("Poppins", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboReadCoilDeviceType.FormattingEnabled = true;
            this.cboReadCoilDeviceType.Items.AddRange(new object[] {
            "M",
            "X",
            "Y"});
            this.cboReadCoilDeviceType.Location = new System.Drawing.Point(438, 189);
            this.cboReadCoilDeviceType.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cboReadCoilDeviceType.Name = "cboReadCoilDeviceType";
            this.cboReadCoilDeviceType.Size = new System.Drawing.Size(122, 42);
            this.cboReadCoilDeviceType.TabIndex = 4;
            // 
            // txtReadCoidDeviceAddress
            // 
            this.txtReadCoidDeviceAddress.Font = new System.Drawing.Font("Poppins", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReadCoidDeviceAddress.Location = new System.Drawing.Point(438, 232);
            this.txtReadCoidDeviceAddress.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtReadCoidDeviceAddress.Name = "txtReadCoidDeviceAddress";
            this.txtReadCoidDeviceAddress.Size = new System.Drawing.Size(122, 35);
            this.txtReadCoidDeviceAddress.TabIndex = 5;
            // 
            // txtReadCoilValue
            // 
            this.txtReadCoilValue.Font = new System.Drawing.Font("Poppins", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReadCoilValue.Location = new System.Drawing.Point(438, 274);
            this.txtReadCoilValue.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtReadCoilValue.Name = "txtReadCoilValue";
            this.txtReadCoilValue.Size = new System.Drawing.Size(122, 35);
            this.txtReadCoilValue.TabIndex = 6;
            // 
            // btnReadSingleCoil
            // 
            this.btnReadSingleCoil.Font = new System.Drawing.Font("Poppins", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadSingleCoil.Location = new System.Drawing.Point(438, 326);
            this.btnReadSingleCoil.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnReadSingleCoil.Name = "btnReadSingleCoil";
            this.btnReadSingleCoil.Size = new System.Drawing.Size(123, 32);
            this.btnReadSingleCoil.TabIndex = 7;
            this.btnReadSingleCoil.Text = "Read";
            this.btnReadSingleCoil.UseVisualStyleBackColor = true;
            this.btnReadSingleCoil.Click += new System.EventHandler(this.btnReadSingleCoil_Click);
            // 
            // btnReadRegister
            // 
            this.btnReadRegister.Font = new System.Drawing.Font("Poppins", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadRegister.Location = new System.Drawing.Point(1102, 326);
            this.btnReadRegister.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnReadRegister.Name = "btnReadRegister";
            this.btnReadRegister.Size = new System.Drawing.Size(123, 32);
            this.btnReadRegister.TabIndex = 15;
            this.btnReadRegister.Text = "Read";
            this.btnReadRegister.UseVisualStyleBackColor = true;
            this.btnReadRegister.Click += new System.EventHandler(this.btnReadRegister_Click);
            // 
            // txtReadRegisterlValue
            // 
            this.txtReadRegisterlValue.Font = new System.Drawing.Font("Poppins", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReadRegisterlValue.Location = new System.Drawing.Point(1102, 275);
            this.txtReadRegisterlValue.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtReadRegisterlValue.Name = "txtReadRegisterlValue";
            this.txtReadRegisterlValue.Size = new System.Drawing.Size(122, 35);
            this.txtReadRegisterlValue.TabIndex = 14;
            // 
            // txtReadRegisterDeviceAddress
            // 
            this.txtReadRegisterDeviceAddress.Font = new System.Drawing.Font("Poppins", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReadRegisterDeviceAddress.Location = new System.Drawing.Point(1102, 234);
            this.txtReadRegisterDeviceAddress.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtReadRegisterDeviceAddress.Name = "txtReadRegisterDeviceAddress";
            this.txtReadRegisterDeviceAddress.Size = new System.Drawing.Size(122, 35);
            this.txtReadRegisterDeviceAddress.TabIndex = 13;
            // 
            // cboReadRegisterDeviceType
            // 
            this.cboReadRegisterDeviceType.Font = new System.Drawing.Font("Poppins", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboReadRegisterDeviceType.FormattingEnabled = true;
            this.cboReadRegisterDeviceType.Items.AddRange(new object[] {
            "D"});
            this.cboReadRegisterDeviceType.Location = new System.Drawing.Point(1102, 189);
            this.cboReadRegisterDeviceType.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cboReadRegisterDeviceType.Name = "cboReadRegisterDeviceType";
            this.cboReadRegisterDeviceType.Size = new System.Drawing.Size(122, 42);
            this.cboReadRegisterDeviceType.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(965, 278);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 34);
            this.label5.TabIndex = 11;
            this.label5.Text = "Value";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(965, 235);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 34);
            this.label6.TabIndex = 10;
            this.label6.Text = "Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poppins", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(965, 192);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 34);
            this.label7.TabIndex = 9;
            this.label7.Text = "Device type";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Poppins", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label8.Location = new System.Drawing.Point(1010, 147);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(209, 34);
            this.label8.TabIndex = 8;
            this.label8.Text = "Read single register";
            // 
            // btnwriteSingleCoil
            // 
            this.btnwriteSingleCoil.Font = new System.Drawing.Font("Poppins", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnwriteSingleCoil.Location = new System.Drawing.Point(438, 642);
            this.btnwriteSingleCoil.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnwriteSingleCoil.Name = "btnwriteSingleCoil";
            this.btnwriteSingleCoil.Size = new System.Drawing.Size(123, 32);
            this.btnwriteSingleCoil.TabIndex = 23;
            this.btnwriteSingleCoil.Text = "Write";
            this.btnwriteSingleCoil.UseVisualStyleBackColor = true;
            this.btnwriteSingleCoil.Click += new System.EventHandler(this.btnwriteSingleCoil_Click);
            // 
            // txtWriteCoidDeviceAddress
            // 
            this.txtWriteCoidDeviceAddress.Font = new System.Drawing.Font("Poppins", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWriteCoidDeviceAddress.Location = new System.Drawing.Point(438, 552);
            this.txtWriteCoidDeviceAddress.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtWriteCoidDeviceAddress.Name = "txtWriteCoidDeviceAddress";
            this.txtWriteCoidDeviceAddress.Size = new System.Drawing.Size(122, 35);
            this.txtWriteCoidDeviceAddress.TabIndex = 21;
            // 
            // cboWriteCoilDeviceType
            // 
            this.cboWriteCoilDeviceType.Font = new System.Drawing.Font("Poppins", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboWriteCoilDeviceType.FormattingEnabled = true;
            this.cboWriteCoilDeviceType.Items.AddRange(new object[] {
            "M",
            "X",
            "Y"});
            this.cboWriteCoilDeviceType.Location = new System.Drawing.Point(438, 507);
            this.cboWriteCoilDeviceType.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cboWriteCoilDeviceType.Name = "cboWriteCoilDeviceType";
            this.cboWriteCoilDeviceType.Size = new System.Drawing.Size(122, 42);
            this.cboWriteCoilDeviceType.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Poppins", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(302, 595);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 34);
            this.label9.TabIndex = 19;
            this.label9.Text = "Value";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Poppins", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(302, 552);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 34);
            this.label10.TabIndex = 18;
            this.label10.Text = "Address";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Poppins", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(302, 509);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(129, 34);
            this.label11.TabIndex = 17;
            this.label11.Text = "Device type";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Poppins", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label12.Location = new System.Drawing.Point(366, 464);
            this.label12.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(169, 34);
            this.label12.TabIndex = 16;
            this.label12.Text = "Write single coil";
            // 
            // cboWriteCoilValue
            // 
            this.cboWriteCoilValue.Font = new System.Drawing.Font("Poppins", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboWriteCoilValue.FormattingEnabled = true;
            this.cboWriteCoilValue.Items.AddRange(new object[] {
            "True",
            "False"});
            this.cboWriteCoilValue.Location = new System.Drawing.Point(438, 595);
            this.cboWriteCoilValue.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cboWriteCoilValue.Name = "cboWriteCoilValue";
            this.cboWriteCoilValue.Size = new System.Drawing.Size(122, 42);
            this.cboWriteCoilValue.TabIndex = 24;
            // 
            // btnWriteRegister
            // 
            this.btnWriteRegister.Font = new System.Drawing.Font("Poppins", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWriteRegister.Location = new System.Drawing.Point(1102, 643);
            this.btnWriteRegister.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnWriteRegister.Name = "btnWriteRegister";
            this.btnWriteRegister.Size = new System.Drawing.Size(123, 32);
            this.btnWriteRegister.TabIndex = 31;
            this.btnWriteRegister.Text = "Write";
            this.btnWriteRegister.UseVisualStyleBackColor = true;
            this.btnWriteRegister.Click += new System.EventHandler(this.btnWriteRegister_Click);
            // 
            // txtWriteRegisterDeviceAddress
            // 
            this.txtWriteRegisterDeviceAddress.Font = new System.Drawing.Font("Poppins", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWriteRegisterDeviceAddress.Location = new System.Drawing.Point(1102, 552);
            this.txtWriteRegisterDeviceAddress.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtWriteRegisterDeviceAddress.Name = "txtWriteRegisterDeviceAddress";
            this.txtWriteRegisterDeviceAddress.Size = new System.Drawing.Size(122, 35);
            this.txtWriteRegisterDeviceAddress.TabIndex = 30;
            // 
            // cboWriteRegisterDeviceType
            // 
            this.cboWriteRegisterDeviceType.Font = new System.Drawing.Font("Poppins", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboWriteRegisterDeviceType.FormattingEnabled = true;
            this.cboWriteRegisterDeviceType.Items.AddRange(new object[] {
            "D"});
            this.cboWriteRegisterDeviceType.Location = new System.Drawing.Point(1102, 507);
            this.cboWriteRegisterDeviceType.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cboWriteRegisterDeviceType.Name = "cboWriteRegisterDeviceType";
            this.cboWriteRegisterDeviceType.Size = new System.Drawing.Size(122, 42);
            this.cboWriteRegisterDeviceType.TabIndex = 29;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Poppins", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(965, 596);
            this.label13.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 34);
            this.label13.TabIndex = 28;
            this.label13.Text = "Value";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Poppins", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(965, 553);
            this.label14.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(93, 34);
            this.label14.TabIndex = 27;
            this.label14.Text = "Address";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Poppins", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(965, 510);
            this.label15.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(129, 34);
            this.label15.TabIndex = 26;
            this.label15.Text = "Device type";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Poppins", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label16.Location = new System.Drawing.Point(1010, 464);
            this.label16.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(212, 34);
            this.label16.TabIndex = 25;
            this.label16.Text = "Write single register";
            // 
            // txtWriteRegisterlValue
            // 
            this.txtWriteRegisterlValue.Font = new System.Drawing.Font("Poppins", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWriteRegisterlValue.Location = new System.Drawing.Point(1102, 595);
            this.txtWriteRegisterlValue.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtWriteRegisterlValue.Name = "txtWriteRegisterlValue";
            this.txtWriteRegisterlValue.Size = new System.Drawing.Size(122, 35);
            this.txtWriteRegisterlValue.TabIndex = 32;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Poppins", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label17.Location = new System.Drawing.Point(603, 40);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(365, 56);
            this.label17.TabIndex = 33;
            this.label17.Text = "Communication test";
            // 
            // GUI_Communication_Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 749);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtWriteRegisterlValue);
            this.Controls.Add(this.btnWriteRegister);
            this.Controls.Add(this.txtWriteRegisterDeviceAddress);
            this.Controls.Add(this.cboWriteRegisterDeviceType);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.cboWriteCoilValue);
            this.Controls.Add(this.btnwriteSingleCoil);
            this.Controls.Add(this.txtWriteCoidDeviceAddress);
            this.Controls.Add(this.cboWriteCoilDeviceType);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnReadRegister);
            this.Controls.Add(this.txtReadRegisterlValue);
            this.Controls.Add(this.txtReadRegisterDeviceAddress);
            this.Controls.Add(this.cboReadRegisterDeviceType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnReadSingleCoil);
            this.Controls.Add(this.txtReadCoilValue);
            this.Controls.Add(this.txtReadCoidDeviceAddress);
            this.Controls.Add(this.cboReadCoilDeviceType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "GUI_Communication_Test";
            this.Text = "GUI_Communication_Test";
            this.Load += new System.EventHandler(this.GUI_Communication_Test_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboReadCoilDeviceType;
        private System.Windows.Forms.TextBox txtReadCoidDeviceAddress;
        private System.Windows.Forms.TextBox txtReadCoilValue;
        private System.Windows.Forms.Button btnReadSingleCoil;
        private System.Windows.Forms.Button btnReadRegister;
        private System.Windows.Forms.TextBox txtReadRegisterlValue;
        private System.Windows.Forms.TextBox txtReadRegisterDeviceAddress;
        private System.Windows.Forms.ComboBox cboReadRegisterDeviceType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnwriteSingleCoil;
        private System.Windows.Forms.TextBox txtWriteCoidDeviceAddress;
        private System.Windows.Forms.ComboBox cboWriteCoilDeviceType;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cboWriteCoilValue;
        private System.Windows.Forms.Button btnWriteRegister;
        private System.Windows.Forms.TextBox txtWriteRegisterDeviceAddress;
        private System.Windows.Forms.ComboBox cboWriteRegisterDeviceType;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtWriteRegisterlValue;
        private System.Windows.Forms.Label label17;
    }
}