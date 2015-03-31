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
using System.IO;
using FileHelpers;

namespace uk.org.riseley.puttySessionManager.controller
{
    class CsvSessionExportImpl : ISessionExport
    {
        /// <summary>
        /// The file type for this provider
        /// </summary>
        private const string EXPORT_FILE_TYPE = "csv";

        /// <summary>
        /// The file description for this provider
        /// </summary>
        private const string EXPORT_FILE_DESCRIPTION = "CSV File";

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
            FileHelperEngine<CsvRecord> engine = new FileHelperEngine<CsvRecord>();
            engine.WriteFile(fileName, createCsvRecords(sessionList));           
            return engine.TotalRecords;
        }

        #endregion

        /// <summary>
        /// Create a list of CsvRecords from a list of Sessions
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        private List<CsvRecord> createCsvRecords(List<Session> list)
        {
            List<CsvRecord> csvList = new List<CsvRecord>();
            foreach ( Session s in list )
            {
                csvList.Add(new CsvRecord(s));
            }
            return csvList;
        }
    }
}
