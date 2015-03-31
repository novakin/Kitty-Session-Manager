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
using System.Text;
using uk.org.riseley.puttySessionManager.model;
using Microsoft.Win32;
using System.IO;
using System.Security.Permissions;

[assembly: RegistryPermissionAttribute(SecurityAction.RequestMinimum,
 ViewAndModify = uk.org.riseley.puttySessionManager.controller.RegistrySessionStorageImpl.PUTTY_SESSIONS_REG_KEY)]

namespace uk.org.riseley.puttySessionManager.controller
{

    /// <summary>
    /// 
    /// </summary>
    class RegistrySessionStorageImpl : SessionAttributesInterface, ISessionStorage, ISessionExport
    {

        /// <summary>
        /// The registry value which stores the Session folder
        /// </summary>
        private const string PUTTY_PSM_FOLDER_ATTRIB = "PsmPath";

        /// <summary>
        /// The hostname registry value
        /// </summary>
        private const string PUTTY_HOSTNAME_ATTRIB = "HostName";

        /// <summary>
        /// The default username registry value
        /// </summary>
        private const string PUTTY_USERNAME_ATTRIB = "UserName";

        /// <summary>
        /// The registry key ( relative to HKCU ) that stores PuTTY sessions
        /// </summary>
        public const string PUTTY_SESSIONS_REG_KEY = "Software\\9bis.com\\KiTTY\\Sessions";

        /// <summary>
        /// The file type for this provider
        /// </summary>
        private const string EXPORT_FILE_TYPE = "reg";

        /// <summary>
        /// The file description for this provider
        /// </summary>
        private const string EXPORT_FILE_DESCRIPTION = "Registry File";

        /// <summary>
        /// The registry key of the "Default Session"
        /// </summary>
        private const string PUTTY_DEFAULT_SESSION = "Default%20Settings";

        private List<string> attribColours = new List<string>();
        private List<string> attribDefaultUsername = new List<string>();
        private List<string> attribFont = new List<string>();
        private List<string> attribHostName = new List<string>();
        private List<string> attribKeepAlives = new List<string>();
        private List<string> attribProtocolPort = new List<string>();
        private List<string> attribScrollback = new List<string>();
        private List<string> attribSelectionChars = new List<string>();
        private List<string> attribSessionFolder = new List<string>();
        private List<string> attribSshPortForwards = new List<string>();

        private Dictionary<SessionAttributes.AttribGroups, List<string>> dictAllAttribGroups; 


        /// <summary>
        /// Default constructor
        /// </summary>
        public RegistrySessionStorageImpl()
        {
            initialiseLists();
        }

        #region SessionStorageInterface Members

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Session> getSessionList()
        {
            List<Session> sl = new List<Session>();

            RegistryKey rk = Registry.CurrentUser.OpenSubKey(PUTTY_SESSIONS_REG_KEY);

            // Check we have some sessions
            if (rk == null)
                return sl;

            foreach (string keyName in rk.GetSubKeyNames())
            {
                RegistryKey sessKey = rk.OpenSubKey(keyName);

                // Exclude keys that have no values in them
                if (sessKey.ValueCount > 0)
                {
                    string psmpath = (string)sessKey.GetValue(PUTTY_PSM_FOLDER_ATTRIB);
                    Session s = new Session(keyName, psmpath, false);

                    // Get all the values from the registry that we are interested in
                    s.Hostname = (string)sessKey.GetValue(PUTTY_HOSTNAME_ATTRIB);
                    s.Username = (string)sessKey.GetValue(PUTTY_USERNAME_ATTRIB);
                    s.Protocol = (string)sessKey.GetValue("Protocol");
                    s.Portforwards = (string)sessKey.GetValue("PortForwardings");
                    s.Remotecommand = (string)sessKey.GetValue("RemoteCommand");
                    
                    // Setup the portnumber 
                    object portnumberObject = sessKey.GetValue("PortNumber");
                    int portnumber = -1;
                    // Only attempt to cast to an int if the object is not null
                    if (portnumberObject != null)
                    {
                        try
                        {
                            portnumber = (int)portnumberObject;
                        }
                        catch
                        {                         
                            portnumber = -1;
                        }
                    }
                    s.Portnumber = portnumber;

                    s.setToolTip();

                    sl.Add(s);
                }
                sessKey.Close();
            }
            rk.Close();
            sl.Sort();

            return sl;
        }

