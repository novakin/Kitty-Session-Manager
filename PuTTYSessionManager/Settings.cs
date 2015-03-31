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
namespace uk.org.riseley.puttySessionManager.Properties
{
    //  This class allows you to handle specific events on the settings class:
    //  The SettingChanging event is raised before a setting's value is changed.
    //  The PropertyChanged event is raised after a setting's value is changed.
    //  The SettingsLoaded event is raised after the setting values are loaded.
    //  The SettingsSaving event is raised before the setting values are saved.
    internal sealed partial class Settings
    {
        private bool settingsChanged = false;

        public Settings()
        {
            // To add event handlers for saving and changing settings, uncomment the lines below:
            this.SettingChanging += this.SettingChangingEventHandler;
            
            this.PropertyChanged += this.PropertyChangedEventHandler;

            this.SettingsSaving += this.SettingsSavingEventHandler;
        }

        private void SettingChangingEventHandler(object sender, System.Configuration.SettingChangingEventArgs e)
        {
            if (e.SettingName.Equals("TransparencyValueInt"))
            {
                TransparencyValueDouble = this.TransparencyValueInt / 100.0;
            }
            else if (e.SettingName.Equals("TransparencyEnabled"))
            {
                if ((bool)e.NewValue == false )
                {
                    TransparencyValueDouble = 1.00;
                }
                else
                {
                    TransparencyValueDouble = this.TransparencyValueInt / 100.0;                    
                }
            }
            else if (e.SettingName.Equals("WindowSize"))
            {
                System.Drawing.Size sz = (System.Drawing.Size)e.NewValue;
                if (sz.Height == 0 && sz.Width == 0)
                    e.Cancel = true;
            }
        }

        private void SettingsSavingEventHandler(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // Cancel the save request if nothing has changed
            if (settingsChanged == false)
                e.Cancel = true;
            else
                settingsChanged = false;
        }

        private void PropertyChangedEventHandler(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            // Record the fact that the settings have changed
            settingsChanged = true;
        }
    }
}
