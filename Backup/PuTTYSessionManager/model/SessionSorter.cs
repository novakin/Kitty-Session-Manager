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
using System.Collections;
using System.Windows.Forms;

namespace uk.org.riseley.puttySessionManager.model
{
    /// <summary>
    /// A class that allows tree nodes to be sorted by folder and name
    /// </summary>
    public class SessionSorter : IComparer
    {
        /// <summary>
        /// Enumeration of different possible sort orders
        /// </summary>
        public enum SortOrder
        {
            FOLDER_FIRST  = 1,
            FOLDER_IGNORE = 0,
            FOLDER_LAST   = -1
        }

        /// <summary>
        /// The current sort order
        /// </summary>
        private int sortOrder;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="order">The sort order for this instance</param>
        public SessionSorter(SortOrder order)
        {
            sortOrder = (int)order;
        }

        #region IComparer Members

        /// <summary>
        /// Method to compare the values of two tree
        /// nodes
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns> x less than    y = less than 0
        ///           x equal to     y = 0
        ///           x greater than y = greater than 0 </returns>
        int IComparer.Compare(object x, object y)
        {
            TreeNode tx = x as TreeNode;
            TreeNode ty = y as TreeNode;

            if ( tx == null || ty == null )
                throw new ArgumentException();

            Session sx = tx.Tag as Session;
            Session sy = ty.Tag as Session;

            if (sx == null && sy == null)
                return 0;
            else if (sx == null && sy != null)
                return -1 * sortOrder;
            else if (sx != null && sy == null)
                return 1 * sortOrder;
            else if (sortOrder == 0)
                return string.Compare(sx.SessionDisplayText, sy.SessionDisplayText);
            else if (sx.IsFolder && !(sy.IsFolder))
                return -1 * sortOrder;
            else if (!(sx.IsFolder) && (sy.IsFolder))
                return 1 * sortOrder;
            // sx.IsFolder == sy.IsFolder
            else
                return string.Compare(sx.SessionDisplayText, sy.SessionDisplayText);
        }

        #endregion
    }
}
