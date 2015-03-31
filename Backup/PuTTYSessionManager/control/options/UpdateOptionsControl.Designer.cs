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
    partial class UpdateOptionsControl
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
            this.updateTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.checkForUpdateButton = new System.Windows.Forms.Button();
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.proxyGroupBox = new System.Windows.Forms.GroupBox();
            this.proxyTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.directRadioButton = new System.Windows.Forms.RadioButton();
            this.proxyPortLabel = new System.Windows.Forms.Label();
            this.ieProxyRadioButton = new System.Windows.Forms.RadioButton();
            this.proxyServerLabel = new System.Windows.Forms.Label();
            this.proxyPortTextBox = new System.Windows.Forms.TextBox();
            this.userProxyRadioButton = new System.Windows.Forms.RadioButton();
            this.proxyServerTextBox = new System.Windows.Forms.TextBox();
            this.urlLabel = new System.Windows.Forms.Label();
            this.urlCheckBox = new System.Windows.Forms.CheckBox();
            this.updateTableLayout.SuspendLayout();
            this.proxyGroupBox.SuspendLayout();
            this.proxyTableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // updateTableLayout
            // 
            this.updateTableLayout.ColumnCount = 2;
            this.updateTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.updateTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.updateTableLayout.Controls.Add(this.checkForUpdateButton, 0, 3);
            this.updateTableLayout.Controls.Add(this.urlTextBox, 1, 1);
            this.updateTableLayout.Controls.Add(this.proxyGroupBox, 0, 2);
            this.updateTableLayout.Controls.Add(this.urlLabel, 1, 0);
            this.updateTableLayout.Controls.Add(this.urlCheckBox, 0, 1);
            this.updateTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.updateTableLayout.Location = new System.Drawing.Point(0, 0);
            this.updateTableLayout.Name = "updateTableLayout";
            this.updateTableLayout.RowCount = 4;
            this.updateTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.updateTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.updateTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.updateTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.updateTableLayout.Size = new System.Drawing.Size(340, 180);
            this.updateTableLayout.TabIndex = 29;
            // 
            // checkForUpdateButton
            // 
            this.checkForUpdateButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.updateTableLayout.SetColumnSpan(this.checkForUpdateButton, 2);
            this.checkForUpdateButton.Location = new System.Drawing.Point(114, 148);
            this.checkForUpdateButton.Name = "checkForUpdateButton";
            this.checkForUpdateButton.Size = new System.Drawing.Size(112, 23);
            this.checkForUpdateButton.TabIndex = 27;
            this.checkForUpdateButton.Text = "&Check for update...";
            this.checkForUpdateButton.Click += new System.EventHandler(this.checkForUpdateButton_Click);
            // 
            // urlTextBox
            // 
            this.urlTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.urlTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::uk.org.riseley.puttySessionManager.Properties.Settings.Default, "UpdateUrl", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.urlTextBox.Location = new System.Drawing.Point(103, 16);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.ReadOnly = true;
            this.urlTextBox.Size = new System.Drawing.Size(234, 20);
            this.urlTextBox.TabIndex = 2;
            this.urlTextBox.Text = global::uk.org.riseley.puttySessionManager.Properties.Settings.Default.UpdateUrl;
            // 
            // proxyGroupBox
            // 
            this.updateTableLayout.SetColumnSpan(this.proxyGroupBox, 2);
            this.proxyGroupBox.Controls.Add(this.proxyTableLayout);
            this.proxyGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.proxyGroupBox.Location = new System.Drawing.Point(3, 42);
            this.proxyGroupBox.Name = "proxyGroupBox";
            this.proxyGroupBox.Size = new System.Drawing.Size(334, 94);
            this.proxyGroupBox.TabIndex = 21;
            this.proxyGroupBox.TabStop = false;
            this.proxyGroupBox.Text = "Proxy Settings";
            // 
            // proxyTableLayout
            // 
            this.proxyTableLayout.ColumnCount = 3;
            this.proxyTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.proxyTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.proxyTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.proxyTableLayout.Controls.Add(this.directRadioButton, 0, 1);
            this.proxyTableLayout.Controls.Add(this.proxyPortLabel, 2, 1);
            this.proxyTableLayout.Controls.Add(this.ieProxyRadioButton, 0, 0);
            this.proxyTableLayout.Controls.Add(this.proxyServerLabel, 1, 1);
            this.proxyTableLayout.Controls.Add(this.proxyPortTextBox, 2, 2);
            this.proxyTableLayout.Controls.Add(this.userProxyRadioButton, 0, 2);
            this.proxyTableLayout.Controls.Add(this.proxyServerTextBox, 1, 2);
            this.proxyTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.proxyTableLayout.Location = new System.Drawing.Point(3, 16);
            this.proxyTableLayout.Name = "proxyTableLayout";
            this.proxyTableLayout.RowCount = 3;
            this.proxyTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.proxyTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.proxyTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.proxyTableLayout.Size = new System.Drawing.Size(328, 75);
            this.proxyTableLayout.TabIndex = 26;
            // 
            // directRadioButton
            // 
            this.directRadioButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.directRadioButton.AutoSize = true;
            this.directRadioButton.Location = new System.Drawing.Point(3, 26);
            this.directRadioButton.Name = "directRadioButton";
            this.directRadioButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.directRadioButton.Size = new System.Drawing.Size(110, 17);
            this.directRadioButton.TabIndex = 4;
            this.directRadioButton.Text = "Direct &Connection";
            this.directRadioButton.UseVisualStyleBackColor = true;
            this.directRadioButton.CheckedChanged += new System.EventHandler(this.proxyRadioButton_CheckedChanged);
            // 
            // proxyPortLabel
            // 
            this.proxyPortLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.proxyPortLabel.AutoSize = true;
            this.proxyPortLabel.Location = new System.Drawing.Point(271, 33);
            this.proxyPortLabel.Name = "proxyPortLabel";
            this.proxyPortLabel.Size = new System.Drawing.Size(26, 13);
            this.proxyPortLabel.TabIndex = 25;
            this.proxyPortLabel.Text = "Port";
            // 
            // ieProxyRadioButton
            // 
            this.ieProxyRadioButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ieProxyRadioButton.AutoSize = true;
            this.ieProxyRadioButton.Checked = true;
            this.ieProxyRadioButton.Location = new System.Drawing.Point(15, 3);
            this.ieProxyRadioButton.Name = "ieProxyRadioButton";
            this.ieProxyRadioButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ieProxyRadioButton.Size = new System.Drawing.Size(98, 17);
            this.ieProxyRadioButton.TabIndex = 3;
            this.ieProxyRadioButton.TabStop = true;
            this.ieProxyRadioButton.Text = "Use &IE Settings";
            this.ieProxyRadioButton.UseVisualStyleBackColor = true;
            this.ieProxyRadioButton.CheckedChanged += new System.EventHandler(this.proxyRadioButton_CheckedChanged);
            // 
            // proxyServerLabel
            // 
            this.proxyServerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.proxyServerLabel.AutoSize = true;
            this.proxyServerLabel.Location = new System.Drawing.Point(119, 33);
            this.proxyServerLabel.Name = "proxyServerLabel";
            this.proxyServerLabel.Size = new System.Drawing.Size(67, 13);
            this.proxyServerLabel.TabIndex = 24;
            this.proxyServerLabel.Text = "Proxy Server";
            // 
            // proxyPortTextBox
            // 
            this.proxyPortTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.proxyPortTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::uk.org.riseley.puttySessionManager.Properties.Settings.Default, "ProxyPort", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.proxyPortTextBox.Location = new System.Drawing.Point(271, 49);
            this.proxyPortTextBox.MaxLength = 5;
            this.proxyPortTextBox.Name = "proxyPortTextBox";
            this.proxyPortTextBox.Size = new System.Drawing.Size(54, 20);
            this.proxyPortTextBox.TabIndex = 7;
            this.proxyPortTextBox.Text = global::uk.org.riseley.puttySessionManager.Properties.Settings.Default.ProxyPort;
            // 
            // userProxyRadioButton
            // 
            this.userProxyRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.userProxyRadioButton.AutoSize = true;
            this.userProxyRadioButton.Location = new System.Drawing.Point(8, 49);
            this.userProxyRadioButton.Name = "userProxyRadioButton";
            this.userProxyRadioButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.userProxyRadioButton.Size = new System.Drawing.Size(105, 17);
            this.userProxyRadioButton.TabIndex = 5;
            this.userProxyRadioButton.Text = "Use &HTTP Proxy";
            this.userProxyRadioButton.UseVisualStyleBackColor = true;
            this.userProxyRadioButton.CheckedChanged += new System.EventHandler(this.proxyRadioButton_CheckedChanged);
            // 
            // proxyServerTextBox
            // 
            this.proxyServerTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.proxyServerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::uk.org.riseley.puttySessionManager.Properties.Settings.Default, "ProxyServer", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.proxyServerTextBox.Location = new System.Drawing.Point(119, 49);
            this.proxyServerTextBox.Name = "proxyServerTextBox";
            this.proxyServerTextBox.Size = new System.Drawing.Size(146, 20);
            this.proxyServerTextBox.TabIndex = 6;
            this.proxyServerTextBox.Text = global::uk.org.riseley.puttySessionManager.Properties.Settings.Default.ProxyServer;
            // 
            // urlLabel
            // 
            this.urlLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.urlLabel.AutoSize = true;
            this.urlLabel.Location = new System.Drawing.Point(103, 0);
            this.urlLabel.Name = "urlLabel";
            this.urlLabel.Size = new System.Drawing.Size(234, 13);
            this.urlLabel.TabIndex = 15;
            this.urlLabel.Text = "Update url";
            // 
            // urlCheckBox
            // 
            this.urlCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.urlCheckBox.AutoSize = true;
            this.urlCheckBox.Checked = true;
            this.urlCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.urlCheckBox.Location = new System.Drawing.Point(3, 17);
            this.urlCheckBox.Name = "urlCheckBox";
            this.urlCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.urlCheckBox.Size = new System.Drawing.Size(94, 17);
            this.urlCheckBox.TabIndex = 1;
            this.urlCheckBox.Text = "Use &default url";
            this.urlCheckBox.UseVisualStyleBackColor = true;
            this.urlCheckBox.CheckedChanged += new System.EventHandler(this.urlCheckBox_CheckedChanged);
            // 
            // UpdateOptionsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.updateTableLayout);
            this.Name = "UpdateOptionsControl";
            this.Size = new System.Drawing.Size(340, 180);
            this.updateTableLayout.ResumeLayout(false);
            this.updateTableLayout.PerformLayout();
            this.proxyGroupBox.ResumeLayout(false);
            this.proxyTableLayout.ResumeLayout(false);
            this.proxyTableLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel updateTableLayout;
        private System.Windows.Forms.Button checkForUpdateButton;
        private System.Windows.Forms.Label urlLabel;
        private System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.CheckBox urlCheckBox;
        private System.Windows.Forms.GroupBox proxyGroupBox;
        private System.Windows.Forms.TableLayoutPanel proxyTableLayout;
        private System.Windows.Forms.RadioButton directRadioButton;
        private System.Windows.Forms.Label proxyPortLabel;
        private System.Windows.Forms.RadioButton ieProxyRadioButton;
        private System.Windows.Forms.Label proxyServerLabel;
        private System.Windows.Forms.TextBox proxyPortTextBox;
        private System.Windows.Forms.RadioButton userProxyRadioButton;
        private System.Windows.Forms.TextBox proxyServerTextBox;
    }
}
