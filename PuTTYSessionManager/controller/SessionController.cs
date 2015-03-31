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
using System.Text;
using System.Security.Permissions;
using System.IO;
using Microsoft.Win32;
using System.Diagnostics;
using uk.org.riseley.puttySessionManager.model;
using uk.org.riseley.puttySessionManager.model.eventargs;
using System.Windows.Forms;
using System.ComponentModel;

[assembly: RegistryPermissionAttribute(SecurityAction.RequestMinimum,
 ViewAndModify = uk.org.riseley.puttySessionManager.controller.SessionController.AUTOSTART_REG_KEY)]

namespace uk.org.riseley.puttySessionManager.controller
{

    /// <summary>
    /// This singleton class provides the interface between the application
    /// and the Session Storage Provider
    /// </summary>
    public class SessionController
    {
        /// <summary>
        /// The registry key ( relative to HKCU ) that stores the Autostart entries
        /// </summary>
        public const string AUTOSTART_REG_KEY = "Software\\Microsoft\\Windows\\CurrentVersion\\Run";

        /// <summary>
        /// The registry key attribute that stores the PSM Autostart entry
        /// </summary>
        public const string PSM_AUTOSTART_REG_ATTRIB = "PuTTYSessionManager";

        /// <summary>
        /// The choice of Transfer Protocols
        /// </summary>
        public enum Protocol { AUTO, FTP, FTPS, SFTP, SCP };

        /// <summary>
        /// The choice of Proxy Modes
        /// </summary>
        public enum ProxyMode { PROXY_IE, PROXY_NONE, PROXY_USER };

        /// <summary>
        /// The current list of all the sessions
        /// </summary>
        private static List<Session> sessionList = new List<Session>();

        /// <summary>
        /// The current list of all the folders which can be used to 
        /// organise sessions. Must be kept in sync with <code>sessionList</code>
        /// </summary>
        private static List<string> folderList = new List<string>();

        /// <summary>
        /// The registry key of the "Default Session"
        /// </summary>
        private const string DEFAULT_SESSION_KEY = "Default%20Settings";

        /// <summary>
        /// A session instance that has the key of the default session
        /// </summary>
        private static Session DEFAULT_SESSION = new Session(DEFAULT_SESSION_KEY, "", false);

        /// <summary>
        /// The singleton instance of this class
        /// </summary>
        private static SessionController instance = null;

        /// <summary>
        /// The session provider
        /// </summary>
        private ISessionStorage sessionProvider = null;

        /// <summary>
        /// CSV Export provider
        /// </summary>
        private ISessionExport csvExportProvider = null;

        /// <summary>
        /// Registry Export provider
        /// </summary>
        private ISessionExport regExportProvider = null;

        /// <summary>
        /// Session Attribute Provider
        /// </summary>
        private SessionAttributesInterface sessionAttribProvider = null;

        /// <summary>
        /// Are updating a batch of sessions
        /// </summary>
        private bool batchUpdate = false;

        /// <summary>
        /// This event is fired when the list of sessions has been altered
        /// </summary>
        public event SessionsRefreshedEventHandler SessionsRefreshed;
        public delegate void SessionsRefreshedEventHandler(object sender, RefreshSessionsEventArgs re);

        /// <summary>
        /// Gets the singleton instance of this class
        /// </summary>
        /// <returns></returns>
        public static SessionController getInstance()
        {
            if (instance == null)
                instance = new SessionController();
            return instance;
        }

        /// <summary>
        /// Private constructor called when the singleton instance is 
        /// created.
        /// </summary>
        private SessionController()
        {
            RegistrySessionStorageImpl regSSI = new RegistrySessionStorageImpl();
            sessionProvider = regSSI;
            regExportProvider = regSSI;
            sessionAttribProvider = regSSI;
            csvExportProvider = new CsvSessionExportImpl();

            invalidateSessionList(this, true);
        }

        /// <summary>
        /// Get the list of sessions
        /// </summary>
        /// <returns></returns>
        public List<Session> getSessionList()
        {
            return sessionList;
        }

        /// <summary>
        /// Get the list of folders
        /// </summary>
        /// <returns>The list of folders</returns>
        public List<string> getFolderList()
        {
            return folderList;
        }

        /// <summary>
        /// Get a list of attributes.  
        /// Delegates to the sessionProvider.
        /// </summary>
        /// <param name="s">The session to get attribs for</param>
        /// <returns>The list of attributes</returns>
        public List<string> getSessionAttributes(Session s)
        {
            return sessionProvider.getSessionAttributes(s);
        }

