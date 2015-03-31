/* 
 * Copyright (C) 2008 David Riseley 
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
    public class HotkeyModifier
    {
        public HotkeyModifier (   int modifier
                                , String description 
                                , char[] protectedKeys )
        {
            this.description = description;
            this.modifier = modifier;
            ProtectedKeys = protectedKeys;
        }
        
        private String description;

        public String Description
        {
            get { return description; }
            set { description = value; }
        }
        private int modifier = -1;

        public int Modifier
        {
            get { return modifier; }
            set { modifier = value; }
        }

        public override string ToString()
        {
            return description;
        }

        private char[] protectedKeys;

        public char[] ProtectedKeys
        {
            get { return protectedKeys; }
            set 
            { 
                protectedKeys = value;
                StringBuilder sb = new StringBuilder();
                foreach (char c in protectedKeys)
                {
                    sb.Append(c + ",");
                }

                // Trim off the trailing comma if it exists
                if (sb.Length > 0)
                {
                    sb.Remove(sb.Length-1, 1);
                }

                protectedKeysDescription = sb.ToString();
            }
        }

        private string protectedKeysDescription;

        public string ProtectedKeysDescription
        {
            get { return protectedKeysDescription; }
        }
    }
}
