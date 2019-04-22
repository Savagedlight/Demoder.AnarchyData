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
    /// Version: 18.04.06.00
    /// </summary>
    /// <remarks>
    /// 18.05.00.02:
    ///     [Items/293877 Vizaresh Spawn Announcer]; [GlobalTextSpell: [Type=53244 ID=0]]; Trgt=2 Delay=0 Count=1; A=Vizaresh has appeared in Pandemonium - The Gauntlet will be opened soon! B=0 C=0 D=0 E=1
    ///     [NanoPrograms/290288 Control Center]; [GlobalTextSpell: [Type=53244 ID=0]]; Trgt=2 Delay=0 Count=1; A=The Desert Rider has arrived! Hurry to coordinates X: 2232 Z:1586 in Newland Desert. You should use the whompah. B=0 C=0 D=0 E=1
    /// </remarks>
    [SpellId(53244)]
    [SpellFormat("Global message: {Message}")]
    public class GlobalTextSpell : Spell
    {
        [StreamData(0)]
        public string Message { get; set; }

        [StreamData(1)]
        public int B { get; set; }

        [StreamData(2)]
        public int C { get; set; }

        [StreamData(3)]
        public int D { get; set; }

        [StreamData(4)]
        public int E { get; set; }
    }
}