        /// <summary>
        /// Return the root folder name
        /// </summary>
        /// <returns></returns>
        public string findDefaultFolder()
        {
            return Session.SESSIONS_FOLDER_NAME;
        }

        /// <summary>
        /// Find the default session
        /// </summary>
        /// <returns>The default session, or null if it can't be found</returns>
        public Session findDefaultSession()
        {
            return findDefaultSession(sessionList, true);
        }

        /// <summary>
        /// Find the default session
        /// </summary>
        /// <param name="defaultSessionOnly">
        /// If true, and no default session exists return null
        /// If false, and no default session exists 
        /// return the first session found
        /// </param>
        /// <returns></returns>
        public Session findDefaultSession(bool defaultSessionOnly)
        {
            return findDefaultSession(sessionList, defaultSessionOnly);
        }

        /// <summary>
        /// Find the default session
        /// </summary>
        /// <param name="sl">The list of sessions to search</param>
        /// <param name="defaultSessionOnly">
        /// If true, and no default session exists return null
        /// If false, and no default session exists 
        /// return the first session found
        /// </param>
        /// <returns></returns>
        public Session findDefaultSession(List<Session> sl, bool defaultSessionOnly)
        {
            Session s = findSession(sl, DEFAULT_SESSION);

            // If we can't find the default session
            // return the first one in the list
            if (defaultSessionOnly == false && s == null && sl.Count > 0)
                s = sl[0];

            return s;
        }

        /// <summary>
        /// Try to find a session by name
        /// </summary>
        /// <param name="sessionName">The session name</param>
        /// <returns>The session if found, null if not</returns>
        public Session findSessionByName(string sessionName)
        {
            return findSession(sessionList, sessionName, false);
        }

        /// <summary>
        /// Try to find a session by key
        /// </summary>
        /// <param name="sessionName">The session key</param>
        /// <returns>The session if found, null if not</returns>
        public Session findSessionByKey(string sessionKey)
        {
            return findSession(sessionList, sessionKey, true);
        }

        /// <summary>
        /// Try to find a session
        /// </summary>
        /// <param name="session">The session</param>
        /// <returns>The session if found, null if not</returns>
        public Session findSession(Session session)
        {
            return findSession(sessionList,session);
        }

        /// <summary>
        /// Try to find a session by name
        /// </summary>
        /// <param name="sl">The session list to search</param>
        /// <param name="sessionName">The session name</param>
        /// <returns>The session if found, null if not</returns>
        private Session findSession(List<Session> sl, string sessionName, bool keySupplied)
        {
            String key = "";
            if (keySupplied)
                key = sessionName;
            else 
                key = Session.convertDisplayToSessionKey(sessionName);

            Session s = new Session(key, "", false);
            return findSession(sl,s);
        }

        /// <summary>
        /// Try to find a session
        /// </summary>
        /// <param name="sl">The session list to search</param>
        /// <param name="session">The session</param>
        /// <returns>The session if found, null if not</returns>
        private Session findSession(List<Session> sl, Session session)
        {
            Session s = null;
            int index = sl.BinarySearch(session);
            if (index >= 0)
            {
                s = sessionList[index];
            }
            return s;
        }

        /// <summary>
        /// Reload the session list from source
        /// </summary>
        /// <param name="sender">The sender to notify when complete</param>
        /// <param name="refreshSender">Should the sender refresh itself</param>
        public void invalidateSessionList(Object sender, bool refreshSender)
        {
            // If we have disabled session updates - just return
            if (batchUpdate == true)
                return;

            // Make sure no two threads could call this at the same time
            lock (sessionList)
            {
                sessionList = sessionProvider.getSessionList();
                folderList = getFolderListFromSessions(sessionList);
            }
            OnSessionsRefreshed(sender, new RefreshSessionsEventArgs(refreshSender));
        }

