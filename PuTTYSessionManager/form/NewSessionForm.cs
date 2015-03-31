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
using uk.org.riseley.puttySessionManager.controller;

namespace uk.org.riseley.puttySessionManager.form
{
    public partial class NewSessionForm : Form
    {
        private Form parentWindow;
        private SessionController sc;

        public NewSessionForm(Form parent)
        {
            parentWindow = parent;
            sc = SessionController.getInstance();
            InitializeComponent();
            SessionController.SessionsRefreshedEventHandler scHandler = new SessionController.SessionsRefreshedEventHandler(this.SessionsRefreshed);
            sc.SessionsRefreshed += scHandler;
            resetDialogFont();
        }

        private void loadList()
        {
            sessionComboBox.Items.AddRange(sc.getSessionList().ToArray());
            sessionComboBox.SelectedItem = sc.findDefaultSession(false);
            sessionFolderComboBox.Items.AddRange(sc.getFolderList().ToArray());
            sessionFolderComboBox.SelectedItem = sc.findDefaultFolder();
        }

        private void clearList()
        {
            sessionComboBox.Items.Clear();
            sessionFolderComboBox.Items.Clear();
        }

        public void SessionsRefreshed(Object sender, EventArgs e)
        {
            sessionComboBox.BeginUpdate();
            sessionFolderComboBox.BeginUpdate();
            clearList();
            loadList();
            sessionComboBox.EndUpdate();
            sessionFolderComboBox.EndUpdate();
        }

        private void hostnameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (hostnameTextBox.Text.Length < sessionnameTextBox.MaxLength)
                sessionnameTextBox.Text = hostnameTextBox.Text;
            else
                sessionnameTextBox.Text = hostnameTextBox.Text.Substring(0,sessionnameTextBox.MaxLength);
        }

        public NewSessionRequest getNewSessionRequest()
        {
            NewSessionRequest nsr = new NewSessionRequest((Session)sessionComboBox.SelectedItem
                                        , sessionFolderComboBox.Text
                                        , hostnameTextBox.Text
                                        , sessionnameTextBox.Text
                                        , copyUsernameCheckBox.Checked
                                        , launchSessionCheckBox.Checked);
            return nsr;

        }

        public void setNewSessionRequest(NewSessionRequest nsr)
        {
            if (nsr.SessionTemplate != null)
            {
                // use the session controller to find the session as the objects held
                // held in the session control may not be the same
                sessionComboBox.SelectedItem = sc.findSession(nsr.SessionTemplate);
                if (nsr.SessionFolder == null)
                    sessionFolderComboBox.SelectedItem = nsr.SessionTemplate.FolderName;
                else
                    sessionFolderComboBox.SelectedItem = nsr.SessionFolder;
            }
            else
            {
                sessionComboBox.SelectedItem = sc.findDefaultSession(false);
                if (nsr.SessionFolder != null && !(nsr.SessionFolder.Equals("")))
                {
                    sessionFolderComboBox.SelectedItem = nsr.SessionFolder;
                }
            }
            launchSessionCheckBox.Checked = nsr.LaunchSession;
            copyUsernameCheckBox.Checked = nsr.CopyDefaultUsername;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (sessionnameTextBox.Text.Equals(""))
            {
                MessageBox.Show("You must specify a session name."
                  , "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.None;
            }
            else if (sc.findSessionByName(sessionnameTextBox.Text) != null)
            {
                MessageBox.Show("Session: " + sessionnameTextBox.Text +
                                " already exists.\nPlease choose another name."
                  , "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.None;
            }
            else if (sc.isDefaultSessionName(sessionnameTextBox.Text))
            {
                MessageBox.Show("You cannot have " + sessionnameTextBox.Text 
                    + " as the session name."
               , "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.None;
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to create: " + sessionnameTextBox.Text
                            , "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
                    DialogResult = DialogResult.None;

            }

        }

        private void NewSessionForm_Shown(object sender, EventArgs e)
        {
            sessionnameTextBox.Clear();
            hostnameTextBox.Clear();
            if (sessionComboBox.Items.Count == 0)
            {
                MessageBox.Show("You must have at least one saved session to copy from.\n" +
                                "Please create a session in PuTTY first"
                  , "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.Cancel;
                this.Visible = false;
            }

        }

        private void sessionComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            sessionFolderComboBox.SelectedItem = ((Session)sessionComboBox.SelectedItem).FolderName;
        }

        public void resetDialogFont()
        {
            Font = Properties.Settings.Default.DialogFont;
        }
    }
}