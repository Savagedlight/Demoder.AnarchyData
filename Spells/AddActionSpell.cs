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
    /// Will add a (perk) action to user.
    /// </summary>
    /// <remarks>
    /// 18.04.15:
    ///     Some items with this spell:<br />
    ///         [Items/262153 Hostile Takeover]; [AddActionSpell: [Type=53182 ID=0]]; Trgt=2 Delay=0 Count=1; A=12994 B=ECPR C=1 D=266064
    ///         [NanoPrograms/230416 Bane of the Challenger]; [AddActionSpell: [Type=53182 ID=0]]; Trgt=2 Delay=0 Count=1; A=20007 B=BTOH C=1 D=230415
    ///         [Items/283678 Hit and Run]; [AddActionSpell: [Type=53182 ID=0]]; Trgt=2 Delay=0 Count=1; A=10931 B=TGHA C=1 D=283665
    /// </remarks>
    [SpellId(53182)]
    [SpellFormat("Add action: {UseItem}.")]
    public class AddActionSpell : Spell
    {
        [StreamData(0, ReadType=typeof(uint))]
        [Hide]
        public int A { get; set; }

        /// <summary>
        /// Hash of item to use?
        /// </summary>
        /// <remarks>
        /// Trigger Happy // TGHA - May be a coincidence.
        /// </remarks>
        [StreamData(1)]
        public Hash B { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks><![CDATA[
        /// 18.04.15:
        ///     Always set to 1
        /// ]]></remarks>
        [StreamData(2)]
        [Hide]
        public int C { get; set; }

        /// <summary>
        /// ID of item to use for this action
        /// </summary>
        [StreamData(3)]
        [ItemIdParameter]
        public uint UseItem { get; set; }
    }
}