        /// <summary>
        /// Iterate over all the sessions to create a consolidated list
        /// of folders
        /// </summary>
        /// <param name="sl">The session list</param>
        /// <returns></returns>
        private List<string> getFolderListFromSessions(List<Session> sl)
        {
            List<string> fl = new List<string>();
            List<string> sfl = new List<string>();

            // Add the default folder
            fl.Add(Session.SESSIONS_FOLDER_NAME);

            foreach (Session s in sl)
            {
                if (fl.Contains(s.FolderName) == false)
                    fl.Add(s.FolderName);
            }

            // Add in the path elements
            foreach (string folder in fl)
            {
                string path = "";
                foreach (string subfolder in folder.Split(Session.PATH_SEPARATOR.ToCharArray()))
                {
                    if (path.Equals(""))
                        path = subfolder;
                    else
                        path = path + Session.PATH_SEPARATOR + subfolder;

                    if (fl.Contains(path) == false &&
                        sfl.Contains(path) == false)
                        sfl.Add(path);
                }
            }

            fl.AddRange(sfl.ToArray());

            fl.Sort();

            return fl;

        }

        /// <summary>
        /// Save the folder information for the session 
        /// using the provider
        /// </summary>
        /// <param name="s"></param>
        public void updateFolder(Session s)
        {
            sessionProvider.updateFolder(s);
        }

        /// <summary>
        /// Fire the Sessions Refreshed event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected virtual void OnSessionsRefreshed(Object sender, RefreshSessionsEventArgs e)
        {
            if (SessionsRefreshed != null)
                SessionsRefreshed(sender, e);
        }

        /// <summary>
        /// Get the file extensions for the supported export types
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public string getExportFileTypeExtension(ExportSessionEventArgs.ExportType type)
        {
            switch (type)
            {
                case ExportSessionEventArgs.ExportType.REG_TYPE:
                    return regExportProvider.getFileTypeExtension();
                case ExportSessionEventArgs.ExportType.CSV_TYPE:
                    return csvExportProvider.getFileTypeExtension();
            }
            return "";
        }

        /// <summary>
        /// Get the file descriptions for the support export types
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public string getExportFileDescription(ExportSessionEventArgs.ExportType type)
        {
            switch (type)
            {
                case ExportSessionEventArgs.ExportType.REG_TYPE:
                    return regExportProvider.getFileTypeDescription();
                case ExportSessionEventArgs.ExportType.CSV_TYPE:
                    return csvExportProvider.getFileTypeDescription();
            }
            return "";
        }

        /// <summary>
        /// Export the sessions to a file
        /// This method may throw an exception if there are File I/O issues
        /// </summary>
        /// <param name="sessionList">The list of sessions to export</param>
        /// <param name="fileName">The file name to save to</param>
        /// <param name="type">The type of export</param>
        /// <returns>Count of sessions successfully exported</returns>
        public int saveSessionsToFile(List<Session> sessionList, String fileName, ExportSessionEventArgs.ExportType type)
        {
            switch (type)
            {
                case ExportSessionEventArgs.ExportType.REG_TYPE:
                    return regExportProvider.saveSessionsToFile(sessionList, fileName);
                case ExportSessionEventArgs.ExportType.CSV_TYPE:
                    return csvExportProvider.saveSessionsToFile(sessionList, fileName);
            }
            return -1;
        }

        /// <summary>
        /// Copy the hostnames to the clipboard
        /// </summary>
        /// <param name="sessionList">The list of sessions to export</param>
        /// <returns>Count of sessions successfully exported</returns>
        public int copyHostnamesToClipboard(List<Session> sessionList)
        {
            int sessionCount = 0;
            StringBuilder sb = new StringBuilder();
            foreach ( Session s in sessionList )
            {               
                sb.AppendLine(s.getCleanHostname());
                sessionCount++;
            }
            Clipboard.SetText(sb.ToString());
            return sessionCount;
        }

        /// <summary>
        /// Backup the sessions to a file
        /// Use the current sessionProvider to implement this
        /// This method may throw an exception if there are File I/O issues
        /// </summary>
        /// <param name="sessionList">The list of sessions to export</param>
        /// <param name="fileName">The file name to save to</param>
        /// <returns>Count of sessions successfully exported</returns>
        public int backupSessionsToFile(List<Session> sessionList, String fileName)
        {
            return sessionProvider.backupSessionsToFile(sessionList, fileName);
        }

        /// <summary>
        /// Create a new session based on an existing session
        /// Delegates to the sessionProvider, and then
        /// fires a session refresh event
        /// </summary>
        /// <param name="nsr">The new session request</param>
        /// <param name="sender"></param>
        /// <returns></returns>
        public bool createNewSession(NewSessionRequest nsr, Object sender)
        {
            bool result = sessionProvider.createNewSession(nsr);

            // Don't refresh the sender - this should have done it's own update
            invalidateSessionList(sender, false);

            return result;
        }

