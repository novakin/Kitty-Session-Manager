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
using System.Net;
using System.IO;
using System.Reflection;
using System.Diagnostics;
using uk.org.riseley.puttySessionManager.controller;

namespace uk.org.riseley.puttySessionManager.form
{
    public partial class UpdateForm : Form
    {
        /// <summary>
        /// Default constructor for the form
        /// </summary>
        public UpdateForm()
        {
            InitializeComponent();
            currVersionTextBox.Text = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            urlToolTip.SetToolTip(sfLinkLabel, sfLinkLabel.Text);
            resetDialogFont();
        }

        /// <summary>
        /// Event handler for the Click event for the checkForUpdateButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>        
        private void checkForUpdateButton_Click(object sender, EventArgs e)
        {
            WebClient wc = new WebClient();
            Stream stream = null;

            // Set the proxy options
            int proxyMode = Properties.Settings.Default.ProxyMode;  
            if (  proxyMode == (int) SessionController.ProxyMode.PROXY_IE )
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
                    MessageBox.Show(this,"Check Proxy configuration: " + Environment.NewLine + ufe.Message
                                      ,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }

            }

            // Clear out the text box
            resultsTextBox.Text = "";
            resultsTextBox.Refresh();

            // Have 3 goes at this if Proxy auth is requested
            bool tryAgain = true;
            bool connected = false;
            for (int i = 0; i < 3 && tryAgain == true && connected == false; i++)
            {
                try
                {
                    Uri updateUri = null;
                    try
                    {
                        // Create a new Uri object.
                        updateUri = new Uri(Properties.Settings.Default.UpdateUrl);
                    }
                    catch (UriFormatException ufe)
                    {
                        MessageBox.Show(this, "Check Update URL: " + Environment.NewLine + ufe.Message
                                          , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    appendText("Attempting to contact update url: " + updateUri);

                    // Make sure that the update file hasn't been cached by a proxy
                    wc.Headers.Add("Cache-Control: max-age=0");
                    stream = wc.OpenRead(updateUri);
                    connected = true;
                }
                catch (WebException we)
                {
                    appendText(we.Message);

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
                                realm = realmHeader.Substring(realmHeader.IndexOf("=")+1);

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
                return;
            }
                

            StreamReader sr = new StreamReader(stream);
            string line = sr.ReadLine();
            appendText("Connected.");

            bool foundLatestVersion = false;
            bool foundUpdateUrl = false;
            bool foundReleaseDate = false;
            bool foundOther = false;

            string latestVersion = "";

            for (int i = 0; i < 3 && line != null; i++)
            {
                if (line.StartsWith("LatestVersion|"))
                {
                    latestVersion = line.Substring(line.IndexOf('|') + 1);
                    availVersionTextBox.Text = latestVersion;
                    appendText("Got latest version...");
                    foundLatestVersion = true;
                }
                else if (line.StartsWith("UpdateUrl|"))
                {
                    sfLinkLabel.Text = line.Substring(line.IndexOf('|') + 1);
                    urlToolTip.SetToolTip(sfLinkLabel, sfLinkLabel.Text);
                    appendText("Got update url...");
                    foundUpdateUrl = true;
                }
                else if (line.StartsWith("ReleaseDate|"))
                {
                    appendText("Got release date...");
                    availVersionTextBox.AppendText(" - Released on " + line.Substring(line.IndexOf('|') + 1));
                    foundReleaseDate = true;
                }
                else
                {
                    foundOther = true;
                }
                resultsTextBox.Refresh();
                line = sr.ReadLine();
            }
            sr.Close();
            stream.Close();

            if (foundLatestVersion && foundReleaseDate && foundUpdateUrl && !foundOther)
            {
                appendText("Complete.");
                if ( ! latestVersion.Equals( currVersionTextBox.Text) )
                    MessageBox.Show(this,"An updated version is available. Click on the link to download","Alert",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
             
        }

        /// <summary>
        /// Append text to the results text box and scroll to the end
        /// </summary>
        /// <param name="text"></param>
        private void appendText(string text)
        {
            resultsTextBox.AppendText(text + Environment.NewLine );
            resultsTextBox.SelectionStart = resultsTextBox.Text.Length;
            resultsTextBox.ScrollToCaret();
        }

        /// <summary>
        /// Clear the text box and start the update check on displaying
        /// the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateForm_Load(object sender, EventArgs e)
        {
            // Clear out the text box
            resultsTextBox.Text = "";
            resultsTextBox.Refresh();

            // Start the update check
            checkForUpdateButton_Click(this, EventArgs.Empty);
        }

        /// <summary>
        /// Launch a browser with the update link
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sfLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process.Start(sfLinkLabel.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void resetDialogFont()
        {
            Font = Properties.Settings.Default.DialogFont;
        }
    }
}