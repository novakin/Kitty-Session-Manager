/* 
 * Copyright (C) 2006,2007 David Riseley 
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
namespace uk.org.riseley.puttySessionManager.form
{
    partial class Options
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
            this.tabsTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.okButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.generalOptionsTab = new System.Windows.Forms.TabPage();
            this.generalOptionsControl1 = new uk.org.riseley.puttySessionManager.control.options.GeneralOptionsControl();
            this.treeOptionsTab = new System.Windows.Forms.TabPage();
            this.treeOptionsControl = new uk.org.riseley.puttySessionManager.control.options.TreeOptionsControl();
            this.KageantOptionsTab = new System.Windows.Forms.TabPage();
            this.KageantOptionsControl = new uk.org.riseley.puttySessionManager.control.options.KageantOptionsControl();
            this.filezillaOptionsTab = new System.Windows.Forms.TabPage();
            this.fileZillaOptionsControl = new uk.org.riseley.puttySessionManager.control.options.FileZillaOptionsControl();
            this.winSCPOptionsTab = new System.Windows.Forms.TabPage();
            this.winSCPOptionsControl = new uk.org.riseley.puttySessionManager.control.options.WinSCPOptionsControl();
            this.updateOptionsTab = new System.Windows.Forms.TabPage();
            this.updateOptionsControl = new uk.org.riseley.puttySessionManager.control.options.UpdateOptionsControl();
            this.cancelButton = new System.Windows.Forms.Button();
            this.tabsTableLayout.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.generalOptionsTab.SuspendLayout();
            this.treeOptionsTab.SuspendLayout();
            this.KageantOptionsTab.SuspendLayout();
            this.filezillaOptionsTab.SuspendLayout();
            this.winSCPOptionsTab.SuspendLayout();
            this.updateOptionsTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabsTableLayout
            // 
            this.tabsTableLayout.AutoSize = true;
            this.tabsTableLayout.ColumnCount = 2;
            this.tabsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tabsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tabsTableLayout.Controls.Add(this.okButton, 0, 1);
            this.tabsTableLayout.Controls.Add(this.tabControl1, 0, 0);
            this.tabsTableLayout.Controls.Add(this.cancelButton, 1, 1);
            this.tabsTableLayout.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::uk.org.riseley.puttySessionManager.Properties.Settings.Default, "DialogFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tabsTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabsTableLayout.Location = new System.Drawing.Point(0, 0);
            this.tabsTableLayout.Name = "tabsTableLayout";
            this.tabsTableLayout.RowCount = 2;
            this.tabsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.7284F));
            this.tabsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.2716F));
            this.tabsTableLayout.Size = new System.Drawing.Size(399, 249);
            this.tabsTableLayout.TabIndex = 1;
            // 
            // okButton
            // 
            this.okButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.okButton.AutoSize = true;
            this.okButton.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::uk.org.riseley.puttySessionManager.Properties.Settings.Default, "DialogFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(130, 218);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(66, 27);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "&OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // tabControl1
            // 
            this.tabsTableLayout.SetColumnSpan(this.tabControl1, 2);
            this.tabControl1.Controls.Add(this.generalOptionsTab);
            this.tabControl1.Controls.Add(this.treeOptionsTab);
            this.tabControl1.Controls.Add(this.KageantOptionsTab);
            this.tabControl1.Controls.Add(this.filezillaOptionsTab);
            this.tabControl1.Controls.Add(this.winSCPOptionsTab);
            this.tabControl1.Controls.Add(this.updateOptionsTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(393, 209);
            this.tabControl1.TabIndex = 2;
            // 
            // generalOptionsTab
            // 
            this.generalOptionsTab.Controls.Add(this.generalOptionsControl1);
            this.generalOptionsTab.Location = new System.Drawing.Point(4, 22);
            this.generalOptionsTab.Name = "generalOptionsTab";
            this.generalOptionsTab.Padding = new System.Windows.Forms.Padding(3);
            this.generalOptionsTab.Size = new System.Drawing.Size(385, 183);
            this.generalOptionsTab.TabIndex = 0;
            this.generalOptionsTab.Text = "General";
            this.generalOptionsTab.UseVisualStyleBackColor = true;
            // 
            // generalOptionsControl1
            // 
            this.generalOptionsControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generalOptionsControl1.Location = new System.Drawing.Point(3, 3);
            this.generalOptionsControl1.Margin = new System.Windows.Forms.Padding(5);
            this.generalOptionsControl1.Name = "generalOptionsControl1";
            this.generalOptionsControl1.Size = new System.Drawing.Size(379, 177);
            this.generalOptionsControl1.TabIndex = 0;
            this.generalOptionsControl1.DialogFontChanged += new System.EventHandler(this.generalOptionsControl1_DialogFontChanged);
            // 
            // treeOptionsTab
            // 
            this.treeOptionsTab.Controls.Add(this.treeOptionsControl);
            this.treeOptionsTab.Location = new System.Drawing.Point(4, 22);
            this.treeOptionsTab.Name = "treeOptionsTab";
            this.treeOptionsTab.Size = new System.Drawing.Size(385, 178);
            this.treeOptionsTab.TabIndex = 5;
            this.treeOptionsTab.Text = "Tree";
            this.treeOptionsTab.UseVisualStyleBackColor = true;
            // 
            // treeOptionsControl
            // 
            this.treeOptionsControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeOptionsControl.Location = new System.Drawing.Point(0, 0);
            this.treeOptionsControl.Margin = new System.Windows.Forms.Padding(5);
            this.treeOptionsControl.Name = "treeOptionsControl";
            this.treeOptionsControl.Size = new System.Drawing.Size(385, 178);
            this.treeOptionsControl.TabIndex = 0;
            // 
            // KageantOptionsTab
            // 
            this.KageantOptionsTab.Controls.Add(this.KageantOptionsControl);
            this.KageantOptionsTab.Location = new System.Drawing.Point(4, 22);
            this.KageantOptionsTab.Name = "KageantOptionsTab";
            this.KageantOptionsTab.Size = new System.Drawing.Size(385, 178);
            this.KageantOptionsTab.TabIndex = 2;
            this.KageantOptionsTab.Text = "Kageant";
            this.KageantOptionsTab.UseVisualStyleBackColor = true;
            // 
            // KageantOptionsControl
            // 
            this.KageantOptionsControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KageantOptionsControl.Location = new System.Drawing.Point(0, 0);
            this.KageantOptionsControl.Margin = new System.Windows.Forms.Padding(5);
            this.KageantOptionsControl.Name = "KageantOptionsControl";
            this.KageantOptionsControl.Size = new System.Drawing.Size(385, 178);
            this.KageantOptionsControl.TabIndex = 0;
            // 
            // filezillaOptionsTab
            // 
            this.filezillaOptionsTab.Controls.Add(this.fileZillaOptionsControl);
            this.filezillaOptionsTab.Location = new System.Drawing.Point(4, 22);
            this.filezillaOptionsTab.Name = "filezillaOptionsTab";
            this.filezillaOptionsTab.Size = new System.Drawing.Size(385, 178);
            this.filezillaOptionsTab.TabIndex = 3;
            this.filezillaOptionsTab.Text = "FileZilla";
            this.filezillaOptionsTab.UseVisualStyleBackColor = true;
            // 
            // fileZillaOptionsControl
            // 
            this.fileZillaOptionsControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileZillaOptionsControl.Location = new System.Drawing.Point(0, 0);
            this.fileZillaOptionsControl.Margin = new System.Windows.Forms.Padding(5);
            this.fileZillaOptionsControl.Name = "fileZillaOptionsControl";
            this.fileZillaOptionsControl.Size = new System.Drawing.Size(385, 178);
            this.fileZillaOptionsControl.TabIndex = 0;
            // 
            // winSCPOptionsTab
            // 
            this.winSCPOptionsTab.Controls.Add(this.winSCPOptionsControl);
            this.winSCPOptionsTab.Location = new System.Drawing.Point(4, 22);
            this.winSCPOptionsTab.Name = "winSCPOptionsTab";
            this.winSCPOptionsTab.Size = new System.Drawing.Size(385, 178);
            this.winSCPOptionsTab.TabIndex = 4;
            this.winSCPOptionsTab.Text = "WinSCP";
            this.winSCPOptionsTab.UseVisualStyleBackColor = true;
            // 
            // winSCPOptionsControl
            // 
            this.winSCPOptionsControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.winSCPOptionsControl.Location = new System.Drawing.Point(0, 0);
            this.winSCPOptionsControl.Margin = new System.Windows.Forms.Padding(5);
            this.winSCPOptionsControl.Name = "winSCPOptionsControl";
            this.winSCPOptionsControl.Size = new System.Drawing.Size(385, 178);
            this.winSCPOptionsControl.TabIndex = 0;
            // 
            // updateOptionsTab
            // 
            this.updateOptionsTab.Controls.Add(this.updateOptionsControl);
            this.updateOptionsTab.Location = new System.Drawing.Point(4, 22);
            this.updateOptionsTab.Name = "updateOptionsTab";
            this.updateOptionsTab.Padding = new System.Windows.Forms.Padding(3);
            this.updateOptionsTab.Size = new System.Drawing.Size(385, 178);
            this.updateOptionsTab.TabIndex = 1;
            this.updateOptionsTab.Text = "Update";
            this.updateOptionsTab.UseVisualStyleBackColor = true;
            // 
            // updateOptionsControl
            // 
            this.updateOptionsControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.updateOptionsControl.Location = new System.Drawing.Point(3, 3);
            this.updateOptionsControl.Margin = new System.Windows.Forms.Padding(5);
            this.updateOptionsControl.Name = "updateOptionsControl";
            this.updateOptionsControl.Size = new System.Drawing.Size(379, 172);
            this.updateOptionsControl.TabIndex = 0;
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cancelButton.AutoSize = true;
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(202, 218);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(66, 27);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "&Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // Options
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(399, 249);
            this.ControlBox = false;
            this.Controls.Add(this.tabsTableLayout);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(407, 283);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(407, 283);
            this.Name = "Options";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Options";
            this.TopMost = true;
            this.tabsTableLayout.ResumeLayout(false);
            this.tabsTableLayout.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.generalOptionsTab.ResumeLayout(false);
            this.treeOptionsTab.ResumeLayout(false);
            this.KageantOptionsTab.ResumeLayout(false);
            this.filezillaOptionsTab.ResumeLayout(false);
            this.winSCPOptionsTab.ResumeLayout(false);
            this.updateOptionsTab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tabsTableLayout;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage generalOptionsTab;
        private System.Windows.Forms.TabPage updateOptionsTab;
        private System.Windows.Forms.TabPage KageantOptionsTab;
        private System.Windows.Forms.TabPage filezillaOptionsTab;
        private System.Windows.Forms.TabPage winSCPOptionsTab;
        private System.Windows.Forms.TabPage treeOptionsTab;
        private System.Windows.Forms.Button cancelButton;
        private uk.org.riseley.puttySessionManager.control.options.UpdateOptionsControl updateOptionsControl;
        private uk.org.riseley.puttySessionManager.control.options.WinSCPOptionsControl winSCPOptionsControl;
        private uk.org.riseley.puttySessionManager.control.options.FileZillaOptionsControl fileZillaOptionsControl;
        private uk.org.riseley.puttySessionManager.control.options.KageantOptionsControl KageantOptionsControl;
        private uk.org.riseley.puttySessionManager.control.options.TreeOptionsControl treeOptionsControl;
        private uk.org.riseley.puttySessionManager.control.options.GeneralOptionsControl generalOptionsControl1;
    }
}