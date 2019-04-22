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
    /// Version: 17.09.00.00
    /// </summary>
    /// <remarks>
    /// No items seem to be using this in 18.04.15
    /// </remarks>
    [SpellId(53213)]
    [SpellFormat("Control hate.")]
    public class ControlHateSpell : Spell
    {
        [StreamData(0)]
        [Hide]
        public int A { get; set; }

        [StreamData(1)]
        [Hide]
        public int B { get; set; }

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
    }
}