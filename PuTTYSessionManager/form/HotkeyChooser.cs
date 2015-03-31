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
using System.Text.RegularExpressions;


namespace uk.org.riseley.puttySessionManager.form
{
    public partial class HotkeyChooser : Form
    {
        private Form parentWindow;
        private SessionController sc;
        private HotkeyController hkc;

        // Setup dictionaries
        private Dictionary<HotkeyController.HotKeyId,ComboBox> comboDictionary;
        private Dictionary<HotkeyController.HotKeyId,TextBox>  textboxDictionary;
        private Dictionary<HotkeyController.HotKeyId,CheckBox> checkboxDictionary;

        private int currentModifierIndex = -1;

        private Boolean suspendHotkeyUpdate = false;

        public HotkeyChooser(Form parent)
        {
            parentWindow = parent;
            sc = SessionController.getInstance();
            hkc = HotkeyController.getInstance();
            InitializeComponent();
            createTags();
            createComboDictionary();
            createTextboxDictionary();
            createCheckboxDictionary();
            SessionController.SessionsRefreshedEventHandler scHandler = new SessionController.SessionsRefreshedEventHandler(this.SessionsRefreshed);
            sc.SessionsRefreshed += scHandler;
            EventHandler hkHandler = new EventHandler(setHotkeys);
            hkc.HotkeysRefreshed += hkHandler;
            resetState();
        }

        private void resetState()
        {
            intialiseTextboxes();
            setModifierLabels();
            updateModifier();
            resetDialogFont();
        }

        /// <summary>
        /// Tag the comboBoxes, checkboxes and textboxes with the session ids
        /// </summary>
        private void createTags()
        {
            comboBox1.Tag = HotkeyController.HotKeyId.HKID_SESSION_1;
            comboBox2.Tag = HotkeyController.HotKeyId.HKID_SESSION_2;
            comboBox3.Tag = HotkeyController.HotKeyId.HKID_SESSION_3;
            comboBox4.Tag = HotkeyController.HotKeyId.HKID_SESSION_4;
            comboBox5.Tag = HotkeyController.HotKeyId.HKID_SESSION_5;
            comboBox6.Tag = HotkeyController.HotKeyId.HKID_SESSION_6;
            comboBox7.Tag = HotkeyController.HotKeyId.HKID_SESSION_7;
            comboBox8.Tag = HotkeyController.HotKeyId.HKID_SESSION_8;
            comboBox9.Tag = HotkeyController.HotKeyId.HKID_SESSION_9;
            comboBox10.Tag = HotkeyController.HotKeyId.HKID_SESSION_10;

            checkBox1.Tag = HotkeyController.HotKeyId.HKID_SESSION_1;
            checkBox2.Tag = HotkeyController.HotKeyId.HKID_SESSION_2;
            checkBox3.Tag = HotkeyController.HotKeyId.HKID_SESSION_3;
            checkBox4.Tag = HotkeyController.HotKeyId.HKID_SESSION_4;
            checkBox5.Tag = HotkeyController.HotKeyId.HKID_SESSION_5;
            checkBox6.Tag = HotkeyController.HotKeyId.HKID_SESSION_6;
            checkBox7.Tag = HotkeyController.HotKeyId.HKID_SESSION_7;
            checkBox8.Tag = HotkeyController.HotKeyId.HKID_SESSION_8;
            checkBox9.Tag = HotkeyController.HotKeyId.HKID_SESSION_9;
            checkBox10.Tag = HotkeyController.HotKeyId.HKID_SESSION_10;
            newSessionHKCheckbox.Tag = HotkeyController.HotKeyId.HKID_NEW;
            minimizeWindowHKCheckbox.Tag = HotkeyController.HotKeyId.HKID_MINIMIZE;

            hk1TextBox.Tag = HotkeyController.HotKeyId.HKID_SESSION_1;
            hk2TextBox.Tag = HotkeyController.HotKeyId.HKID_SESSION_2;
            hk3TextBox.Tag = HotkeyController.HotKeyId.HKID_SESSION_3;
            hk4TextBox.Tag = HotkeyController.HotKeyId.HKID_SESSION_4;
            hk5TextBox.Tag = HotkeyController.HotKeyId.HKID_SESSION_5;
            hk6TextBox.Tag = HotkeyController.HotKeyId.HKID_SESSION_6;
            hk7TextBox.Tag = HotkeyController.HotKeyId.HKID_SESSION_7;
            hk8TextBox.Tag = HotkeyController.HotKeyId.HKID_SESSION_8;
            hk9TextBox.Tag = HotkeyController.HotKeyId.HKID_SESSION_9;
            hk10TextBox.Tag = HotkeyController.HotKeyId.HKID_SESSION_10;
            newSessionHKTextbox.Tag = HotkeyController.HotKeyId.HKID_NEW;
            minimizeWindowHKTextbox.Tag = HotkeyController.HotKeyId.HKID_MINIMIZE;
        }

