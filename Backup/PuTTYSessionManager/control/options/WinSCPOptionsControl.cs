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
    public partial class WinSCPOptionsControl : OptionsControl, ResetableOptionsControl
    {
        public WinSCPOptionsControl()
        {
            InitializeComponent();

            // Reset all the elements to their saved state
            resetState();
        }

        public void resetState()
        {
            // Reset the WinSCP Version buttons to the saved pref
            int wsVer = Properties.Settings.Default.WinSCPVersion;
            if (wsVer == 3)
            {
                wsVer3RadioButton.Checked = true;
            }
            else if (wsVer == 4)
            {
                wsVer4RadioButton.Checked = true;
            }

            // Reset the WinSCP protocol buttons to the saved pref
            SessionController.Protocol wp = (SessionController.Protocol)Properties.Settings.Default.WinSCPProtocol;
            if (wp == SessionController.Protocol.FTP)
            {
                wsFtpRadioButton.Checked = true;
            }
            else if (wp == SessionController.Protocol.SCP)
            {
                wsScpRadioButton.Checked = true;
            }
            else if (wp == SessionController.Protocol.SFTP)
            {
                wsSftpRadioButton.Checked = true;
            }
            else if (wp == SessionController.Protocol.AUTO)
            {
                wsSessionInfoRadioButton.Checked = true;
            }

            // Reset the WinSCP pref protocol buttons to the saved pref
            SessionController.Protocol wpp = (SessionController.Protocol)Properties.Settings.Default.WinSCPPrefProtocol;
            if (wpp == SessionController.Protocol.SFTP)
            {
                wsprefSftpRadioButton.Checked = true;
            }
            else if (wpp == SessionController.Protocol.SCP)
            {
                wsprefScpRadioButton.Checked = true;
            }

            // Call the wsVerRadioButton_CheckedChanged method
            // to ensure only a valid combination of protocol and
            // version is displayed
            wsVerRadioButton_CheckedChanged(this, EventArgs.Empty);
        }

        /// <summary>
        /// Update the WinSCPProtocol setting when any of the radio buttons
        /// are clicked
        /// </summary>
        /// <param name="sender">The button that was clicked</param>
        /// <param name="e"></param>
        private void protocolRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            wsPrefGroupBox.Enabled = wsSessionInfoRadioButton.Checked;

            if (wsSessionInfoRadioButton.Checked == true)
            {
                Properties.Settings.Default.WinSCPProtocol = (int)SessionController.Protocol.AUTO;
                if (wsprefScpRadioButton.Checked == true)
                {
                    Properties.Settings.Default.WinSCPPrefProtocol = (int)SessionController.Protocol.SCP;
                }
                else if (wsprefSftpRadioButton.Checked == true)
                {
                    Properties.Settings.Default.WinSCPPrefProtocol = (int)SessionController.Protocol.SFTP;
                }
            }
            else if (wsSftpRadioButton.Checked == true)
            {
                Properties.Settings.Default.WinSCPProtocol = (int)SessionController.Protocol.SFTP;
            }
            else if (wsScpRadioButton.Checked == true)
            {
                Properties.Settings.Default.WinSCPProtocol = (int)SessionController.Protocol.SCP;
            }
            else if (wsFtpRadioButton.Checked == true)
            {
                Properties.Settings.Default.WinSCPProtocol = (int)SessionController.Protocol.FTP;
            }
        }

        /// <summary>
        /// Listener for the Checked Changed event from the
        /// WinSCP Version radio buttons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void wsVerRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            wsFtpRadioButton.Enabled = wsVer3RadioButton.Checked;
            if (wsVer3RadioButton.Checked == true)
            {
                Properties.Settings.Default.WinSCPVersion = 3;
                wsFtpRadioButton.Enabled = false;
                // FTP is not supported in WinSCP v3.x
                // so switch preference to SFTP
                if (wsFtpRadioButton.Checked == true)
                {
                    wsSftpRadioButton.Checked = true;
                    Properties.Settings.Default.WinSCPProtocol = (int)SessionController.Protocol.SFTP;
                }
            }
            else if (wsVer4RadioButton.Checked == true)
            {
                wsFtpRadioButton.Enabled = true;
                Properties.Settings.Default.WinSCPVersion = 4;
            }
        }

        /// <summary>
        /// Display the WinSCP file chooser
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void locateWinSCPButton_Click(object sender, EventArgs e)
        {
            setupOpenFileDialogue(FileDialogType.WINSCP);
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                winSCPTextBox.Text = openFileDialog.FileName;
            }
        }

        /// <summary>
        /// Display the WinSCP ini file chooser
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void locateWinSCPIniButton_Click(object sender, EventArgs e)
        {
            setupOpenFileDialogue(FileDialogType.WINSCPINI);
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                winSCPIniTextBox.Text = openFileDialog.FileName;
            }
        }

    }
}