        /// <summary>
        /// Delete sessions.  
        /// Delegates to the sessionProvider, and then
        /// fires a session refresh event
        /// </summary>
        /// <param name="sl">The</param>
        /// <param name="sender"></param>
        /// <returns></returns>
        public bool deleteSessions(List<Session> sl, Object sender)
        {
            bool result = sessionProvider.deleteSessions(sl);

            // Don't refresh the sender - this should have done it's own update
            invalidateSessionList(sender, false);

            return result;
        }

        /// <summary>
        /// Launch PuTTY
        /// </summary>
        /// <param name="sessionName">The session name to launch</param>
        /// <returns>The error message if the process fails to start</returns>
        public string launchSession(string sessionName)
        {
            String puttyExec = Properties.Settings.Default.PuttyLocation;
            Process p = new Process();
            p.StartInfo.FileName = puttyExec;
            p.StartInfo.Arguments = "-load \"" + sessionName + "\"";

            bool result = false;
            String errMsg = "";
            try
            {
                result = p.Start();
            }
            catch (Exception ex)
            {
                result = false;
                errMsg = ex.Message;
            }
            p.Close();

            return errMsg;
        }

        /// <summary>
        /// Launch Kageant with the saved list of keys
        /// </summary>
        /// <returns>The error message if the process fails to start</returns>
        public string launchKageant()
        {
            String KageantExec = Properties.Settings.Default.KageantLocation;
            Process p = new Process();
            p.StartInfo.FileName = KageantExec;

            foreach (String key in Properties.Settings.Default.KageantKeyList)
            {
                p.StartInfo.Arguments += "\"" + key + "\" ";
            }

            bool result = false;
            String errMsg = "";
            try
            {
                result = p.Start();
            }
            catch (Exception ex)
            {
                result = false;
                errMsg = ex.Message;
            }
            p.Close();

            return errMsg;
        }

        /// <summary>
        /// Rename the session.
        /// Delegates to the sessionProvider
        /// </summary>
        /// <param name="s">The session to rename</param>
        /// <param name="newSessionName">It's new name</param>
        /// <returns>true if sucessful, false otherwise</returns>
        public bool renameSession(Session s, string newSessionName, Object sender)
        {
            bool result = sessionProvider.renameSession(s, newSessionName);
        
            // Don't refresh the sender - this should have done it's own update
            invalidateSessionList(sender, false);

            return result;
        }

        /// <summary>
        /// Is the passed in session the "Default Session"
        /// </summary>
        /// <param name="sessionName">the Session name to test</param>
        /// <returns></returns>
        public bool isDefaultSessionName(string sessionName)
        {
            if (Session.convertDisplayToSessionKey(sessionName).Equals(DEFAULT_SESSION_KEY))
                return true;
            else
                return false;

        }

        /// <summary>
        /// Copy the specified attributes from a template session
        /// to a list of target sessions
        /// Delgates to the sessionProvider.
        /// </summary>
        /// <param name="csr">The copy session request</param>
        /// <returns>true if sucessful, false otherwise</returns>
        public bool copySessionAttributes(CopySessionRequest csr)
        {
            return sessionProvider.copySessionAttributes(csr);
        }


        /// <summary>
        /// Check whether auto start on logon is enabled in the registry
        /// </summary>
        /// <returns></returns>
        public bool isAutoStartEnabled()
        {
            bool retval = false;

            // Open the autostart registry key
            RegistryKey rk = Registry.CurrentUser.OpenSubKey(AUTOSTART_REG_KEY);

            // This key should exist - but just in case...
            if (rk != null)
            {
                // Check if the PSM attribute exists
                if (rk.GetValue(PSM_AUTOSTART_REG_ATTRIB) != null)
                    retval = true;

                // Clost the registry key
                rk.Close();
            }
            return retval;
        }

