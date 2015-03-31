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
    partial class KageantOptionsControl
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
            this.KageantTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.launchKageantButton = new System.Windows.Forms.Button();
            this.launchKageantCheckBox = new System.Windows.Forms.CheckBox();
            this.keysListBox = new System.Windows.Forms.ListBox();
            this.removeKeyButton = new System.Windows.Forms.Button();
            this.locateKageantButton = new System.Windows.Forms.Button();
            this.KageantTextBox = new System.Windows.Forms.TextBox();
            this.addKeyButton = new System.Windows.Forms.Button();
            this.KageantTableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // KageantTableLayout
            // 
            this.KageantTableLayout.AutoSize = true;
            this.KageantTableLayout.ColumnCount = 2;
            this.KageantTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.KageantTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.KageantTableLayout.Controls.Add(this.launchKageantButton, 0, 0);
            this.KageantTableLayout.Controls.Add(this.launchKageantCheckBox, 1, 0);
            this.KageantTableLayout.Controls.Add(this.keysListBox, 1, 1);
            this.KageantTableLayout.Controls.Add(this.removeKeyButton, 0, 2);
            this.KageantTableLayout.Controls.Add(this.locateKageantButton, 0, 3);
            this.KageantTableLayout.Controls.Add(this.KageantTextBox, 1, 3);
            this.KageantTableLayout.Controls.Add(this.addKeyButton, 0, 1);
            this.KageantTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KageantTableLayout.Location = new System.Drawing.Point(0, 0);
            this.KageantTableLayout.Name = "KageantTableLayout";
            this.KageantTableLayout.RowCount = 4;
            this.KageantTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.KageantTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.KageantTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.KageantTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.KageantTableLayout.Size = new System.Drawing.Size(327, 164);
            this.KageantTableLayout.TabIndex = 24;
            // 
            // launchKageantButton
            // 
            this.launchKageantButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.launchKageantButton.AutoSize = true;
            this.launchKageantButton.Location = new System.Drawing.Point(8, 3);
            this.launchKageantButton.Name = "launchKageantButton";
            this.launchKageantButton.Size = new System.Drawing.Size(109, 23);
            this.launchKageantButton.TabIndex = 22;
            this.launchKageantButton.Text = "Launch &Now";
            this.launchKageantButton.UseVisualStyleBackColor = true;
            this.launchKageantButton.Click += new System.EventHandler(this.launchKageantButton_Click);
            // 
            // launchKageantCheckBox
            // 
            this.launchKageantCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.launchKageantCheckBox.AutoSize = true;
            this.launchKageantCheckBox.Checked = global::uk.org.riseley.puttySessionManager.Properties.Settings.Default.LaunchKageantOnStart;
            this.launchKageantCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::uk.org.riseley.puttySessionManager.Properties.Settings.Default, "LaunchKageantOnStart", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.launchKageantCheckBox.Location = new System.Drawing.Point(172, 6);
            this.launchKageantCheckBox.Name = "launchKageantCheckBox";
            this.launchKageantCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.launchKageantCheckBox.Size = new System.Drawing.Size(152, 17);
            this.launchKageantCheckBox.TabIndex = 18;
            this.launchKageantCheckBox.Text = "Launch Kageant at &startup";
            this.optionsToolTip.SetToolTip(this.launchKageantCheckBox, "Automatically launch Kageant, with the keys listed below,\r\nwhen PSM starts");
            this.launchKageantCheckBox.UseVisualStyleBackColor = true;
            // 
            // keysListBox
            // 
            this.keysListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.keysListBox.FormattingEnabled = true;
            this.keysListBox.HorizontalScrollbar = true;
            this.keysListBox.Location = new System.Drawing.Point(123, 32);
            this.keysListBox.Name = "keysListBox";
            this.KageantTableLayout.SetRowSpan(this.keysListBox, 2);
            this.keysListBox.Size = new System.Drawing.Size(201, 95);
            this.keysListBox.TabIndex = 19;
            // 
            // removeKeyButton
            // 
            this.removeKeyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.removeKeyButton.AutoSize = true;
            this.removeKeyButton.Location = new System.Drawing.Point(8, 61);
            this.removeKeyButton.Name = "removeKeyButton";
            this.removeKeyButton.Size = new System.Drawing.Size(109, 23);
            this.removeKeyButton.TabIndex = 21;
            this.removeKeyButton.Text = "&Remove Key";
            this.optionsToolTip.SetToolTip(this.removeKeyButton, "Remove selected key from the list");
            this.removeKeyButton.UseVisualStyleBackColor = true;
            this.removeKeyButton.Click += new System.EventHandler(this.removeKeyButton_Click);
            // 
            // locateKageantButton
            // 
            this.locateKageantButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.locateKageantButton.AutoSize = true;
            this.locateKageantButton.Location = new System.Drawing.Point(3, 133);
            this.locateKageantButton.Name = "locateKageantButton";
            this.locateKageantButton.Size = new System.Drawing.Size(114, 23);
            this.locateKageantButton.TabIndex = 17;
            this.locateKageantButton.Text = "&Locate kageant.exe";
            this.locateKageantButton.UseVisualStyleBackColor = true;
            this.locateKageantButton.Click += new System.EventHandler(this.locatePagentButton_Click);
            // 
            // KageantTextBox
            // 
            this.KageantTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.KageantTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::uk.org.riseley.puttySessionManager.Properties.Settings.Default, "KageantLocation", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.KageantTextBox.Location = new System.Drawing.Point(123, 135);
            this.KageantTextBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.KageantTextBox.Name = "KageantTextBox";
            this.KageantTextBox.ReadOnly = true;
            this.KageantTextBox.Size = new System.Drawing.Size(201, 20);
            this.KageantTextBox.TabIndex = 16;
            this.KageantTextBox.Text = global::uk.org.riseley.puttySessionManager.Properties.Settings.Default.KageantLocation;
            // 
            // addKeyButton
            // 
            this.addKeyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addKeyButton.AutoSize = true;
            this.addKeyButton.Location = new System.Drawing.Point(8, 32);
            this.addKeyButton.Name = "addKeyButton";
            this.addKeyButton.Size = new System.Drawing.Size(109, 23);
            this.addKeyButton.TabIndex = 20;
            this.addKeyButton.Text = "&Add Key";
            this.optionsToolTip.SetToolTip(this.addKeyButton, "Add an SSH private key(s) that will be opened\r\nwhen Kageant launches");
            this.addKeyButton.UseVisualStyleBackColor = true;
            this.addKeyButton.Click += new System.EventHandler(this.addKeyButton_Click);
            // 
            // KageantOptionsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.KageantTableLayout);
            this.Name = "KageantOptionsControl";
            this.Size = new System.Drawing.Size(327, 164);
            this.KageantTableLayout.ResumeLayout(false);
            this.KageantTableLayout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel KageantTableLayout;
        private System.Windows.Forms.Button launchKageantButton;
        private System.Windows.Forms.CheckBox launchKageantCheckBox;
        private System.Windows.Forms.ListBox keysListBox;
        private System.Windows.Forms.Button removeKeyButton;
        private System.Windows.Forms.Button locateKageantButton;
        private System.Windows.Forms.TextBox KageantTextBox;
        private System.Windows.Forms.Button addKeyButton;
    }
}
