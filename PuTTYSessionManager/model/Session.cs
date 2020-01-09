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

namespace uk.org.riseley.puttySessionManager.model
{

    public class Session : IEquatable<Session>, IComparable<Session>
    {
        public const string SESSIONS_FOLDER_NAME = "Sessions";
        public const string PATH_SEPARATOR = "\\";

        private const string KEY_SESSION = "SESSION|";
        private const string KEY_FOLDER = "FOLDER|";

        private static Encoding systemEncoding = Encoding.GetEncoding(System.Globalization.CultureInfo.CurrentCulture.TextInfo.ANSICodePage);
        private static int SESSIONS_FOLDER_LEN = SESSIONS_FOLDER_NAME.Length + PATH_SEPARATOR.Length;

        private string sessionKey = "";
        public string SessionKey
        {
            get { return sessionKey; }
            private set { sessionKey = value; }
        }

        private string nodeKey = "";
        public string NodeKey
        {
            get { return nodeKey; }
            private set { nodeKey = value; }
        }

        private string sessionDisplayText = "";
        public string SessionDisplayText
        {
            get { return sessionDisplayText; }
            private set { sessionDisplayText = value; }
        }

        private string folderName = "";
        public string FolderName
        {
            get { return folderName; }
            set { folderName = value; }
        }

        private string folderDisplayText = "";
        public string FolderDisplayText
        {
            get { return folderDisplayText; }
            set { folderDisplayText = value; }
        }
        private bool isFolder = false;
        public bool IsFolder
        {
            get { return isFolder; }
            private set { isFolder = value; }
        }

        public Session(string regKey, string folderName, bool isFolder)
        {
            SessionKey = regKey;
            SessionDisplayText = System.Web.HttpUtility.UrlDecode(regKey, System.Text.Encoding.Default);

            if (folderName == null || folderName.Equals("") || folderName.Equals(SESSIONS_FOLDER_NAME))
            {
                FolderName = SESSIONS_FOLDER_NAME;
                FolderDisplayText = "";
            }
            else
            {
                FolderName = folderName;
                FolderDisplayText = FolderName.Remove(0, SESSIONS_FOLDER_LEN);
            }

            IsFolder = isFolder;
            cellValues = new String[] { SessionDisplayText, FolderDisplayText, "" };

            if (isFolder == true)
                NodeKey = KEY_FOLDER + FolderName;
            else
                NodeKey = KEY_SESSION + SessionKey;
        }

        public override string ToString()
        {
            return SessionDisplayText;
        }

        public int CompareTo(Session s)
        {
            return this.SessionKey.CompareTo(s.SessionKey);
        }

        public bool Equals(Session s)
        {
            return (this.SessionKey.Equals(s.SessionKey));
        }

        /// <summary>
        /// This method strips hex encoded characters from the session
        /// name stored in the registry
        /// Based on the unmungestr() method in WINDOWS\WINSTORE.c
        /// from the PuTTY v0.60 src tree
        /// Support for different codepages has been added to attempt to 
        /// match the PuTTY encoding
        /// </summary>
        /// <param name="key">The registry key name to convert</param>
        /// <returns>The display formatted session name</returns>
        private String convertSessionKeyToDisplay(string key)
        {
            CharEnumerator ce = key.GetEnumerator();
            StringBuilder sb = new StringBuilder(key.Length);

            while (ce.MoveNext())
            {
                if (ce.Current == '%')
                {
                    CharEnumerator clone = (CharEnumerator)ce.Clone();
                    StringBuilder hexVal = new StringBuilder(2);
                    if ( clone.MoveNext() )
                        hexVal.Append(clone.Current);
                    if ( clone.MoveNext())
                        hexVal.Append(clone.Current);
                    if (hexVal.Length == 2)
                    {                        
                        Byte byteVal = Byte.Parse(hexVal.ToString(), System.Globalization.NumberStyles.HexNumber);
                        sb.Append(systemEncoding.GetString(new byte[] { byteVal }));
                        ce.MoveNext();
                        ce.MoveNext();
                    }
                    else
                    {
                        sb.Append(ce.Current);
                    }
                }
                else
                {
                    sb.Append(ce.Current);
                }

            }
            return sb.ToString();
        }

