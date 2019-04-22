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
    [SpellId(53230)]
    [SpellFormat("Knockback a radius of {Radius}.")]
    public class KnockbackSpell : Spell
    {
        [StreamData(0)]
        [DistanceParameter]
        public int Radius { get; set; }

        [StreamData(1)]
        public int B { get; set; }
    }

    // Version: 18.00.00.00
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// 18.04.15
    ///     [NanoPrograms/279361 Put up or Shut Up]; [KnockbackSpell_1: [Type=53230 ID=0]]; Trgt=3 Delay=0 Count=1; A=5 B=0 C=50
    ///         Description: An enforcer does not need to be convincing. They just need to hit you so hard that you no longer care. Your opponent should land somewhere in next week.
    ///     [NanoPrograms/279368 Sawed-Off Kiss]; [KnockbackSpell_1: [Type=53230 ID=0]]; Trgt=3 Delay=0 Count=1; A=15 B=0 C=150
    ///     [Items/285167 Gravity Shift]; [KnockbackSpell_1: [Type=53230 ID=0]]; Trgt=3 Delay=25 Count=1; A=35 B=0 C=400
    ///     [Items/285167 Gravity Shift]; [KnockbackSpell_1: [Type=53230 ID=0]]; Trgt=3 Delay=25 Count=1; A=35 B=0 C=400
    ///     [NanoPrograms/290201 She Set You Up the Bomb!]; [KnockbackSpell_1: [Type=53230 ID=0]]; Trgt=8 Delay=1 Count=1; A=2 B=10 C=75
    ///     [Items/277441 The I Win Button]; [KnockbackSpell_1: [Type=53230 ID=0]]; Trgt=2 Delay=0 Count=1; A=40 B=10 C=400
    ///         
    /// Judging by the I Win button alone, A= affected radius (meters) and C= distance people are thrown back (meters)
    /// </remarks>
    [SpellId(53230, "18.00.00")]
    [SpellFormat("Knockback a radius of {Radius} with {Power} force.")]
    public class KnockbackSpell_1 : Spell
    {
        /// <summary>
        /// Apply to dynels in this distance from epicenter, in meters.
        /// </summary>
        [StreamData(0)]
        [DistanceParameter]
        public int Radius { get; set; }

        [StreamData(1)]
        public int B { get; set; }

        /// <summary>
        /// Knockback power, in meters.
        /// </summary>
        [StreamData(2)]
        public int Power { get; set; }
    }
}