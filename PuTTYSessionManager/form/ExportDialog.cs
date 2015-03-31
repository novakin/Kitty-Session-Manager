/* 
 * Copyright (C) 2007 David Riseley 
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
using uk.org.riseley.puttySessionManager.model.eventargs;

namespace uk.org.riseley.puttySessionManager.form
{
    /// <summary>
    /// Dialog box to select the export type
    /// </summary>
    public partial class ExportDialog :  Form
    {
        /// <summary>
        /// 
        /// </summary>
        public ExportDialog()
        {
            InitializeComponent();
            resetDialogFont();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ExportSessionEventArgs.ExportType getExportType()
        {
            if (registryRadioButton.Checked)
                return ExportSessionEventArgs.ExportType.REG_TYPE;
            else if ( csvRadioButton.Checked )
                return ExportSessionEventArgs.ExportType.CSV_TYPE;
            else if ( clipRadioButton.Checked )
                return ExportSessionEventArgs.ExportType.CLIP_TYPE;
            else
                return ExportSessionEventArgs.ExportType.CSV_TYPE;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void okButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Hide();
        }

        public void resetDialogFont()
        {
            Font = Properties.Settings.Default.DialogFont;
        }
    }
}