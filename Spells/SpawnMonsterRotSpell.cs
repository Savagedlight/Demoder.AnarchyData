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
    [SpellId(53192)]
    [SpellFormat("Spawn QL {Quality} corpse {Monster}.")]
    public class SpawnMonsterRotSpell : Spell
    {
        [StreamData(0)]
        public Hash Monster { get; set; }

        [StreamData(1)]
        public int Quality { get; set; }

        [StreamData(2)]
        public int B1 { get; set; }

        [StreamData(3)]
        public int B2 { get; set; }

        [StreamData(4)]
        public int B3 { get; set; }

        [StreamData(5)]
        public int B4 { get; set; }

        [StreamData(6)]
        public int B5 { get; set; }

        [StreamData(7)]
        public int B6 { get; set; }

        [StreamData(8)]
        public int B7 { get; set; }

        [StreamData(9)]
        public int B8 { get; set; }

        [StreamData(10)]
        public int B9 { get; set; }
    }
}