/* 
 * Copyright (C) 2008,2009 David Riseley 
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
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using uk.org.riseley.puttySessionManager.model;
using uk.org.riseley.puttySessionManager.model.eventargs;
using uk.org.riseley.puttySessionManager.controller;

namespace uk.org.riseley.puttySessionManager.control
{
    public partial class TableControl : UserControl
    {
        /// <summary>
        /// The session controller
        /// </summary>
        private SessionController sc;

        /// <summary>
        /// The original list of sessions to sync
        /// Used to support reset functionality
        /// </summary>
        private List<Session> sessionList;

        /// <summary>
        /// The template session for new sessions
        /// </summary>
        private Session templateSession;

        /// <summary>
        /// 
        /// </summary>
        private bool ignoreExistingSessions = false;

        /// <summary>
        /// 
        /// </summary>
        private const string ACTION_UPDATE = "Update";

        /// <summary>
        /// 
        /// </summary>
        private const string ACTION_IGNORE = "Ignore";

        /// <summary>
        /// Event handler for the SyncSessionsRequested event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public delegate void SyncSessionsRequestedEventHandler(object sender, SyncSessionsRequestedEventArgs e);

        /// <summary>
        /// This event is fired when a the user wishes to sync sessions 
        /// </summary>
        [Description("Fires when sessions have been successfully loaded")]
        public event SyncSessionsRequestedEventHandler SyncSessionsRequested;

        /// <summary>
        /// Default constructor for TableControl 
        /// </summary>
        public TableControl()
        {
            InitializeComponent();
            sc = SessionController.getInstance();
        }

        /// <summary>
        /// Load sessions into the table
        /// </summary>
        /// <param name="ea"></param>
        public void LoadSessions(SyncSessionsLoadedEventArgs ea)
        {
            DataGridViewRow dgvr = null;
           
            sessionList = ea.SessionList;
            templateSession = ea.SessionTemplate;
            ignoreExistingSessions = ea.IgnoreExistingSessions;

            Dictionary<String,Session> sessionsDictionary = new Dictionary<string,Session>();

            dataGridView1.SuspendLayout();
            dataGridView1.Rows.Clear();

            foreach (Session newSession in sessionList)
            {
                Session existingSession = sc.findSession(newSession);
                SessionAction action = new SessionAction(existingSession, newSession);

                // Make sure we skip over duplicate sessions
                if (!sessionsDictionary.ContainsKey(newSession.SessionKey))
                {
                    sessionsDictionary.Add(newSession.SessionKey, newSession);

                    dgvr = new DataGridViewRow();
                    dgvr.CreateCells(dataGridView1, getCellValues(action));
                    dgvr.Tag = action;
                    dataGridView1.Rows.Add(dgvr);
                }                
            }

            if (ea.IgnoreExistingSessions == false)
            {
                foreach (Session existingSession in sc.getSessionList())
                {
                    if (!sessionsDictionary.ContainsKey(existingSession.SessionKey))
                    {
                        SessionAction action = new SessionAction(existingSession, null);

                        dgvr = new DataGridViewRow();
                        dgvr.CreateCells(dataGridView1, getCellValues(action));
                        dgvr.Tag = action;
                        dataGridView1.Rows.Add(dgvr);
                    }
                }
            }

            dataGridView1.ResumeLayout();
        }

        /// <summary>
        /// Get the values to populate each row of the table
        /// </summary>
        /// <param name="action">The session action to process</param>
        /// <returns>The row data</returns>
        private String [] getCellValues( SessionAction action )
        {
            string sessionName = "";
            string newSessionFolder = "";
            string existingSessionFolder = "";
            string newSessionHostname = "";
            string existingSessionHostname = "";

            if (action.NewSession != null)
            {
                sessionName = action.NewSession.SessionDisplayText;
                newSessionFolder = action.NewSession.FolderDisplayText;
                newSessionHostname = action.NewSession.Hostname;
            }

            if (action.ExistingSession != null)
            {
                if (action.Action != SessionAction.ACTION.RENAME)
                {
                    sessionName = action.ExistingSession.SessionDisplayText;
                }
                else
                {
                    sessionName = action.NewSession.SessionDisplayText + " [" +
                                  action.ExistingSession.SessionDisplayText + "]";
                }
                existingSessionFolder = action.ExistingSession.FolderDisplayText;
                existingSessionHostname = action.ExistingSession.Hostname;
            }

            String[] cellValues = new String[] {    sessionName
                                                  , existingSessionFolder
                                                  , newSessionFolder
                                                  , existingSessionHostname
                                                  , newSessionHostname
                                                  , action.getActionDescription()
                                                  , getAction(action.Action)
                                                };
            return cellValues;                                                              
        }

        /// <summary>
        /// Decide whether to update or ignore the row
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        private String getAction(SessionAction.ACTION a)
        {
            switch (a)
            {
                case SessionAction.ACTION.DELETE: { return ACTION_UPDATE; }
                case SessionAction.ACTION.ADD:    { return ACTION_UPDATE; }
                case SessionAction.ACTION.UPDATE: { return ACTION_UPDATE; }
                case SessionAction.ACTION.RENAME: { return ACTION_UPDATE; }
                case SessionAction.ACTION.NONE:   { return ACTION_IGNORE; }
                default:                          { return ACTION_IGNORE; }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="action"></param>
        private void amendActions(string action)
        {
            dataGridView1.SuspendLayout();
            foreach (DataGridViewRow dvgr in dataGridView1.Rows)
            {
                if (dvgr.Selected)
                {
                    dvgr.Cells["actionColumn"].Value = action;
                }
            }
            dataGridView1.ResumeLayout();
        }       

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void resetButton_Click(object sender, EventArgs e)
        {
            LoadSessions(new SyncSessionsLoadedEventArgs(sessionList, templateSession, ignoreExistingSessions));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void updateButton_Click(object sender, EventArgs e)
        {
            amendActions(ACTION_UPDATE);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ignoreButton_Click(object sender, EventArgs e)
        {
            amendActions(ACTION_IGNORE);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void removeUnchangedButton_Click(object sender, EventArgs e)
        {
            List<DataGridViewRow> rowsToRemove = new List<DataGridViewRow>();

            // First find all the rows to remove
            foreach (DataGridViewRow dvgr in dataGridView1.Rows)
            {
                if (dvgr.Cells["statusColumn"].Value.Equals("Unchanged"))
                    rowsToRemove.Add(dvgr);
            }

            // Then susupend the layout and remove the rows
            dataGridView1.SuspendLayout();
            foreach (DataGridViewRow dvgr in rowsToRemove)
            {
                dataGridView1.Rows.Remove(dvgr);
            }
            dataGridView1.ResumeLayout();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private List<SessionAction> getSessionsToUpdate()
        {
            List<SessionAction> sl = new List<SessionAction>();
            foreach (DataGridViewRow dvgr in dataGridView1.Rows)
            {
                if (dvgr.Cells["actionColumn"].Value.Equals(ACTION_UPDATE))
                {
                    sl.Add((SessionAction)dvgr.Tag);
                }
            }

            return sl;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void syncButton_Click(object sender, EventArgs e)
        {
            SyncSessionsRequestedEventArgs ssre = new SyncSessionsRequestedEventArgs(getSessionsToUpdate(),templateSession,ignoreExistingSessions);
            if ( ssre.SessionActionList.Count > 0 )
                OnSyncSessionsRequested(this, ssre);
            else
                MessageBox.Show("No sessions selected for modification"
                    , "Warning"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Warning);

        }

        /// <summary>
        /// Fire the SyncSessionsRequested event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected virtual void OnSyncSessionsRequested(Object sender, SyncSessionsRequestedEventArgs e)
        {
            if (SyncSessionsRequested != null)
                SyncSessionsRequested(sender, e);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void renameButton_Click(object sender, EventArgs e)
        {
            int matchCount = 0;

            if (dataGridView1.Rows.Count == 0)
                return;

            DialogResult r = MessageBox.Show("This will attempt to identify renamed \n"
                            + "sessions based on matching the hostnames.\n"
                            + "Do you want restrict the matching to sessions\n"
                            + "with the same folder names?"
                            , "Question"
                            , MessageBoxButtons.YesNoCancel
                            , MessageBoxIcon.Question);
            
            if (r == DialogResult.Yes || r == DialogResult.No)
            {
                List<SessionAction> deletedSessions = new List<SessionAction>();
                Dictionary <String , SessionAction> newSessionsDict = new Dictionary<String , SessionAction>();
                Dictionary <SessionAction, DataGridViewRow> rowDict = new Dictionary<SessionAction,DataGridViewRow>();

                bool includeFoldersInMatch = (r == DialogResult.Yes);

                // First indentify all the new and deleted sessions
                foreach (DataGridViewRow dvgr in dataGridView1.Rows)
                {
                    SessionAction sa = (SessionAction)dvgr.Tag;
                    if (sa.Action == SessionAction.ACTION.ADD ||
                        sa.Action == SessionAction.ACTION.DELETE)
                    {
                        rowDict.Add(sa, dvgr);
                        if (sa.Action == SessionAction.ACTION.ADD)
                        {
                            string key = sa.NewSession.Hostname;
                            if ( includeFoldersInMatch )
                                key += "|" + sa.NewSession.FolderName;

                            // Only use the first instance of each key
                            if ( ! newSessionsDict.ContainsKey(key) )
                                newSessionsDict.Add(key,sa);
                        }
                        else
                        {
                            deletedSessions.Add(sa);                        
                        }
                    }
                }

                dataGridView1.SuspendLayout();
                // Then try to match a new session to each deleted session
                foreach (SessionAction delSession in deletedSessions)
                {
                    string key = delSession.ExistingSession.Hostname;
                    if ( includeFoldersInMatch )
                        key += "|" + delSession.ExistingSession.FolderName;

                    if ( newSessionsDict.ContainsKey(key) )
                    {
                        SessionAction newSession = null;
                        newSessionsDict.TryGetValue(key,out newSession);
                        if ( newSession != null )
                        {
                            DataGridViewRow dvgr;
                            rowDict.TryGetValue(newSession, out dvgr);
                            if (dvgr != null)
                            {
                                dataGridView1.Rows.Remove(dvgr);
                                newSessionsDict.Remove(key);
                                delSession.NewSession = newSession.NewSession;
                                delSession.Action = SessionAction.ACTION.RENAME;
                                rowDict.TryGetValue(delSession, out dvgr);
                                if (dvgr != null)
                                {
                                    dataGridView1.Rows.Remove(dvgr);
                                    dvgr = new DataGridViewRow();
                                    dvgr.CreateCells(dataGridView1,getCellValues(delSession));
                                    dvgr.Tag = delSession;
                                    dataGridView1.Rows.Add(dvgr);
                                    rowDict.Remove(delSession);
                                    rowDict.Add(delSession,dvgr);
                                    matchCount++;
                                }
                            }
                        }
                    }                
                }
                dataGridView1.ResumeLayout();

                MessageBox.Show("Matched " + matchCount + " sessions"
                            , "Information"
                            , MessageBoxButtons.OK
                            , MessageBoxIcon.Information);
            }

            return;
        }
    }
}
