/* 
 * Copyright (C) 2006,2007,2008 David Riseley 
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
using System.Windows.Forms;
using uk.org.riseley.puttySessionManager.form;
using System.Configuration;
using System.IO;
using Microsoft.Win32;

namespace uk.org.riseley.puttySessionManager
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Use the SingleInstanceManager to ensure that only one instance
            // of PSM can be launched
            using (SingleInstanceManager sim = new SingleInstanceManager())
            {
                // If there is already one running, request the process
                // to come to the foreground
                if (sim.EventAlreadyExists())
                {
                    sim.SignalEvent();
                }
                else
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);

                    // Instantiate the application context
                    PsmApplicationContext appContext = new PsmApplicationContext();

                    // Only start the application if the intialisation succeeds
                    if (appContext.initialise())
                    {
                        // Set the callback for displaying the main window
                        sim.setObject(appContext.getSmf(), appContext.getSmf().showApplication); 
                        // Start the main event loop
                        Application.Run(appContext);

                        // Make sure all threads exit after the end of the Run method
                        Environment.Exit(0);
                    }
                }
            }
        }
    }

    /// <summary>
    /// Application context class to handle the application lifecycle
    /// for PSM
    /// </summary>
    class PsmApplicationContext : ApplicationContext
    {
        /// <summary>
        /// The single SessionManagerForm instance
        /// </summary>
        private SessionManagerForm smf;

        /// <summary>
        /// Constructor for the PsmApplicationContext
        /// </summary>
        public PsmApplicationContext()
        {
        }

        /// <summary>
        /// Get a handle to the SessionManagerForm
        /// </summary>
        /// <returns></returns>
        public SessionManagerForm getSmf()
        {
            return smf;
        }

        /// <summary>
        /// Initialise the application
        /// </summary>
        /// <returns>true if initialisation succeeds</returns>
        public bool initialise()
        {
            // Upgrade settings
            if (upgradeSettings())
            {
                // Handle the ApplicationExit event to know when the application is exiting.
                Application.ApplicationExit += new EventHandler(OnApplicationExit);

                // Attempt to handle session ending ( logoff / shutdown ) events
                SystemEvents.SessionEnding += new SessionEndingEventHandler(OnSessionEnding);

                // Attempt to handle session ended ( logoff / shutdown ) events
                SystemEvents.SessionEnded += new SessionEndedEventHandler(OnSessionEnded);

                // Instantiate the SessionManagerForm           
                smf = new SessionManagerForm();

                // Perform startup actions
                smf.doStartupActions();

                // Only make the form visible if the required
                smf.Visible = !(Properties.Settings.Default.MinimizeOnStart);

                return true;
            }
            return false;
        }

        /// <summary>
        /// Attempt to upgrade settings.
        /// If the user.config file is corrupted, we will
        /// detect it here.  Attempt to recover from this
        /// </summary>
        /// <returns>false if the user.config file corrupted</returns>
        private bool upgradeSettings()
        {
            bool result = true;

            // Upgrade settings from a previous release
            try
            {
                if (Properties.Settings.Default.UpgradeRequired == true)
                {
                    Properties.Settings.Default.Upgrade();
                    Properties.Settings.Default.UpgradeRequired = false;
                    Properties.Settings.Default.Save();
                }
            }
            catch (ConfigurationErrorsException ce)
            {
                // Something has gone wrong with the user.config file
                string fileName = ce.Filename;
                if (string.IsNullOrEmpty(fileName))
                {
                    if (ce.InnerException is ConfigurationErrorsException)
                    {
                        fileName = ((ConfigurationErrorsException)ce.InnerException).Filename;
                    }
                }
                if (File.Exists(fileName))
                {
                    if (MessageBox.Show("Your preferences stored at:\n" + fileName + "\n" +
                                    "are corrupt. Do you want to delete and recreate them?"
                                   , "ERROR", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                    {
                        System.IO.File.Delete(fileName);
                        MessageBox.Show("File deleted.\n" +
                                        "Please restart KiTTY Session Manager"
                                        , "ABORT", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        MessageBox.Show("Please correct this manually.\nThe application will now exit"
                                        , "ABORT", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    result = false;
                }
            }
            return result;
        }

        /// <summary>
        /// Attempt to save settings
        /// If something goes wrong - it's too late,
        /// we only call this when we are exiting the app
        /// </summary>
        private void saveSettings()
        {
            try
            {
                Properties.Settings.Default.Save();
            }
            catch (Exception)
            {
                // Do nothing!
            }
        }

        /// <summary>
        /// Event handler for the application exit event
        /// Attempt to save the settings
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnApplicationExit(object sender, EventArgs e)
        {
            saveSettings();
        }

        /// <summary>
        /// Event handler for the SessionEnding event
        /// Attempt to save the settings
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnSessionEnding(object sender, SessionEndingEventArgs e)
        {
            smf.Exit();
            saveSettings();
        }

        /// <summary>
        /// Event handler for the SessionEnded event
        /// Attempt to save the settings
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnSessionEnded(object sender, SessionEndedEventArgs e)
        {
            smf.Exit();
            saveSettings();
        }
    }

}