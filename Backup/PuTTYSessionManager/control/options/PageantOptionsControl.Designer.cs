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
    partial class PageantOptionsControl
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
            this.pageantTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.launchPageantButton = new System.Windows.Forms.Button();
            this.launchPageantCheckBox = new System.Windows.Forms.CheckBox();
            this.keysListBox = new System.Windows.Forms.ListBox();
            this.removeKeyButton = new System.Windows.Forms.Button();
            this.locatePageantButton = new System.Windows.Forms.Button();
            this.pageantTextBox = new System.Windows.Forms.TextBox();
            this.addKeyButton = new System.Windows.Forms.Button();
            this.pageantTableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // pageantTableLayout
            // 
            this.pageantTableLayout.AutoSize = true;
            this.pageantTableLayout.ColumnCount = 2;
            this.pageantTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.pageantTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.pageantTableLayout.Controls.Add(this.launchPageantButton, 0, 0);
            this.pageantTableLayout.Controls.Add(this.launchPageantCheckBox, 1, 0);
            this.pageantTableLayout.Controls.Add(this.keysListBox, 1, 1);
            this.pageantTableLayout.Controls.Add(this.removeKeyButton, 0, 2);
            this.pageantTableLayout.Controls.Add(this.locatePageantButton, 0, 3);
            this.pageantTableLayout.Controls.Add(this.pageantTextBox, 1, 3);
            this.pageantTableLayout.Controls.Add(this.addKeyButton, 0, 1);
            this.pageantTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pageantTableLayout.Location = new System.Drawing.Point(0, 0);
            this.pageantTableLayout.Name = "pageantTableLayout";
            this.pageantTableLayout.RowCount = 4;
            this.pageantTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pageantTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pageantTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pageantTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pageantTableLayout.Size = new System.Drawing.Size(327, 164);
            this.pageantTableLayout.TabIndex = 24;
            // 
            // launchPageantButton
            // 
            this.launchPageantButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.launchPageantButton.AutoSize = true;
            this.launchPageantButton.Location = new System.Drawing.Point(8, 3);
            this.launchPageantButton.Name = "launchPageantButton";
            this.launchPageantButton.Size = new System.Drawing.Size(109, 23);
            this.launchPageantButton.TabIndex = 22;
            this.launchPageantButton.Text = "Launch &Now";
            this.launchPageantButton.UseVisualStyleBackColor = true;
            this.launchPageantButton.Click += new System.EventHandler(this.launchPageantButton_Click);
            // 
            // launchPageantCheckBox
            // 
            this.launchPageantCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.launchPageantCheckBox.AutoSize = true;
            this.launchPageantCheckBox.Checked = global::uk.org.riseley.puttySessionManager.Properties.Settings.Default.LaunchPageantOnStart;
            this.launchPageantCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::uk.org.riseley.puttySessionManager.Properties.Settings.Default, "LaunchPageantOnStart", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.launchPageantCheckBox.Location = new System.Drawing.Point(172, 6);
            this.launchPageantCheckBox.Name = "launchPageantCheckBox";
            this.launchPageantCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.launchPageantCheckBox.Size = new System.Drawing.Size(152, 17);
            this.launchPageantCheckBox.TabIndex = 18;
            this.launchPageantCheckBox.Text = "Launch Pageant at &startup";
            this.optionsToolTip.SetToolTip(this.launchPageantCheckBox, "Automatically launch Pageant, with the keys listed below,\r\nwhen PSM starts");
            this.launchPageantCheckBox.UseVisualStyleBackColor = true;
            // 
            // keysListBox
            // 
            this.keysListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.keysListBox.FormattingEnabled = true;
            this.keysListBox.HorizontalScrollbar = true;
            this.keysListBox.Location = new System.Drawing.Point(123, 32);
            this.keysListBox.Name = "keysListBox";
            this.pageantTableLayout.SetRowSpan(this.keysListBox, 2);
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
            // locatePageantButton
            // 
            this.locatePageantButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.locatePageantButton.AutoSize = true;
            this.locatePageantButton.Location = new System.Drawing.Point(3, 133);
            this.locatePageantButton.Name = "locatePageantButton";
            this.locatePageantButton.Size = new System.Drawing.Size(114, 23);
            this.locatePageantButton.TabIndex = 17;
            this.locatePageantButton.Text = "&Locate pageant.exe";
            this.locatePageantButton.UseVisualStyleBackColor = true;
            this.locatePageantButton.Click += new System.EventHandler(this.locatePagentButton_Click);
            // 
            // pageantTextBox
            // 
            this.pageantTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pageantTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::uk.org.riseley.puttySessionManager.Properties.Settings.Default, "PageantLocation", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.pageantTextBox.Location = new System.Drawing.Point(123, 135);
            this.pageantTextBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.pageantTextBox.Name = "pageantTextBox";
            this.pageantTextBox.ReadOnly = true;
            this.pageantTextBox.Size = new System.Drawing.Size(201, 20);
            this.pageantTextBox.TabIndex = 16;
            this.pageantTextBox.Text = global::uk.org.riseley.puttySessionManager.Properties.Settings.Default.PageantLocation;
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
            this.optionsToolTip.SetToolTip(this.addKeyButton, "Add an SSH private key(s) that will be opened\r\nwhen pageant launches");
            this.addKeyButton.UseVisualStyleBackColor = true;
            this.addKeyButton.Click += new System.EventHandler(this.addKeyButton_Click);
            // 
            // PageantOptionsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pageantTableLayout);
            this.Name = "PageantOptionsControl";
            this.Size = new System.Drawing.Size(327, 164);
            this.pageantTableLayout.ResumeLayout(false);
            this.pageantTableLayout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel pageantTableLayout;
        private System.Windows.Forms.Button launchPageantButton;
        private System.Windows.Forms.CheckBox launchPageantCheckBox;
        private System.Windows.Forms.ListBox keysListBox;
        private System.Windows.Forms.Button removeKeyButton;
        private System.Windows.Forms.Button locatePageantButton;
        private System.Windows.Forms.TextBox pageantTextBox;
        private System.Windows.Forms.Button addKeyButton;
    }
}
