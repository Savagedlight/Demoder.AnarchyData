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
    /// <remarks>
    /// Some examples:
    ///   [Items/163809 Boss Modifier Item (Critical Hit Boss)]; [S_53124: [Type=53124 ID=0]]; Trgt=2 Delay=0 Count=1; A=55 Item=INDI C=1 D=0 E=-1 F=3 G=0 H=0 I=0
    ///   [Items/163809 Boss Modifier Item (Critical Hit Boss)]; [S_53124: [Type=53124 ID=0]]; Trgt=2 Delay=0 Count=1; A=30 Item=AABC C=1 D=0 E=-1 F=3 G=0 H=0 I=0
    ///   [Items/163809 Boss Modifier Item (Critical Hit Boss)]; [S_53124: [Type=53124 ID=0]]; Trgt=2 Delay=0 Count=1; A=24 Item=ITDC C=1 D=0 E=-1 F=3 G=0 H=0 I=0
    /// 
    /// </remarks>>
    [SpellId(53124)]
    public class SpawnItemChanceSpell : Spell
    {
        /// <summary>
        /// Chance of spawn, in percent.
        /// </summary>
        /// <remarks>
        /// All occurances are between 1 and 101 (inclusive)
        /// 
        /// Suspicion: % chance of item spawn.
        /// </remarks>
        [StreamData(0)]
        [Interpolate]
        public int Chance { get; set; }
        
        /// <summary>
        /// Item to spawn
        /// </summary>
        [StreamData(1)]
        public Hash Item { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 18.04.15: Always between 1 and 400 (inclusive)
        /// 
        /// Conclusion: Confirmation that this is indeed item QL.
        /// </remarks>
        [StreamData(2)]
        [Interpolate]
        public int Quality { get; set; }

        #region Footer?
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 18.04.15: Always 0 for items/nanos
        /// </remarks>
        [StreamData(3)]
        [Hide]
        public int D { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 18.04.15: Always -1 for items/nanos
        /// </remarks>
        [StreamData(4)]
        [Hide]
        public int E { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 18.04.15: Always 3 for items/nanos
        /// </remarks>
        [StreamData(5)]
        [Hide]
        public int F { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 18.04.15: Always 0 for items/nanos
        /// </remarks>
        [StreamData(6)]
        [Hide]
        public int G { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 18.04.15: Always 0 for items/nanos
        /// </remarks>
        [StreamData(7)]
        [Hide]
        public int H { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 18.04.15: Always 0 for items/nanos
        /// </remarks>
        [StreamData(8)]
        [Hide]
        public int I { get; set; }
        #endregion
    }
}