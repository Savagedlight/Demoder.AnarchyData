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
    [SpellId(53063)]
    public class SpawnMonsterSpell : Spell
    {
        [StreamData(0)]
        public Hash MonsterHash { get; set; }

        [StreamData(1)]
        public int Quality { get; set; }

        [StreamData(2)]
        [DurationParameter]
        public int Duration { get; set; }

        #region What is this?
        [Hide]
        [StreamData(3)]
        public int D1 { get; set; }

        [Hide]
        [StreamData(4)]
        public int D2 { get; set; }

        [Hide]
        [StreamData(5)]
        public int D3 { get; set; }

        [Hide]
        [StreamData(6)]
        public int D4 { get; set; }

        [Hide]
        [StreamData(7)]
        public int D5 { get; set; }

        [Hide]
        [StreamData(8)]
        public int D6 { get; set; }

        [Hide]
        [StreamData(9)]
        public int D7 { get; set; }
        #endregion
    }
}