        /// <summary>
        /// Get a list of attribute names
        /// </summary>
        /// <param name="s">The session to get attribs for</param>
        /// <returns>The list of attributes</returns>
        public List<string> getSessionAttributes(Session s)
        {
            RegistryKey rk = Registry.CurrentUser.OpenSubKey(PUTTY_SESSIONS_REG_KEY + "\\" + s.SessionKey);
            List<string> attributes = new List<string>();
            if (rk != null)
            {
                attributes.AddRange(rk.GetValueNames());
                attributes.Sort();
                rk.Close();
            }
            return attributes;
        }

        /// <summary>
        /// Save the session folder to the registry
        /// </summary>
        /// <param name="s"></param>
        public bool updateFolder(Session s)
        {
            bool result = false;
            RegistryKey rk = Registry.CurrentUser.OpenSubKey(PUTTY_SESSIONS_REG_KEY + "\\" + s.SessionKey, true);
            if (rk != null)
            {
                rk.SetValue(PUTTY_PSM_FOLDER_ATTRIB, s.FolderName, RegistryValueKind.String);
                rk.Close();
                result = true;
            }
            return result;
        }

        /// <summary>
        /// Create a new session based on an old session
        /// </summary>
        /// <param name="nsr">The new session request</param>
        /// <returns></returns>
        public bool createNewSession(NewSessionRequest nsr)
        {
            // Check the template session is still there
            RegistryKey template = Registry.CurrentUser.OpenSubKey(PUTTY_SESSIONS_REG_KEY + "\\" + nsr.SessionTemplate.SessionKey, false);
            if (template == null)
                return false;

            // Check no-one has created a new session with the same name
            RegistryKey newSession = Registry.CurrentUser.OpenSubKey(PUTTY_SESSIONS_REG_KEY + "\\" + nsr.SessionName, false);
            if (newSession != null)
            {
                newSession.Close();
                return false;
            }

            // Create the new session 
            newSession = Registry.CurrentUser.CreateSubKey(PUTTY_SESSIONS_REG_KEY + "\\" + Session.convertDisplayToSessionKey(nsr.SessionName));

            // Copy the values
            bool hostnameSet = false;
            bool foldernameSet = false;

            object value;
            foreach (string valueName in template.GetValueNames())
            {

                if (valueName.Equals(PUTTY_HOSTNAME_ATTRIB))
                {
                    hostnameSet = true;
                    value = nsr.Hostname;
                }
                else if (valueName.Equals(PUTTY_PSM_FOLDER_ATTRIB))
                {
                    foldernameSet = true;
                    value = nsr.SessionFolder;
                }
                else if (nsr.CopyDefaultUsername == false &&
                            valueName.Equals(PUTTY_USERNAME_ATTRIB))
                {
                    value = "";
                }
                else
                {
                    value = template.GetValue(valueName);
                }

                newSession.SetValue(valueName, value, template.GetValueKind(valueName));
            }

            // Set the hostname if it hasn't already been set
            if (hostnameSet == false)
                newSession.SetValue(PUTTY_HOSTNAME_ATTRIB, nsr.Hostname, RegistryValueKind.String);

            // Set the foldername if it hasn't already been set
            if (foldernameSet == false)
                newSession.SetValue(PUTTY_PSM_FOLDER_ATTRIB, nsr.SessionFolder, RegistryValueKind.String);

            template.Close();
            newSession.Close();

            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sl"></param>
        /// <returns></returns>
        public bool deleteSessions(List<Session> sl)
        {
            // Check all the sessions still exist
            RegistryKey rk;
            foreach (Session s in sl)
            {
                rk = Registry.CurrentUser.OpenSubKey(PUTTY_SESSIONS_REG_KEY + "\\" + s.SessionKey);
                if (rk == null)
                    return false;
                rk.Close();
            }

            // Delete the sessions
            foreach (Session s in sl)
            {
                Registry.CurrentUser.DeleteSubKey(PUTTY_SESSIONS_REG_KEY + "\\" + s.SessionKey, false);
            }

            return true;
        }

        /// <summary>
        /// Rename the session.
        /// </summary>
        /// <param name="s">The session to rename</param>
        /// <param name="newSessionName">The new session display name</param>
        /// <returns>true if sucessful, false otherwise</returns>
        public bool renameSession(Session s, string newSessionName)
        {
            string newSessionKey = Session.convertDisplayToSessionKey(newSessionName);

            // Check the old session isn't the default session
            if (s.SessionKey.Equals(PUTTY_DEFAULT_SESSION))
                return false;

            // Check the current session is still there
            RegistryKey current = Registry.CurrentUser.OpenSubKey(PUTTY_SESSIONS_REG_KEY + "\\" + s.SessionKey, false);
            if (current == null)
                return false;

            // Check no-one has created a new session with the same name
            RegistryKey newSession = Registry.CurrentUser.OpenSubKey(PUTTY_SESSIONS_REG_KEY + "\\" + newSessionKey, false);
            if (newSession != null)
            {
                current.Close();
                newSession.Close();
                return false;
            }

            // Create the new session
            newSession = Registry.CurrentUser.CreateSubKey(PUTTY_SESSIONS_REG_KEY + "\\" + newSessionKey);
            if (newSession == null)
            {
                current.Close();
                return false;
            }

            // Copy all the attributes
            object value;
            foreach (string valueName in current.GetValueNames())
            {
                value = current.GetValue(valueName);
                newSession.SetValue(valueName, value, current.GetValueKind(valueName));
            }

            // Close the new session
            newSession.Close();

            // Close the current session;
            current.Close();

            // Delete the current session
            Registry.CurrentUser.DeleteSubKey(PUTTY_SESSIONS_REG_KEY + "\\" + s.SessionKey);

            return true;
        }

        /// <summary>
        /// Copy the specified attributes from a template session
        /// to a list of target sessions
        /// </summary>
        /// <param name="csr">The copy session request</param>
        /// <returns>true if sucessful, false otherwise</returns>
        public bool copySessionAttributes(CopySessionRequest csr)
        {
            // Check the template session is still there
            RegistryKey template = Registry.CurrentUser.OpenSubKey(PUTTY_SESSIONS_REG_KEY + "\\" + csr.SessionTemplate.SessionKey, false);
            if (template == null)
                return false;

            // Check all the target sessions still exist
            foreach (Session s in csr.TargetSessions)
            {
                RegistryKey targetSession = Registry.CurrentUser.OpenSubKey(PUTTY_SESSIONS_REG_KEY + "\\" + s.SessionKey, false);
                if (targetSession == null)
                {
                    template.Close();
                    return false;
                }
                else
                {
                    targetSession.Close();
                }
            }

            // Copy all the attributes
            foreach (Session s in csr.TargetSessions)
            {
                RegistryKey targetSession = Registry.CurrentUser.OpenSubKey(PUTTY_SESSIONS_REG_KEY + "\\" + s.SessionKey, true);
                object value;
                bool copy;
                foreach (string valueName in template.GetValueNames())
                {
                    copy = false;
                    // Never copy the hostname onto the default session
                    if (s.SessionKey.Equals(PUTTY_DEFAULT_SESSION) &&
                        valueName.Equals(PUTTY_HOSTNAME_ATTRIB))
                        copy = false;
                    else if ((csr.CopyOptions == CopySessionRequest.CopySessionOptions.COPY_ALL) &&
                         !(valueName.Equals(PUTTY_HOSTNAME_ATTRIB)) &&
                         !(valueName.Equals(PUTTY_PSM_FOLDER_ATTRIB))
                        )
                        copy = true;
                    else if ((csr.CopyOptions == CopySessionRequest.CopySessionOptions.COPY_EXCLUDE) &&
                         !(valueName.Equals(PUTTY_HOSTNAME_ATTRIB)) &&
                         !(valueName.Equals(PUTTY_PSM_FOLDER_ATTRIB)) &&
                         !(csr.SelectedAttributes.Contains(valueName)))
                        copy = true;
                    else if (csr.CopyOptions == CopySessionRequest.CopySessionOptions.COPY_INCLUDE)
                        copy = csr.SelectedAttributes.Contains(valueName);

                    if (copy == true)
                    {
                        value = template.GetValue(valueName);
                        targetSession.SetValue(valueName, value, template.GetValueKind(valueName));
                    }
                }
                targetSession.Close();

            }

            // Close the template session;
            template.Close();

            return true;
        }

        /// <summary>
        /// Create a backup of the sessions in this providers type
        /// delegates to saveSessionsToFile
        /// </summary>
        /// <param name="sessionList">The list of sessions to store</param>
        /// <param name="fileName">The file name to store the backup in </param>
        /// <returns>Count of backed up sessions</returns>
        public int backupSessionsToFile(List<Session> sessionList, string fileName)
        {
            return saveSessionsToFile(sessionList, fileName);
        }


        /// <summary>
        /// Update the session hostname
        /// </summary>
        /// <param name="s"></param>
        public bool updateHostname(Session s)
        {
            bool result = false;
            RegistryKey rk = Registry.CurrentUser.OpenSubKey(PUTTY_SESSIONS_REG_KEY + "\\" + s.SessionKey, true);

            if (rk != null)
            {
                rk.SetValue(PUTTY_HOSTNAME_ATTRIB, s.Hostname, RegistryValueKind.String);
                rk.Close();
                result = true;
            }

            return result;
        }


        #endregion     
    
        #region SessionExportInterface Members

        /// <summary>
        /// Get a description for the file type
        /// </summary>
        /// <returns></returns>
        public string getFileTypeDescription()
        {
            return EXPORT_FILE_DESCRIPTION;
        }

        /// <summary>
        /// Get the file extension
        /// </summary>
        /// <returns></returns>
        public string getFileTypeExtension()
        {
            return EXPORT_FILE_TYPE;
        }

        /// <summary>
        /// Create an export of the sessions in this providers type
        /// This may throw an exception if there are File I/O issues
        /// </summary>
        /// <param name="sessionList">The list of sessions to store</param>
        /// <param name="fileName">The file name to store the backup in </param>
        /// <returns>Count of exported sessions</returns>
        public int saveSessionsToFile(List<Session> sessionList, string fileName)
        {
            int savedCount = 0;
            if (sessionList.Count == 0)
                return 0;

            using (StreamWriter sw = File.CreateText(fileName))
            {
                writeSessionExportHeader(sw);
                foreach (Session s in sessionList)
                {
                    if (saveSession(s, sw))
                        savedCount++;
                }
                sw.Close();
            }
            return savedCount;
        }

        #endregion

        #region SessionAttributesInterface Members

        /// <summary>
        /// Get a list for attribute names for the group
        /// </summary>
        /// <param name="group">The attribute group to find</param>
        /// <returns>The list of attributes</returns>
        public List<string> getAttributeGroup(SessionAttributes.AttribGroups group)
        {
            List<string> attribList;
            dictAllAttribGroups.TryGetValue(group, out attribList);
            return attribList;
        }

        /// <summary>
        /// Gets special attributes.
        /// </summary>
        /// <param name="attrib">The attribute to find</param>
        /// <returns>The attribute name</returns>
        public string getSpecialAttribute(SessionAttributes.SpecialAttributes attrib)
        {
            switch (attrib)
            {
                case SessionAttributes.SpecialAttributes.FOLDER:
                    return PUTTY_PSM_FOLDER_ATTRIB;
                case SessionAttributes.SpecialAttributes.HOSTNAME:
                    return PUTTY_HOSTNAME_ATTRIB;
                case SessionAttributes.SpecialAttributes.USERNAME:
                    return PUTTY_USERNAME_ATTRIB;
            }
            return "";
        }

        #endregion

        /// <summary>
        /// Write the file header to the stream
        /// </summary>
        /// <param name="sw"></param>
        private void writeSessionExportHeader(StreamWriter sw)
        {
            sw.WriteLine("Windows Registry Editor Version 5.00");
            sw.WriteLine();
            sw.WriteLine("[" + Registry.CurrentUser.Name + "\\" + PUTTY_SESSIONS_REG_KEY + "]");
            sw.WriteLine();
        }

        /// <summary>
        /// Save a single session to the stream
        /// </summary>
        /// <param name="s">The session to save</param>
        /// <param name="sw"></param>
        /// <returns>true if sucessful, false otherwise</returns>
        private bool saveSession(Session s, StreamWriter sw)
        {
            RegistryKey rk = Registry.CurrentUser.OpenSubKey(PUTTY_SESSIONS_REG_KEY + "\\" + s.SessionKey);
            if (rk != null)
                sw.WriteLine("[" + Registry.CurrentUser.Name + "\\" + PUTTY_SESSIONS_REG_KEY + "\\" + s.SessionKey + "]");
            else
                return false;
            foreach (string valueName in rk.GetValueNames())
            {
                RegistryValueKind valueKind = rk.GetValueKind(valueName);
                if (valueKind.Equals(RegistryValueKind.String))
                {
                    sw.WriteLine("\"" + valueName + "\"=\"" + rk.GetValue(valueName).ToString().Replace("\\", "\\\\") + "\"");
                }
                else if (valueKind.Equals(RegistryValueKind.DWord))
                {
                    Object o = rk.GetValue(valueName);
                    string hex = ((int)o).ToString("x8");
                    sw.WriteLine("\"" + valueName + "\"=dword:" + hex);
                }

            }
            sw.WriteLine();
            rk.Close();
            return true;
        }

        /// <summary>
        /// Setup the lists of attributes
        /// </summary>
        private void initialiseLists()
        {
            dictAllAttribGroups = new Dictionary<SessionAttributes.AttribGroups, List<string>>();

            initialiseColours();
            initialiseDefaultUsername();
            initialiseFont();
            initialiseHostName();
            initialiseKeepAlives();
            initialiseProtocolPort();
            initialiseScrollback();
            initialiseSelectionChars();
            initialiseSessionFolder();
            initialiseSshPortForwards();

            // Consolidate the attributes
            initialiseDictionary();
        }

        /// <summary>
        /// Setup the colours list
        /// </summary>
        private void initialiseColours()
        {
            for (int i = 0; i <= 21; i++)
            {
                attribColours.Add("Colour" + i);
            }
        }

        /// <summary>
        /// Setup the username
        /// </summary>
        private void initialiseDefaultUsername()
        {
            attribDefaultUsername.Add(getSpecialAttribute(SessionAttributes.SpecialAttributes.USERNAME));
        }

        /// <summary>
        /// Setup the font list 
        /// </summary>
        private void initialiseFont()
        {
            attribFont.Add("Font");
            attribFont.Add("FontCharSet");
            attribFont.Add("FontHeight");
            attribFont.Add("FontIsBold");
            attribFont.Add("FontVTMode");
            attribFont.Add("WideBoldFont");
            attribFont.Add("WideBoldFontCharSet");
            attribFont.Add("WideBoldFontHeight");
            attribFont.Add("WideBoldFontIsBold");
            attribFont.Add("BoldFont");
            attribFont.Add("BoldFontCharSet");
            attribFont.Add("BoldFontHeight");
            attribFont.Add("BoldFontIsBold");
        }

        /// <summary>
        /// Setup the hostname
        /// </summary>
        private void initialiseHostName()
        {
            attribHostName.Add(getSpecialAttribute(SessionAttributes.SpecialAttributes.HOSTNAME));
        }

        /// <summary>
        /// Setup the keep alives
        /// </summary>
        private void initialiseKeepAlives()
        {
            attribKeepAlives.Add("PingInterval");
            attribKeepAlives.Add("PingIntervalSecs");
        }

        /// <summary>
        /// Setup the Protocol and port attributes
        /// </summary>
        private void initialiseProtocolPort()
        {
            attribProtocolPort.Add("Protocol");
            attribProtocolPort.Add("PortNumber");
        }

        /// <summary>
        /// Setup the scrollback attributes
        /// </summary>
        private void initialiseScrollback()
        {
            attribScrollback.Add("ScrollbackLines");
            attribScrollback.Add("ScrollBar");
            attribScrollback.Add("ScrollBarFullScreen");
            attribScrollback.Add("ScrollbarOnLeft");
            attribScrollback.Add("ScrollOnDisp");
            attribScrollback.Add("ScrollOnKey");
        }

        /// <summary>
        /// Setup the selection characters attributes
        /// </summary>
        private void initialiseSelectionChars()
        {
            attribSelectionChars.Add("Wordness0");
            attribSelectionChars.Add("Wordness32");
            attribSelectionChars.Add("Wordness64");
            attribSelectionChars.Add("Wordness96");
            attribSelectionChars.Add("Wordness128");
            attribSelectionChars.Add("Wordness160");
            attribSelectionChars.Add("Wordness192");
            attribSelectionChars.Add("Wordness224");
        }

        /// <summary>
        /// Setup the folder attribute
        /// </summary>
        private void initialiseSessionFolder()
        {
            attribSessionFolder.Add(getSpecialAttribute(SessionAttributes.SpecialAttributes.FOLDER));
        }

        /// <summary>
        /// Get the port forwards attributes
        /// </summary>
        private void initialiseSshPortForwards()
        {
            attribSshPortForwards.Add("PortForwardings");
        }

        /// <summary>
        /// Setup a dictionary to make it easy to find the attribute groups
        /// </summary>
        private void initialiseDictionary()
        {
            dictAllAttribGroups.Add(SessionAttributes.AttribGroups.COLOURS, attribColours);
            dictAllAttribGroups.Add(SessionAttributes.AttribGroups.DEFAULT_USERNAME, attribDefaultUsername);
            dictAllAttribGroups.Add(SessionAttributes.AttribGroups.FONT, attribFont);
            dictAllAttribGroups.Add(SessionAttributes.AttribGroups.HOSTNAME, attribHostName);
            dictAllAttribGroups.Add(SessionAttributes.AttribGroups.KEEP_ALIVES, attribKeepAlives);
            dictAllAttribGroups.Add(SessionAttributes.AttribGroups.PROTOCOL_PORT, attribProtocolPort);
            dictAllAttribGroups.Add(SessionAttributes.AttribGroups.SCROLLBACK, attribScrollback);
            dictAllAttribGroups.Add(SessionAttributes.AttribGroups.SELECTION_CHARS, attribSelectionChars);
            dictAllAttribGroups.Add(SessionAttributes.AttribGroups.SESSION_FOLDER, attribSessionFolder);
            dictAllAttribGroups.Add(SessionAttributes.AttribGroups.SSH_PORT_FORWARDS, attribSshPortForwards);
        }

    }
}
