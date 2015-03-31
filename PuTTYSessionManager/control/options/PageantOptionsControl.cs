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
using System.IO;

namespace uk.org.riseley.puttySessionManager.control.options
{
    public partial class KageantOptionsControl : OptionsControl, ResetableOptionsControl
    {
        private SessionController sc;

        public KageantOptionsControl()
        {
            InitializeComponent();

            sc = SessionController.getInstance();

            // Reset all the elements to their saved state
            resetState();
        }

        public void resetState()
        {
            // Clear the keys list box
            keysListBox.Items.Clear();

            // Initialise the key list from the properties
            foreach (String key in Properties.Settings.Default.KageantKeyList)
            {
                keysListBox.Items.Add(key);
            }
        }

        private void locatePagentButton_Click(object sender, EventArgs e)
        {
            setupOpenFileDialogue(FileDialogType.Kageant);
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                KageantTextBox.Text = openFileDialog.FileName;
            }
        }

        private void addKeyButton_Click(object sender, EventArgs e)
        {
            setupOpenFileDialogue(FileDialogType.Kageant_KEYS);
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.KageantKeyList.Add(openFileDialog.FileName);
                keysListBox.Items.Add(openFileDialog.FileName);
            }
        }

        private void removeKeyButton_Click(object sender, EventArgs e)
        {
            if (keysListBox.SelectedItem != null)
            {
                Properties.Settings.Default.KageantKeyList.Remove(keysListBox.SelectedItem.ToString());
                keysListBox.Items.Remove(keysListBox.SelectedItem);
            }
        }

        private void launchKageantButton_Click(object sender, EventArgs e)
        {
            String errMsg = sc.launchKageant();
            if (errMsg.Equals("") == false)
            {
                MessageBox.Show("Kageant Failed to start. Check the Kageant location.\n" +
                                errMsg
                    , "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
