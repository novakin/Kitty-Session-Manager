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
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using uk.org.riseley.puttySessionManager.model;
using uk.org.riseley.puttySessionManager.model.eventargs;

namespace uk.org.riseley.puttySessionManager.form
{
    /// <summary>
    /// This form allows various session management functions to be
    /// performed on more than one session:
    ///     Export Sessions
    ///     Copy Sesssion Attributes
    ///     Delete sessions
    ///     Save new session
    /// </summary>
    public partial class SessionEditorForm : SessionManagementForm
    {
        /// <summary>
        /// Copy session form used to select which attributes to copy
        /// to the selected sessions
        /// </summary>
        private CopySessionForm csf;

        /// <summary>
        /// Dialog used to choose which type of export to use
        /// </summary>
        private ExportDialog ed = new ExportDialog();
 
        /// <summary>
        /// Default constructor
        /// </summary>
        public SessionEditorForm()
            : base()
        {
            InitializeComponent();
            csf = new CopySessionForm(this);
        }

        /// <summary>
        /// Event handler for the sessionEditorControl ExportSessionsEvent
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sessionEditorControl1_ExportSessions(object sender, EventArgs e)
        {
            if (ed.ShowDialog() == DialogResult.OK)
                exportSessions(sessionEditorControl1.getSelectedSessions(), new ExportSessionEventArgs(ed.getExportType()));
        }

        /// <summary>
        /// Event handler for the sessionEditorControl NewSessionEvent
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sessionEditorControl1_NewSession(object sender, EventArgs e)
        {
            newSession(sessionEditorControl1.getSelectedSessions());
        }

        /// <summary>
        /// Event handler for the sessionEditorControl DeleteSessionsEvent
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sessionEditorControl1_DeleteSessions(object sender, EventArgs e)
        {
            // Don't pass the orginal sender , to ensure that the SessionEditor
            // control gets the refresh event.
            deleteSessions(sessionEditorControl1.getSelectedSessions(), this);
        }

        /// <summary>
        /// Event handler for the sessionEditorControl CopySessionAttributesEvent
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sessionEditorControl1_CopySessionAttributes(object sender, EventArgs e)
        {
            // Get the list of selected sessions
            List<Session> sl = sessionEditorControl1.getSelectedSessions();

            // If there are none - display the error and return
            if (sl.Count == 0)
            {
                MessageBox.Show("You must select some target sessions!"
                    , "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Pass in the target sessions
            csf.setTargetSessions(sl);

            // Display the copy session form.
            // The form is responsible for actually copying the session 
            // attributes - just display a confirmation if it worked
            if (csf.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Attributes copied successfully"
                        , "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);                
            }            
        }

        /// <summary>
        /// Event handler for the FormClosingEvent
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SessionEditorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            formClosing(sender, e);
        }

        /// <summary>
        /// Event handler for the sessionEditorControl CloseSessionEditorEvent
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sessionEditorControl1_CloseSessionEditor(object sender, EventArgs e)
        {
            closeSessionManagementForm(sender, e);
        }

        public override void resetDialogFont()
        {
            base.resetDialogFont();
            if ( csf != null )
                csf.resetDialogFont();
            ed.resetDialogFont();
            if ( sessionEditorControl1 != null )
                sessionEditorControl1.resetDialogFont();
        }
    }
}