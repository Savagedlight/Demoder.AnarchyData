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
    /// this item:
    ///  [Items/223762]; [TeleportProxyASpell: [Type=53082 ID=0]]; Trgt=2 Delay=0 Count=1; A=51102 B=4313 C=0 D=3221229473 E=100001 F=69849
    /// 
    /// resulted in character being moved to following location:
    /// Extended location information:
    /// - 421.6, 335.4, 76.7 (421.6 335.4 y 76.7 2629228)
    /// - Pf Proxy: Model=51102:4313 GS=1 SG=3221229473 R=2629228, resource: 4313
    /// - zone: 170, area: "Nascense Training Grounds"
    /// Server id: 3121, character id: 50000:2852714021, time: 2012-05-23 15:30:36 (UTC)
    /// Version: 18.4.15_EP1, map id: 18.4.15.2_07.02.2012_15.41.26, build: 49987.
    /// 
    /// Observations
    /// - A and B match PF Proxy Model (51102:4313)
    /// - D match SG (3221229473)
    /// - E match playfields RDB category (100001)
    /// 
    /// Conclusion:
    /// - A+B = Identity
    /// - D=SG (whatever that is..)
    /// - E+F might be identity of playfield resource, but no RDB record of type 100001:69849 exists.
    /// 
    /// </remarks>
    [SpellId(53082)]
    [SpellFormat("Teleport to {Playfield}, subgroup {SG}.")]
    public class TeleportProxyASpell : Spell
    {
        /// <summary>
        /// Denotes the object type; in this case, playfield
        /// </summary>
        [StreamData(0)]
        [Hide]
        public uint A { get; set; }

        [StreamData(1)]
        public uint Playfield { get; set; }
        
        [StreamData(2)]
        public int C { get; set; }

        [StreamData(3)]
        public uint SG { get; set; }

        /// <remarks>
        /// Seems to always be 100001, which incidentially is a RDB category describing playfields.
        /// </remarks>
        [StreamData(4)]
        public uint E { get; set; }

        [StreamData(5)]
        public uint F { get; set; }
    }
}