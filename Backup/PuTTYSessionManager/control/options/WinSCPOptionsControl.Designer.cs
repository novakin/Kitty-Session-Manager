namespace uk.org.riseley.puttySessionManager.control.options
{
    partial class WinSCPOptionsControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.wsTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.locateWinSCPButton = new System.Windows.Forms.Button();
            this.enableWinSCPCheckBox = new System.Windows.Forms.CheckBox();
            this.winSCPIniTextBox = new System.Windows.Forms.TextBox();
            this.useWinSCPIniCheckBox = new System.Windows.Forms.CheckBox();
            this.locateWinSCPIniButton = new System.Windows.Forms.Button();
            this.winSCPTextBox = new System.Windows.Forms.TextBox();
            this.wsVerGroupBox = new System.Windows.Forms.GroupBox();
            this.wsVerTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.wsVer3RadioButton = new System.Windows.Forms.RadioButton();
            this.wsVer4RadioButton = new System.Windows.Forms.RadioButton();
            this.wsProtoGroupBox = new System.Windows.Forms.GroupBox();
            this.wsProtoTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.wsSessionInfoRadioButton = new System.Windows.Forms.RadioButton();
            this.wsPrefGroupBox = new System.Windows.Forms.GroupBox();
            this.wsPrefProtoTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.wsprefSftpRadioButton = new System.Windows.Forms.RadioButton();
            this.wsprefScpRadioButton = new System.Windows.Forms.RadioButton();
            this.wsFtpRadioButton = new System.Windows.Forms.RadioButton();
            this.wsSftpRadioButton = new System.Windows.Forms.RadioButton();
            this.wsScpRadioButton = new System.Windows.Forms.RadioButton();
            this.wsTableLayout.SuspendLayout();
            this.wsVerGroupBox.SuspendLayout();
            this.wsVerTableLayout.SuspendLayout();
            this.wsProtoGroupBox.SuspendLayout();
            this.wsProtoTableLayout.SuspendLayout();
            this.wsPrefGroupBox.SuspendLayout();
            this.wsPrefProtoTableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // wsTableLayout
            // 
            this.wsTableLayout.ColumnCount = 2;
            this.wsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.wsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.wsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.wsTableLayout.Controls.Add(this.locateWinSCPButton, 0, 4);
            this.wsTableLayout.Controls.Add(this.enableWinSCPCheckBox, 0, 0);
            this.wsTableLayout.Controls.Add(this.winSCPIniTextBox, 1, 3);
            this.wsTableLayout.Controls.Add(this.useWinSCPIniCheckBox, 0, 2);
            this.wsTableLayout.Controls.Add(this.locateWinSCPIniButton, 0, 3);
            this.wsTableLayout.Controls.Add(this.winSCPTextBox, 1, 4);
            this.wsTableLayout.Controls.Add(this.wsVerGroupBox, 0, 1);
            this.wsTableLayout.Controls.Add(this.wsProtoGroupBox, 1, 0);
            this.wsTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wsTableLayout.Location = new System.Drawing.Point(0, 0);
            this.wsTableLayout.Name = "wsTableLayout";
            this.wsTableLayout.RowCount = 5;
            this.wsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.wsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.wsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.wsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.wsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.wsTableLayout.Size = new System.Drawing.Size(384, 184);
            this.wsTableLayout.TabIndex = 32;
            // 
            // locateWinSCPButton
            // 
            this.locateWinSCPButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.locateWinSCPButton.AutoSize = true;
            this.locateWinSCPButton.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", global::uk.org.riseley.puttySessionManager.Properties.Settings.Default, "WinSCPEnabled", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.locateWinSCPButton.Enabled = global::uk.org.riseley.puttySessionManager.Properties.Settings.Default.WinSCPEnabled;
            this.locateWinSCPButton.Location = new System.Drawing.Point(3, 154);
            this.locateWinSCPButton.Name = "locateWinSCPButton";
            this.locateWinSCPButton.Size = new System.Drawing.Size(142, 24);
            this.locateWinSCPButton.TabIndex = 25;
            this.locateWinSCPButton.Text = "&Locate WinSCP*.exe";
            this.locateWinSCPButton.UseVisualStyleBackColor = true;
            this.locateWinSCPButton.Click += new System.EventHandler(this.locateWinSCPButton_Click);
            // 
            // enableWinSCPCheckBox
            // 
            this.enableWinSCPCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.enableWinSCPCheckBox.AutoSize = true;
            this.enableWinSCPCheckBox.Checked = global::uk.org.riseley.puttySessionManager.Properties.Settings.Default.WinSCPEnabled;
            this.enableWinSCPCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::uk.org.riseley.puttySessionManager.Properties.Settings.Default, "WinSCPEnabled", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.enableWinSCPCheckBox.Location = new System.Drawing.Point(3, 3);
            this.enableWinSCPCheckBox.Name = "enableWinSCPCheckBox";
            this.enableWinSCPCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.enableWinSCPCheckBox.Size = new System.Drawing.Size(142, 17);
            this.enableWinSCPCheckBox.TabIndex = 23;
            this.enableWinSCPCheckBox.Text = "Enable WinSCP Support";
            this.enableWinSCPCheckBox.UseVisualStyleBackColor = true;
            // 
            // winSCPIniTextBox
            // 
            this.winSCPIniTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.winSCPIniTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", global::uk.org.riseley.puttySessionManager.Properties.Settings.Default, "WinSCPEnabled", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.winSCPIniTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::uk.org.riseley.puttySessionManager.Properties.Settings.Default, "WinSCPIniLocation", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.winSCPIniTextBox.Enabled = global::uk.org.riseley.puttySessionManager.Properties.Settings.Default.WinSCPEnabled;
            this.winSCPIniTextBox.Location = new System.Drawing.Point(151, 126);
            this.winSCPIniTextBox.Name = "winSCPIniTextBox";
            this.winSCPIniTextBox.ReadOnly = true;
            this.winSCPIniTextBox.Size = new System.Drawing.Size(230, 20);
            this.winSCPIniTextBox.TabIndex = 30;
            this.winSCPIniTextBox.Text = global::uk.org.riseley.puttySessionManager.Properties.Settings.Default.WinSCPIniLocation;
            // 
            // useWinSCPIniCheckBox
            // 
            this.useWinSCPIniCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.useWinSCPIniCheckBox.AutoSize = true;
            this.useWinSCPIniCheckBox.Checked = global::uk.org.riseley.puttySessionManager.Properties.Settings.Default.WinSCPIniEnabled;
            this.useWinSCPIniCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::uk.org.riseley.puttySessionManager.Properties.Settings.Default, "WinSCPIniEnabled", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.useWinSCPIniCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", global::uk.org.riseley.puttySessionManager.Properties.Settings.Default, "WinSCPEnabled", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.useWinSCPIniCheckBox.Enabled = global::uk.org.riseley.puttySessionManager.Properties.Settings.Default.WinSCPEnabled;
            this.useWinSCPIniCheckBox.Location = new System.Drawing.Point(28, 101);
            this.useWinSCPIniCheckBox.Name = "useWinSCPIniCheckBox";
            this.useWinSCPIniCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.useWinSCPIniCheckBox.Size = new System.Drawing.Size(117, 17);
            this.useWinSCPIniCheckBox.TabIndex = 28;
            this.useWinSCPIniCheckBox.Text = "Use WinSCP ini file";
            this.optionsToolTip.SetToolTip(this.useWinSCPIniCheckBox, "Pass the /ini option to WinSCP.\r\nUse the ini file in the location specified below" +
                    ".");
            this.useWinSCPIniCheckBox.UseVisualStyleBackColor = true;
            // 
            // locateWinSCPIniButton
            // 
            this.locateWinSCPIniButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.locateWinSCPIniButton.AutoSize = true;
            this.locateWinSCPIniButton.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", global::uk.org.riseley.puttySessionManager.Properties.Settings.Default, "WinSCPEnabled", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.locateWinSCPIniButton.Enabled = global::uk.org.riseley.puttySessionManager.Properties.Settings.Default.WinSCPEnabled;
            this.locateWinSCPIniButton.Location = new System.Drawing.Point(3, 124);
            this.locateWinSCPIniButton.Name = "locateWinSCPIniButton";
            this.locateWinSCPIniButton.Size = new System.Drawing.Size(142, 24);
            this.locateWinSCPIniButton.TabIndex = 29;
            this.locateWinSCPIniButton.Text = "&Locate WinSCP ini file";
            this.locateWinSCPIniButton.UseVisualStyleBackColor = true;
            this.locateWinSCPIniButton.Click += new System.EventHandler(this.locateWinSCPIniButton_Click);
            // 
            // winSCPTextBox
            // 
            this.winSCPTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.winSCPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", global::uk.org.riseley.puttySessionManager.Properties.Settings.Default, "WinSCPEnabled", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.winSCPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::uk.org.riseley.puttySessionManager.Properties.Settings.Default, "WinSCPLocation", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.winSCPTextBox.Enabled = global::uk.org.riseley.puttySessionManager.Properties.Settings.Default.WinSCPEnabled;
            this.winSCPTextBox.Location = new System.Drawing.Point(151, 154);
            this.winSCPTextBox.Name = "winSCPTextBox";
            this.winSCPTextBox.ReadOnly = true;
            this.winSCPTextBox.Size = new System.Drawing.Size(230, 20);
            this.winSCPTextBox.TabIndex = 24;
            this.winSCPTextBox.Text = global::uk.org.riseley.puttySessionManager.Properties.Settings.Default.WinSCPLocation;
            // 
            // wsVerGroupBox
            // 
            this.wsVerGroupBox.Controls.Add(this.wsVerTableLayout);
            this.wsVerGroupBox.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", global::uk.org.riseley.puttySessionManager.Properties.Settings.Default, "WinSCPEnabled", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.wsVerGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wsVerGroupBox.Enabled = global::uk.org.riseley.puttySessionManager.Properties.Settings.Default.WinSCPEnabled;
            this.wsVerGroupBox.Location = new System.Drawing.Point(3, 26);
            this.wsVerGroupBox.Name = "wsVerGroupBox";
            this.wsVerGroupBox.Size = new System.Drawing.Size(142, 43);
            this.wsVerGroupBox.TabIndex = 27;
            this.wsVerGroupBox.TabStop = false;
            this.wsVerGroupBox.Text = "WinSCP Version";
            // 
            // wsVerTableLayout
            // 
            this.wsVerTableLayout.ColumnCount = 2;
            this.wsVerTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.wsVerTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.wsVerTableLayout.Controls.Add(this.wsVer3RadioButton, 0, 0);
            this.wsVerTableLayout.Controls.Add(this.wsVer4RadioButton, 1, 0);
            this.wsVerTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wsVerTableLayout.Location = new System.Drawing.Point(3, 16);
            this.wsVerTableLayout.Name = "wsVerTableLayout";
            this.wsVerTableLayout.RowCount = 1;
            this.wsVerTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.wsVerTableLayout.Size = new System.Drawing.Size(136, 24);
            this.wsVerTableLayout.TabIndex = 2;
            // 
            // wsVer3RadioButton
            // 
            this.wsVer3RadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.wsVer3RadioButton.Checked = true;
            this.wsVer3RadioButton.Location = new System.Drawing.Point(3, 3);
            this.wsVer3RadioButton.Name = "wsVer3RadioButton";
            this.wsVer3RadioButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.wsVer3RadioButton.Size = new System.Drawing.Size(62, 17);
            this.wsVer3RadioButton.TabIndex = 0;
            this.wsVer3RadioButton.TabStop = true;
            this.wsVer3RadioButton.Text = "3.X";
            this.wsVer3RadioButton.UseVisualStyleBackColor = true;
            this.wsVer3RadioButton.CheckedChanged += new System.EventHandler(this.wsVerRadioButton_CheckedChanged);
            // 
            // wsVer4RadioButton
            // 
            this.wsVer4RadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.wsVer4RadioButton.Location = new System.Drawing.Point(71, 3);
            this.wsVer4RadioButton.Name = "wsVer4RadioButton";
            this.wsVer4RadioButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.wsVer4RadioButton.Size = new System.Drawing.Size(62, 17);
            this.wsVer4RadioButton.TabIndex = 1;
            this.wsVer4RadioButton.Text = "4.X";
            this.wsVer4RadioButton.UseVisualStyleBackColor = true;
            this.wsVer4RadioButton.CheckedChanged += new System.EventHandler(this.wsVerRadioButton_CheckedChanged);
            // 
            // wsProtoGroupBox
            // 
            this.wsProtoGroupBox.Controls.Add(this.wsProtoTableLayout);
            this.wsProtoGroupBox.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", global::uk.org.riseley.puttySessionManager.Properties.Settings.Default, "WinSCPEnabled", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.wsProtoGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wsProtoGroupBox.Enabled = global::uk.org.riseley.puttySessionManager.Properties.Settings.Default.WinSCPEnabled;
            this.wsProtoGroupBox.Location = new System.Drawing.Point(151, 3);
            this.wsProtoGroupBox.Name = "wsProtoGroupBox";
            this.wsTableLayout.SetRowSpan(this.wsProtoGroupBox, 3);
            this.wsProtoGroupBox.Size = new System.Drawing.Size(230, 115);
            this.wsProtoGroupBox.TabIndex = 26;
            this.wsProtoGroupBox.TabStop = false;
            this.wsProtoGroupBox.Text = "Protocol";
            // 
            // wsProtoTableLayout
            // 
            this.wsProtoTableLayout.ColumnCount = 2;
            this.wsProtoTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66F));
            this.wsProtoTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.wsProtoTableLayout.Controls.Add(this.wsSessionInfoRadioButton, 0, 0);
            this.wsProtoTableLayout.Controls.Add(this.wsPrefGroupBox, 0, 1);
            this.wsProtoTableLayout.Controls.Add(this.wsFtpRadioButton, 1, 2);
            this.wsProtoTableLayout.Controls.Add(this.wsSftpRadioButton, 2, 1);
            this.wsProtoTableLayout.Controls.Add(this.wsScpRadioButton, 2, 0);
            this.wsProtoTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wsProtoTableLayout.Location = new System.Drawing.Point(3, 16);
            this.wsProtoTableLayout.Name = "wsProtoTableLayout";
            this.wsProtoTableLayout.RowCount = 3;
            this.wsProtoTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.wsProtoTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.wsProtoTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.wsProtoTableLayout.Size = new System.Drawing.Size(224, 96);
            this.wsProtoTableLayout.TabIndex = 5;
            // 
            // wsSessionInfoRadioButton
            // 
            this.wsSessionInfoRadioButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.wsSessionInfoRadioButton.AutoSize = true;
            this.wsSessionInfoRadioButton.Checked = true;
            this.wsSessionInfoRadioButton.Location = new System.Drawing.Point(5, 3);
            this.wsSessionInfoRadioButton.Name = "wsSessionInfoRadioButton";
            this.wsSessionInfoRadioButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.wsSessionInfoRadioButton.Size = new System.Drawing.Size(139, 17);
            this.wsSessionInfoRadioButton.TabIndex = 3;
            this.wsSessionInfoRadioButton.TabStop = true;
            this.wsSessionInfoRadioButton.Text = "Use Session Information";
            this.wsSessionInfoRadioButton.UseVisualStyleBackColor = true;
            this.wsSessionInfoRadioButton.CheckedChanged += new System.EventHandler(this.protocolRadioButton_CheckedChanged);
            // 
            // wsPrefGroupBox
            // 
            this.wsPrefGroupBox.Controls.Add(this.wsPrefProtoTableLayout);
            this.wsPrefGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wsPrefGroupBox.Location = new System.Drawing.Point(3, 26);
            this.wsPrefGroupBox.Name = "wsPrefGroupBox";
            this.wsProtoTableLayout.SetRowSpan(this.wsPrefGroupBox, 2);
            this.wsPrefGroupBox.Size = new System.Drawing.Size(141, 67);
            this.wsPrefGroupBox.TabIndex = 4;
            this.wsPrefGroupBox.TabStop = false;
            this.wsPrefGroupBox.Text = "Preferred Protocol";
            // 
            // wsPrefProtoTableLayout
            // 
            this.wsPrefProtoTableLayout.ColumnCount = 1;
            this.wsPrefProtoTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.wsPrefProtoTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.wsPrefProtoTableLayout.Controls.Add(this.wsprefSftpRadioButton, 0, 0);
            this.wsPrefProtoTableLayout.Controls.Add(this.wsprefScpRadioButton, 0, 1);
            this.wsPrefProtoTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wsPrefProtoTableLayout.Location = new System.Drawing.Point(3, 16);
            this.wsPrefProtoTableLayout.Name = "wsPrefProtoTableLayout";
            this.wsPrefProtoTableLayout.RowCount = 2;
            this.wsPrefProtoTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.wsPrefProtoTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.wsPrefProtoTableLayout.Size = new System.Drawing.Size(135, 48);
            this.wsPrefProtoTableLayout.TabIndex = 5;
            // 
            // wsprefSftpRadioButton
            // 
            this.wsprefSftpRadioButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.wsprefSftpRadioButton.AutoSize = true;
            this.wsprefSftpRadioButton.Checked = true;
            this.wsprefSftpRadioButton.Location = new System.Drawing.Point(62, 3);
            this.wsprefSftpRadioButton.Name = "wsprefSftpRadioButton";
            this.wsprefSftpRadioButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.wsprefSftpRadioButton.Size = new System.Drawing.Size(70, 17);
            this.wsprefSftpRadioButton.TabIndex = 3;
            this.wsprefSftpRadioButton.TabStop = true;
            this.wsprefSftpRadioButton.Text = "SFTP(22)";
            this.wsprefSftpRadioButton.UseVisualStyleBackColor = true;
            this.wsprefSftpRadioButton.CheckedChanged += new System.EventHandler(this.protocolRadioButton_CheckedChanged);
            // 
            // wsprefScpRadioButton
            // 
            this.wsprefScpRadioButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.wsprefScpRadioButton.AutoSize = true;
            this.wsprefScpRadioButton.Location = new System.Drawing.Point(68, 27);
            this.wsprefScpRadioButton.Name = "wsprefScpRadioButton";
            this.wsprefScpRadioButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.wsprefScpRadioButton.Size = new System.Drawing.Size(64, 17);
            this.wsprefScpRadioButton.TabIndex = 4;
            this.wsprefScpRadioButton.Text = "SCP(22)";
            this.wsprefScpRadioButton.UseVisualStyleBackColor = true;
            this.wsprefScpRadioButton.CheckedChanged += new System.EventHandler(this.protocolRadioButton_CheckedChanged);
            // 
            // wsFtpRadioButton
            // 
            this.wsFtpRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.wsFtpRadioButton.AutoSize = true;
            this.wsFtpRadioButton.Location = new System.Drawing.Point(155, 49);
            this.wsFtpRadioButton.Name = "wsFtpRadioButton";
            this.wsFtpRadioButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.wsFtpRadioButton.Size = new System.Drawing.Size(66, 17);
            this.wsFtpRadioButton.TabIndex = 0;
            this.wsFtpRadioButton.TabStop = true;
            this.wsFtpRadioButton.Text = "FTP (21)";
            this.wsFtpRadioButton.UseVisualStyleBackColor = true;
            this.wsFtpRadioButton.CheckedChanged += new System.EventHandler(this.protocolRadioButton_CheckedChanged);
            // 
            // wsSftpRadioButton
            // 
            this.wsSftpRadioButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.wsSftpRadioButton.AutoSize = true;
            this.wsSftpRadioButton.Location = new System.Drawing.Point(151, 26);
            this.wsSftpRadioButton.Name = "wsSftpRadioButton";
            this.wsSftpRadioButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.wsSftpRadioButton.Size = new System.Drawing.Size(70, 17);
            this.wsSftpRadioButton.TabIndex = 1;
            this.wsSftpRadioButton.TabStop = true;
            this.wsSftpRadioButton.Text = "SFTP(22)";
            this.wsSftpRadioButton.UseVisualStyleBackColor = true;
            this.wsSftpRadioButton.CheckedChanged += new System.EventHandler(this.protocolRadioButton_CheckedChanged);
            // 
            // wsScpRadioButton
            // 
            this.wsScpRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.wsScpRadioButton.AutoSize = true;
            this.wsScpRadioButton.Location = new System.Drawing.Point(157, 3);
            this.wsScpRadioButton.Name = "wsScpRadioButton";
            this.wsScpRadioButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.wsScpRadioButton.Size = new System.Drawing.Size(64, 17);
            this.wsScpRadioButton.TabIndex = 2;
            this.wsScpRadioButton.TabStop = true;
            this.wsScpRadioButton.Text = "SCP(22)";
            this.wsScpRadioButton.UseVisualStyleBackColor = true;
            this.wsScpRadioButton.CheckedChanged += new System.EventHandler(this.protocolRadioButton_CheckedChanged);
            // 
            // WinSCPOptionsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.wsTableLayout);
            this.Name = "WinSCPOptionsControl";
            this.Size = new System.Drawing.Size(384, 184);
            this.wsTableLayout.ResumeLayout(false);
            this.wsTableLayout.PerformLayout();
            this.wsVerGroupBox.ResumeLayout(false);
            this.wsVerTableLayout.ResumeLayout(false);
            this.wsProtoGroupBox.ResumeLayout(false);
            this.wsProtoTableLayout.ResumeLayout(false);
            this.wsProtoTableLayout.PerformLayout();
            this.wsPrefGroupBox.ResumeLayout(false);
            this.wsPrefProtoTableLayout.ResumeLayout(false);
            this.wsPrefProtoTableLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel wsTableLayout;
        private System.Windows.Forms.Button locateWinSCPButton;
        private System.Windows.Forms.CheckBox enableWinSCPCheckBox;
        private System.Windows.Forms.TextBox winSCPIniTextBox;
        private System.Windows.Forms.CheckBox useWinSCPIniCheckBox;
        private System.Windows.Forms.Button locateWinSCPIniButton;
        private System.Windows.Forms.TextBox winSCPTextBox;
        private System.Windows.Forms.GroupBox wsVerGroupBox;
        private System.Windows.Forms.TableLayoutPanel wsVerTableLayout;
        private System.Windows.Forms.RadioButton wsVer3RadioButton;
        private System.Windows.Forms.RadioButton wsVer4RadioButton;
        private System.Windows.Forms.GroupBox wsProtoGroupBox;
        private System.Windows.Forms.TableLayoutPanel wsProtoTableLayout;
        private System.Windows.Forms.RadioButton wsSessionInfoRadioButton;
        private System.Windows.Forms.GroupBox wsPrefGroupBox;
        private System.Windows.Forms.TableLayoutPanel wsPrefProtoTableLayout;
        private System.Windows.Forms.RadioButton wsprefSftpRadioButton;
        private System.Windows.Forms.RadioButton wsprefScpRadioButton;
        private System.Windows.Forms.RadioButton wsFtpRadioButton;
        private System.Windows.Forms.RadioButton wsSftpRadioButton;
        private System.Windows.Forms.RadioButton wsScpRadioButton;
    }
}
