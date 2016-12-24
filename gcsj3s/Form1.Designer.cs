namespace gcsj3s
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnCon = new System.Windows.Forms.Button();
            this.tbxIP = new System.Windows.Forms.TextBox();
            this.IPLabel = new System.Windows.Forms.Label();
            this.btnEsc = new System.Windows.Forms.Button();
            this.btnClearBuf = new System.Windows.Forms.Button();
            this.btnCloseComPort = new System.Windows.Forms.Button();
            this.btnOpenComPort = new System.Windows.Forms.Button();
            this.cbxBps = new System.Windows.Forms.ComboBox();
            this.cbxComPort = new System.Windows.Forms.ComboBox();
            this.BpsLabel = new System.Windows.Forms.Label();
            this.ComLabel = new System.Windows.Forms.Label();
            this.RightPanel = new System.Windows.Forms.Panel();
            this.labTempTime = new System.Windows.Forms.Label();
            this.tbxTempTime = new System.Windows.Forms.TextBox();
            this.tbxConInfo = new System.Windows.Forms.TextBox();
            this.tbxGasTime = new System.Windows.Forms.TextBox();
            this.tbxGas = new System.Windows.Forms.TextBox();
            this.tbxTemp = new System.Windows.Forms.TextBox();
            this.labGasTime = new System.Windows.Forms.Label();
            this.labGas = new System.Windows.Forms.Label();
            this.labTemp = new System.Windows.Forms.Label();
            this.sp = new System.IO.Ports.SerialPort(this.components);
            this.LeftPanel.SuspendLayout();
            this.RightPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.Color.RosyBrown;
            this.LeftPanel.Controls.Add(this.btnStart);
            this.LeftPanel.Controls.Add(this.btnStop);
            this.LeftPanel.Controls.Add(this.btnCon);
            this.LeftPanel.Controls.Add(this.tbxIP);
            this.LeftPanel.Controls.Add(this.IPLabel);
            this.LeftPanel.Controls.Add(this.btnEsc);
            this.LeftPanel.Controls.Add(this.btnClearBuf);
            this.LeftPanel.Controls.Add(this.btnCloseComPort);
            this.LeftPanel.Controls.Add(this.btnOpenComPort);
            this.LeftPanel.Controls.Add(this.cbxBps);
            this.LeftPanel.Controls.Add(this.cbxComPort);
            this.LeftPanel.Controls.Add(this.BpsLabel);
            this.LeftPanel.Controls.Add(this.ComLabel);
            this.LeftPanel.Location = new System.Drawing.Point(2, 1);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(202, 557);
            this.LeftPanel.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(49, 374);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(88, 33);
            this.btnStart.TabIndex = 16;
            this.btnStart.Text = "发送";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(49, 423);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(88, 33);
            this.btnStop.TabIndex = 15;
            this.btnStop.Text = "暂停发送";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnCon
            // 
            this.btnCon.Location = new System.Drawing.Point(49, 325);
            this.btnCon.Name = "btnCon";
            this.btnCon.Size = new System.Drawing.Size(88, 33);
            this.btnCon.TabIndex = 14;
            this.btnCon.Text = "建立TCP连接";
            this.btnCon.UseVisualStyleBackColor = true;
            this.btnCon.Click += new System.EventHandler(this.btnCon_Click);
            // 
            // tbxIP
            // 
            this.tbxIP.Location = new System.Drawing.Point(58, 104);
            this.tbxIP.Name = "tbxIP";
            this.tbxIP.Size = new System.Drawing.Size(131, 21);
            this.tbxIP.TabIndex = 13;
            // 
            // IPLabel
            // 
            this.IPLabel.AutoSize = true;
            this.IPLabel.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.IPLabel.Location = new System.Drawing.Point(17, 108);
            this.IPLabel.Name = "IPLabel";
            this.IPLabel.Size = new System.Drawing.Size(35, 14);
            this.IPLabel.TabIndex = 12;
            this.IPLabel.Text = "IP：";
            // 
            // btnEsc
            // 
            this.btnEsc.Location = new System.Drawing.Point(49, 472);
            this.btnEsc.Name = "btnEsc";
            this.btnEsc.Size = new System.Drawing.Size(88, 33);
            this.btnEsc.TabIndex = 11;
            this.btnEsc.Text = "退出";
            this.btnEsc.UseVisualStyleBackColor = true;
            this.btnEsc.Click += new System.EventHandler(this.btnEsc_Click);
            // 
            // btnClearBuf
            // 
            this.btnClearBuf.Location = new System.Drawing.Point(49, 276);
            this.btnClearBuf.Name = "btnClearBuf";
            this.btnClearBuf.Size = new System.Drawing.Size(88, 33);
            this.btnClearBuf.TabIndex = 10;
            this.btnClearBuf.Text = "清空缓存区";
            this.btnClearBuf.UseVisualStyleBackColor = true;
            this.btnClearBuf.Click += new System.EventHandler(this.btnClearBuf_Click);
            // 
            // btnCloseComPort
            // 
            this.btnCloseComPort.Location = new System.Drawing.Point(49, 227);
            this.btnCloseComPort.Name = "btnCloseComPort";
            this.btnCloseComPort.Size = new System.Drawing.Size(88, 33);
            this.btnCloseComPort.TabIndex = 9;
            this.btnCloseComPort.Text = "关闭串口";
            this.btnCloseComPort.UseVisualStyleBackColor = true;
            this.btnCloseComPort.Click += new System.EventHandler(this.btnCloseComPort_Click);
            // 
            // btnOpenComPort
            // 
            this.btnOpenComPort.Location = new System.Drawing.Point(49, 178);
            this.btnOpenComPort.Name = "btnOpenComPort";
            this.btnOpenComPort.Size = new System.Drawing.Size(88, 33);
            this.btnOpenComPort.TabIndex = 8;
            this.btnOpenComPort.Text = "打开串口";
            this.btnOpenComPort.UseVisualStyleBackColor = true;
            this.btnOpenComPort.Click += new System.EventHandler(this.btnOpenComPort_Click);
            // 
            // cbxBps
            // 
            this.cbxBps.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbxBps.FormattingEnabled = true;
            this.cbxBps.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "43000",
            "56000",
            "57600",
            "115200"});
            this.cbxBps.Location = new System.Drawing.Point(83, 65);
            this.cbxBps.Name = "cbxBps";
            this.cbxBps.Size = new System.Drawing.Size(98, 24);
            this.cbxBps.TabIndex = 7;
            // 
            // cbxComPort
            // 
            this.cbxComPort.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbxComPort.FormattingEnabled = true;
            this.cbxComPort.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9",
            "COM10",
            "COM11",
            "COM12",
            "COM13",
            "COM14",
            "COM15"});
            this.cbxComPort.Location = new System.Drawing.Point(83, 26);
            this.cbxComPort.Name = "cbxComPort";
            this.cbxComPort.Size = new System.Drawing.Size(98, 24);
            this.cbxComPort.TabIndex = 6;
            // 
            // BpsLabel
            // 
            this.BpsLabel.AutoSize = true;
            this.BpsLabel.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BpsLabel.Location = new System.Drawing.Point(10, 69);
            this.BpsLabel.Name = "BpsLabel";
            this.BpsLabel.Size = new System.Drawing.Size(63, 14);
            this.BpsLabel.TabIndex = 5;
            this.BpsLabel.Text = "波特率：";
            // 
            // ComLabel
            // 
            this.ComLabel.AutoSize = true;
            this.ComLabel.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ComLabel.Location = new System.Drawing.Point(10, 28);
            this.ComLabel.Name = "ComLabel";
            this.ComLabel.Size = new System.Drawing.Size(63, 14);
            this.ComLabel.TabIndex = 4;
            this.ComLabel.Text = "  串口：";
            // 
            // RightPanel
            // 
            this.RightPanel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.RightPanel.Controls.Add(this.labTempTime);
            this.RightPanel.Controls.Add(this.tbxTempTime);
            this.RightPanel.Controls.Add(this.tbxConInfo);
            this.RightPanel.Controls.Add(this.tbxGasTime);
            this.RightPanel.Controls.Add(this.tbxGas);
            this.RightPanel.Controls.Add(this.tbxTemp);
            this.RightPanel.Controls.Add(this.labGasTime);
            this.RightPanel.Controls.Add(this.labGas);
            this.RightPanel.Controls.Add(this.labTemp);
            this.RightPanel.Location = new System.Drawing.Point(206, 1);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.Size = new System.Drawing.Size(731, 557);
            this.RightPanel.TabIndex = 1;
            // 
            // labTempTime
            // 
            this.labTempTime.AutoSize = true;
            this.labTempTime.BackColor = System.Drawing.Color.RosyBrown;
            this.labTempTime.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labTempTime.Location = new System.Drawing.Point(233, 23);
            this.labTempTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labTempTime.Name = "labTempTime";
            this.labTempTime.Size = new System.Drawing.Size(39, 19);
            this.labTempTime.TabIndex = 20;
            this.labTempTime.Text = "时间";
            // 
            // tbxTempTime
            // 
            this.tbxTempTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tbxTempTime.Location = new System.Drawing.Point(165, 57);
            this.tbxTempTime.Margin = new System.Windows.Forms.Padding(2);
            this.tbxTempTime.Multiline = true;
            this.tbxTempTime.Name = "tbxTempTime";
            this.tbxTempTime.Size = new System.Drawing.Size(171, 418);
            this.tbxTempTime.TabIndex = 19;
            this.tbxTempTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxConInfo
            // 
            this.tbxConInfo.BackColor = System.Drawing.Color.White;
            this.tbxConInfo.Location = new System.Drawing.Point(14, 479);
            this.tbxConInfo.Margin = new System.Windows.Forms.Padding(2);
            this.tbxConInfo.Multiline = true;
            this.tbxConInfo.Name = "tbxConInfo";
            this.tbxConInfo.Size = new System.Drawing.Size(707, 69);
            this.tbxConInfo.TabIndex = 18;
            this.tbxConInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxGasTime
            // 
            this.tbxGasTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tbxGasTime.Location = new System.Drawing.Point(550, 57);
            this.tbxGasTime.Margin = new System.Windows.Forms.Padding(2);
            this.tbxGasTime.Multiline = true;
            this.tbxGasTime.Name = "tbxGasTime";
            this.tbxGasTime.Size = new System.Drawing.Size(171, 418);
            this.tbxGasTime.TabIndex = 17;
            this.tbxGasTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxGas
            // 
            this.tbxGas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tbxGas.Location = new System.Drawing.Point(400, 57);
            this.tbxGas.Margin = new System.Windows.Forms.Padding(2);
            this.tbxGas.Multiline = true;
            this.tbxGas.Name = "tbxGas";
            this.tbxGas.Size = new System.Drawing.Size(137, 418);
            this.tbxGas.TabIndex = 16;
            this.tbxGas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxTemp
            // 
            this.tbxTemp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tbxTemp.Location = new System.Drawing.Point(14, 57);
            this.tbxTemp.Margin = new System.Windows.Forms.Padding(2);
            this.tbxTemp.Multiline = true;
            this.tbxTemp.Name = "tbxTemp";
            this.tbxTemp.Size = new System.Drawing.Size(137, 418);
            this.tbxTemp.TabIndex = 15;
            this.tbxTemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labGasTime
            // 
            this.labGasTime.AutoSize = true;
            this.labGasTime.BackColor = System.Drawing.Color.RosyBrown;
            this.labGasTime.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labGasTime.Location = new System.Drawing.Point(617, 23);
            this.labGasTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labGasTime.Name = "labGasTime";
            this.labGasTime.Size = new System.Drawing.Size(39, 19);
            this.labGasTime.TabIndex = 14;
            this.labGasTime.Text = "时间";
            // 
            // labGas
            // 
            this.labGas.AutoSize = true;
            this.labGas.BackColor = System.Drawing.Color.RosyBrown;
            this.labGas.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labGas.Location = new System.Drawing.Point(451, 23);
            this.labGas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labGas.Name = "labGas";
            this.labGas.Size = new System.Drawing.Size(39, 19);
            this.labGas.TabIndex = 13;
            this.labGas.Text = "气体";
            // 
            // labTemp
            // 
            this.labTemp.AutoSize = true;
            this.labTemp.BackColor = System.Drawing.Color.RosyBrown;
            this.labTemp.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labTemp.Location = new System.Drawing.Point(66, 23);
            this.labTemp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labTemp.Name = "labTemp";
            this.labTemp.Size = new System.Drawing.Size(39, 19);
            this.labTemp.TabIndex = 12;
            this.labTemp.Text = "温度";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 560);
            this.Controls.Add(this.RightPanel);
            this.Controls.Add(this.LeftPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.LeftPanel.ResumeLayout(false);
            this.LeftPanel.PerformLayout();
            this.RightPanel.ResumeLayout(false);
            this.RightPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Panel RightPanel;
        private System.Windows.Forms.ComboBox cbxComPort;
        private System.Windows.Forms.Label BpsLabel;
        private System.Windows.Forms.Label ComLabel;
        private System.Windows.Forms.ComboBox cbxBps;
        private System.Windows.Forms.Button btnEsc;
        private System.Windows.Forms.Button btnClearBuf;
        private System.Windows.Forms.Button btnCloseComPort;
        private System.Windows.Forms.Button btnOpenComPort;
        private System.Windows.Forms.TextBox tbxGasTime;
        private System.Windows.Forms.TextBox tbxGas;
        private System.Windows.Forms.TextBox tbxTemp;
        private System.Windows.Forms.Label labGasTime;
        private System.Windows.Forms.Label labGas;
        private System.Windows.Forms.Label labTemp;
        private System.IO.Ports.SerialPort sp;
        private System.Windows.Forms.TextBox tbxIP;
        private System.Windows.Forms.Label IPLabel;
        private System.Windows.Forms.TextBox tbxConInfo;
        private System.Windows.Forms.Button btnCon;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox tbxTempTime;
        private System.Windows.Forms.Label labTempTime;
    }
}

