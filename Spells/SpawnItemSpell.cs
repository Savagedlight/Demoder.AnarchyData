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
    [SpellId(53064)]
    public class SpawnItemSpell : Spell
    {
        [StreamData(0)]
        public Hash Item { get; set; }

        [StreamData(1)]
        [Interpolate]
        public uint Quality { get; set; }

        [StreamData(2)]
        public int C { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        ///  * -1: 278623 278623<br/>
        /// 0: 281458 281591<br/>
        /// 7200: 245411 245410 245407<br/>
        /// 400: 245411 245410 245407<br/>
        /// <br/>
        /// On items which have both 7200 and 400 (in two separate spells),<br/>
        /// the two separate spells also test which instance the player is in.<br/>
        /// This means it might be a item modifier of some sort... but what does it do?<br/>
        /// <br/>
        /// Jaydes tool says this is how long the item will exist.<br/>
        /// </remarks>
        [StreamData(3)]
        [Interpolate]
        [DurationParameter(1)]
        public int Duration { get; set; }
        
        [StreamData(4)]
        public int E { get; set; }

        [StreamData(5)]
        public int F1 { get; set; }

        [StreamData(6)]
        public int F2 { get; set; }

        [StreamData(7)]
        public int F3 { get; set; }
    }
}