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
using uk.org.riseley.puttySessionManager.form;
using uk.org.riseley.puttySessionManager.controller;

namespace uk.org.riseley.puttySessionManager.control.options
{
    public partial class UpdateOptionsControl : OptionsControl, ResetableOptionsControl
    {
        private UpdateForm uf;

        public UpdateOptionsControl()
        {
            InitializeComponent();

            // Create the update form
            uf = new UpdateForm();

            // Reset all the elements to their saved state
            resetState();
        }

        public void resetState()
        {
            // Check if the update url is changed
            if (!urlTextBox.Text.Equals(Properties.Settings.Default.DefaultUpdateUrl))
                urlCheckBox.Checked = false;
            else
                urlCheckBox.Checked = true;

            // Reset the proxy mode button to the saved pref
            SessionController.ProxyMode pm = (SessionController.ProxyMode)Properties.Settings.Default.ProxyMode;
            if (pm == SessionController.ProxyMode.PROXY_IE)
            {
                ieProxyRadioButton.Checked = true;
            }
            else if (pm == SessionController.ProxyMode.PROXY_NONE)
            {
                directRadioButton.Checked = true;
            }
            else if (pm == SessionController.ProxyMode.PROXY_USER)
            {
                userProxyRadioButton.Checked = true;
            }
            proxyServerTextBox.ReadOnly = !userProxyRadioButton.Checked;
            proxyPortTextBox.ReadOnly = !userProxyRadioButton.Checked;
        }

        private void urlCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            urlTextBox.ReadOnly = urlCheckBox.Checked;
            if (urlCheckBox.Checked == true)
                urlTextBox.Text = Properties.Settings.Default.DefaultUpdateUrl;
        }

        private void checkForUpdateButton_Click(object sender, EventArgs e)
        {
            uf.ShowDialog();
        }

        private void proxyRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (ieProxyRadioButton.Checked == true)
            {
                Properties.Settings.Default.ProxyMode = (int)SessionController.ProxyMode.PROXY_IE;
            }
            else if (directRadioButton.Checked == true)
            {
                Properties.Settings.Default.ProxyMode = (int)SessionController.ProxyMode.PROXY_NONE;
            }
            else if (userProxyRadioButton.Checked == true)
            {
                Properties.Settings.Default.ProxyMode = (int)SessionController.ProxyMode.PROXY_USER;
            }
            proxyServerTextBox.ReadOnly = !userProxyRadioButton.Checked;
            proxyPortTextBox.ReadOnly = !userProxyRadioButton.Checked;
        }

        public void resetDialogFont()
        {
            uf.resetDialogFont();
        }
    }
}
