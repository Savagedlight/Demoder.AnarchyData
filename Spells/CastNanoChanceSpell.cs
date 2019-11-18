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
    /// Chance to cast a nano program; no defense checks.
    /// </summary>
    [SpellId(53089)]
    [SpellFormat("{Chance} chance to cast {NanoID}; no defense checks.")]
    public class CastNanoChanceSpell : Spell
    {
        [StreamData(0)]
        [NanoIdParameter]
        public uint NanoID { get; set; }

        /// <summary>
        /// Percent chance.
        /// </summary>
        [StreamData(1)]
        [Interpolate]
        [PercentParameter]
        public int Chance { get; set; }
    }
}