        /// <summary>
        /// This method encodes special characters to make the session
        /// display name suitable for storage as a key in the registry
        /// Based on the mungestr() method in WINDOWS\WINSTORE.c
        /// from the PuTTY v0.60 src tree 
        /// </summary>
        /// <param name="display">The session name displayed</param>
        /// <returns>The registry key to be stored</returns>
        public static String convertDisplayToSessionKey(string display)
        {
            CharEnumerator ce = display.GetEnumerator();
            StringBuilder sb = new StringBuilder();
            int i = 0;
            while (ce.MoveNext())
            {
                Char c = ce.Current;
                if (c == ' ' || c == '\\' || c == '*' || c == '?' ||
                    c == '%' || c < ' ' || c > '~' || (c == '.' && i == 0))
                {
                    byte[] b = systemEncoding.GetBytes(new char[] { c });
                    sb.Append("%" + Convert.ToString((int)b[0], 16).ToUpper());
                }
                else
                {
                    sb.Append(c);
                }
                i++;
            }
            return sb.ToString();
        }

        private string[] cellValues;
        public string[] getCellValues()
        {
            return cellValues;
        }

        public static string getFolderKey(string folder)
        {
            return KEY_FOLDER + folder;
        }

        private string toolTipText = "";
        public string ToolTipText
        {
            get { return toolTipText; }
            set { toolTipText = value; }
        }

        private string hostname = "";

        public string Hostname
        {
            get { return hostname; }
            set
            {
                hostname = value;
                cellValues[2] = hostname;
            }
        }
        private string username = "";

        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        private string protocol = "";

        public string Protocol
        {
            get { return protocol; }
            set { protocol = value; }
        }
        private int portnumber = -1;

        public int Portnumber
        {
            get { return portnumber; }
            set { portnumber = value; }
        }

        private string portforwards;

        public string Portforwards
        {
            get { return portforwards; }
            set { portforwards = value; }
        }

        private string remotecommand;

        public string Remotecommand
        {
            get { return remotecommand; }
            set { remotecommand = value; }
        }

        public void setToolTip()
        {
            string hn = Hostname;
            string un = Username;

            // Check if the hostname is set
            if (hn == null || hn.Equals(""))
                hn = "[NONE SET]";

            // Ignore the default username if the hostname contains an @
            if (hn != null && hn.Contains("@"))
                un = null;
            else if (un != null && !(un.Equals("")))
                un = un + "@";

            // Set the port number to null if default for the protocol
            string port = ":" + Portnumber;
            if (Protocol != null &&
               ((Protocol.Equals("ssh") && Portnumber == 22) ||
                (Protocol.Equals("telnet") && Portnumber == 23) ||
                (Protocol.Equals("rlogin") && Portnumber == 513) ||
                 Portnumber == -1))
            {
                port = "";
            }

            // Build the connection string
            String connection = Protocol + "://" + un + hn + port;

            // Now build the full tooltip text
            if (SessionDisplayText != null && !SessionDisplayText.Equals(""))
                ToolTipText += "Session: " + SessionDisplayText + Environment.NewLine;

            ToolTipText += connection + Environment.NewLine;

            if (remotecommand != null && !remotecommand.Equals(""))
                ToolTipText += "Remote Command: " + remotecommand + Environment.NewLine;

            if (portforwards != null && !portforwards.Equals(""))
                ToolTipText += "Port Forwards: " + portforwards + Environment.NewLine;

            // Strip off any trailing newline
            if (ToolTipText.EndsWith(Environment.NewLine))
                ToolTipText = ToolTipText.Remove(ToolTipText.LastIndexOf(Environment.NewLine));

        }

        public String getCleanHostname()
        {
            if ( hostname != null && hostname.Contains("@") && !(hostname.EndsWith("@")) )
                return hostname.Substring(hostname.IndexOf('@')+1);
            else
                return hostname;
        }
    }
}