        /// <summary>
        /// Create a dictionary of comboboxes to iterate over later on
        /// </summary>
        private void createComboDictionary()
        {
            comboDictionary = new Dictionary<HotkeyController.HotKeyId, ComboBox>();
            comboDictionary.Add((HotkeyController.HotKeyId)comboBox1.Tag, comboBox1);
            comboDictionary.Add((HotkeyController.HotKeyId)comboBox2.Tag, comboBox2);
            comboDictionary.Add((HotkeyController.HotKeyId)comboBox3.Tag, comboBox3);
            comboDictionary.Add((HotkeyController.HotKeyId)comboBox4.Tag, comboBox4);
            comboDictionary.Add((HotkeyController.HotKeyId)comboBox5.Tag, comboBox5);
            comboDictionary.Add((HotkeyController.HotKeyId)comboBox6.Tag, comboBox6);
            comboDictionary.Add((HotkeyController.HotKeyId)comboBox7.Tag, comboBox7);
            comboDictionary.Add((HotkeyController.HotKeyId)comboBox8.Tag, comboBox8);
            comboDictionary.Add((HotkeyController.HotKeyId)comboBox9.Tag, comboBox9);
            comboDictionary.Add((HotkeyController.HotKeyId)comboBox10.Tag, comboBox10);
        }

        /// <summary>
        /// Create a dictionary of textboxes to iterate over later on
        /// </summary>
        private void createTextboxDictionary()
        {
            textboxDictionary = new Dictionary<HotkeyController.HotKeyId, TextBox>();
            textboxDictionary.Add((HotkeyController.HotKeyId)hk1TextBox.Tag, hk1TextBox);
            textboxDictionary.Add((HotkeyController.HotKeyId)hk2TextBox.Tag, hk2TextBox);
            textboxDictionary.Add((HotkeyController.HotKeyId)hk3TextBox.Tag, hk3TextBox);
            textboxDictionary.Add((HotkeyController.HotKeyId)hk4TextBox.Tag, hk4TextBox);
            textboxDictionary.Add((HotkeyController.HotKeyId)hk5TextBox.Tag, hk5TextBox);
            textboxDictionary.Add((HotkeyController.HotKeyId)hk6TextBox.Tag, hk6TextBox);
            textboxDictionary.Add((HotkeyController.HotKeyId)hk7TextBox.Tag, hk7TextBox);
            textboxDictionary.Add((HotkeyController.HotKeyId)hk8TextBox.Tag, hk8TextBox);
            textboxDictionary.Add((HotkeyController.HotKeyId)hk9TextBox.Tag, hk9TextBox);
            textboxDictionary.Add((HotkeyController.HotKeyId)hk10TextBox.Tag, hk10TextBox);
            textboxDictionary.Add((HotkeyController.HotKeyId)minimizeWindowHKTextbox.Tag, minimizeWindowHKTextbox);
            textboxDictionary.Add((HotkeyController.HotKeyId)newSessionHKTextbox.Tag, newSessionHKTextbox);
        }

        /// <summary>
        /// Create a dictionary of checkboxes to iterate over later on
        /// </summary>
        private void createCheckboxDictionary()
        {
            checkboxDictionary = new Dictionary<HotkeyController.HotKeyId, CheckBox>();
            checkboxDictionary.Add((HotkeyController.HotKeyId)checkBox1.Tag, checkBox1);
            checkboxDictionary.Add((HotkeyController.HotKeyId)checkBox2.Tag, checkBox2);
            checkboxDictionary.Add((HotkeyController.HotKeyId)checkBox3.Tag, checkBox3);
            checkboxDictionary.Add((HotkeyController.HotKeyId)checkBox4.Tag, checkBox4);
            checkboxDictionary.Add((HotkeyController.HotKeyId)checkBox5.Tag, checkBox5);
            checkboxDictionary.Add((HotkeyController.HotKeyId)checkBox6.Tag, checkBox6);
            checkboxDictionary.Add((HotkeyController.HotKeyId)checkBox7.Tag, checkBox7);
            checkboxDictionary.Add((HotkeyController.HotKeyId)checkBox8.Tag, checkBox8);
            checkboxDictionary.Add((HotkeyController.HotKeyId)checkBox9.Tag, checkBox9);
            checkboxDictionary.Add((HotkeyController.HotKeyId)checkBox10.Tag, checkBox10);
            checkboxDictionary.Add((HotkeyController.HotKeyId)minimizeWindowHKCheckbox.Tag, minimizeWindowHKCheckbox);
            checkboxDictionary.Add((HotkeyController.HotKeyId)newSessionHKCheckbox.Tag, newSessionHKCheckbox);
        }

