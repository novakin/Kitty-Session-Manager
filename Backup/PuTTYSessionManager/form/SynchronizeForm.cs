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
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using uk.org.riseley.puttySessionManager.control;
using uk.org.riseley.puttySessionManager.controller;
using uk.org.riseley.puttySessionManager.model.eventargs;

namespace uk.org.riseley.puttySessionManager.form
{
    public partial class SynchronizeForm : SessionManagementForm
    {
        private ProgressDialog progressDialog = new ProgressDialog();

        private int sessionsCount = 0;

        public SynchronizeForm()
            :base()
        {
            InitializeComponent();
            SessionController.SessionsRefreshedEventHandler scHandler = new SessionController.SessionsRefreshedEventHandler(this.SessionsRefreshed);
            sc.SessionsRefreshed += scHandler;
            resetDialogFont();
        }

        private void SynchronizeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }

        public void SessionsRefreshed(Object sender, EventArgs e)
        {
            optionsControl1.loadList(sc.getSessionList().ToArray(), sc.findDefaultSession(false));
        }

        private void optionsControl1_SyncSessionsLoaded(object sender, SyncSessionsLoadedEventArgs e)
        {
            tableControl1.LoadSessions(e);
            if ( e.SessionList.Count > 0 )
                tabControl1.SelectTab(1);
        }

        private void tableControl1_SyncSessionsRequested(object sender, SyncSessionsRequestedEventArgs e)
        {
            // Double check that the template session still exists
            // or else that will cause issues later
            if (sc.findSession(e.SessionTemplate) == null)
            {
                MessageBox.Show("Template session:\n" + e.SessionTemplate.SessionDisplayText 
                    + "\nhas been removed.\n"
                    + "Please clear your selection and try again." 
                    , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Attempt to backup the existing sessions
            DialogResult dr = backupSessions(sc.getSessionList());
            if (( dr == DialogResult.Yes ) ||
                ( dr == DialogResult.No) )
            {
                sessionsCount = e.SessionActionList.Count;
                progressDialog.reset(sessionsCount);

                backgroundWorker.RunWorkerAsync(e);
            }
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            // Get the BackgroundWorker that raised this event.
            BackgroundWorker worker = sender as BackgroundWorker;
            SyncSessionsRequestedEventArgs srea = (SyncSessionsRequestedEventArgs)e.Argument;

            e.Result = sc.syncSessions(worker, srea);
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (progressDialog.Visible == false)
                progressDialog.Show(this);
            progressDialog.updateProgress("Updated " + e.ProgressPercentage + 
                                          " of " + sessionsCount + " sessions"
                                          , e.ProgressPercentage);
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // And request a session refresh
            sc.invalidateSessionList(this, true);

            int modifiedCount = (int)e.Result;
            progressDialog.updateProgress("Updated " + modifiedCount +
                              " of " + sessionsCount + " sessions"
                              , modifiedCount);

            // Reset the controls
            optionsControl1.clearButton_Click(this, new EventArgs());
            tabControl1.SelectTab(0);
        }

        public override void resetDialogFont()
        {
            base.resetDialogFont();
            progressDialog.resetDialogFont();
        }
    }
}