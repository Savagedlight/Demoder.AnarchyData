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
    [SpellId(53016)]
    [SpellFormat("Teleport to {Playfield} at {X}x{Z} elevation: {Y}")]
    public class TeleportSpell : Spell
    {
        /// <summary>
        /// 3D X position (Same as X in 2D)
        /// </summary>
        [StreamData(0)]
        public int X { get; set; }

        /// <summary>
        /// 3D Y position (height)
        /// </summary>
        [StreamData(1)]
        [DistanceParameter]
        public int Y { get; set; }

        /// <summary>
        /// 3D Z Position (Same as Y in 2D)
        /// </summary>
        [StreamData(2)]
        public int Z { get; set; }

        [StreamData(3)]
        [PlayfieldParameter]
        public uint Playfield { get; set; }
    }
}
