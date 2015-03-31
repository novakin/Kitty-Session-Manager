/* 
 * Copyright (C) 2009 David Riseley 
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
    public class SessionAction
    {
        public enum ACTION { ADD, UPDATE, DELETE, RENAME, NONE };

        public SessionAction(Session existingSession, Session newSession)
        {
            this.existingSession = existingSession;
            this.newSession = newSession;
            caculateAction();
        }

        private ACTION action;

        private Session existingSession;
        private Session newSession;

        public Session ExistingSession
        {
            get { return existingSession; }
            set { existingSession = value; }
        }

        public Session NewSession
        {
            get { return newSession; }
            set { newSession = value; }
        }


        public ACTION Action
        {
            get { return action; }
            set { action = value; }
        }

        private void caculateAction()
        {
            if (newSession == null)
                this.action = ACTION.DELETE;
            else if (existingSession == null)
                this.action = ACTION.ADD;
            else if ((newSession.Hostname.Equals(existingSession.Hostname)) &&
                     (newSession.FolderName.Equals(existingSession.FolderName)))
                this.action = ACTION.NONE;
            else
                this.action = ACTION.UPDATE;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public String getActionDescription()
        {
            switch (action)
            {
                case ACTION.DELETE:     { return "Deleted"; }
                case ACTION.ADD:        { return "New"; }
                case ACTION.UPDATE:     { return "Changed"; }
                case ACTION.RENAME:     { return "Renamed"; }
                case ACTION.NONE:       { return "Unchanged"; }
                default:                { return "Unchanged"; }
            }
        }
    }
}
