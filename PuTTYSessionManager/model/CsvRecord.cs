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
using FileHelpers;

namespace uk.org.riseley.puttySessionManager.model
{
    [IgnoreEmptyLines()]
    [IgnoreCommentedLines("#", true)]
    [DelimitedRecord(",")]
    public sealed class CsvRecord
    {

        public CsvRecord()
        {
        }

        public CsvRecord(Session s)
        {
            SessionName = s.SessionDisplayText;
            FolderName = s.FolderName;
            Username = s.Username;
            Hostname = s.Hostname;
        }

        [FieldQuoted('"', QuoteMode.OptionalForRead, MultilineMode.AllowForRead)]
        private String mSessionName;

        public String SessionName
        {
            get { return mSessionName; }
            set { mSessionName = value; }
        }


        [FieldQuoted('"', QuoteMode.OptionalForRead, MultilineMode.AllowForRead)]
        private String mFolderName;

        public String FolderName
        {
            get { return mFolderName; }
            set { mFolderName = value; }
        }


        [FieldQuoted('"', QuoteMode.OptionalForRead, MultilineMode.AllowForRead)]
        private String mUsername;

        public String Username
        {
            get { return mUsername; }
            set { mUsername = value; }
        }


        [FieldQuoted('"', QuoteMode.OptionalForRead, MultilineMode.AllowForRead)]
        private String mHostname;

        public String Hostname
        {
            get { return mHostname; }
            set { mHostname = value; }
        }
    }
}
