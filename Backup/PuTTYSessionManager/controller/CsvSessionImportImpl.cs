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
using uk.org.riseley.puttySessionManager.form;
using System.IO;
using FileHelpers;
using System.Net;
using System.Windows.Forms;

namespace uk.org.riseley.puttySessionManager.controller
{
    class CsvSessionImportImpl : ISessionImport
    {
        /// <summary>
        /// The file type for this provider
        /// </summary>
        private const string IMPORT_FILE_TYPE = "csv";

        /// <summary>
        /// The file description for this provider
        /// </summary>
        private const string IMPORT_FILE_DESCRIPTION = "CSV File";

        #region SessionExportInterface Members

        /// <summary>
        /// Get a description for the file type
        /// </summary>
        /// <returns></returns>
        public string getFileTypeDescription()
        {
            return IMPORT_FILE_DESCRIPTION;
        }

        /// <summary>
        /// Get the file extension
        /// </summary>
        /// <returns></returns>
        public string getFileTypeExtension()
        {
            return IMPORT_FILE_TYPE;
        }

        /// <summary>
        /// Import the sessions in this providers type
        /// This may throw an exception if there are File I/O issues
        /// </summary>
        /// <param name="location">The location of the csv file</param>
        /// <returns>The list of sessions</returns>
        public List<Session> loadSessions(string location)
        {
            Uri uri = null;
            try
            {
                uri = new Uri(location);
            }
            catch (Exception e)
            {
                throw new Exception("Unable to parse location: " + e.Message);
            }

            FileHelperEngine<CsvRecord> engine = new FileHelperEngine<CsvRecord>();
            List<CsvRecord> csvList = null;
            List<Session> sessionList = null;

            if (uri.Scheme == Uri.UriSchemeFile)
            {
                try
                {
                    csvList = new List<CsvRecord>(engine.ReadFile(uri.LocalPath));
                }
                catch
                {
                    throw new Exception("Unable to parse sessions file - is it corrupted?");
                }

            }
            else if (uri.Scheme == Uri.UriSchemeHttp || uri.Scheme == Uri.UriSchemeHttps)
            {
                Stream s = getRemoteCsvFile(uri);
                if (s != null)
                {
                    try
                    {
                        csvList = new List<CsvRecord>(engine.ReadStream(new StreamReader(s)));
                    }
                    catch
                    {
                        throw new Exception("Unable to parse sessions file - is it corrupted?");
                    }
                    finally
                    {
                        if ( s != null )
                            s.Close();
                    }
                }
            }
            else
            {
                throw new Exception("Unable to parse location: unsupported protocol");
            }

            if (csvList != null)
            {
                sessionList = csvList.ConvertAll(new Converter<CsvRecord, Session>(CsvToSessionConvertor));
            }

            return sessionList;
        }

        #endregion

        /// <summary>
        /// Convert the csv record to a Session
        /// </summary>
        /// <param name="rec"></param>
        /// <returns></returns>
        private Session CsvToSessionConvertor(CsvRecord rec)
        {
            Session s = new Session(Session.convertDisplayToSessionKey(rec.SessionName), rec.FolderName, false);
            s.Hostname = rec.Hostname;
            s.Username = rec.Username;
            return s;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="uri"></param>
        /// <returns></returns>
        private Stream getRemoteCsvFile(Uri sessionsUri)
        {
            WebClient wc = new WebClient();
            Stream stream = null;

            // Set the proxy options
            int proxyMode = Properties.Settings.Default.ProxyMode;
            if (proxyMode == (int)SessionController.ProxyMode.PROXY_IE)
            {
                wc.Proxy = WebRequest.GetSystemWebProxy();
            }
            else if (proxyMode == (int)SessionController.ProxyMode.PROXY_NONE)
            {
                wc.Proxy = null;
            }
            else if (proxyMode == (int)SessionController.ProxyMode.PROXY_USER)
            {
                WebProxy wp = new WebProxy();

                Uri proxyUri;

                try
                {
                    // Create a new Uri object.
                    proxyUri = new Uri("http://" + Properties.Settings.Default.ProxyServer
                                           + ":" + Properties.Settings.Default.ProxyPort);
                    wp.Address = proxyUri;
                    wc.Proxy = wp;
                }
                catch (UriFormatException ufe)
                {
                    MessageBox.Show(null, "Check Proxy configuration: " + Environment.NewLine + ufe.Message
                                      , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }

            }

            // Have 3 goes at this if Proxy auth is requested
            bool tryAgain = true;
            bool connected = false;
            for (int i = 0; i < 3 && tryAgain == true && connected == false; i++)
            {
                try
                {                    
                    // Make sure that the file hasn't been cached by a proxy
                    wc.Headers.Add("Cache-Control: max-age=0");
                    stream = wc.OpenRead(sessionsUri);
                    connected = true;
                }
                catch (WebException we)
                {
                    tryAgain = false;
                    connected = false;

                    // If the exception was a protocol error 
                    // and proxy authentication is required 
                    // ask for the credentials
                    if (we.Status == WebExceptionStatus.ProtocolError)
                    {
                        HttpWebResponse hwe = (HttpWebResponse)we.Response;
                        if (hwe.StatusCode == HttpStatusCode.ProxyAuthenticationRequired)
                        {
                            String realmHeader = hwe.Headers.Get("Proxy-Authenticate");
                            String realm = "";
                            if (realmHeader != null)
                                realm = realmHeader.Substring(realmHeader.IndexOf("=") + 1);

                            ProxyAuthenticationForm paf = new ProxyAuthenticationForm();
                            paf.setRealm(realm);
                            DialogResult dr = paf.ShowDialog();
                            if (dr == DialogResult.OK)
                            {
                                wc.Proxy.Credentials = paf.getCredentials();
                                tryAgain = true;
                            }
                        }
                    }

                    if (stream != null)
                        stream.Close();
                }
            }

            if (connected == false)
            {
                if (stream != null)
                    stream.Close();
                return null;
            }

            return stream;
        }
    }
}
