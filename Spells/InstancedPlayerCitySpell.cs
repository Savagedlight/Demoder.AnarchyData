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
    /// Version: 18.01.00.00
    /// </summary>
    /// <remarks>
    /// 18.04.15:
    ///     [Items/281586 Organization City Door]; [InstancedPlayerCitySpell: [Type=53233 ID=0]]; Trgt=1 Delay=0 Count=1; A={ 51102, 6010, 0, 0, 100001, 71546, 0 }
    ///     
    /// Entering a instanced city produced the following Shift+F9 output:
    ///     Extended location information:
    ///     - 1090.8, 1475.9, 5.6 (1090.8 1475.9 y 5.6 2629295)
    ///     - Pf Proxy: Model=51102:6010 GS=0 SG=8159233 R=2629295, resource: 6010
    ///     - zone: 2187, area: "Serenity Islands"
    ///     Server id: 3118, character id: 50000:1147648203, time: 2012-05-24 17:24:52 (UTC)
    ///     Version: 18.4.15_EP1, map id: 18.4.15.2_07.02.2012_15.41.26, build: 49987.
    ///     
    /// Note how Pf Proxy: Model=51102:6012 is identical to two first parameters.
    /// 
    /// </remarks>
    [SpellId(53233)]
    public class InstancedPlayerCitySpell : Spell
    {
        [StreamData(0)]
        public uint PlayfieldA { get; set; }

        [StreamData(1)]
        public uint PlayfieldB { get; set; }

        [StreamData(2)]
        public uint B { get; set; }

        [StreamData(3)]
        public uint C { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 18.04.15: 100001 (Same as ID of RDB category with playfield info)
        /// </remarks>
        [StreamData(4)]
        public uint D { get; set; }

        [StreamData(5)]
        public uint E { get; set; }

        [StreamData(6)]
        public uint F { get; set; }

    }
}
