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
    [SpellId(53014)]
    [SpellFormat("Modify {Stat} for {Duration} {|right|}{Amount}{|/right|}")]
    public class TimedEffectSpell : Spell
    {
        [StreamData(0)]
        public Stat Stat { get; set; }

        [StreamData(1)]
        [Interpolate]
        [BelongsTo("Stat")]
        public int Amount { get; set; }

        // Ignored by Xyphos
        // Seems to be 0, 1 or 5
        [StreamData(2)]
        [Hide]
        public int C { get; set; }

        // Ignored by Xyphos
        [StreamData(3)]
        [Hide]
        public int D { get; set; }

        /// <summary>
        /// Duration in 1/100s of a second.
        /// </summary>
        [StreamData(4)]
        [Interpolate]
        [DurationParameter(0.01)]
        public int Duration { get; set; }
    }
}
