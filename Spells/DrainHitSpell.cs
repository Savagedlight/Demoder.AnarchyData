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
    /// Verifying that auno.org and xyphos.com got this right:
    /// 18.04.15:
    ///     [NanoPrograms/266066 Exchange Product]; [DrainHitSpell: [Type=53185 ID=0]]; Trgt=3 Delay=0 Count=1; A=27 B=-1500 C=-1500 D=95 E=25
    ///         Description: 
    ///             In combat when wielding ranged weapons, you will occasionally perform an additional strike with your weapon, stealing a portion of the damage done to heal yourself.
    ///         
    ///         A=27 is health;
    ///         B=-1120/C=-1120 is a likely damage range
    ///         D=95; Damage usually has a type, and this would be ColdAC 
    ///         E would then logically be amount to steal. Studying other items with this spell, it seems like percent is correct.

    /// </remarks>
    [SpellId(53185)]
    public class DrainHitSpell : Spell
    {
        /// <summary>
        /// Generally Health or Nano
        /// </summary>
        [StreamData(0)]
        public Stat Stat { get; set; }

        [StreamData(1)]
        [Interpolate]
        public int MinValue { get; set; }

        [StreamData(2)]
        [Interpolate]
        public int MaxValue { get; set; }

        /// <summary>
        /// Generally AC or None
        /// </summary>
        [StreamData(3)]
        public Stat ModifierStat { get; set; }
        
        /// <summary>
        /// Amount to drain from target, in percent.
        /// </summary>
        [StreamData(4)]
        [Interpolate]
        [PercentParameter]
        public int DrainAmount { get; set; }
    }
}