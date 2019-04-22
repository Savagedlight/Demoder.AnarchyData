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
    /// 18.04.15:
    ///     [Items/285384 Omni-Tek Daily Missions]; [SpawnQuestSpell: [Type=53226 ID=0]]; Trgt=2 Delay=0 Count=1; A=L7T9 B=6 C=0
    ///     [Items/285384 Omni-Tek Daily Missions]; [SpawnQuestSpell: [Type=53226 ID=0]]; Trgt=2 Delay=0 Count=1; A=Z392 B=6 C=0
    ///     [Items/285720 Prisoner Quest First Mission Spawn Item]; [SpawnQuestSpell: [Type=53226 ID=0]]; Trgt=2 Delay=0 Count=1; A=J552 B=9 C=0
    ///     [Items/285720 Prisoner Quest First Mission Spawn Item]; [SpawnQuestSpell: [Type=53226 ID=0]]; Trgt=2 Delay=0 Count=1; A=AHHZ B=9 C=0
    ///     [Items/283783 New Quest]; [SpawnQuestSpell: [Type=53226 ID=0]]; Trgt=2 Delay=0 Count=1; A=6KC2 B=6 C=0
    ///     [Items/291631 The Hunt]; [SpawnQuestSpell: [Type=53226 ID=0]]; Trgt=2 Delay=10 Count=1; A=DEQK B=6 C=0
    ///     [Items/274330 Resolves Mission JV8Z]; [SpawnQuestSpell: [Type=53226 ID=0]]; Trgt=2 Delay=0 Count=1; A=EPCW B=9 C=0
    ///     [Items/274330 Resolves Mission JV8Z]; [SpawnQuestSpell: [Type=53226 ID=0]]; Trgt=2 Delay=0 Count=1; A=EPCW B=9 C=0
    ///     [Items/284221 Lush Evesdropping False COL SPHERE]; [SpawnQuestSpell: [Type=53226 ID=0]]; Trgt=2 Delay=0 Count=1; A=Y63G B=9 C=0
    ///  
    /// All prisoner missions are B=9
    /// </remarks>
    [SpellId(53226)]
    [SpellFormat("Spawn quest {Quest}.")]
    public class SpawnQuestSpell : Spell
    {
        [StreamData(0)]
        public Hash Quest { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 18.04.15: Either 6 or 9.<br/>
        /// </remarks>
        [StreamData(1)]
        public int B { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 18.04.15: Always 0
        /// </remarks>
        [StreamData(2)]
        public int C { get; set; }
    }
}