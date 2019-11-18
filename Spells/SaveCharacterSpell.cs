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
using Demoder.Common.Attributes;
using Demoder.AnarchyData.Attributes;

namespace Demoder.AnarchyData.Spells
{
    [SpellId(53032)]
    [SpellFormat("Save character.")]
    public class SaveCharacterSpell : Spell
    {
        [StreamData(0)]
        public int A { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 18.6.2:<br/>
        /// Item 24562 (Cell Structure Scanner): This value is 65000. It's 0 for the rest.
        /// </remarks>
        [StreamData(1)]
        public int B { get; set; }

        [StreamData(2)]
        public int C { get; set; }

        [StreamData(3)]
        public int D { get; set; }
    }
}