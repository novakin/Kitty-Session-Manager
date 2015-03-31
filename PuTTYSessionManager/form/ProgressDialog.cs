/* 
 * Copyright (C) 2009 David Riseley 
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

namespace uk.org.riseley.puttySessionManager.form
{
    public partial class ProgressDialog
        : Form
    {
        public ProgressDialog()
        {
            InitializeComponent();
            resetDialogFont();
        }

        public void updateProgress ( string message, int progress )
        {
            if (progress < progressBar.Maximum)
            {
                okButton.Enabled = false;
            }
            else
            {
                okButton.Enabled = true;
            }
            messageLabel.Text = message;
            progressBar.Value = progress;
        }

        public void resetDialogFont()
        {
            Font = Properties.Settings.Default.DialogFont;
        }

        public void reset(int maxvalue)
        {
            progressBar.Maximum = maxvalue;
            messageLabel.Text = "Synchronized 0 out of " 
                                + progressBar.Maximum
                                + "sessions";
            okButton.Enabled = false;
            progressBar.Value = 0;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}