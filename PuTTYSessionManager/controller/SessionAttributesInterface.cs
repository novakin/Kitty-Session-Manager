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

namespace uk.org.riseley.puttySessionManager.controller
{
    interface SessionAttributesInterface
    {
        /// <summary>
        /// Gets special attributes.
        /// </summary>
        /// <param name="attrib">The attribute to find</param>
        /// <returns>The attribute name</returns>
        string getSpecialAttribute(SessionAttributes.SpecialAttributes attrib);

        /// <summary>
        /// Get a list for attribute names for the group
        /// </summary>
        /// <param name="group">The attribute group to find</param>
        /// <returns>The list of attributes</returns>
        List<string> getAttributeGroup(SessionAttributes.AttribGroups group);
    }
}
