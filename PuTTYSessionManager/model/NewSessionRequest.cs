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
    public class NewSessionRequest
    {
        public NewSessionRequest(Session sessionTemplate
                                , string sessionFolder                                
                                , string hostname
                                , string sessionName
                                , bool copyDefaultUsername
                                , bool launchSession )
        {
            this.sessionTemplate = sessionTemplate;
            this.copyDefaultUsername = copyDefaultUsername;
            this.hostname = hostname;
            this.sessionName = sessionName;
            this.sessionFolder = sessionFolder;
            this.launchSession = launchSession;
        }

        private Session sessionTemplate;

        public Session SessionTemplate
        {
            get { return sessionTemplate; }
        }
        private bool copyDefaultUsername;

        public bool CopyDefaultUsername
        {
            get { return copyDefaultUsername; }
        }
        private string hostname;

        public string Hostname
        {
            get { return hostname; }
        }

        private string sessionName;

        public string SessionName
        {
            get { return sessionName; }
        }

        private string sessionFolder;

        public string SessionFolder
        {
            get { return sessionFolder; }
        }

        private bool launchSession;

        public bool LaunchSession
        {
            get { return launchSession; }
        }
    }
}
