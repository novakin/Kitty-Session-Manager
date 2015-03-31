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
    partial class ProgressDialog
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
            this.okButton = new System.Windows.Forms.Button();
            this.messageLabel = new System.Windows.Forms.Label();
            this.sesssionNameTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.sesssionNameTableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(166, 71);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // messageLabel
            // 
            this.messageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.messageLabel.AutoSize = true;
            this.messageLabel.Location = new System.Drawing.Point(3, 0);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Padding = new System.Windows.Forms.Padding(10);
            this.messageLabel.Size = new System.Drawing.Size(402, 33);
            this.messageLabel.TabIndex = 2;
            this.messageLabel.Text = "Synchronized 0 out of 0 sessions";
            this.messageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sesssionNameTableLayout
            // 
            this.sesssionNameTableLayout.ColumnCount = 2;
            this.sesssionNameTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.sesssionNameTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.sesssionNameTableLayout.Controls.Add(this.okButton, 1, 2);
            this.sesssionNameTableLayout.Controls.Add(this.progressBar, 1, 1);
            this.sesssionNameTableLayout.Controls.Add(this.messageLabel, 1, 0);
            this.sesssionNameTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sesssionNameTableLayout.Location = new System.Drawing.Point(0, 0);
            this.sesssionNameTableLayout.Name = "sesssionNameTableLayout";
            this.sesssionNameTableLayout.RowCount = 3;
            this.sesssionNameTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.sesssionNameTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.sesssionNameTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.sesssionNameTableLayout.Size = new System.Drawing.Size(408, 103);
            this.sesssionNameTableLayout.TabIndex = 3;
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(10, 36);
            this.progressBar.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(388, 23);
            this.progressBar.TabIndex = 3;
            // 
            // ProgressDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.okButton;
            this.ClientSize = new System.Drawing.Size(408, 103);
            this.ControlBox = false;
            this.Controls.Add(this.sesssionNameTableLayout);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(414, 135);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(414, 135);
            this.Name = "ProgressDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Progress";
            this.TopMost = true;
            this.sesssionNameTableLayout.ResumeLayout(false);
            this.sesssionNameTableLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.TableLayoutPanel sesssionNameTableLayout;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}