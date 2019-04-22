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
    /// Spell ID: 53177
    /// </summary>
    [SpellId(53177)]
    [SpellFormat("Reduce {NanoStrain} by {Duration}.")]
    public class ReduceNanoStrainDurationSpell : Spell
    {
        /// <summary>
        /// Which nano strain to reduce
        /// </summary>
        [StreamData(0)]
        [Parameter(SpellParameterType.NanoStrain)]
        public uint NanoStrain { get; set; }

        /// <summary>
        /// How many seconds to reduce by
        /// </summary>
        [StreamData(1)]
        [Interpolate]
        [DurationParameter]
        public int Duration { get; set; }

        public override string ToString()
        {
            return String.Format("Strain: {0} Seconds: {1}", this.NanoStrain, this.Duration);
        }
    }
}