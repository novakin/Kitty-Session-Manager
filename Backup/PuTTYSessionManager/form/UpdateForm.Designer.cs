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
    partial class UpdateForm
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
            this.components = new System.ComponentModel.Container();
            this.checkForUpdateButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.resultsGroupBox = new System.Windows.Forms.GroupBox();
            this.resultsTextBox = new System.Windows.Forms.TextBox();
            this.currVersionLabel = new System.Windows.Forms.Label();
            this.currVersionTextBox = new System.Windows.Forms.TextBox();
            this.availVersionLabel = new System.Windows.Forms.Label();
            this.availVersionTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sfLinkLabel = new System.Windows.Forms.LinkLabel();
            this.urlToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.updateTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.resultsGroupBox.SuspendLayout();
            this.updateTableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkForUpdateButton
            // 
            this.checkForUpdateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkForUpdateButton.Location = new System.Drawing.Point(127, 241);
            this.checkForUpdateButton.Name = "checkForUpdateButton";
            this.checkForUpdateButton.Size = new System.Drawing.Size(102, 22);
            this.checkForUpdateButton.TabIndex = 0;
            this.checkForUpdateButton.Text = "Check For Update";
            this.checkForUpdateButton.UseVisualStyleBackColor = true;
            this.checkForUpdateButton.Click += new System.EventHandler(this.checkForUpdateButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(235, 241);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(81, 22);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // resultsGroupBox
            // 
            this.updateTableLayout.SetColumnSpan(this.resultsGroupBox, 3);
            this.resultsGroupBox.Controls.Add(this.resultsTextBox);
            this.resultsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultsGroupBox.Location = new System.Drawing.Point(3, 3);
            this.resultsGroupBox.Name = "resultsGroupBox";
            this.resultsGroupBox.Size = new System.Drawing.Size(458, 154);
            this.resultsGroupBox.TabIndex = 11;
            this.resultsGroupBox.TabStop = false;
            this.resultsGroupBox.Text = "Update results";
            // 
            // resultsTextBox
            // 
            this.resultsTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultsTextBox.Location = new System.Drawing.Point(3, 17);
            this.resultsTextBox.Multiline = true;
            this.resultsTextBox.Name = "resultsTextBox";
            this.resultsTextBox.ReadOnly = true;
            this.resultsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.resultsTextBox.Size = new System.Drawing.Size(452, 134);
            this.resultsTextBox.TabIndex = 0;
            // 
            // currVersionLabel
            // 
            this.currVersionLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.currVersionLabel.AutoSize = true;
            this.currVersionLabel.Location = new System.Drawing.Point(31, 166);
            this.currVersionLabel.Name = "currVersionLabel";
            this.currVersionLabel.Size = new System.Drawing.Size(82, 13);
            this.currVersionLabel.TabIndex = 14;
            this.currVersionLabel.Text = "Current Version";
            // 
            // currVersionTextBox
            // 
            this.currVersionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.updateTableLayout.SetColumnSpan(this.currVersionTextBox, 2);
            this.currVersionTextBox.Location = new System.Drawing.Point(119, 163);
            this.currVersionTextBox.Name = "currVersionTextBox";
            this.currVersionTextBox.ReadOnly = true;
            this.currVersionTextBox.Size = new System.Drawing.Size(342, 21);
            this.currVersionTextBox.TabIndex = 13;
            // 
            // availVersionLabel
            // 
            this.availVersionLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.availVersionLabel.AutoSize = true;
            this.availVersionLabel.Location = new System.Drawing.Point(25, 192);
            this.availVersionLabel.Name = "availVersionLabel";
            this.availVersionLabel.Size = new System.Drawing.Size(88, 13);
            this.availVersionLabel.TabIndex = 16;
            this.availVersionLabel.Text = "Available Version";
            // 
            // availVersionTextBox
            // 
            this.availVersionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.updateTableLayout.SetColumnSpan(this.availVersionTextBox, 2);
            this.availVersionTextBox.Location = new System.Drawing.Point(119, 189);
            this.availVersionTextBox.Name = "availVersionTextBox";
            this.availVersionTextBox.ReadOnly = true;
            this.availVersionTextBox.Size = new System.Drawing.Size(342, 21);
            this.availVersionTextBox.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Update Link";
            // 
            // sfLinkLabel
            // 
            this.sfLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.updateTableLayout.SetColumnSpan(this.sfLinkLabel, 2);
            this.sfLinkLabel.Location = new System.Drawing.Point(122, 216);
            this.sfLinkLabel.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.sfLinkLabel.Name = "sfLinkLabel";
            this.sfLinkLabel.Size = new System.Drawing.Size(339, 17);
            this.sfLinkLabel.TabIndex = 26;
            this.sfLinkLabel.TabStop = true;
            this.sfLinkLabel.Text = "http://puttysm.sourceforge.net";
            this.sfLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sfLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.sfLinkLabel_LinkClicked);
            // 
            // updateTableLayout
            // 
            this.updateTableLayout.ColumnCount = 3;
            this.updateTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.updateTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.updateTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.updateTableLayout.Controls.Add(this.resultsGroupBox, 0, 0);
            this.updateTableLayout.Controls.Add(this.availVersionTextBox, 1, 2);
            this.updateTableLayout.Controls.Add(this.availVersionLabel, 0, 2);
            this.updateTableLayout.Controls.Add(this.currVersionLabel, 0, 1);
            this.updateTableLayout.Controls.Add(this.label1, 0, 3);
            this.updateTableLayout.Controls.Add(this.currVersionTextBox, 1, 1);
            this.updateTableLayout.Controls.Add(this.sfLinkLabel, 1, 3);
            this.updateTableLayout.Controls.Add(this.cancelButton, 2, 4);
            this.updateTableLayout.Controls.Add(this.checkForUpdateButton, 1, 4);
            this.updateTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.updateTableLayout.Location = new System.Drawing.Point(0, 0);
            this.updateTableLayout.Name = "updateTableLayout";
            this.updateTableLayout.RowCount = 5;
            this.updateTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.updateTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.updateTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.updateTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.updateTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.updateTableLayout.Size = new System.Drawing.Size(464, 267);
            this.updateTableLayout.TabIndex = 27;
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(464, 267);
            this.Controls.Add(this.updateTableLayout);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::uk.org.riseley.puttySessionManager.Properties.Settings.Default, "DialogFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Font = global::uk.org.riseley.puttySessionManager.Properties.Settings.Default.DialogFont;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(472, 301);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(472, 301);
            this.Name = "UpdateForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Check For Update";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.UpdateForm_Load);
            this.resultsGroupBox.ResumeLayout(false);
            this.resultsGroupBox.PerformLayout();
            this.updateTableLayout.ResumeLayout(false);
            this.updateTableLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button checkForUpdateButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.GroupBox resultsGroupBox;
        private System.Windows.Forms.TextBox resultsTextBox;
        private System.Windows.Forms.Label currVersionLabel;
        private System.Windows.Forms.TextBox currVersionTextBox;
        private System.Windows.Forms.Label availVersionLabel;
        private System.Windows.Forms.TextBox availVersionTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel sfLinkLabel;
        private System.Windows.Forms.ToolTip urlToolTip;
        private System.Windows.Forms.TableLayoutPanel updateTableLayout;
    }
}