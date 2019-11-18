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
    ///     [Items/283669 Trigger Happy]; [LockPerkSpell: [Type=53187 ID=0]]; Trgt=2 Delay=0 Count=1; A=3 B=931 C=60
    ///     [Items/283669 Trigger Happy]; [LockPerkSpell: [Type=53187 ID=0]]; Trgt=2 Delay=0 Count=1; A=3 B=931 C=30
    ///     
    /// </remarks>
    [SpellId(53187)]
    [SpellFormat("Lock perk {PerkID} for {Duration}.")]
    public class LockPerkSpell : Spell
    {
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 18.04.15: Is 3 for all item/nano entries.
        /// </remarks>
        [StreamData(0)]
        [Hide]
        public int A { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 18.04.15
        ///     Always a valid perk ID (RdbCat 1000036), except for this item:
        ///         [Items/212912 Shatter Psyche]; [LockPerkSpell: [Type=53187 ID=0]]; Trgt=2 Delay=0 Count=1; A=3 B=626 C=10
        /// </remarks>
        [StreamData(1)]
        [PerkIdParameter]
        public uint PerkID { get; set; }

        [StreamData(2)]
        [DurationParameter]
        public int Duration { get; set; }
    }
}