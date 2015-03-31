/* 
 * Copyright (C) 2006-2009 David Riseley 
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
    /// <summary>
    /// This is the control from which all other session controls extend
    /// It registers with the <code>SessionController</code>
    /// and listens for <code>SessionsRefreshedEvent</code>s
    /// </summary>
    public partial class SessionControl : UserControl
    {
        /// <summary>
        /// Fired when a launch session request is made
        /// </summary>
        public event LaunchSessionEventHandler LaunchSession;

        /// <summary>
        /// Fired when an export session(s) request is made
        /// </summary>
        public event ExportSessionEventHandler ExportSessions;

        /// <summary>
        /// Fired when a new session request is made
        /// </summary>
        public event System.EventHandler NewSession;

        /// <summary>
        /// Fired when a delete session(s) request is made
        /// </summary>
        public event DeleteSessionsEventHandler DeleteSessions;

        /// <summary>
        /// Event handler for the <code>LaunchSessionEvent</code>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="se">EventArgs containing the session name to launch</param>
        public delegate void LaunchSessionEventHandler(object sender, LaunchSessionEventArgs se);

        /// <summary>
        /// Event handler for the <code>ExportSessionEvent</code>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="se">EventArgs containing the export type</param>
        public delegate void ExportSessionEventHandler(object sender, ExportSessionEventArgs se);

        /// <summary>
        /// Event handler for the <code>DeleteSessionsEvent</code>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="ce">The delete sessions event can be cancelled if validation fails</param>
        public delegate void DeleteSessionsEventHandler(object sender, CancelEventArgs ce);

        /// <summary>
        /// Reference to the session controller
        /// </summary>
        protected SessionController sc;

        /// <summary>
        /// Variable to capture if the enter key has been pressed in this 
        /// control
        /// </summary>
        protected Boolean enterPressed = false;

        /// <summary>
        /// Default constructor for this control
        /// This will get a reference to the singleton SessionController
        /// and register the SessionsRefreshedEventHandler
        /// </summary>
        public SessionControl()
        {
            sc = SessionController.getInstance();
            InitializeComponent();
            SessionController.SessionsRefreshedEventHandler scHandler = new SessionController.SessionsRefreshedEventHandler(this.SessionsRefreshed);
            sc.SessionsRefreshed += scHandler;
        }

        protected virtual void OnLaunchSession(LaunchSessionEventArgs se)
        {
            if (LaunchSession != null)
            {
                // Hide the form if the option has been requested
                if (Properties.Settings.Default.MinimizeOnUse == true && ParentForm.Visible)
                    ParentForm.Hide();
                LaunchSession(this, se);
            }
        }

        protected virtual void OnExportSessions(ExportSessionEventArgs e)
        {
            if (ExportSessions != null)
            {
                ExportSessions(this, e);
            }
        }

        protected virtual void OnNewSession(EventArgs e)
        {
            if (NewSession != null)
            {
                NewSession(this, e);
            }
        }

        protected virtual void OnDeleteSessions(CancelEventArgs ce)
        {
            if (DeleteSessions != null)
            {
                DeleteSessions(this, ce);
            }
        }

        public virtual void getSessionMenuItems(ContextMenuStrip cms, ToolStripMenuItem parent)
        {
        }

        protected virtual void LoadSessions()
        {
        }

        public virtual List<Session> getSelectedSessions()
        {
            List<Session> sl = new List<Session>();
            return sl;
        }

        protected SessionController getSessionController()
        {
            return sc;
        }

        public void SessionsRefreshed(Object sender, RefreshSessionsEventArgs e)
        {
            if (!(sender.Equals(this) && e.RefreshSource == false))
                LoadSessions();
        }

        public bool ContextMenuVisible
        {
            get
            {
                return (this.ContextMenuStrip == null ? false : true);
            }

            set
            {
                if (value == false)
                    this.ContextMenuStrip = null;
                else
                    this.ContextMenuStrip = this.contextMenuStrip;
            }
        }

        private void refreshSessionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sc.invalidateSessionList(this, true);
        }

        /// <summary>
        /// Capture when the enter key is press in this control 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void sessionControl_KeyDown(object sender, KeyEventArgs e)
        {
            enterPressed = false;
            if (e.KeyCode == Keys.Enter)
            {
                enterPressed = true;
            }
        }

        public virtual void resetDialogFont()
        {
        }
    }
}
