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
    /// 18.04.15:
    ///     [Items/286151 Wearable: Immortal_Guardian_001]; [DelayedSpawnNpcSpell: [Type=53220 ID=0]]; Trgt=2 Delay=1 Count=1; A=IMGU B={ 240, 0, 0, 0, 0, 0, 10, 0 }
    ///     [Items/286152 Wearable: Immortal_Guardian_300]; [DelayedSpawnNpcSpell: [Type=53220 ID=0]]; Trgt=2 Delay=1 Count=1; A=IMGU B={ 240, 0, 0, 0, 0, 0, 10, 0 }
    ///     [Items/286201 Wearable: Collected_Essence_300]; [DelayedSpawnNpcSpell: [Type=53220 ID=0]]; Trgt=2 Delay=1 Count=1; A=70LT B={ 1, 2, 32, 2, 0, 1000, 0, 1 }
    ///     [Items/287627 Wearable: Clan_Ext_NPC_2_001]; [DelayedSpawnNpcSpell: [Type=53220 ID=0]]; Trgt=2 Delay=1 Count=1; A=VEOA B={ 1, 163, 6, 83, 0, 0, 0, 1 }
    ///     [Items/286149 Wearable: Botanicus_wallknocker_001]; [DelayedSpawnNpcSpell: [Type=53220 ID=0]]; Trgt=2 Delay=1 Count=1; A=YUWH B={ 250, 600, 9, 683, 0, 0, 0, 1 }
    /// 
    /// 
    /// </remarks>
    [SpellId(53220)]
    [SpellFormat("Spawn QL {Quality} NPC {Spawnee}.")]
    public class DelayedSpawnNpcSpell : Spell
    {
        [StreamData(0)]
        public Hash Spawnee { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 18.04.15
        ///     [Items/286151 Wearable: Immortal_Guardian_001]; [DelayedSpawnNpcSpell: [Type=53220 ID=0]]; Trgt=2 Delay=1 Count=1; A=IMGU B={ 240, 0, 0, 0, 0, 0, 10, 0 }
        ///     [Items/286201 Wearable: Collected_Essence_300]; [DelayedSpawnNpcSpell: [Type=53220 ID=0]]; Trgt=2 Delay=1 Count=1; A=70LT B={ 1, 2, 32, 2, 0, 1000, 0, 1 }
        /// Assuming there's a QL here somewhere, it's either B.0 or B.6 (See item 286151). Add in item 286201 and we know b.6 isn't it.
        /// B.0 is therefore it.
        /// </remarks>
        [StreamData(1)]
        [Interpolate]
        public int Quality { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [StreamData(2)]
        [Hide]
        public int C { get; set; }

        [StreamData(3)]
        [Hide]
        public int D { get; set; }

        [StreamData(4)]
        [Hide]
        public int E { get; set; }

        [StreamData(5)]
        [Hide]
        public int F { get; set; }

        [StreamData(6)]
        [Hide]
        public int G { get; set; }

        [StreamData(7)]
        [Hide]
        public int H { get; set; }

        [StreamData(8)]
        [Hide]
        public int I { get; set; }

    }
}