        /// <summary>
        /// Adds or removes a key from the registry to automatically
        /// start Putty Session Manager on logon
        /// </summary>
        /// <param name="enabled">Enable or disable auto start</param>
        public bool setAutoStart(bool enabled)
        {
            // Assume we fail
            bool result = false;

            // Open the autostart registry key
            RegistryKey rk = Registry.CurrentUser.OpenSubKey(AUTOSTART_REG_KEY, true);

            // If we are trying to enable autostart and the key doesn't exist
            // try to create it
            if (rk == null && enabled)
            {
                rk = Registry.CurrentUser.CreateSubKey(AUTOSTART_REG_KEY);
            }

            // Check if we can open the key
            if (rk != null)
            {
                // If we are enabling autstart set the value to the current exec path
                if (enabled)
                    rk.SetValue(PSM_AUTOSTART_REG_ATTRIB, "\"" + Application.ExecutablePath + "\"", RegistryValueKind.String);
                // otherwise delete it, but only if it exists
                else if (rk.GetValue(PSM_AUTOSTART_REG_ATTRIB) != null)
                    rk.DeleteValue(PSM_AUTOSTART_REG_ATTRIB, false);

                // Close the value
                rk.Close();

                // It worked
                result = true;
            }
            // if we can't get to the registry value - but the preference is disabled
            // don't worry
            else if (enabled == false)
            {
                result = true;
            }

            return result;
        }


        /// <summary>
        /// Lauch a WinSCP or FileZilla session
        /// </summary>
        /// <param name="s">The session to launch</param>
        /// <returns>The error message if the process fails to start</returns>
        public string launchOtherSession(Session s, LaunchSessionEventArgs.PROGRAM program)
        {
            String errMsg = "";

            // Get all the values from the registry that we are interested in
            string hostname = s.Hostname;
            string username = s.Username;
            string protocol = s.Protocol;
            int portnumber = s.Portnumber;

            // Override the default username if stored in the hostname
            if (hostname != null && hostname.Contains("@"))
            {
                username = hostname.Substring(0, hostname.IndexOf("@"));
                if (hostname.IndexOf("@") < hostname.Length)
                    hostname = hostname.Substring(hostname.IndexOf("@") + 1);
            }

            String execLocation = "";
            String execArgs = "";

            // Setup the FileZilla args
            if (program == LaunchSessionEventArgs.PROGRAM.FILEZILLA)
            {

                // Only bother if we have a hostname set
                if (hostname == null || hostname.Length == 0)
                {
                    execArgs = "";
                }
                else
                {


                    // Setup the protocol and port
                    Protocol fp = (Protocol)Properties.Settings.Default.FileZillaProtocol;
                    switch (fp)
                    {
                        case Protocol.FTP:
                            protocol = "ftp://";
                            portnumber = 21;
                            break;
                        case Protocol.FTPS:
                            protocol = "ftps://";
                            portnumber = 990;
                            break;
                        case Protocol.SFTP:
                            protocol = "sftp://";
                            portnumber = 22;
                            break;
                        case Protocol.AUTO:
                            if (protocol.Equals("ssh", StringComparison.InvariantCultureIgnoreCase))
                            {
                                protocol = "sftp://";
                                if (portnumber == -1)
                                    portnumber = 22;
                            }
                            else
                            {
                                protocol = "ftp://";
                                portnumber = 21;
                            }
                            break;
                    }

                    // Setup Pageaent auth if requested and the protocol is sftp
                    String password = "";
                    if (protocol.Equals("sftp://") &&
                         Properties.Settings.Default.FileZillaAttemptKeyAuth == true)
                        password = ":";

                    // Finalise the auth string
                    String auth = "";
                    if (username != null && !(username.Equals("")))
                        auth = username + password + "@";

                    execArgs = protocol + auth + hostname + ":" + portnumber;
                }
                execLocation = Properties.Settings.Default.FileZillaLocation;

            }
            else if (program == LaunchSessionEventArgs.PROGRAM.WINSCP)
            {
                // Setup the /ini option

                if (Properties.Settings.Default.WinSCPIniEnabled == true &&
                    Properties.Settings.Default.WinSCPIniLocation != null &&
                    !Properties.Settings.Default.WinSCPIniLocation.Equals("") )
                {
                    execArgs = "/ini=\"" + Properties.Settings.Default.WinSCPIniLocation + "\" ";
                }
                // Only bother if we have a hostname set
                if (hostname != null && hostname.Length != 0)
                {
                    // Setup the protocol and port
                    Protocol wp = (Protocol)Properties.Settings.Default.WinSCPProtocol;
                    int wsVer = Properties.Settings.Default.WinSCPVersion;

                    // FTP isn't supported for v3, so default to SFTP
                    if (wsVer == 3 && wp == Protocol.FTP)
                        wp = Protocol.SFTP;

                    switch (wp)
                    {
                        case Protocol.FTP:
                            protocol = "ftp://";
                            portnumber = 21;
                            break;
                        case Protocol.SFTP:
                            protocol = "sftp://";
                            portnumber = 22;
                            break;
                        case Protocol.SCP:
                            protocol = "scp://";
                            portnumber = 22;
                            break;
                        case Protocol.AUTO:
                            if (protocol.Equals("ssh", StringComparison.InvariantCultureIgnoreCase))
                            {
                                Protocol wpp = (Protocol)Properties.Settings.Default.WinSCPPrefProtocol;
                                if (wpp == Protocol.SCP)
                                {
                                    protocol = "scp://";
                                }
                                else
                                {
                                    protocol = "sftp://";
                                }
                                if (portnumber == -1)
                                    portnumber = 22;
                            }
                            else if (wsVer == 4)
                            {
                                protocol = "ftp://";
                                portnumber = 21;
                            }
                            else
                            {
                                protocol = "sftp://";
                                portnumber = 22;
                            }
                            break;
                    }


                    // Finalise the auth string
                    String auth = "";
                    if (username != null && !(username.Equals("")))
                        auth = username + "@";

                    execArgs = execArgs + protocol + auth + hostname + ":" + portnumber;
                }
                execLocation = Properties.Settings.Default.WinSCPLocation;
            }

            Process p = new Process();
            p.StartInfo.FileName = execLocation;
            p.StartInfo.Arguments = execArgs;

            // Attempt to start the process
            try
            {
                p.Start();
            }
            catch (Exception ex)
            {
                errMsg = ex.Message;
            }
            p.Close();


            return errMsg;
        }