        /// <summary>
        /// Setup the textboxes with the saved values
        /// </summary>
        private void intialiseTextboxes()
        {
            foreach (TextBox t in textboxDictionary.Values)
            {
                t.Text = hkc.getHotKeyFromId((HotkeyController.HotKeyId)t.Tag);
            }

            modifierComboBox.BeginUpdate();
            modifierComboBox.Items.Clear();
            modifierComboBox.Items.AddRange(hkc.getAllModifiers());
            modifierComboBox.Text = hkc.getModifier().Description;
            currentModifierIndex = modifierComboBox.SelectedIndex;
            modifierComboBox.EndUpdate();
        }

        
        /// <summary>
        /// Load the selected value to the saved hotkey
        /// and load the combo boxes with the stored sessions
        /// and set the selected value to the saved hotkey
        /// </summary>
        /// <param name="reloadSessions"></param>
        private void setHotkeys(bool reloadSessions)
        {
            Session[] sa = null;
            ComboBox c;

            if ( reloadSessions )
                sa = sc.getSessionList().ToArray();

            // Suspend hotkey updates
            suspendHotkeyUpdate = true;

            foreach (HotkeyController.HotKeyId hkid in comboDictionary.Keys)
            {
                comboDictionary.TryGetValue(hkid, out c);
                if ( reloadSessions )
                    c.Items.AddRange(sa);
                c.SelectedItem = hkc.getSessionFromHotkey(hkid);
            }

            // Resume hotkey updates
            suspendHotkeyUpdate = false;

        }

        /// <summary>
        /// Event handler for the HotKeysRefreshed event
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        private void setHotkeys(object source , EventArgs e)
        {
            setHotkeys(false);
        }

        /// <summary>
        /// Clear each combo box
        /// </summary>
        private void clearLists()
        {
            foreach (ComboBox c in comboDictionary.Values)
            {
                c.Items.Clear();
            }
        }

        /// <summary>
        /// Event handler for the okButton Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void okButton_Click(object sender, EventArgs e)
        {
            foreach (CheckBox c in checkboxDictionary.Values)
            {
                if (c.Checked == false)
                {
                    TextBox t = null;
                    HotkeyController.HotKeyId hkid = (HotkeyController.HotKeyId)c.Tag;
                    textboxDictionary.TryGetValue(hkid, out t);
                    if (t != null)
                        t.Text = hkc.getHotKeyFromId(hkid);
                }
            }
            this.Hide();
            Properties.Settings.Default.Save();
        }

        private void hotkeyCheckbox_Click(object sender, EventArgs e)
        {
            // Get the checkbox that was clicked
            CheckBox cb = (CheckBox)sender;

            // Get the hotkey to adjust and the text box to query
            HotkeyController.HotKeyId hkid;
            TextBox tb = null;
            
            hkid = (HotkeyController.HotKeyId)cb.Tag;
            if (textboxDictionary.TryGetValue(hkid, out tb) == false)
            {
                // If we can't get the text box give up
                return;
            }

            // Unregister the hotkey if the box is unticked
            if (cb.Checked == false)
            {
                bool result = hkc.UnregisterHotKey(parentWindow, hkid);
                if (result == false)
                {
                    MessageBox.Show(this, "Failed to unregister hotkey"
                                   , "Warning"
                                   , MessageBoxButtons.OK
                                   , MessageBoxIcon.Warning);
                }
                tb.Text = hkc.getHotKeyFromId(hkid);
                hkc.refreshHotkeys();             
            }
            else
            {
                if ( tb.Text.Length != 1 ) {
                    MessageBox.Show(this, "Hotkey must be specified"
                                   , "Warning"
                                   , MessageBoxButtons.OK
                                   , MessageBoxIcon.Warning);
                    tb.Text = hkc.getHotKeyFromId(hkid);
                    cb.Checked = false;
                } 
                else 
                {
                    char newHotkey = tb.Text.ToCharArray(0,1)[0];
                    if (hkc.isHotkeyAvailable(newHotkey) == false)
                    {
                        string warningMessage = "Hotkey may not be duplicated";
                        if ( hkc.getModifier().ProtectedKeys.Length > 0 )
                        {
                            warningMessage = warningMessage + " or one of the system keys: "  + hkc.getModifier().ProtectedKeysDescription;
                        }
                        MessageBox.Show(this, warningMessage
                                       , "Warning"
                                       , MessageBoxButtons.OK
                                       , MessageBoxIcon.Warning);
                        tb.Text = hkc.getHotKeyFromId(hkid);
                        cb.Checked = false;
                    }
                    else
                    {
                        bool result = hkc.RegisterHotkey(parentWindow, newHotkey, hkid);
                        if (result == false)
                        {
                            MessageBox.Show(this, "Failed to register hotkey"
                                           , "Warning"
                                           , MessageBoxButtons.OK
                                           , MessageBoxIcon.Warning);
                            tb.Text = hkc.getHotKeyFromId(hkid);
                            cb.Checked = false;
                        }
                        else
                        {
                            tb.Text = hkc.getHotKeyFromId(hkid);

                            // Try to enable any associated combox box
                            ComboBox cmb = null;
                            comboDictionary.TryGetValue(hkid, out cmb);
                            if (cb != null)
                                cb.Enabled = true;

                            hkc.refreshHotkeys();
                        }
                    }
                }                
            }
        }

