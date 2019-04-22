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
    /// Only items with this spell:
    ///     [Items/120802 Random Name Generation Terminal]; [GenerateNameSpell: [Type=53132 ID=0]]; Trgt=2 Delay=0 Count=1; A=John B=Doe C={ 3, 0, 0, 0 }
    ///     [Items/203911 Random Name Generator]; [GenerateNameSpell: [Type=53132 ID=0]]; Trgt=2 Delay=0 Count=1; A=John B=Doe C={ 3, 0, 0, 0 }
    /// </remarks>
    [SpellId(53132)]
    [SpellFormat("Generate name.")]
    public class GenerateNameSpell : Spell
    {
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 18.04.15: Always 'John'
        /// </remarks>
        [StreamData(0)]
        public string FirstName { get; set; }

        /// <summary>
        /// 18.04.15: Always 'Doe'
        /// </summary>
        [StreamData(1)]
        public string LastName { get; set; }

        /// <summary>
        /// 18.04.15: Always 3
        /// </summary>
        [StreamData(2)]
        public int C { get; set; }
    }
}