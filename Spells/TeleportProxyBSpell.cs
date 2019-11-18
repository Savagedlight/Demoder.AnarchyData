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
    /// <remarks>
    /// Casting this nano:
    /// [NanoPrograms/142729]; [TeleportProxyBSpell: [Type=53083 ID=0]]; Trgt=1 Delay=0 Count=1; Playfield=[Type=51102 ID=152] B=0 C=0 D=100001 E=1310872 F=0
    /// 
    /// resulted in this shift+f9:
    /// Extended location information:
    /// - 169.1, 245.6, 3.8 (169.1 245.6 y 3.8 2628824)
    /// - Pf Proxy: Model=51102:152 GS=1 SG=0 R=2628824, resource: 152
    /// - zone: 0, area: "Grid"
    /// Server id: 3108, character id: 50000:1147648203, time: 2012-05-23 16:05:45 (UTC)
    /// Version: 18.4.15_EP1, map id: 18.4.15.2_07.02.2012_15.41.26, build: 49987.
    /// 
    /// Conclusion: 
    /// - First two integers are playfield <seealso cref="T:Demoder.RdbParser.Data.Identity">Identity</seealso>; Where Instance is the playfield ID.
    /// </remarks>
    [SpellId(53083)]
    [SpellFormat("Teleport to {Playfield}.")]
    public class TeleportProxyBSpell : Spell
    {
        /// <summary>
        /// Denotes the object type; in this case, playfield
        /// </summary>
        [StreamData(0)]
        [Hide]
        public uint A { get; set; }

        [StreamData(1)]
        [PlayfieldParameter]
        public uint Playfield { get; set; }

        [StreamData(2)]
        public int B { get; set; }

        [StreamData(3)]
        public int C { get; set; }

        /// <remarks>
        /// Seems to always be 100001 ; which incidentially is a RDB category for playfields.
        /// </remarks>
        [StreamData(4)]
        [Hide]
        public uint D { get; set; }

        [StreamData(5)]
        public uint E { get; set; }

        [StreamData(6)]
        public int F { get; set; }
    }
}