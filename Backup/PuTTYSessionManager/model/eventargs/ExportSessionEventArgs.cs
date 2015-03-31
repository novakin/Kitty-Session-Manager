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

namespace uk.org.riseley.puttySessionManager.model.eventargs
{
    public class ExportSessionEventArgs : EventArgs 
    {
        public enum ExportType {
            REG_TYPE ,
            CSV_TYPE ,
            CLIP_TYPE
        }
        public ExportSessionEventArgs()
            : this(ExportType.REG_TYPE)
        {    
        }

        public ExportSessionEventArgs(ExportType type)
        {
            this.type = type;
        }

        public ExportType type;

    }
}
