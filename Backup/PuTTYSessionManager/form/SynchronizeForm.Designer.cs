/* 
 * Copyright (C) 2009 David Riseley 
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
    partial class SynchronizeForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.optionsControl1 = new uk.org.riseley.puttySessionManager.control.options.SyncOptionsControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableControl1 = new uk.org.riseley.puttySessionManager.control.TableControl();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(737, 331);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.optionsControl1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(729, 305);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Locate Sessions";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // optionsControl1
            // 
            this.optionsControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.optionsControl1.Location = new System.Drawing.Point(3, 3);
            this.optionsControl1.Name = "optionsControl1";
            this.optionsControl1.Size = new System.Drawing.Size(723, 299);
            this.optionsControl1.TabIndex = 0;
            this.optionsControl1.SyncSessionsLoaded += new uk.org.riseley.puttySessionManager.control.options.SyncOptionsControl.SyncSessionsLoadedEventHandler(this.optionsControl1_SyncSessionsLoaded);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableControl1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(729, 305);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Synchronise Sessions";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableControl1
            // 
            this.tableControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableControl1.Location = new System.Drawing.Point(3, 3);
            this.tableControl1.Name = "tableControl1";
            this.tableControl1.Size = new System.Drawing.Size(723, 299);
            this.tableControl1.TabIndex = 0;
            this.tableControl1.SyncSessionsRequested += new uk.org.riseley.puttySessionManager.control.TableControl.SyncSessionsRequestedEventHandler(this.tableControl1_SyncSessionsRequested);
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            // 
            // SynchronizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 331);
            this.Controls.Add(this.tabControl1);
            this.MinimumSize = new System.Drawing.Size(745, 365);
            this.Name = "SynchronizeForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Synchronize Sessions";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SynchronizeForm_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private uk.org.riseley.puttySessionManager.control.options.SyncOptionsControl optionsControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private uk.org.riseley.puttySessionManager.control.TableControl tableControl1;
        private System.ComponentModel.BackgroundWorker backgroundWorker;


    }
}