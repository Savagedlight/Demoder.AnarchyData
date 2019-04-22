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
    ///     Items with this spell:
    ///         [NanoPrograms/209488 Pet Warp]; [SummonPetsSpell: [Type=53181 ID=0]]; Trgt=2 Delay=0 Count=1; A=0
    ///             Description: 
    ///                 The body of the pet' master becomes a living beacon that can be used to warp the masters pets to his location. Setting up a connection with one of the micro-sats that populate the atmosphere of Rubi-Ka, the master uses this satellite feed to determine the exact location of all his pets. A momentary warp in the fabric of space is created, and all the masters pets are instantaneously transported to the location of the master.
    ///                 You may only summon pets that are not in combat.
    ///             
    ///         [NanoPrograms/210206 Pet Combat Warp]; [SummonPetsSpell: [Type=53181 ID=0]]; Trgt=2 Delay=0 Count=1; A=1
    ///             Description:
    ///                 The body of the pet master becomes a living beacon that can be used to warp the masters pets to his location. Setting up a connection with one of the micro-sats that populate the atmosphere of Rubi-Ka, the master uses this satellite feed to determine the exact location of all his pets. A momentary warp in the fabric of space is created, and all the masters pets are instantaneously transported to the location of the master.
    ///                 With this upgared version of the basic pet warp nano the master is able to summon the pet even if it is in combat.
    ///                 
    ///         [NanoPrograms/275167 Battle Station Enhanced Pet Warp]; [SummonPetsSpell: [Type=53181 ID=0]]; Trgt=2 Delay=0 Count=1; A=0
    ///             Description:
    ///                 The body of the pet's master becomes a living beacon that can be used to warp the masters pets to his location. Setting up a connection with one of the micro-sats that populate the atmosphere of Rubi-Ka, the master uses this satellite feed to determine the exact location of all his pets. A momentary warp in the fabric of space is created, and all the masters pets are instantaneously transported to the location of the master.
    ///                 You may only summon pets that are not in combat.
    ///                 The item can only be used on the Battle Stations.
    ///     
    ///     Observation:
    ///         According to description, spells with A=0 can only summon pets which are not in combat, 
    ///         while spells with A=1 can summon pets which are in combat.
    /// </remarks>
    [SpellId(53181)]
    public class SummonPetsSpell : Spell
    {
        /// <summary>
        /// Whether to summon pets which are in combat.
        /// </summary>
        [StreamData(0)]
        public bool InCombat { get; set; }
    }
}