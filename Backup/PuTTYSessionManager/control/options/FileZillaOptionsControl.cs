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
    public partial class FileZillaOptionsControl : OptionsControl, ResetableOptionsControl
    {
        public FileZillaOptionsControl()
        {
            InitializeComponent();

            // Reset all the elements to their saved state
            resetState();
        }

        public void resetState()
        {
            // Reset the filezilla protocol button to the save pref
            SessionController.Protocol fp = (SessionController.Protocol)Properties.Settings.Default.FileZillaProtocol;
            if (fp == SessionController.Protocol.FTP)
            {
                fzFtpRadioButton.Checked = true;
            }
            else if (fp == SessionController.Protocol.FTPS)
            {
                fzFtpsRadioButton.Checked = true;
            }
            else if (fp == SessionController.Protocol.SFTP)
            {
                fzSftpRadioButton.Checked = true;
            }
            else if (fp == SessionController.Protocol.AUTO)
            {
                fzSessionInfoRadioButton.Checked = true;
            }
        }

        /// <summary>
        /// Update the FileZillaProtocol setting when any of the radio buttons
        /// are clicked
        /// </summary>
        /// <param name="sender">The button that was clicked</param>
        /// <param name="e"></param>
        private void protocolRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (fzFtpRadioButton.Checked == true)
            {
                Properties.Settings.Default.FileZillaProtocol = (int)SessionController.Protocol.FTP;
            }
            else if (fzFtpsRadioButton.Checked == true)
            {
                Properties.Settings.Default.FileZillaProtocol = (int)SessionController.Protocol.FTPS;
            }
            else if (fzSftpRadioButton.Checked == true)
            {
                Properties.Settings.Default.FileZillaProtocol = (int)SessionController.Protocol.SFTP;
            }
            else if (fzSessionInfoRadioButton.Checked == true)
            {
                Properties.Settings.Default.FileZillaProtocol = (int)SessionController.Protocol.AUTO;
            }
        }

        /// <summary>
        /// Display the filezilla file chooser
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void locateFileZillaButton_Click(object sender, EventArgs e)
        {
            setupOpenFileDialogue(FileDialogType.FILEZILLA);
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filezillaTextBox.Text = openFileDialog.FileName;
            }
        }
    }
}
