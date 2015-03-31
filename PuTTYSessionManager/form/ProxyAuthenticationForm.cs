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
using System.Net;

namespace uk.org.riseley.puttySessionManager.form
{
    /// <summary>
    /// Form to collect the proxy username and password 
    /// for update functionality
    /// </summary>
    public partial class ProxyAuthenticationForm : Form
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public ProxyAuthenticationForm()
        {
            InitializeComponent();
            resetDialogFont();
        }

        /// <summary>
        /// Set the proxy realm to be displayed on the form
        /// </summary>
        /// <param name="realm"></param>
        public void setRealm(string realm)
        {
            realmLabel.Text = realm;
        }

        /// <summary>
        /// Get the network credential that has been specified
        /// </summary>
        /// <returns></returns>
        public NetworkCredential getCredentials()
        {
            return new NetworkCredential(usernameTextBox.Text, passwordTextBox.Text);
        }

        public void resetDialogFont()
        {
            Font = Properties.Settings.Default.DialogFont;
        }
    }
}