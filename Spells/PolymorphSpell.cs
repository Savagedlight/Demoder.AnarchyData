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
    /// 18.04.15
    /// Items with this spell:
    ///     [Items/215350 Blackstep]; [PolymorphAttackSpell: [Type=53193 ID=0]]; Trgt=2 Delay=0 Count=1; A=208395 B=208398
    ///     [Items/215351 Obscure Vision]; [PolymorphAttackSpell: [Type=53193 ID=0]]; Trgt=2 Delay=0 Count=1; A=208657 B=208671
    ///     [Items/215352 Gather Darkness]; [PolymorphAttackSpell: [Type=53193 ID=0]]; Trgt=2 Delay=0 Count=1; A=208814 B=208827
    ///     [Items/215353 Lightstep]; [PolymorphAttackSpell: [Type=53193 ID=0]]; Trgt=2 Delay=0 Count=1; A=214000 B=214009
    ///     [Items/215354 Gather Light]; [PolymorphAttackSpell: [Type=53193 ID=0]]; Trgt=2 Delay=0 Count=1; A=213986 B=214022
    ///     [Items/215355 Rain of Light]; [PolymorphAttackSpell: [Type=53193 ID=0]]; Trgt=2 Delay=0 Count=1; A=214089 B=214109
    ///     [Items/215356 Blackfist]; [PolymorphAttackSpell: [Type=53193 ID=0]]; Trgt=2 Delay=0 Count=1; A=208395 B=208398
    ///     [Items/215357 Slam of Darkness]; [PolymorphAttackSpell: [Type=53193 ID=0]]; Trgt=2 Delay=0 Count=1; A=208657 B=208671
    ///     [Items/215358 Scream of Death]; [PolymorphAttackSpell: [Type=53193 ID=0]]; Trgt=2 Delay=0 Count=1; A=208814 B=208827
    ///     [Items/215359 Screen of light]; [PolymorphAttackSpell: [Type=53193 ID=0]]; Trgt=2 Delay=0 Count=1; A=214000 B=214009
    ///     [Items/215360 Shield of Light]; [PolymorphAttackSpell: [Type=53193 ID=0]]; Trgt=2 Delay=0 Count=1; A=213986 B=214022
    ///     [Items/215361 Fortress of Light]; [PolymorphAttackSpell: [Type=53193 ID=0]]; Trgt=2 Delay=0 Count=1; A=214089 B=214109
    ///     [Items/215362 Path of Darkness]; [PolymorphAttackSpell: [Type=53193 ID=0]]; Trgt=2 Delay=0 Count=1; A=208395 B=208398
    ///     [Items/215363 Road to Darkness]; [PolymorphAttackSpell: [Type=53193 ID=0]]; Trgt=2 Delay=0 Count=1; A=208657 B=208671
    ///     [Items/215364 The Choice]; [PolymorphAttackSpell: [Type=53193 ID=0]]; Trgt=2 Delay=0 Count=1; A=208814 B=208827
    ///     [Items/215365 Path of Light]; [PolymorphAttackSpell: [Type=53193 ID=0]]; Trgt=2 Delay=0 Count=1; A=214000 B=214009
    ///     [Items/215366 Tunnel of Light]; [PolymorphAttackSpell: [Type=53193 ID=0]]; Trgt=2 Delay=0 Count=1; A=213986 B=214022
    ///     [Items/215367 The Choice]; [PolymorphAttackSpell: [Type=53193 ID=0]]; Trgt=2 Delay=0 Count=1; A=214089 B=214109
    ///     [Items/215368 Silence]; [PolymorphAttackSpell: [Type=53193 ID=0]]; Trgt=2 Delay=0 Count=1; A=208395 B=208398
    ///     [Items/215369 Misery]; [PolymorphAttackSpell: [Type=53193 ID=0]]; Trgt=2 Delay=0 Count=1; A=208657 B=208671
    ///     [Items/215370 Death]; [PolymorphAttackSpell: [Type=53193 ID=0]]; Trgt=2 Delay=0 Count=1; A=208814 B=208827
    ///     [Items/215371 Morning]; [PolymorphAttackSpell: [Type=53193 ID=0]]; Trgt=2 Delay=0 Count=1; A=214000 B=214009
    ///     [Items/215372 Hope]; [PolymorphAttackSpell: [Type=53193 ID=0]]; Trgt=2 Delay=0 Count=1; A=213986 B=214022
    ///     [Items/215373 Life]; [PolymorphAttackSpell: [Type=53193 ID=0]]; Trgt=2 Delay=0 Count=1; A=214089 B=214109
    ///     [Items/239346 Blackstep]; [PolymorphAttackSpell: [Type=53193 ID=0]]; Trgt=2 Delay=0 Count=1; A=208395 B=208398
    ///     [Items/239347 Gather Light]; [PolymorphAttackSpell: [Type=53193 ID=0]]; Trgt=2 Delay=0 Count=1; A=213986 B=214022
    ///     [Items/239348 Obscure Vision]; [PolymorphAttackSpell: [Type=53193 ID=0]]; Trgt=2 Delay=0 Count=1; A=208657 B=208671
    ///     [Items/239349 Silence]; [PolymorphAttackSpell: [Type=53193 ID=0]]; Trgt=2 Delay=0 Count=1; A=208395 B=208398
    ///     [Items/239350 Morning]; [PolymorphAttackSpell: [Type=53193 ID=0]]; Trgt=2 Delay=0 Count=1; A=21400 B=21409
    ///     [Items/239351 Misery]; [PolymorphAttackSpell: [Type=53193 ID=0]]; Trgt=2 Delay=0 Count=1; A=208657 B=208671
    ///     [Items/239352 Path of Darkness]; [PolymorphAttackSpell: [Type=53193 ID=0]]; Trgt=2 Delay=0 Count=1; A=208395 B=208398
    ///     [Items/239353 Path of Light]; [PolymorphAttackSpell: [Type=53193 ID=0]]; Trgt=2 Delay=0 Count=1; A=214000 B=214009
    ///     [Items/239354 Road to Darkness]; [PolymorphAttackSpell: [Type=53193 ID=0]]; Trgt=2 Delay=0 Count=1; A=208657 B=208671
    ///     [Items/239355 Blackfist]; [PolymorphAttackSpell: [Type=53193 ID=0]]; Trgt=2 Delay=0 Count=1; A=208395 B=208398
    ///     [Items/239356 Screen of light]; [PolymorphAttackSpell: [Type=53193 ID=0]]; Trgt=2 Delay=0 Count=1; A=214000 B=214009
    ///     [Items/239357 Slam of Darkness]; [PolymorphAttackSpell: [Type=53193 ID=0]]; Trgt=2 Delay=0 Count=1; A=208657 B=208671
    ///     [Items/281199 Brute's Signet of The Apocalypse]; [PolymorphAttackSpell: [Type=53193 ID=0]]; Trgt=2 Delay=0 Count=1; A=210952 B=210968
    ///     [NanoPrograms/215340 Obscure Vision]; [PolymorphAttackSpell: [Type=53193 ID=0]]; Trgt=2 Delay=0 Count=1; A=208657 B=208671
    ///     [NanoPrograms/280867 Crystal Boss Shape Changer]; [PolymorphAttackSpell: [Type=53193 ID=0]]; Trgt=2 Delay=0 Count=1; A=208657 B=208671
    /// </remarks>
    [SpellId(53193)]
    public class PolymorphSpell : Spell
    {
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 18.04.15
        /// Always a valid instance of RDB category 
        /// 1000046 (unknown; seems to be 16 bytes of data per entry) or
        /// 1000047 (unknown; seems to be 16 bytes of data per entry)
        /// 
        /// Only item which had an entry matching category 1000046:
        ///     [Type=1000020 ID=239350]; A=1000046 B=1010004
        /// This item was also the only 'outsider' for B.
        /// </remarks>
        [StreamData(0)]
        public uint A { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 18.04.15
        /// Always a valid instance of RDB category 1010003 (Bip01A) or 1010004 (Textures)
        /// Only item with an entry matching category 1010004:
        ///     [Type=1000020 ID=239350]; A=1000046 B=1010004
        /// This item was also the only 'outsider' for A.
        /// 
        /// Bip01 seems to be a format for storing models or bones.
        /// </remarks>
        [StreamData(1)]
        public uint Model { get; set; }
    }
}