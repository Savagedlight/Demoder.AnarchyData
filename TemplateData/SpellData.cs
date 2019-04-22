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
    public class SpellData : TemplateDataBase
    {
        public SpellData(TemplateDataBase source)
            : base(source)
        {
            
        }
        public Spell[] Items { get; set; }
        public TemplateEvent Event { get { return (TemplateEvent)this.Identity.Instance; } }

        public override string ToString()
        {
            return String.Format("{0}: {1} spells.", this.Event, this.Entries);
        }
    }
}
