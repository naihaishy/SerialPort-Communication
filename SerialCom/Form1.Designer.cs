namespace SerialCom
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuTools = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.ResetPortConfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuIHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AuthorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ContributorSylvesterLiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.groupBoxSerialPortSetting = new System.Windows.Forms.GroupBox();
            this.comboBoxStopBit = new System.Windows.Forms.ComboBox();
            this.comboBoxCheckBit = new System.Windows.Forms.ComboBox();
            this.comboBoxDataBit = new System.Windows.Forms.ComboBox();
            this.comboBoxBaudRate = new System.Windows.Forms.ComboBox();
            this.comboBoxCom = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonOpenCloseCom = new System.Windows.Forms.Button();
            this.groupBoxSendSetting = new System.Windows.Forms.GroupBox();
            this.radioButtonSendDataHex = new System.Windows.Forms.RadioButton();
            this.radioButtonSendDataASCII = new System.Windows.Forms.RadioButton();
            this.groupBoxReceiveSetting = new System.Windows.Forms.GroupBox();
            this.radioButtonReceiveDataHEX = new System.Windows.Forms.RadioButton();
            this.radioButtonReceiveDataASCII = new System.Windows.Forms.RadioButton();
            this.groupBoxReceiveData = new System.Windows.Forms.GroupBox();
            this.buttonClearRecData = new System.Windows.Forms.Button();
            this.textBoxReceive = new System.Windows.Forms.TextBox();
            this.groupBoxSendData = new System.Windows.Forms.GroupBox();
            this.buttonSendData = new System.Windows.Forms.Button();
            this.textBoxSend = new System.Windows.Forms.TextBox();
            this.Button_Refresh = new System.Windows.Forms.Button();
            this.SaveReceiveDataToFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.groupBoxSerialPortSetting.SuspendLayout();
            this.groupBoxSendSetting.SuspendLayout();
            this.groupBoxReceiveSetting.SuspendLayout();
            this.groupBoxReceiveData.SuspendLayout();
            this.groupBoxSendData.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFile,
            this.MenuTools,
            this.MenuSetting,
            this.MenuIHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(569, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuFile
            // 
            this.MenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveReceiveDataToFileToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.MenuFile.Name = "MenuFile";
            this.MenuFile.Size = new System.Drawing.Size(51, 24);
            this.MenuFile.Text = "文件";
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.ExitToolStripMenuItem.Text = "退出";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // MenuTools
            // 
            this.MenuTools.Name = "MenuTools";
            this.MenuTools.Size = new System.Drawing.Size(51, 24);
            this.MenuTools.Text = "工具";
            // 
            // MenuSetting
            // 
            this.MenuSetting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ResetPortConfToolStripMenuItem});
            this.MenuSetting.Name = "MenuSetting";
            this.MenuSetting.Size = new System.Drawing.Size(51, 24);
            this.MenuSetting.Text = "设置";
            // 
            // ResetPortConfToolStripMenuItem
            // 
            this.ResetPortConfToolStripMenuItem.Name = "ResetPortConfToolStripMenuItem";
            this.ResetPortConfToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.ResetPortConfToolStripMenuItem.Text = "重置串口设置";
            this.ResetPortConfToolStripMenuItem.Click += new System.EventHandler(this.ResetPortConfToolStripMenuItem_Click);
            // 
            // MenuIHelp
            // 
            this.MenuIHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutToolStripMenuItem});
            this.MenuIHelp.Name = "MenuIHelp";
            this.MenuIHelp.Size = new System.Drawing.Size(51, 24);
            this.MenuIHelp.Text = "帮助";
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AuthorToolStripMenuItem,
            this.ContributorSylvesterLiToolStripMenuItem});
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(114, 26);
            this.AboutToolStripMenuItem.Text = "关于";
            // 
            // AuthorToolStripMenuItem
            // 
            this.AuthorToolStripMenuItem.Name = "AuthorToolStripMenuItem";
            this.AuthorToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.AuthorToolStripMenuItem.Text = "作者：NaiHai";
            // 
            // ContributorSylvesterLiToolStripMenuItem
            // 
            this.ContributorSylvesterLiToolStripMenuItem.Name = "ContributorSylvesterLiToolStripMenuItem";
            this.ContributorSylvesterLiToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.ContributorSylvesterLiToolStripMenuItem.Text = "贡献者：Sylvester Li";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(569, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // groupBoxSerialPortSetting
            // 
            this.groupBoxSerialPortSetting.Controls.Add(this.comboBoxStopBit);
            this.groupBoxSerialPortSetting.Controls.Add(this.comboBoxCheckBit);
            this.groupBoxSerialPortSetting.Controls.Add(this.comboBoxDataBit);
            this.groupBoxSerialPortSetting.Controls.Add(this.comboBoxBaudRate);
            this.groupBoxSerialPortSetting.Controls.Add(this.comboBoxCom);
            this.groupBoxSerialPortSetting.Controls.Add(this.label5);
            this.groupBoxSerialPortSetting.Controls.Add(this.label4);
            this.groupBoxSerialPortSetting.Controls.Add(this.label3);
            this.groupBoxSerialPortSetting.Controls.Add(this.label2);
            this.groupBoxSerialPortSetting.Controls.Add(this.label1);
            this.groupBoxSerialPortSetting.Location = new System.Drawing.Point(12, 53);
            this.groupBoxSerialPortSetting.Name = "groupBoxSerialPortSetting";
            this.groupBoxSerialPortSetting.Size = new System.Drawing.Size(200, 219);
            this.groupBoxSerialPortSetting.TabIndex = 2;
            this.groupBoxSerialPortSetting.TabStop = false;
            this.groupBoxSerialPortSetting.Text = "串口设置";
            // 
            // comboBoxStopBit
            // 
            this.comboBoxStopBit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStopBit.FormattingEnabled = true;
            this.comboBoxStopBit.Location = new System.Drawing.Point(63, 171);
            this.comboBoxStopBit.Name = "comboBoxStopBit";
            this.comboBoxStopBit.Size = new System.Drawing.Size(121, 28);
            this.comboBoxStopBit.TabIndex = 9;
            // 
            // comboBoxCheckBit
            // 
            this.comboBoxCheckBit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCheckBit.FormattingEnabled = true;
            this.comboBoxCheckBit.Location = new System.Drawing.Point(63, 133);
            this.comboBoxCheckBit.Name = "comboBoxCheckBit";
            this.comboBoxCheckBit.Size = new System.Drawing.Size(121, 28);
            this.comboBoxCheckBit.TabIndex = 8;
            // 
            // comboBoxDataBit
            // 
            this.comboBoxDataBit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDataBit.FormattingEnabled = true;
            this.comboBoxDataBit.Location = new System.Drawing.Point(63, 99);
            this.comboBoxDataBit.Name = "comboBoxDataBit";
            this.comboBoxDataBit.Size = new System.Drawing.Size(121, 28);
            this.comboBoxDataBit.TabIndex = 7;
            // 
            // comboBoxBaudRate
            // 
            this.comboBoxBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBaudRate.FormattingEnabled = true;
            this.comboBoxBaudRate.Location = new System.Drawing.Point(63, 65);
            this.comboBoxBaudRate.Name = "comboBoxBaudRate";
            this.comboBoxBaudRate.Size = new System.Drawing.Size(121, 28);
            this.comboBoxBaudRate.TabIndex = 6;
            // 
            // comboBoxCom
            // 
            this.comboBoxCom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxCom.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxCom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCom.FormattingEnabled = true;
            this.comboBoxCom.Location = new System.Drawing.Point(63, 34);
            this.comboBoxCom.Name = "comboBoxCom";
            this.comboBoxCom.Size = new System.Drawing.Size(121, 28);
            this.comboBoxCom.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "停止位";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "校验位";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "数据位";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "波特率";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "端   口";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonOpenCloseCom
            // 
            this.buttonOpenCloseCom.Location = new System.Drawing.Point(413, 38);
            this.buttonOpenCloseCom.Name = "buttonOpenCloseCom";
            this.buttonOpenCloseCom.Size = new System.Drawing.Size(111, 38);
            this.buttonOpenCloseCom.TabIndex = 3;
            this.buttonOpenCloseCom.Text = "打开串口";
            this.buttonOpenCloseCom.UseVisualStyleBackColor = true;
            this.buttonOpenCloseCom.Click += new System.EventHandler(this.buttonOpenCloseCom_Click);
            // 
            // groupBoxSendSetting
            // 
            this.groupBoxSendSetting.Controls.Add(this.radioButtonSendDataHex);
            this.groupBoxSendSetting.Controls.Add(this.radioButtonSendDataASCII);
            this.groupBoxSendSetting.Location = new System.Drawing.Point(12, 278);
            this.groupBoxSendSetting.Name = "groupBoxSendSetting";
            this.groupBoxSendSetting.Size = new System.Drawing.Size(200, 100);
            this.groupBoxSendSetting.TabIndex = 5;
            this.groupBoxSendSetting.TabStop = false;
            this.groupBoxSendSetting.Text = "发送设置";
            // 
            // radioButtonSendDataHex
            // 
            this.radioButtonSendDataHex.AutoSize = true;
            this.radioButtonSendDataHex.Location = new System.Drawing.Point(82, 22);
            this.radioButtonSendDataHex.Name = "radioButtonSendDataHex";
            this.radioButtonSendDataHex.Size = new System.Drawing.Size(60, 24);
            this.radioButtonSendDataHex.TabIndex = 1;
            this.radioButtonSendDataHex.TabStop = true;
            this.radioButtonSendDataHex.Text = "HEX";
            this.radioButtonSendDataHex.UseVisualStyleBackColor = true;
            // 
            // radioButtonSendDataASCII
            // 
            this.radioButtonSendDataASCII.AutoSize = true;
            this.radioButtonSendDataASCII.Location = new System.Drawing.Point(19, 23);
            this.radioButtonSendDataASCII.Name = "radioButtonSendDataASCII";
            this.radioButtonSendDataASCII.Size = new System.Drawing.Size(68, 24);
            this.radioButtonSendDataASCII.TabIndex = 0;
            this.radioButtonSendDataASCII.TabStop = true;
            this.radioButtonSendDataASCII.Text = "ASCII";
            this.radioButtonSendDataASCII.UseVisualStyleBackColor = true;
            // 
            // groupBoxReceiveSetting
            // 
            this.groupBoxReceiveSetting.Controls.Add(this.radioButtonReceiveDataHEX);
            this.groupBoxReceiveSetting.Controls.Add(this.radioButtonReceiveDataASCII);
            this.groupBoxReceiveSetting.Location = new System.Drawing.Point(12, 384);
            this.groupBoxReceiveSetting.Name = "groupBoxReceiveSetting";
            this.groupBoxReceiveSetting.Size = new System.Drawing.Size(200, 100);
            this.groupBoxReceiveSetting.TabIndex = 6;
            this.groupBoxReceiveSetting.TabStop = false;
            this.groupBoxReceiveSetting.Text = "接收设置";
            // 
            // radioButtonReceiveDataHEX
            // 
            this.radioButtonReceiveDataHEX.AutoSize = true;
            this.radioButtonReceiveDataHEX.Location = new System.Drawing.Point(82, 22);
            this.radioButtonReceiveDataHEX.Name = "radioButtonReceiveDataHEX";
            this.radioButtonReceiveDataHEX.Size = new System.Drawing.Size(60, 24);
            this.radioButtonReceiveDataHEX.TabIndex = 1;
            this.radioButtonReceiveDataHEX.TabStop = true;
            this.radioButtonReceiveDataHEX.Text = "HEX";
            this.radioButtonReceiveDataHEX.UseVisualStyleBackColor = true;
            // 
            // radioButtonReceiveDataASCII
            // 
            this.radioButtonReceiveDataASCII.AutoSize = true;
            this.radioButtonReceiveDataASCII.Location = new System.Drawing.Point(19, 22);
            this.radioButtonReceiveDataASCII.Name = "radioButtonReceiveDataASCII";
            this.radioButtonReceiveDataASCII.Size = new System.Drawing.Size(68, 24);
            this.radioButtonReceiveDataASCII.TabIndex = 0;
            this.radioButtonReceiveDataASCII.TabStop = true;
            this.radioButtonReceiveDataASCII.Text = "ASCII";
            this.radioButtonReceiveDataASCII.UseVisualStyleBackColor = true;
            // 
            // groupBoxReceiveData
            // 
            this.groupBoxReceiveData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxReceiveData.Controls.Add(this.buttonClearRecData);
            this.groupBoxReceiveData.Controls.Add(this.textBoxReceive);
            this.groupBoxReceiveData.Location = new System.Drawing.Point(254, 87);
            this.groupBoxReceiveData.Name = "groupBoxReceiveData";
            this.groupBoxReceiveData.Size = new System.Drawing.Size(276, 249);
            this.groupBoxReceiveData.TabIndex = 7;
            this.groupBoxReceiveData.TabStop = false;
            this.groupBoxReceiveData.Text = "接收数据";
            // 
            // buttonClearRecData
            // 
            this.buttonClearRecData.Location = new System.Drawing.Point(195, 221);
            this.buttonClearRecData.Name = "buttonClearRecData";
            this.buttonClearRecData.Size = new System.Drawing.Size(75, 23);
            this.buttonClearRecData.TabIndex = 1;
            this.buttonClearRecData.Text = "清空";
            this.buttonClearRecData.UseVisualStyleBackColor = true;
            this.buttonClearRecData.Click += new System.EventHandler(this.buttonClearRecData_Click);
            // 
            // textBoxReceive
            // 
            this.textBoxReceive.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBoxReceive.Location = new System.Drawing.Point(3, 19);
            this.textBoxReceive.Multiline = true;
            this.textBoxReceive.Name = "textBoxReceive";
            this.textBoxReceive.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxReceive.Size = new System.Drawing.Size(270, 193);
            this.textBoxReceive.TabIndex = 0;
            // 
            // groupBoxSendData
            // 
            this.groupBoxSendData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSendData.Controls.Add(this.buttonSendData);
            this.groupBoxSendData.Controls.Add(this.textBoxSend);
            this.groupBoxSendData.Location = new System.Drawing.Point(254, 384);
            this.groupBoxSendData.Name = "groupBoxSendData";
            this.groupBoxSendData.Size = new System.Drawing.Size(276, 100);
            this.groupBoxSendData.TabIndex = 8;
            this.groupBoxSendData.TabStop = false;
            this.groupBoxSendData.Text = "发送数据";
            // 
            // buttonSendData
            // 
            this.buttonSendData.Location = new System.Drawing.Point(195, 71);
            this.buttonSendData.Name = "buttonSendData";
            this.buttonSendData.Size = new System.Drawing.Size(75, 23);
            this.buttonSendData.TabIndex = 1;
            this.buttonSendData.Text = "发送";
            this.buttonSendData.UseVisualStyleBackColor = true;
            this.buttonSendData.Click += new System.EventHandler(this.buttonSendData_Click);
            // 
            // textBoxSend
            // 
            this.textBoxSend.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxSend.Location = new System.Drawing.Point(3, 23);
            this.textBoxSend.Multiline = true;
            this.textBoxSend.Name = "textBoxSend";
            this.textBoxSend.Size = new System.Drawing.Size(270, 45);
            this.textBoxSend.TabIndex = 0;
            // 
            // Button_Refresh
            // 
            this.Button_Refresh.Location = new System.Drawing.Point(254, 38);
            this.Button_Refresh.Name = "Button_Refresh";
            this.Button_Refresh.Size = new System.Drawing.Size(110, 38);
            this.Button_Refresh.TabIndex = 10;
            this.Button_Refresh.Text = "刷新串口列表";
            this.Button_Refresh.UseVisualStyleBackColor = true;
            this.Button_Refresh.Click += new System.EventHandler(this.Button_Refresh_Click);
            // 
            // SaveReceiveDataToFileToolStripMenuItem
            // 
            this.SaveReceiveDataToFileToolStripMenuItem.Name = "SaveReceiveDataToFileToolStripMenuItem";
            this.SaveReceiveDataToFileToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.SaveReceiveDataToFileToolStripMenuItem.Text = "保存接收数据";
            this.SaveReceiveDataToFileToolStripMenuItem.Click += new System.EventHandler(this.SaveReceiveDataToFileToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 512);
            this.Controls.Add(this.Button_Refresh);
            this.Controls.Add(this.groupBoxSendData);
            this.Controls.Add(this.groupBoxReceiveData);
            this.Controls.Add(this.groupBoxReceiveSetting);
            this.Controls.Add(this.groupBoxSendSetting);
            this.Controls.Add(this.buttonOpenCloseCom);
            this.Controls.Add(this.groupBoxSerialPortSetting);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "串口调试软件";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxSerialPortSetting.ResumeLayout(false);
            this.groupBoxSerialPortSetting.PerformLayout();
            this.groupBoxSendSetting.ResumeLayout(false);
            this.groupBoxSendSetting.PerformLayout();
            this.groupBoxReceiveSetting.ResumeLayout(false);
            this.groupBoxReceiveSetting.PerformLayout();
            this.groupBoxReceiveData.ResumeLayout(false);
            this.groupBoxReceiveData.PerformLayout();
            this.groupBoxSendData.ResumeLayout(false);
            this.groupBoxSendData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuFile;
        private System.Windows.Forms.ToolStripMenuItem MenuTools;
        private System.Windows.Forms.ToolStripMenuItem MenuSetting;
        private System.Windows.Forms.ToolStripMenuItem MenuIHelp;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.GroupBox groupBoxSerialPortSetting;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxStopBit;
        private System.Windows.Forms.ComboBox comboBoxCheckBit;
        private System.Windows.Forms.ComboBox comboBoxDataBit;
        private System.Windows.Forms.ComboBox comboBoxBaudRate;
        private System.Windows.Forms.ComboBox comboBoxCom;
        private System.Windows.Forms.Button buttonOpenCloseCom;
        private System.Windows.Forms.GroupBox groupBoxSendSetting;
        private System.Windows.Forms.RadioButton radioButtonSendDataASCII;
        private System.Windows.Forms.RadioButton radioButtonSendDataHex;
        private System.Windows.Forms.GroupBox groupBoxReceiveSetting;
        private System.Windows.Forms.RadioButton radioButtonReceiveDataASCII;
        private System.Windows.Forms.RadioButton radioButtonReceiveDataHEX;
        private System.Windows.Forms.GroupBox groupBoxReceiveData;
        private System.Windows.Forms.TextBox textBoxReceive;
        private System.Windows.Forms.GroupBox groupBoxSendData;
        private System.Windows.Forms.Button buttonClearRecData;
        private System.Windows.Forms.TextBox textBoxSend;
        private System.Windows.Forms.Button buttonSendData;
        private System.Windows.Forms.Button Button_Refresh;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AuthorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ContributorSylvesterLiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ResetPortConfToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveReceiveDataToFileToolStripMenuItem;
    }
}

