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
    ///     [Items/293236 Augmented Subturbine]; [AddOffensiveProcSpell: [Type=53227 ID=0]]; Trgt=2 Delay=0 Count=1; A=5 B=293234
    ///     [NanoPrograms/285696 Droid Damage Matrix]; [AddOffensiveProcSpell: [Type=53227 ID=0]]; Trgt=3 Delay=0 Count=1; A=5 B=267915
    ///     [NanoPrograms/285340 Touch of Death]; [AddOffensiveProcSpell: [Type=53227 ID=0]]; Trgt=1 Delay=0 Count=1; A=50 B=285341
    /// 
    /// Same layout as DefensiveProcSpell.
    /// </remarks>
    [SpellId(53227)]
    [SpellFormat("Add offensive proc {Proc},  {Chance} trigger chance.")]
    public class AddOffensiveProcSpell : Spell
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