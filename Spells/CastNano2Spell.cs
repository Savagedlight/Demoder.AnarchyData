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
    ///     [Items/291138 Dust Brigade Teleport Beacon]; [CastNano2Spell: [Type=53242 ID=0]]; Trgt=2 Delay=0 Count=1; A=291156
    ///     [Items/291138 Dust Brigade Teleport Beacon]; [CastNano2Spell: [Type=53242 ID=0]]; Trgt=2 Delay=0 Count=1; A=291175
    ///     [Items/291138 Dust Brigade Teleport Beacon]; [CastNano2Spell: [Type=53242 ID=0]]; Trgt=2 Delay=0 Count=1; A=291176
    /// </remarks>
    [SpellId(53242)]
    [SpellFormat("Cast {NanoID}.")]
    public class CastNano2Spell : Spell
    {
        [StreamData(0)]
        [NanoIdParameter]
        public uint NanoID { get; set; }
    }
}
