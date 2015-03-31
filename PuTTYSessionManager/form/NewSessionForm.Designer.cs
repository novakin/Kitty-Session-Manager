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
    partial class NewSessionForm
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
            this.hostnameTextBox = new System.Windows.Forms.TextBox();
            this.hostnameLabel = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.sessionNameLabel = new System.Windows.Forms.Label();
            this.sessionnameTextBox = new System.Windows.Forms.TextBox();
            this.copyUsernameCheckBox = new System.Windows.Forms.CheckBox();
            this.sessionFolderLabel = new System.Windows.Forms.Label();
            this.sessionFolderComboBox = new System.Windows.Forms.ComboBox();
            this.launchSessionCheckBox = new System.Windows.Forms.CheckBox();
            this.newSessionTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.newSessionTableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // chooseSessionLabel
            // 
            this.chooseSessionLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.chooseSessionLabel.AutoSize = true;
            this.chooseSessionLabel.Location = new System.Drawing.Point(9, 7);
            this.chooseSessionLabel.Name = "chooseSessionLabel";
            this.chooseSessionLabel.Size = new System.Drawing.Size(129, 13);
            this.chooseSessionLabel.TabIndex = 13;
            this.chooseSessionLabel.Text = "Choose Session Template";
            // 
            // sessionComboBox
            // 
            this.sessionComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.newSessionTableLayout.SetColumnSpan(this.sessionComboBox, 2);
            this.sessionComboBox.DisplayMember = "Default Settings";
            this.sessionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sessionComboBox.FormattingEnabled = true;
            this.sessionComboBox.Location = new System.Drawing.Point(144, 3);
            this.sessionComboBox.Name = "sessionComboBox";
            this.sessionComboBox.Size = new System.Drawing.Size(256, 21);
            this.sessionComboBox.TabIndex = 7;
            this.sessionComboBox.SelectionChangeCommitted += new System.EventHandler(this.sessionComboBox_SelectionChangeCommitted);
            // 
            // hostnameTextBox
            // 
            this.hostnameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.newSessionTableLayout.SetColumnSpan(this.hostnameTextBox, 2);
            this.hostnameTextBox.Location = new System.Drawing.Point(144, 57);
            this.hostnameTextBox.Name = "hostnameTextBox";
            this.hostnameTextBox.Size = new System.Drawing.Size(256, 21);
            this.hostnameTextBox.TabIndex = 1;
            this.hostnameTextBox.TextChanged += new System.EventHandler(this.hostnameTextBox_TextChanged);
            // 
            // hostnameLabel
            // 
            this.hostnameLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.hostnameLabel.AutoSize = true;
            this.hostnameLabel.Location = new System.Drawing.Point(23, 61);
            this.hostnameLabel.Name = "hostnameLabel";
            this.hostnameLabel.Size = new System.Drawing.Size(115, 13);
            this.hostnameLabel.TabIndex = 15;
            this.hostnameLabel.Text = "Enter Hostname String";
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.newSessionTableLayout.SetColumnSpan(this.okButton, 2);
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(123, 134);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 5;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(204, 134);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // sessionNameLabel
            // 
            this.sessionNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.sessionNameLabel.AutoSize = true;
            this.sessionNameLabel.Location = new System.Drawing.Point(36, 88);
            this.sessionNameLabel.Name = "sessionNameLabel";
            this.sessionNameLabel.Size = new System.Drawing.Size(102, 13);
            this.sessionNameLabel.TabIndex = 19;
            this.sessionNameLabel.Text = "Enter Session Name";
            // 
            // sessionnameTextBox
            // 
            this.sessionnameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.newSessionTableLayout.SetColumnSpan(this.sessionnameTextBox, 2);
            this.sessionnameTextBox.Location = new System.Drawing.Point(144, 84);
            this.sessionnameTextBox.MaxLength = 60;
            this.sessionnameTextBox.Name = "sessionnameTextBox";
            this.sessionnameTextBox.Size = new System.Drawing.Size(256, 21);
            this.sessionnameTextBox.TabIndex = 2;
            // 
            // copyUsernameCheckBox
            // 
            this.copyUsernameCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.copyUsernameCheckBox.AutoSize = true;
            this.copyUsernameCheckBox.Checked = true;
            this.copyUsernameCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.newSessionTableLayout.SetColumnSpan(this.copyUsernameCheckBox, 2);
            this.copyUsernameCheckBox.Location = new System.Drawing.Point(58, 111);
            this.copyUsernameCheckBox.Name = "copyUsernameCheckBox";
            this.copyUsernameCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.copyUsernameCheckBox.Size = new System.Drawing.Size(140, 17);
            this.copyUsernameCheckBox.TabIndex = 3;
            this.copyUsernameCheckBox.Text = "Copy Default Username";
            this.copyUsernameCheckBox.UseVisualStyleBackColor = true;
            // 
            // sessionFolderLabel
            // 
            this.sessionFolderLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.sessionFolderLabel.AutoSize = true;
            this.sessionFolderLabel.Location = new System.Drawing.Point(23, 34);
            this.sessionFolderLabel.Name = "sessionFolderLabel";
            this.sessionFolderLabel.Size = new System.Drawing.Size(115, 13);
            this.sessionFolderLabel.TabIndex = 23;
            this.sessionFolderLabel.Text = "Choose Session Folder";
            // 
            // sessionFolderComboBox
            // 
            this.sessionFolderComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.newSessionTableLayout.SetColumnSpan(this.sessionFolderComboBox, 2);
            this.sessionFolderComboBox.DisplayMember = "Default Settings";
            this.sessionFolderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sessionFolderComboBox.FormattingEnabled = true;
            this.sessionFolderComboBox.Location = new System.Drawing.Point(144, 30);
            this.sessionFolderComboBox.Name = "sessionFolderComboBox";
            this.sessionFolderComboBox.Size = new System.Drawing.Size(256, 21);
            this.sessionFolderComboBox.TabIndex = 8;
            // 
            // launchSessionCheckBox
            // 
            this.launchSessionCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.launchSessionCheckBox.AutoSize = true;
            this.launchSessionCheckBox.Checked = true;
            this.launchSessionCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.launchSessionCheckBox.Location = new System.Drawing.Point(204, 111);
            this.launchSessionCheckBox.Name = "launchSessionCheckBox";
            this.launchSessionCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.launchSessionCheckBox.Size = new System.Drawing.Size(123, 17);
            this.launchSessionCheckBox.TabIndex = 4;
            this.launchSessionCheckBox.Text = "Launch Session Now";
            this.launchSessionCheckBox.UseVisualStyleBackColor = true;
            // 
            // newSessionTableLayout
            // 
            this.newSessionTableLayout.ColumnCount = 3;
            this.newSessionTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.newSessionTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.newSessionTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.newSessionTableLayout.Controls.Add(this.chooseSessionLabel, 0, 0);
            this.newSessionTableLayout.Controls.Add(this.sessionnameTextBox, 1, 3);
            this.newSessionTableLayout.Controls.Add(this.sessionFolderComboBox, 1, 1);
            this.newSessionTableLayout.Controls.Add(this.hostnameTextBox, 1, 2);
            this.newSessionTableLayout.Controls.Add(this.sessionFolderLabel, 0, 1);
            this.newSessionTableLayout.Controls.Add(this.hostnameLabel, 0, 2);
            this.newSessionTableLayout.Controls.Add(this.sessionComboBox, 1, 0);
            this.newSessionTableLayout.Controls.Add(this.sessionNameLabel, 0, 3);
            this.newSessionTableLayout.Controls.Add(this.launchSessionCheckBox, 2, 4);
            this.newSessionTableLayout.Controls.Add(this.cancelButton, 2, 5);
            this.newSessionTableLayout.Controls.Add(this.okButton, 0, 5);
            this.newSessionTableLayout.Controls.Add(this.copyUsernameCheckBox, 0, 4);
            this.newSessionTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newSessionTableLayout.Location = new System.Drawing.Point(0, 0);
            this.newSessionTableLayout.Name = "newSessionTableLayout";
            this.newSessionTableLayout.RowCount = 6;
            this.newSessionTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.newSessionTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.newSessionTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.newSessionTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.newSessionTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.newSessionTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.newSessionTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.newSessionTableLayout.Size = new System.Drawing.Size(403, 166);
            this.newSessionTableLayout.TabIndex = 24;
            // 
            // NewSessionForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(403, 166);
            this.ControlBox = false;
            this.Controls.Add(this.newSessionTableLayout);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(409, 198);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(409, 198);
            this.Name = "NewSessionForm";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "New Session";
            this.TopMost = true;
            this.Shown += new System.EventHandler(this.NewSessionForm_Shown);
            this.newSessionTableLayout.ResumeLayout(false);
            this.newSessionTableLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label chooseSessionLabel;
        private System.Windows.Forms.ComboBox sessionComboBox;
        private System.Windows.Forms.TextBox hostnameTextBox;
        private System.Windows.Forms.Label hostnameLabel;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label sessionNameLabel;
        private System.Windows.Forms.TextBox sessionnameTextBox;
        private System.Windows.Forms.CheckBox copyUsernameCheckBox;
        private System.Windows.Forms.Label sessionFolderLabel;
        private System.Windows.Forms.ComboBox sessionFolderComboBox;
        private System.Windows.Forms.CheckBox launchSessionCheckBox;
        private System.Windows.Forms.TableLayoutPanel newSessionTableLayout;
    }
}