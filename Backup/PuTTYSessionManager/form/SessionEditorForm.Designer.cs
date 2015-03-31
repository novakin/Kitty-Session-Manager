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
using uk.org.riseley.puttySessionManager.control;
namespace uk.org.riseley.puttySessionManager.form
{
    partial class SessionEditorForm
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
            this.sessionEditorControl1 = new uk.org.riseley.puttySessionManager.control.SessionEditorControl();
            this.SuspendLayout();
            // 
            // sessionEditorControl1
            // 
            this.sessionEditorControl1.ContextMenuVisible = false;
            this.sessionEditorControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sessionEditorControl1.Location = new System.Drawing.Point(0, 0);
            this.sessionEditorControl1.Name = "sessionEditorControl1";
            this.sessionEditorControl1.Size = new System.Drawing.Size(545, 419);
            this.sessionEditorControl1.TabIndex = 0;
            this.sessionEditorControl1.ExportSessions += new uk.org.riseley.puttySessionManager.control.SessionControl.ExportSessionEventHandler(this.sessionEditorControl1_ExportSessions);
            this.sessionEditorControl1.CopySessionAttributes += new System.EventHandler(this.sessionEditorControl1_CopySessionAttributes);
            this.sessionEditorControl1.NewSession += new System.EventHandler(this.sessionEditorControl1_NewSession);
            this.sessionEditorControl1.CloseSessionEditor += new System.EventHandler(this.sessionEditorControl1_CloseSessionEditor);
            this.sessionEditorControl1.DeleteSessions += new uk.org.riseley.puttySessionManager.control.SessionControl.DeleteSessionsEventHandler(this.sessionEditorControl1_DeleteSessions);
            // 
            // SessionEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 419);
            this.Controls.Add(this.sessionEditorControl1);
            this.MinimumSize = new System.Drawing.Size(553, 187);
            this.Name = "SessionEditorForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SessionEditorForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private SessionEditorControl sessionEditorControl1;




    }
}