        /// <summary>
        /// Gets special attributes.
        /// Delegates to the sessionAttribProvider
        /// </summary>
        /// <param name="attrib">The attribute to find</param>
        /// <returns>The attribute name</returns>
        public string getSpecialAttribute(SessionAttributes.SpecialAttributes attrib)
        {
            return sessionAttribProvider.getSpecialAttribute(attrib);
        }

        /// <summary>
        /// Get a list for attribute names for the group
        /// Delegates to the sessionAttribProvider
        /// </summary>
        /// <param name="group">The attribute group to find</param>
        /// <returns>The list of attributes</returns>
        public List<string> getAttributeGroup(SessionAttributes.AttribGroups group)
        {
            return sessionAttribProvider.getAttributeGroup(group);
        }

        /// <summary>
        /// Check to see if we can locate the PuTTY exec
        /// </summary>
        /// <returns></returns>
        public bool isPuTTYExecutableAccessible()
        {
            return File.Exists(Properties.Settings.Default.PuttyLocation);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        public int syncSessions(BackgroundWorker worker, SyncSessionsRequestedEventArgs e)
        {
            int modifiedCount = 0;
            List<Session> delList = new List<Session>();

            // Disable session refreshes
            BeginUpdate();

            foreach ( SessionAction sa in e.SessionActionList )
            {

                if ( sa.Action == SessionAction.ACTION.ADD )
                {
                    NewSessionRequest nsr = new NewSessionRequest(e.SessionTemplate
                                                                , sa.NewSession.FolderName
                                                                , sa.NewSession.Hostname
                                                                , sa.NewSession.SessionDisplayText
                                                                , true, false);
                    createNewSession(nsr, worker);
                    modifiedCount++;
                }
                else if ( sa.Action == SessionAction.ACTION.DELETE )
                {
                    delList.Add(sa.ExistingSession);
                    modifiedCount++;
                }
                else if ( sa.Action == SessionAction.ACTION.UPDATE )
                {
                    Session existingSession = findSession(sa.NewSession);
                    if (existingSession != null)
                    {
                        sessionProvider.updateHostname(sa.NewSession);
                        sessionProvider.updateFolder(sa.NewSession);
                        modifiedCount++;
                    }
                }
                else if (sa.Action == SessionAction.ACTION.RENAME)
                {
                    Session existingSession = findSession(sa.ExistingSession);
                    sessionProvider.renameSession(existingSession, sa.NewSession.SessionDisplayText);
                    existingSession.FolderName = sa.NewSession.FolderName;
                    sessionProvider.updateFolder(existingSession);
                    modifiedCount++;
                }
                worker.ReportProgress(modifiedCount);
            }

            if (delList.Count > 0)
                deleteSessions(delList, worker);

            worker.ReportProgress(e.SessionActionList.Count);

            // Re-enable session refreshes
            EndUpdate();

            return modifiedCount;
        }

        private void BeginUpdate()
        {
            batchUpdate = true;
        }

        private void EndUpdate()
        {
            batchUpdate = false;
        }

    }
}
