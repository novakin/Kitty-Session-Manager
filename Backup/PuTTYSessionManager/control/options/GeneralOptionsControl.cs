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
    public partial class GeneralOptionsControl : OptionsControl, ResetableOptionsControl
    {
        private SessionController sc;
        private HotkeyController hc;
        private Form parentWindow;

        /// <summary>
        /// Fired when the dialog font is changed
        /// </summary>
        public event System.EventHandler DialogFontChanged;

        public GeneralOptionsControl()
        {
            InitializeComponent();

            sc = SessionController.getInstance();
            hc = HotkeyController.getInstance();

            // Reset all the elements to their saved state
            resetState();
        }

        public void setParentWindow(Form parentWindow)
        {
            this.parentWindow = parentWindow;
        }

        public  void resetState()
        {
            autostartCheckBox.Checked = sc.isAutoStartEnabled();
        }

        private void locatePuttyButton_Click(object sender, EventArgs e)
        {
            setupOpenFileDialogue(FileDialogType.PUTTY);
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                puttyTextBox.Text = openFileDialog.FileName;
            }
        }

        private void chooseFontButton_Click(object sender, EventArgs e)
        {
            fontDialog.Font = Properties.Settings.Default.DialogFont;
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                sampleDialogTextbox.Font = fontDialog.Font;
                OnDialogFontChanged(new EventArgs());
            }
        }

        private void autostartCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            bool result = sc.setAutoStart(autostartCheckBox.Checked);
            if (result == false)
            {
                MessageBox.Show(this, "Failed to set \"Start on logon\" preference"
                               , "Warning"
                               , MessageBoxButtons.OK
                               , MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Changing the state of the taskbar icon seems to unregister all the hotkeys
        /// so re-register them here
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void taskbarCheckBox_Click(object sender, EventArgs e)
        {
            hc.UnregisterAllHotKeys(parentWindow);
            hc.registerAllEnabledHotkeys(parentWindow);
        }

        protected virtual void OnDialogFontChanged(EventArgs e)
        {
            if (DialogFontChanged != null)
            {
                DialogFontChanged(this, e);
            }
        }
    }
}
