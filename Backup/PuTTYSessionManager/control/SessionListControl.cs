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

namespace uk.org.riseley.puttySessionManager.control
{
    /// <summary>
    /// This control presents a flat list of sessions
    /// </summary>
    public partial class SessionListControl : SessionControl
    {

        ToolStripMenuItem[] tsmiArray;

        /// <summary>
        /// Default constructor for the list control
        /// </summary>
        public SessionListControl() : base()
        {
            InitializeComponent();
        }

        
        /// <summary>
        /// Load sessions into the list and the system tray
        /// </summary>
        protected override void LoadSessions()
        {
            // Suppress repainting the ListBox until all the objects have been created.
            listBox1.BeginUpdate();

            // Clear out the current list
            listBox1.Items.Clear();

            // Add the contents of the list to the list box
            listBox1.Items.AddRange(getSessionController().getSessionList().ToArray());

            // Sort the list
            listBox1.Sorted = true;

            // Select the first session
            if ( listBox1.Items.Count > 0 )
                listBox1.SelectedIndex = 0;

            // Begin repainting the TreeView.
            listBox1.EndUpdate();

            // Setup the System tray array of menu items
            tsmiArray = new ToolStripMenuItem[getSessionController().getSessionList().Count];
            int i=0;
            foreach (Session s in getSessionController().getSessionList())
            {
                tsmiArray[i] = new ToolStripMenuItem(s.SessionDisplayText, null, listBox1_DoubleClick);
                // Make sure the menu item is tagged with the session
                tsmiArray[i].Tag = s;
                i++;
            }
        }

        /// <summary>
        /// Event handler for the double click event on the list box
        /// or one of the tool strip menu items
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            Session s = null;

            if ( sender is ListBox ) {
                s = (Session)((ListBox)sender).SelectedItem;
            }
            else if (sender is ToolStripMenuItem)
            {
                s = (Session)((ToolStripMenuItem)sender).Tag;
            }

            OnLaunchSession(new LaunchSessionEventArgs(s));            
        }

        /// <summary>
        /// Add the array of menu items to the system tray
        /// </summary>
        /// <param name="cms">The menu</param>
        /// <param name="parent">The root of the systray menu</param>
        public override void getSessionMenuItems(ContextMenuStrip cms, ToolStripMenuItem parent)
        {
            // Suspend the layout before modification
            cms.SuspendLayout();

            parent.DropDownItems.Clear();
            if ( tsmiArray != null )
                parent.DropDownItems.AddRange(tsmiArray);            

            // Now resume the layout
            cms.ResumeLayout();
        }

        /// <summary>
        /// Get a list of selected items
        /// </summary>
        /// <returns></returns>
        public override List<Session> getSelectedSessions()
        {
            List<Session> sl = new List<Session>();
            Session s = (Session)listBox1.SelectedItem;
            if ( s != null )
                sl.Add(s);
            return sl;
        }

        /// <summary>
        /// Event handler for key up from the list view
        /// If ENTER is pressed launch that session
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && enterPressed)
            {
                Session s = (Session)listBox1.SelectedItem;
                OnLaunchSession(new LaunchSessionEventArgs(s));

                // Reset the enter pressed flag
                // and mark the event as handled
                enterPressed = false;
                e.Handled = true;
            }
        }

        /// <summary>
        /// Event handler for key down event
        /// Capture if ENTER is pressed in this window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox1_KeyDown(object sender, KeyEventArgs e)
        {
            sessionControl_KeyDown(sender, e);
        }
    }
}
