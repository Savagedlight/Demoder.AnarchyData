/*
 * Demoder.AnarchyData
 *
 * Copyright (c) 2012-2016 Marie Helene Kvello-Aune 
 * 
 * This library is free software; you can redistribute it and/or
 * modify it under the terms of the GNU Lesser General Public
 * License as published by the Free Software Foundation; either 
 * version 3 of the License.
 * 
 * This library is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
 * Lesser General Public License for more details.
 * 
 * You should have received a copy of the GNU Lesser General Public 
 * License along with this library.  If not, see <http://www.gnu.org/licenses/>.
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demoder.AnarchyData.TemplateData
{
    public class TemplateDataBase
    {
        public Identity Identity { get; set; }
       
        /// <summary>
        /// Enum representing the DataBlock type ID
        /// </summary>
        public ItemTemplateDataType BlockType { get { return (ItemTemplateDataType)this.Identity.Type; } }

        /// <summary>
        /// Number of data entries in block
        /// </summary>
        public int Entries { get; set; }

        public TemplateDataBase()
        {
            this.Identity = new Identity();
        }

        protected TemplateDataBase(TemplateDataBase source)
        {
            this.Identity = source.Identity.Clone() as Identity;
            this.Entries = source.Entries;
        }
    }
}
