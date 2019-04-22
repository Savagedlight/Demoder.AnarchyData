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
    [SpellId(53133)]
    public class SetGovernmentTypeSpell : Spell
    {
        /// <summary>
        /// Government form.
        /// </summary>
        /// <remarks>
        /// 18.04.15:
        /// Only appears in these items
        ///    [Items/81796 Organization government chip - Departmental]; [SetGovernmentTypeSpell: [Type=53133 ID=0]]; Trgt=3 Delay=0 Count=1; A=1
        ///    [Items/83874 Organization government chip - Republic]; [SetGovernmentTypeSpell: [Type=53133 ID=0]]; Trgt=3 Delay=0 Count=1; A=3
        ///    [Items/83876 Organization government chip - Feudalism]; [SetGovernmentTypeSpell: [Type=53133 ID=0]]; Trgt=3 Delay=0 Count=1; A=6
        ///    [Items/83877 Organization government chip - Monarchy]; [SetGovernmentTypeSpell: [Type=53133 ID=0]]; Trgt=3 Delay=0 Count=1; A=4
        ///    
        /// Item descriptions indicate these are to be applied to organizational contracts.
        /// </remarks>
        [StreamData(0)]
        public int Government { get; set; }
    }
}

