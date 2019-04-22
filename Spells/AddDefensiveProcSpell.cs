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
    /// 18.04.15
    ///     [Items/289306 Engelen's Ring of Damage]; [AddDefProcSpell: [Type=53224 ID=0]]; Trgt=2 Delay=0 Count=1; A=2 B=267675
    ///     [Items/289307 Engelen's Ring of Damage]; [AddDefProcSpell: [Type=53224 ID=0]]; Trgt=2 Delay=0 Count=1; A=2 B=267675
    ///     [Items/289296 Jayde's Odyssey ring]; [AddDefProcSpell: [Type=53224 ID=0]]; Trgt=2 Delay=0 Count=1; A=2 B=267782
    ///     [NanoPrograms/275242 Shade's Caress]; [AddDefProcSpell: [Type=53224 ID=0]]; Trgt=3 Delay=0 Count=1; A=100 B=275243
    ///     
    /// B is always a valid nano ID; Thus, A must be the chance for the proc to trigger.
    /// </remarks>
    [SpellId(53224)]
    [SpellFormat("Add defensive proc {Proc}, {Chance} trigger chance.")]
    public class AddDefensiveProcSpell : Spell
    {

        [StreamData(0)]
        // Not sure
        [Interpolate]
        [PercentParameter]
        public int Chance { get; set; }

        [StreamData(1)]
        [NanoIdParameter]
        public uint Proc { get; set; }
    }
}