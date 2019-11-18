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

using Demoder.AnarchyData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demoder.AnarchyData
{
    public class StatValueTypeMap
    {
        public StatValueTypeMap()
        {
            this.Parameter = String.Empty;
            this.TemplateType = (TemplateGuessedType)(-1);
        }

        public StatValueTypeMap(Stat stat, SpellParameterType type, string parameter="")
        {
            this.TemplateType = (TemplateGuessedType)(-1);
            this.Stat = stat;
            this.DataType = type;
            this.Parameter = parameter;
        }

        public Stat Stat { get; set; }
        public TemplateGuessedType TemplateType { get; set; }
        public SpellParameterType DataType { get; set; }
        public string Parameter { get; set; }
    }
}
