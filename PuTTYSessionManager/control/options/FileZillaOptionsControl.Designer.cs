/* 
 * Copyright (C) 2008 David Riseley 
 *
 * This program is free software; you can redistribute it and/or
 * modify it under the terms of the GNU General Public License
 * as published by the Free Software Foundation; either version 2
 * of the License, or (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program; if not, write to the Free Software
 * Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.
 */
namespace uk.org.riseley.puttySessionManager.control.options
{
    partial class FileZillaOptionsControl
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
            this.components = new System.ComponentModel.Container();
            this.filezillaTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.locateFileZillaButton = new System.Windows.Forms.Button();
            this.protocolGroupBox = new System.Windows.Forms.GroupBox();
            this.filezillaProtoTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.fzSessionInfoRadioButton = new System.Windows.Forms.RadioButton();
            this.fzFtpsRadioButton = new System.Windows.Forms.RadioButton();
            this.fzFtpRadioButton = new System.Windows.Forms.RadioButton();
            this.fzSftpRadioButton = new System.Windows.Forms.RadioButton();
            this.sshAuthCheckBox = new System.Windows.Forms.CheckBox();
            this.enableFileZillaCheckBox = new System.Windows.Forms.CheckBox();
            this.filezillaTextBox = new System.Windows.Forms.TextBox();
            this.filezillaTableLayout.SuspendLayout();
            this.protocolGroupBox.SuspendLayout();
            this.filezillaProtoTableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // filezillaTableLayout
            // 
            this.filezillaTableLayout.ColumnCount = 3;
            this.filezillaTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.filezillaTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.filezillaTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.filezillaTableLayout.Controls.Add(this.locateFileZillaButton, 0, 2);
            this.filezillaTableLayout.Controls.Add(this.protocolGroupBox, 2, 0);
            this.filezillaTableLayout.Controls.Add(this.sshAuthCheckBox, 0, 1);
            this.filezillaTableLayout.Controls.Add(this.enableFileZillaCheckBox, 0, 0);
            this.filezillaTableLayout.Controls.Add(this.filezillaTextBox, 1, 2);
            this.filezillaTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filezillaTableLayout.Location = new System.Drawing.Point(0, 0);
            this.filezillaTableLayout.Name = "filezillaTableLayout";
            this.filezillaTableLayout.RowCount = 3;
            this.filezillaTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.filezillaTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.filezillaTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.filezillaTableLayout.Size = new System.Drawing.Size(362, 157);
            this.filezillaTableLayout.TabIndex = 24;
            // 
            // locateFileZillaButton
            // 
            this.locateFileZillaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.locateFileZillaButton.AutoSize = true;
            this.locateFileZillaButton.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", global::uk.org.riseley.puttySessionManager.Properties.Settings.Default, "FileZillaEnabled", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.locateFileZillaButton.Enabled = global::uk.org.riseley.puttySessionManager.Properties.Settings.Default.FileZillaEnabled;
            this.locateFileZillaButton.Location = new System.Drawing.Point(9, 129);
            this.locateFileZillaButton.Name = "locateFileZillaButton";
            this.locateFileZillaButton.Size = new System.Drawing.Size(108, 24);
            this.locateFileZillaButton.TabIndex = 19;
            this.locateFileZillaButton.Text = "&Locate FileZilla.exe";
            this.locateFileZillaButton.UseVisualStyleBackColor = true;
            this.locateFileZillaButton.Click += new System.EventHandler(this.locateFileZillaButton_Click);
            // 
            // protocolGroupBox
            // 
            this.protocolGroupBox.Controls.Add(this.filezillaProtoTableLayout);
            this.protocolGroupBox.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", global::uk.org.riseley.puttySessionManager.Properties.Settings.Default, "FileZillaEnabled", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.protocolGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.protocolGroupBox.Enabled = global::uk.org.riseley.puttySessionManager.Properties.Settings.Default.FileZillaEnabled;
            this.protocolGroupBox.Location = new System.Drawing.Point(243, 3);
            this.protocolGroupBox.Name = "protocolGroupBox";
            this.filezillaTableLayout.SetRowSpan(this.protocolGroupBox, 2);
            this.protocolGroupBox.Size = new System.Drawing.Size(116, 120);
            this.protocolGroupBox.TabIndex = 20;
            this.protocolGroupBox.TabStop = false;
            this.protocolGroupBox.Text = "Protocol";
            // 
            // filezillaProtoTableLayout
            // 
            this.filezillaProtoTableLayout.ColumnCount = 1;
            this.filezillaProtoTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.filezillaProtoTableLayout.Controls.Add(this.fzSessionInfoRadioButton, 0, 0);
            this.filezillaProtoTableLayout.Controls.Add(this.fzFtpsRadioButton, 0, 3);
            this.filezillaProtoTableLayout.Controls.Add(this.fzFtpRadioButton, 0, 1);
            this.filezillaProtoTableLayout.Controls.Add(this.fzSftpRadioButton, 0, 2);
            this.filezillaProtoTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filezillaProtoTableLayout.Location = new System.Drawing.Point(3, 16);
            this.filezillaProtoTableLayout.Name = "filezillaProtoTableLayout";
            this.filezillaProtoTableLayout.RowCount = 4;
            this.filezillaProtoTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.filezillaProtoTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.filezillaProtoTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.filezillaProtoTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.filezillaProtoTableLayout.Size = new System.Drawing.Size(110, 101);
            this.filezillaProtoTableLayout.TabIndex = 4;
            // 
            // fzSessionInfoRadioButton
            // 
            this.fzSessionInfoRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fzSessionInfoRadioButton.AutoSize = true;
            this.fzSessionInfoRadioButton.Checked = true;
            this.fzSessionInfoRadioButton.Location = new System.Drawing.Point(3, 3);
            this.fzSessionInfoRadioButton.Name = "fzSessionInfoRadioButton";
            this.fzSessionInfoRadioButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.fzSessionInfoRadioButton.Size = new System.Drawing.Size(105, 17);
            this.fzSessionInfoRadioButton.TabIndex = 3;
            this.fzSessionInfoRadioButton.TabStop = true;
            this.fzSessionInfoRadioButton.Text = "Use Session Info";
            this.optionsToolTip.SetToolTip(this.fzSessionInfoRadioButton, "Use SFTP and the specified port for sessions defined as SSH,\r\notherwise default t" +
                    "o FTP on port 21");
            this.fzSessionInfoRadioButton.UseVisualStyleBackColor = true;
            this.fzSessionInfoRadioButton.CheckedChanged += new System.EventHandler(this.protocolRadioButton_CheckedChanged);
            // 
            // fzFtpsRadioButton
            // 
            this.fzFtpsRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fzFtpsRadioButton.AutoSize = true;
            this.fzFtpsRadioButton.Location = new System.Drawing.Point(32, 72);
            this.fzFtpsRadioButton.Name = "fzFtpsRadioButton";
            this.fzFtpsRadioButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.fzFtpsRadioButton.Size = new System.Drawing.Size(76, 17);
            this.fzFtpsRadioButton.TabIndex = 2;
            this.fzFtpsRadioButton.TabStop = true;
            this.fzFtpsRadioButton.Text = "FTPS(990)";
            this.fzFtpsRadioButton.UseVisualStyleBackColor = true;
            this.fzFtpsRadioButton.CheckedChanged += new System.EventHandler(this.protocolRadioButton_CheckedChanged);
            // 
            // fzFtpRadioButton
            // 
            this.fzFtpRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fzFtpRadioButton.AutoSize = true;
            this.fzFtpRadioButton.Location = new System.Drawing.Point(42, 26);
            this.fzFtpRadioButton.Name = "fzFtpRadioButton";
            this.fzFtpRadioButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.fzFtpRadioButton.Size = new System.Drawing.Size(66, 17);
            this.fzFtpRadioButton.TabIndex = 0;
            this.fzFtpRadioButton.TabStop = true;
            this.fzFtpRadioButton.Text = "FTP (21)";
            this.fzFtpRadioButton.UseVisualStyleBackColor = true;
            this.fzFtpRadioButton.CheckedChanged += new System.EventHandler(this.protocolRadioButton_CheckedChanged);
            // 
            // fzSftpRadioButton
            // 
            this.fzSftpRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fzSftpRadioButton.AutoSize = true;
            this.fzSftpRadioButton.Location = new System.Drawing.Point(38, 49);
            this.fzSftpRadioButton.Name = "fzSftpRadioButton";
            this.fzSftpRadioButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.fzSftpRadioButton.Size = new System.Drawing.Size(70, 17);
            this.fzSftpRadioButton.TabIndex = 1;
            this.fzSftpRadioButton.TabStop = true;
            this.fzSftpRadioButton.Text = "SFTP(22)";
            this.fzSftpRadioButton.UseVisualStyleBackColor = true;
            this.fzSftpRadioButton.CheckedChanged += new System.EventHandler(this.protocolRadioButton_CheckedChanged);
            // 
            // sshAuthCheckBox
            // 
            this.sshAuthCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sshAuthCheckBox.AutoSize = true;
            this.sshAuthCheckBox.Checked = global::uk.org.riseley.puttySessionManager.Properties.Settings.Default.FileZillaAttemptKeyAuth;
            this.sshAuthCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.filezillaTableLayout.SetColumnSpan(this.sshAuthCheckBox, 2);
            this.sshAuthCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", global::uk.org.riseley.puttySessionManager.Properties.Settings.Default, "FileZillaEnabled", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.sshAuthCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::uk.org.riseley.puttySessionManager.Properties.Settings.Default, "FileZillaAttemptKeyAuth", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.sshAuthCheckBox.Enabled = global::uk.org.riseley.puttySessionManager.Properties.Settings.Default.FileZillaEnabled;
            this.sshAuthCheckBox.Location = new System.Drawing.Point(59, 66);
            this.sshAuthCheckBox.Name = "sshAuthCheckBox";
            this.sshAuthCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.sshAuthCheckBox.Size = new System.Drawing.Size(178, 17);
            this.sshAuthCheckBox.TabIndex = 22;
            this.sshAuthCheckBox.Text = "&Attempt SSH Key Auth for SFTP";
            this.optionsToolTip.SetToolTip(this.sshAuthCheckBox, "Use SFTP and the specified port for sessions defined as SSH,\r\notherwise default t" +
                    "o FTP on port 21");
            this.sshAuthCheckBox.UseVisualStyleBackColor = true;
            // 
            // enableFileZillaCheckBox
            // 
            this.enableFileZillaCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.enableFileZillaCheckBox.AutoSize = true;
            this.enableFileZillaCheckBox.Checked = global::uk.org.riseley.puttySessionManager.Properties.Settings.Default.FileZillaEnabled;
            this.filezillaTableLayout.SetColumnSpan(this.enableFileZillaCheckBox, 2);
            this.enableFileZillaCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::uk.org.riseley.puttySessionManager.Properties.Settings.Default, "FileZillaEnabled", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.enableFileZillaCheckBox.Location = new System.Drawing.Point(83, 43);
            this.enableFileZillaCheckBox.Name = "enableFileZillaCheckBox";
            this.enableFileZillaCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.enableFileZillaCheckBox.Size = new System.Drawing.Size(154, 17);
            this.enableFileZillaCheckBox.TabIndex = 0;
            this.enableFileZillaCheckBox.Text = "&Enable FileZilla 2.x Support";
            this.optionsToolTip.SetToolTip(this.enableFileZillaCheckBox, "Add support for FileZilla 2.x.\\nFileZilla sessions can be launched from the Sessi" +
                    "on Tree.\r\nNOTE: FileZilla 3.x is NOT currently supported.");
            this.enableFileZillaCheckBox.UseVisualStyleBackColor = true;
            // 
            // filezillaTextBox
            // 
            this.filezillaTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.filezillaTableLayout.SetColumnSpan(this.filezillaTextBox, 2);
            this.filezillaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::uk.org.riseley.puttySessionManager.Properties.Settings.Default, "FileZillaLocation", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.filezillaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", global::uk.org.riseley.puttySessionManager.Properties.Settings.Default, "FileZillaEnabled", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.filezillaTextBox.Enabled = global::uk.org.riseley.puttySessionManager.Properties.Settings.Default.FileZillaEnabled;
            this.filezillaTextBox.Location = new System.Drawing.Point(123, 131);
            this.filezillaTextBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.filezillaTextBox.Name = "filezillaTextBox";
            this.filezillaTextBox.ReadOnly = true;
            this.filezillaTextBox.Size = new System.Drawing.Size(236, 20);
            this.filezillaTextBox.TabIndex = 18;
            this.filezillaTextBox.Text = global::uk.org.riseley.puttySessionManager.Properties.Settings.Default.FileZillaLocation;
            // 
            // FileZillaOptionsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.filezillaTableLayout);
            this.Name = "FileZillaOptionsControl";
            this.Size = new System.Drawing.Size(362, 157);
            this.filezillaTableLayout.ResumeLayout(false);
            this.filezillaTableLayout.PerformLayout();
            this.protocolGroupBox.ResumeLayout(false);
            this.filezillaProtoTableLayout.ResumeLayout(false);
            this.filezillaProtoTableLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel filezillaTableLayout;
        private System.Windows.Forms.Button locateFileZillaButton;
        private System.Windows.Forms.GroupBox protocolGroupBox;
        private System.Windows.Forms.TableLayoutPanel filezillaProtoTableLayout;
        private System.Windows.Forms.RadioButton fzSessionInfoRadioButton;
        private System.Windows.Forms.RadioButton fzFtpsRadioButton;
        private System.Windows.Forms.RadioButton fzFtpRadioButton;
        private System.Windows.Forms.RadioButton fzSftpRadioButton;
        private System.Windows.Forms.CheckBox sshAuthCheckBox;
        private System.Windows.Forms.CheckBox enableFileZillaCheckBox;
        private System.Windows.Forms.TextBox filezillaTextBox;
    }
}
