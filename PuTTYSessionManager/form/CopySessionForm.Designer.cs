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
    partial class CopySessionForm
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
            this.chooseSessionLabel = new System.Windows.Forms.Label();
            this.sessionComboBox = new System.Windows.Forms.ComboBox();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.copyAllRadioButton = new System.Windows.Forms.RadioButton();
            this.includeRadioButton = new System.Windows.Forms.RadioButton();
            this.attributesGroupBox = new System.Windows.Forms.GroupBox();
            this.attributesTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.hostnameCheckBox = new System.Windows.Forms.CheckBox();
            this.folderCheckBox = new System.Windows.Forms.CheckBox();
            this.portForwardCheckBox = new System.Windows.Forms.CheckBox();
            this.selectionCheckBox = new System.Windows.Forms.CheckBox();
            this.keepalivesCheckBox = new System.Windows.Forms.CheckBox();
            this.scrollBackCheckBox = new System.Windows.Forms.CheckBox();
            this.protocoCheckBox = new System.Windows.Forms.CheckBox();
            this.coloursCheckBox = new System.Windows.Forms.CheckBox();
            this.userNameCheckBox = new System.Windows.Forms.CheckBox();
            this.fontCheckBox = new System.Windows.Forms.CheckBox();
            this.selectAllButton = new System.Windows.Forms.Button();
            this.invertButton = new System.Windows.Forms.Button();
            this.selectNoneButton = new System.Windows.Forms.Button();
            this.attributeListBox = new System.Windows.Forms.ListBox();
            this.excludeRadioButton = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.attributesGroupBox.SuspendLayout();
            this.attributesTableLayout.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chooseSessionLabel
            // 
            this.chooseSessionLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.chooseSessionLabel.AutoSize = true;
            this.chooseSessionLabel.Location = new System.Drawing.Point(138, 7);
            this.chooseSessionLabel.Name = "chooseSessionLabel";
            this.chooseSessionLabel.Size = new System.Drawing.Size(129, 13);
            this.chooseSessionLabel.TabIndex = 13;
            this.chooseSessionLabel.Text = "Choose Session Template";
            // 
            // sessionComboBox
            // 
            this.sessionComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.sessionComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", global::uk.org.riseley.puttySessionManager.Properties.Settings.Default, "HotkeyFavouriteEnabled", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.sessionComboBox.DisplayMember = "Default Settings";
            this.sessionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sessionComboBox.Enabled = global::uk.org.riseley.puttySessionManager.Properties.Settings.Default.HotkeyFavouriteEnabled;
            this.sessionComboBox.FormattingEnabled = true;
            this.sessionComboBox.Location = new System.Drawing.Point(273, 3);
            this.sessionComboBox.Name = "sessionComboBox";
            this.sessionComboBox.Size = new System.Drawing.Size(265, 21);
            this.sessionComboBox.TabIndex = 12;
            this.sessionComboBox.SelectionChangeCommitted += new System.EventHandler(this.sessionComboBox_SelectionChangeCommitted);
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(192, 384);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 16;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(273, 384);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 17;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // copyAllRadioButton
            // 
            this.copyAllRadioButton.AutoSize = true;
            this.copyAllRadioButton.Checked = true;
            this.copyAllRadioButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.copyAllRadioButton.Location = new System.Drawing.Point(3, 30);
            this.copyAllRadioButton.Name = "copyAllRadioButton";
            this.copyAllRadioButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.copyAllRadioButton.Size = new System.Drawing.Size(264, 17);
            this.copyAllRadioButton.TabIndex = 18;
            this.copyAllRadioButton.TabStop = true;
            this.copyAllRadioButton.Text = "Copy all attributes except hostname and folder";
            this.copyAllRadioButton.UseVisualStyleBackColor = true;
            this.copyAllRadioButton.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // includeRadioButton
            // 
            this.includeRadioButton.AutoSize = true;
            this.includeRadioButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.includeRadioButton.Location = new System.Drawing.Point(3, 76);
            this.includeRadioButton.Name = "includeRadioButton";
            this.includeRadioButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.includeRadioButton.Size = new System.Drawing.Size(264, 17);
            this.includeRadioButton.TabIndex = 19;
            this.includeRadioButton.Text = "Copy only selected attributes";
            this.includeRadioButton.UseVisualStyleBackColor = true;
            this.includeRadioButton.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // attributesGroupBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.attributesGroupBox, 2);
            this.attributesGroupBox.Controls.Add(this.attributesTableLayout);
            this.attributesGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.attributesGroupBox.Enabled = false;
            this.attributesGroupBox.Location = new System.Drawing.Point(3, 99);
            this.attributesGroupBox.Name = "attributesGroupBox";
            this.attributesGroupBox.Size = new System.Drawing.Size(535, 279);
            this.attributesGroupBox.TabIndex = 20;
            this.attributesGroupBox.TabStop = false;
            this.attributesGroupBox.Text = "Attributes";
            // 
            // attributesTableLayout
            // 
            this.attributesTableLayout.ColumnCount = 4;
            this.attributesTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.attributesTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.attributesTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.attributesTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.attributesTableLayout.Controls.Add(this.hostnameCheckBox, 0, 3);
            this.attributesTableLayout.Controls.Add(this.folderCheckBox, 0, 8);
            this.attributesTableLayout.Controls.Add(this.portForwardCheckBox, 0, 9);
            this.attributesTableLayout.Controls.Add(this.selectionCheckBox, 0, 7);
            this.attributesTableLayout.Controls.Add(this.keepalivesCheckBox, 0, 4);
            this.attributesTableLayout.Controls.Add(this.scrollBackCheckBox, 0, 6);
            this.attributesTableLayout.Controls.Add(this.protocoCheckBox, 0, 5);
            this.attributesTableLayout.Controls.Add(this.coloursCheckBox, 0, 0);
            this.attributesTableLayout.Controls.Add(this.userNameCheckBox, 0, 1);
            this.attributesTableLayout.Controls.Add(this.fontCheckBox, 0, 2);
            this.attributesTableLayout.Controls.Add(this.selectAllButton, 1, 10);
            this.attributesTableLayout.Controls.Add(this.invertButton, 2, 10);
            this.attributesTableLayout.Controls.Add(this.selectNoneButton, 3, 10);
            this.attributesTableLayout.Controls.Add(this.attributeListBox, 1, 0);
            this.attributesTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.attributesTableLayout.Location = new System.Drawing.Point(3, 17);
            this.attributesTableLayout.Name = "attributesTableLayout";
            this.attributesTableLayout.RowCount = 11;
            this.attributesTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.attributesTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.attributesTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.attributesTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.attributesTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.attributesTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.attributesTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.attributesTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.attributesTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.attributesTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.attributesTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.attributesTableLayout.Size = new System.Drawing.Size(529, 259);
            this.attributesTableLayout.TabIndex = 14;
            // 
            // hostnameCheckBox
            // 
            this.hostnameCheckBox.AutoSize = true;
            this.hostnameCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hostnameCheckBox.Location = new System.Drawing.Point(3, 72);
            this.hostnameCheckBox.Name = "hostnameCheckBox";
            this.hostnameCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.hostnameCheckBox.Size = new System.Drawing.Size(125, 17);
            this.hostnameCheckBox.TabIndex = 13;
            this.hostnameCheckBox.Text = "Hostname";
            this.hostnameCheckBox.UseVisualStyleBackColor = true;
            this.hostnameCheckBox.Click += new System.EventHandler(this.checkBox_Click);
            // 
            // folderCheckBox
            // 
            this.folderCheckBox.AutoSize = true;
            this.folderCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.folderCheckBox.Location = new System.Drawing.Point(3, 187);
            this.folderCheckBox.Name = "folderCheckBox";
            this.folderCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.folderCheckBox.Size = new System.Drawing.Size(125, 17);
            this.folderCheckBox.TabIndex = 8;
            this.folderCheckBox.Text = "Session Folder";
            this.folderCheckBox.UseVisualStyleBackColor = true;
            this.folderCheckBox.Click += new System.EventHandler(this.checkBox_Click);
            // 
            // portForwardCheckBox
            // 
            this.portForwardCheckBox.AutoSize = true;
            this.portForwardCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.portForwardCheckBox.Location = new System.Drawing.Point(3, 210);
            this.portForwardCheckBox.Name = "portForwardCheckBox";
            this.portForwardCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.portForwardCheckBox.Size = new System.Drawing.Size(125, 17);
            this.portForwardCheckBox.TabIndex = 7;
            this.portForwardCheckBox.Text = "SSH Port Forwards";
            this.portForwardCheckBox.UseVisualStyleBackColor = true;
            this.portForwardCheckBox.Click += new System.EventHandler(this.checkBox_Click);
            // 
            // selectionCheckBox
            // 
            this.selectionCheckBox.AutoSize = true;
            this.selectionCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectionCheckBox.Location = new System.Drawing.Point(3, 164);
            this.selectionCheckBox.Name = "selectionCheckBox";
            this.selectionCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.selectionCheckBox.Size = new System.Drawing.Size(125, 17);
            this.selectionCheckBox.TabIndex = 5;
            this.selectionCheckBox.Text = "Selection Characters";
            this.selectionCheckBox.UseVisualStyleBackColor = true;
            this.selectionCheckBox.Click += new System.EventHandler(this.checkBox_Click);
            // 
            // keepalivesCheckBox
            // 
            this.keepalivesCheckBox.AutoSize = true;
            this.keepalivesCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.keepalivesCheckBox.Location = new System.Drawing.Point(3, 95);
            this.keepalivesCheckBox.Name = "keepalivesCheckBox";
            this.keepalivesCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.keepalivesCheckBox.Size = new System.Drawing.Size(125, 17);
            this.keepalivesCheckBox.TabIndex = 6;
            this.keepalivesCheckBox.Text = "Keepalives";
            this.keepalivesCheckBox.UseVisualStyleBackColor = true;
            this.keepalivesCheckBox.Click += new System.EventHandler(this.checkBox_Click);
            // 
            // scrollBackCheckBox
            // 
            this.scrollBackCheckBox.AutoSize = true;
            this.scrollBackCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scrollBackCheckBox.Location = new System.Drawing.Point(3, 141);
            this.scrollBackCheckBox.Name = "scrollBackCheckBox";
            this.scrollBackCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.scrollBackCheckBox.Size = new System.Drawing.Size(125, 17);
            this.scrollBackCheckBox.TabIndex = 1;
            this.scrollBackCheckBox.Text = "Scrollback";
            this.scrollBackCheckBox.UseVisualStyleBackColor = true;
            this.scrollBackCheckBox.Click += new System.EventHandler(this.checkBox_Click);
            // 
            // protocoCheckBox
            // 
            this.protocoCheckBox.AutoSize = true;
            this.protocoCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.protocoCheckBox.Location = new System.Drawing.Point(3, 118);
            this.protocoCheckBox.Name = "protocoCheckBox";
            this.protocoCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.protocoCheckBox.Size = new System.Drawing.Size(125, 17);
            this.protocoCheckBox.TabIndex = 3;
            this.protocoCheckBox.Text = "Protocol / Port";
            this.protocoCheckBox.UseVisualStyleBackColor = true;
            this.protocoCheckBox.Click += new System.EventHandler(this.checkBox_Click);
            // 
            // coloursCheckBox
            // 
            this.coloursCheckBox.AutoSize = true;
            this.coloursCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.coloursCheckBox.Location = new System.Drawing.Point(3, 3);
            this.coloursCheckBox.Name = "coloursCheckBox";
            this.coloursCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.coloursCheckBox.Size = new System.Drawing.Size(125, 17);
            this.coloursCheckBox.TabIndex = 0;
            this.coloursCheckBox.Text = "Colours";
            this.coloursCheckBox.UseVisualStyleBackColor = true;
            this.coloursCheckBox.Click += new System.EventHandler(this.checkBox_Click);
            // 
            // userNameCheckBox
            // 
            this.userNameCheckBox.AutoSize = true;
            this.userNameCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userNameCheckBox.Location = new System.Drawing.Point(3, 26);
            this.userNameCheckBox.Name = "userNameCheckBox";
            this.userNameCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.userNameCheckBox.Size = new System.Drawing.Size(125, 17);
            this.userNameCheckBox.TabIndex = 2;
            this.userNameCheckBox.Text = "Default Username";
            this.userNameCheckBox.UseVisualStyleBackColor = true;
            this.userNameCheckBox.Click += new System.EventHandler(this.checkBox_Click);
            // 
            // fontCheckBox
            // 
            this.fontCheckBox.AutoSize = true;
            this.fontCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fontCheckBox.Location = new System.Drawing.Point(3, 49);
            this.fontCheckBox.Name = "fontCheckBox";
            this.fontCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.fontCheckBox.Size = new System.Drawing.Size(125, 17);
            this.fontCheckBox.TabIndex = 4;
            this.fontCheckBox.Text = "Font";
            this.fontCheckBox.UseVisualStyleBackColor = true;
            this.fontCheckBox.Click += new System.EventHandler(this.checkBox_Click);
            // 
            // selectAllButton
            // 
            this.selectAllButton.Location = new System.Drawing.Point(134, 233);
            this.selectAllButton.Name = "selectAllButton";
            this.selectAllButton.Size = new System.Drawing.Size(75, 23);
            this.selectAllButton.TabIndex = 10;
            this.selectAllButton.Text = "Select All";
            this.selectAllButton.UseVisualStyleBackColor = true;
            this.selectAllButton.Click += new System.EventHandler(this.selectAllButton_Click);
            // 
            // invertButton
            // 
            this.invertButton.Location = new System.Drawing.Point(215, 233);
            this.invertButton.Name = "invertButton";
            this.invertButton.Size = new System.Drawing.Size(89, 23);
            this.invertButton.TabIndex = 12;
            this.invertButton.Text = "Invert Selection";
            this.invertButton.UseVisualStyleBackColor = true;
            this.invertButton.Click += new System.EventHandler(this.invertButton_Click);
            // 
            // selectNoneButton
            // 
            this.selectNoneButton.Location = new System.Drawing.Point(310, 233);
            this.selectNoneButton.Name = "selectNoneButton";
            this.selectNoneButton.Size = new System.Drawing.Size(75, 23);
            this.selectNoneButton.TabIndex = 11;
            this.selectNoneButton.Text = "Select None";
            this.selectNoneButton.UseVisualStyleBackColor = true;
            this.selectNoneButton.Click += new System.EventHandler(this.selectNoneButton_Click);
            // 
            // attributeListBox
            // 
            this.attributesTableLayout.SetColumnSpan(this.attributeListBox, 3);
            this.attributeListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.attributeListBox.Location = new System.Drawing.Point(134, 3);
            this.attributeListBox.Name = "attributeListBox";
            this.attributesTableLayout.SetRowSpan(this.attributeListBox, 10);
            this.attributeListBox.ScrollAlwaysVisible = true;
            this.attributeListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.attributeListBox.Size = new System.Drawing.Size(393, 212);
            this.attributeListBox.Sorted = true;
            this.attributeListBox.TabIndex = 9;
            this.attributeListBox.SelectedValueChanged += new System.EventHandler(this.attributeListBox_SelectedValueChanged);
            // 
            // excludeRadioButton
            // 
            this.excludeRadioButton.AutoSize = true;
            this.excludeRadioButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.excludeRadioButton.Location = new System.Drawing.Point(3, 53);
            this.excludeRadioButton.Name = "excludeRadioButton";
            this.excludeRadioButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.excludeRadioButton.Size = new System.Drawing.Size(264, 17);
            this.excludeRadioButton.TabIndex = 21;
            this.excludeRadioButton.Text = "Exclude hostname, folder and selected attributes";
            this.excludeRadioButton.UseVisualStyleBackColor = true;
            this.excludeRadioButton.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.sessionComboBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.attributesGroupBox, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.excludeRadioButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.chooseSessionLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.copyAllRadioButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.includeRadioButton, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.okButton, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.cancelButton, 1, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(541, 418);
            this.tableLayoutPanel1.TabIndex = 22;
            // 
            // CopySessionForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(541, 418);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(547, 450);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(547, 450);
            this.Name = "CopySessionForm";
            this.ShowInTaskbar = false;
            this.Text = "Copy Session Attributes";
            this.attributesGroupBox.ResumeLayout(false);
            this.attributesTableLayout.ResumeLayout(false);
            this.attributesTableLayout.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label chooseSessionLabel;
        private System.Windows.Forms.ComboBox sessionComboBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.RadioButton copyAllRadioButton;
        private System.Windows.Forms.RadioButton includeRadioButton;
        private System.Windows.Forms.GroupBox attributesGroupBox;
        private System.Windows.Forms.RadioButton excludeRadioButton;
        private System.Windows.Forms.CheckBox coloursCheckBox;
        private System.Windows.Forms.CheckBox userNameCheckBox;
        private System.Windows.Forms.CheckBox scrollBackCheckBox;
        private System.Windows.Forms.CheckBox fontCheckBox;
        private System.Windows.Forms.CheckBox protocoCheckBox;
        private System.Windows.Forms.CheckBox portForwardCheckBox;
        private System.Windows.Forms.CheckBox keepalivesCheckBox;
        private System.Windows.Forms.CheckBox selectionCheckBox;
        private System.Windows.Forms.ListBox attributeListBox;
        private System.Windows.Forms.CheckBox folderCheckBox;
        private System.Windows.Forms.Button selectNoneButton;
        private System.Windows.Forms.Button selectAllButton;
        private System.Windows.Forms.Button invertButton;
        private System.Windows.Forms.CheckBox hostnameCheckBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel attributesTableLayout;
    }
}