        public void SessionsRefreshed(Object sender, EventArgs e)
        {
            clearLists();
            setHotkeys(true);
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Do nothing if we have suspended updates
            if (suspendHotkeyUpdate == true)
                return;

            ComboBox c = (ComboBox)sender;
            Session s = (Session)c.SelectedItem;
            HotkeyController.HotKeyId hkid = (HotkeyController.HotKeyId)c.Tag;

            if (s == null || 
                Properties.Settings.Default.HotkeyFavouriteEnabled == false ||
                hkc.isSessionHotkeyEnabled(hkid) == false )
                return;

            hkc.saveSessionnameToHotkey(parentWindow, hkid, s);
        }

        private void favSessCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (favSessCheckBox.Checked == true)
            {
                foreach (HotkeyController.HotKeyId hkid in comboDictionary.Keys)
                {
                    if ( hkc.isSessionHotkeyEnabled(hkid) )
                        hkc.RegisterHotkey(parentWindow, hkid);
                }                
            }
            else
            {
                foreach (HotkeyController.HotKeyId hkid in comboDictionary.Keys)
                {
                    hkc.UnregisterHotKey(parentWindow, hkid);
                }                
            }
            hkc.setFavouriteSessionHotkeysEnabled(favSessCheckBox.Checked);
        }

        /// <summary>
        /// This method will clear the hotkey if the delete key 
        /// is pressed in the combo box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox_KeyUp(object sender, KeyEventArgs e)
        {
            ComboBox c = (ComboBox)sender;
            HotkeyController.HotKeyId hkid = (HotkeyController.HotKeyId)c.Tag;
            if (e.KeyCode == Keys.Delete)
            {
                c.SelectedItem = null;
                hkc.saveSessionnameToHotkey(parentWindow, hkid, null);
            }
        }

        /// <summary>
        /// Set all the modifier labels to be the current modifier text
        /// </summary>
        private void setModifierLabels()
        {
            String modifier = hkc.getModifier().Description;            
            hkLabel1.Text = modifier;
            hkLabel2.Text = modifier;
            hkLabel3.Text = modifier;
            hkLabel4.Text = modifier;
            hkLabel5.Text = modifier;
            hkLabel6.Text = modifier;
            hkLabel7.Text = modifier;
            hkLabel8.Text = modifier;
            hkLabel9.Text = modifier;
            hkLabel10.Text = modifier;
            newSessionHKLabel.Text = modifier;
            minimizeWindowHKLabel.Text = modifier;
        }

        private void modifierComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            HotkeyModifier modifier = (HotkeyModifier)modifierComboBox.SelectedItem;
            if (hkc.validateNewModifier(modifier) == false)
            {
                MessageBox.Show(this, "Your current hotkeys contain one or more protected keys for \n" +
                                      "the " + modifier.Description + " modifier: " + modifier.ProtectedKeysDescription + "\n" + 
                                      "Please disable or remove these hotkeys first."
               , "Warning"
               , MessageBoxButtons.OK
               , MessageBoxIcon.Warning);
                modifierComboBox.SelectedIndex = currentModifierIndex;
                return;
            }

            updateModifier();         
        }

        private void updateModifier()
        {
            hkc.setModifier((HotkeyModifier)modifierComboBox.SelectedItem);
            setModifierLabels();
            hkc.UnregisterAllHotKeys(parentWindow);
            hkc.registerAllEnabledHotkeys(parentWindow);
            currentModifierIndex = modifierComboBox.SelectedIndex;

            // Fire a refresh event
            hkc.refreshHotkeys();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            // Hide the form
            this.Hide();

            // Unregister the current hotkeys
            hkc.UnregisterAllHotKeys(parentWindow);

            // Reload all the settings
            Properties.Settings.Default.Reload();

            // Reset the state of the form
            resetState();
        }

        public void resetDialogFont()
        {
            Font = Properties.Settings.Default.DialogFont;
        }
    }
}