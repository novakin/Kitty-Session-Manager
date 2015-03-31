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
    partial class TreeOptionsControl
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
            this.treeTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.subfolderTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.sessionWarningLabel = new System.Windows.Forms.Label();
            this.sampleTreeTextbox = new System.Windows.Forms.TextBox();
            this.chooseTreeFontButton = new System.Windows.Forms.Button();
            this.expandTreeCheckBox = new System.Windows.Forms.CheckBox();
            this.displayTreeIconsCheckBox = new System.Windows.Forms.CheckBox();
            this.toolTipsCheckBox = new System.Windows.Forms.CheckBox();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.treeTableLayout.SuspendLayout();
            this.subfolderTableLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // treeTableLayout
            // 
            this.treeTableLayout.ColumnCount = 2;
            this.treeTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.treeTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.treeTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.treeTableLayout.Controls.Add(this.subfolderTableLayout, 0, 3);
            this.treeTableLayout.Controls.Add(this.sampleTreeTextbox, 1, 4);
            this.treeTableLayout.Controls.Add(this.chooseTreeFontButton, 0, 4);
            this.treeTableLayout.Controls.Add(this.expandTreeCheckBox, 1, 0);
            this.treeTableLayout.Controls.Add(this.displayTreeIconsCheckBox, 1, 1);
            this.treeTableLayout.Controls.Add(this.toolTipsCheckBox, 1, 2);
            this.treeTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeTableLayout.Location = new System.Drawing.Point(0, 0);
            this.treeTableLayout.Name = "treeTableLayout";
            this.treeTableLayout.RowCount = 5;
            this.treeTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.treeTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.treeTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.treeTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.treeTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.treeTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.treeTableLayout.Size = new System.Drawing.Size(328, 132);
            this.treeTableLayout.TabIndex = 35;
            // 
            // subfolderTableLayout
            // 
            this.subfolderTableLayout.AutoSize = true;
            this.subfolderTableLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.subfolderTableLayout.ColumnCount = 2;
            this.treeTableLayout.SetColumnSpan(this.subfolderTableLayout, 2);
            this.subfolderTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.subfolderTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.subfolderTableLayout.Controls.Add(this.numericUpDown1, 1, 0);
            this.subfolderTableLayout.Controls.Add(this.sessionWarningLabel, 0, 0);
            this.subfolderTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subfolderTableLayout.Location = new System.Drawing.Point(3, 72);
            this.subfolderTableLayout.Name = "subfolderTableLayout";
            this.subfolderTableLayout.RowCount = 1;
            this.subfolderTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.subfolderTableLayout.Size = new System.Drawing.Size(322, 26);
            this.subfolderTableLayout.TabIndex = 34;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.numericUpDown1.AutoSize = true;
            this.numericUpDown1.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::uk.org.riseley.puttySessionManager.Properties.Settings.Default, "SubfolderSessionWarning", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.numericUpDown1.Location = new System.Drawing.Point(284, 3);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(35, 20);
            this.numericUpDown1.TabIndex = 32;
            this.optionsToolTip.SetToolTip(this.numericUpDown1, "Threshold for warning when using \"Launch Folder\" or \r\n\"Launch Folder and Subfolde" +
                    "rs\" from the tree view");
            this.numericUpDown1.Value = global::uk.org.riseley.puttySessionManager.Properties.Settings.Default.SubfolderSessionWarning;
            // 
            // sessionWarningLabel
            // 
            this.sessionWarningLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.sessionWarningLabel.AutoSize = true;
            this.sessionWarningLabel.Location = new System.Drawing.Point(3, 6);
            this.sessionWarningLabel.Name = "sessionWarningLabel";
            this.sessionWarningLabel.Size = new System.Drawing.Size(273, 13);
            this.sessionWarningLabel.TabIndex = 31;
            this.sessionWarningLabel.Text = "&Number of sessions in subfolders to open before warning";
            this.sessionWarningLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // sampleTreeTextbox
            // 
            this.sampleTreeTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.sampleTreeTextbox.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::uk.org.riseley.puttySessionManager.Properties.Settings.Default, "TreeFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.sampleTreeTextbox.Font = global::uk.org.riseley.puttySessionManager.Properties.Settings.Default.TreeFont;
            this.sampleTreeTextbox.Location = new System.Drawing.Point(111, 106);
            this.sampleTreeTextbox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.sampleTreeTextbox.Name = "sampleTreeTextbox";
            this.sampleTreeTextbox.ReadOnly = true;
            this.sampleTreeTextbox.Size = new System.Drawing.Size(214, 20);
            this.sampleTreeTextbox.TabIndex = 29;
            this.sampleTreeTextbox.Text = "Sample Text for Tree";
            this.sampleTreeTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chooseTreeFontButton
            // 
            this.chooseTreeFontButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.chooseTreeFontButton.AutoSize = true;
            this.chooseTreeFontButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.chooseTreeFontButton.Location = new System.Drawing.Point(3, 104);
            this.chooseTreeFontButton.Name = "chooseTreeFontButton";
            this.chooseTreeFontButton.Size = new System.Drawing.Size(102, 23);
            this.chooseTreeFontButton.TabIndex = 28;
            this.chooseTreeFontButton.Text = "&Choose Tree Font";
            this.chooseTreeFontButton.UseVisualStyleBackColor = true;
            this.chooseTreeFontButton.Click += new System.EventHandler(this.chooseFontButton_Click);
            // 
            // expandTreeCheckBox
            // 
            this.expandTreeCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.expandTreeCheckBox.AutoSize = true;
            this.expandTreeCheckBox.Checked = global::uk.org.riseley.puttySessionManager.Properties.Settings.Default.ExpandTreeOnStartup;
            this.expandTreeCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::uk.org.riseley.puttySessionManager.Properties.Settings.Default, "ExpandTreeOnStartup", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.expandTreeCheckBox.Location = new System.Drawing.Point(192, 3);
            this.expandTreeCheckBox.Name = "expandTreeCheckBox";
            this.expandTreeCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.expandTreeCheckBox.Size = new System.Drawing.Size(133, 17);
            this.expandTreeCheckBox.TabIndex = 27;
            this.expandTreeCheckBox.Text = "E&xpand tree on startup";
            this.optionsToolTip.SetToolTip(this.expandTreeCheckBox, "The tree view will be fully expanded on startup.\r\nNot recommended if you have 100" +
                    "\'s of sessions.");
            this.expandTreeCheckBox.UseVisualStyleBackColor = true;
            // 
            // displayTreeIconsCheckBox
            // 
            this.displayTreeIconsCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.displayTreeIconsCheckBox.AutoSize = true;
            this.displayTreeIconsCheckBox.Checked = global::uk.org.riseley.puttySessionManager.Properties.Settings.Default.DisplayTreeIcons;
            this.displayTreeIconsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.displayTreeIconsCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::uk.org.riseley.puttySessionManager.Properties.Settings.Default, "DisplayTreeIcons", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.displayTreeIconsCheckBox.Location = new System.Drawing.Point(205, 26);
            this.displayTreeIconsCheckBox.Name = "displayTreeIconsCheckBox";
            this.displayTreeIconsCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.displayTreeIconsCheckBox.Size = new System.Drawing.Size(120, 17);
            this.displayTreeIconsCheckBox.TabIndex = 30;
            this.displayTreeIconsCheckBox.Text = "&Display icons in tree";
            this.optionsToolTip.SetToolTip(this.displayTreeIconsCheckBox, "Display icons in the tree view");
            this.displayTreeIconsCheckBox.UseVisualStyleBackColor = true;
            this.displayTreeIconsCheckBox.Click += new System.EventHandler(this.displayTreeIconsCheckBox_Click);
            // 
            // toolTipsCheckBox
            // 
            this.toolTipsCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.toolTipsCheckBox.AutoSize = true;
            this.toolTipsCheckBox.Checked = global::uk.org.riseley.puttySessionManager.Properties.Settings.Default.ToolTipsEnabled;
            this.toolTipsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolTipsCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::uk.org.riseley.puttySessionManager.Properties.Settings.Default, "ToolTipsEnabled", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.toolTipsCheckBox.Location = new System.Drawing.Point(230, 49);
            this.toolTipsCheckBox.Name = "toolTipsCheckBox";
            this.toolTipsCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolTipsCheckBox.Size = new System.Drawing.Size(95, 17);
            this.toolTipsCheckBox.TabIndex = 33;
            this.toolTipsCheckBox.Text = "&Enable tooltips";
            this.optionsToolTip.SetToolTip(this.toolTipsCheckBox, "Enable the display of the session information\r\nin tooltips in the tree view");
            this.toolTipsCheckBox.UseVisualStyleBackColor = true;
            // 
            // fontDialog
            // 
            this.fontDialog.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.fontDialog.ShowColor = true;
            this.fontDialog.ShowEffects = false;
            // 
            // TreeOptionsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.treeTableLayout);
            this.Name = "TreeOptionsControl";
            this.Size = new System.Drawing.Size(328, 132);
            this.treeTableLayout.ResumeLayout(false);
            this.treeTableLayout.PerformLayout();
            this.subfolderTableLayout.ResumeLayout(false);
            this.subfolderTableLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel treeTableLayout;
        private System.Windows.Forms.TableLayoutPanel subfolderTableLayout;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label sessionWarningLabel;
        private System.Windows.Forms.TextBox sampleTreeTextbox;
        private System.Windows.Forms.Button chooseTreeFontButton;
        private System.Windows.Forms.CheckBox expandTreeCheckBox;
        private System.Windows.Forms.CheckBox displayTreeIconsCheckBox;
        private System.Windows.Forms.CheckBox toolTipsCheckBox;
        private System.Windows.Forms.FontDialog fontDialog;
    }
}
