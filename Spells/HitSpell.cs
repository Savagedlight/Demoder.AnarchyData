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
    [SpellId(53002)]
    public class HitSpell : Spell
    {
        /// <summary>
        /// Generally Health or Nano
        /// </summary>
        [StreamData(0)]
        public Stat Stat { get; set; }

        [StreamData(1)]
        [Interpolate]
        public int MinValue { get; set; }

        /// <summary>
        /// If this value is 0, and MinValue != 0, MinValue is percent.
        /// </summary>
        [StreamData(2)]
        [Interpolate]
        public int MaxValue { get; set; }

        /// <summary>
        /// Generally a AC type, or None
        /// </summary>
        [StreamData(3)]
        public Stat ModifierStat { get; set; }
    }
}
