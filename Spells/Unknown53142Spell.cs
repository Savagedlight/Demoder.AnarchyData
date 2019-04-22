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
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// 15.04.15:
    ///     No items with this spell.
    /// This spell occurs in the v11.0 RDB.
    /// </remarks>
    
    [SpellId(53142)]
    public class Unknown53142Spell : Spell
    {
        [StreamData(0)]
        public int A0 { get; set; }

        [StreamData(1)]
        public int A1 { get; set; }

        [StreamData(2)]
        public int A2 { get; set; }

        [StreamData(3)]
        public int A3 { get; set; }
    }
}