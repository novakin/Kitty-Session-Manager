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
using System.IO;
using uk.org.riseley.puttySessionManager.control.options;

namespace uk.org.riseley.puttySessionManager.form
{
    public partial class Options : Form
    {
        private Form parentWindow;

        private List<ResetableOptionsControl> optionsControls;

        /// <summary>
        /// Fired when the dialog font is changed
        /// </summary>
        public event System.EventHandler DialogFontChanged;

        public Options(Form parentWindow)
        {
            this.parentWindow = parentWindow;
            InitializeComponent();

            registerControls();
            resetState();
        }

        /// <summary>
        /// Register all the controls
        /// </summary>
        private void registerControls()
        {
            optionsControls = new List<ResetableOptionsControl>();
            optionsControls.Add(updateOptionsControl);
            optionsControls.Add(winSCPOptionsControl);
            optionsControls.Add(fileZillaOptionsControl);
            optionsControls.Add(pageantOptionsControl);
            optionsControls.Add(treeOptionsControl);
            optionsControls.Add(generalOptionsControl1);
            generalOptionsControl1.setParentWindow(parentWindow);
        }

        private void resetState()
        {
            foreach (ResetableOptionsControl control in optionsControls)
            {
                control.resetState();
            }
            Graphics graphics;
            graphics = this.CreateGraphics();
            if (graphics.DpiX != 96)
            {
                int newWidth =  (int)(this.Width * (graphics.DpiX / 90));
                int newHeight = (int)(this.Height * (graphics.DpiX / 90));
                this.MinimumSize = new System.Drawing.Size(newWidth, newHeight);
                this.MaximumSize = this.MaximumSize;
            }
            graphics.Dispose(); // don’t forget to release the unnecessary resources
            resetDialogFont();
        }

        /// <summary>
        /// Event handler for the okButton click event
        /// Save the modified settings
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void okButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
            this.Close();
        }

        /// <summary>
        /// Event handler for the cancelButton click event
        /// Hide the dialog , and reload the saved settings
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.SuspendLayout();
            Properties.Settings.Default.Reload();
            resetState();
            this.ResumeLayout();
            this.Close();
        }

        private void generalOptionsControl1_DialogFontChanged(object sender, EventArgs e)
        {
            resetDialogFont();            
            OnDialogFontChanged(new EventArgs());
        }

        private void resetDialogFont()
        {
            Font = Properties.Settings.Default.DialogFont;
            updateOptionsControl.resetDialogFont();
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