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
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using uk.org.riseley.puttySessionManager.controller;

namespace uk.org.riseley.puttySessionManager.control.options
{
    public partial class TreeOptionsControl : OptionsControl, ResetableOptionsControl
    {
        private SessionController sc;

        public TreeOptionsControl()
        {
            InitializeComponent();

            sc = SessionController.getInstance();

            // Reset all the elements to their saved state
            resetState();
        }

        public void resetState()
        {

        }

        /// <summary>
        /// Event handler for displayTreeIconsCheckBox Click event
        /// Send a refresh request to the tree view when this value is changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void displayTreeIconsCheckBox_Click(object sender, EventArgs e)
        {
            sc.invalidateSessionList(this, false);
        }


        private void chooseFontButton_Click(object sender, EventArgs e)
        {
            fontDialog.Font = Properties.Settings.Default.TreeFont;
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                sampleTreeTextbox.Font = fontDialog.Font;
            }
        }
    }
}
