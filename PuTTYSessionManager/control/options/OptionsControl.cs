/* 
 * Copyright (C) 2008,2009 David Riseley 
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
using System.IO;

namespace uk.org.riseley.puttySessionManager.control.options
{
    public partial class OptionsControl : UserControl
    {
        protected enum FileDialogType { PUTTY, Kageant, Kageant_KEYS, FILEZILLA, WINSCP, WINSCPINI, CSV };

        public OptionsControl()
        {
            InitializeComponent();
        }

        protected void setupOpenFileDialogue(FileDialogType fdt)
        {
            setupOpenFileDialogue(fdt, "");
        }

        protected void setupOpenFileDialogue(FileDialogType fdt, string lastknownfile)
        {
            String filename = "";
            String fileFilter = "";
            String currentFile = "";
            const String allFilesFilter = "|All Files|*.*";
            switch (fdt)
            {
                case FileDialogType.PUTTY:
                    filename = "kitty.exe";
                    currentFile = Properties.Settings.Default.PuttyLocation;
                    break;
                case FileDialogType.Kageant:
                    filename = "kageant.exe";
                    currentFile = Properties.Settings.Default.KageantLocation;
                    break;
                case FileDialogType.Kageant_KEYS:
                    filename = "*.ppk";
                    break;
                case FileDialogType.FILEZILLA:
                    filename = "FileZilla.exe";
                    currentFile = Properties.Settings.Default.FileZillaLocation;
                    break;
                case FileDialogType.WINSCP:
                    filename = "WinSCP*.exe";
                    currentFile = Properties.Settings.Default.WinSCPLocation;
                    break;
                case FileDialogType.WINSCPINI:
                    filename = "*.ini";
                    currentFile = Properties.Settings.Default.WinSCPIniLocation;
                    break;
                case FileDialogType.CSV:
                    filename = "*.csv";
                    currentFile = Properties.Settings.Default.WinSCPIniLocation;
                    break;
            }

            // Override the default current file if we have supplied 
            // an existing file
            if (lastknownfile != null && !lastknownfile.Equals(""))
                currentFile = lastknownfile;

            // Attempt to set the working directory
            string directory = "";
            if (currentFile != null && !currentFile.Equals(""))
                directory = Path.GetFullPath(currentFile);
            if (File.Exists(directory))
                openFileDialog.InitialDirectory = directory;

            // And the filename
            openFileDialog.FileName = filename;

            // And the file filter
            fileFilter = filename + "|" + filename + allFilesFilter;
            openFileDialog.Filter = fileFilter;
        }

        private void optionsToolTip_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
