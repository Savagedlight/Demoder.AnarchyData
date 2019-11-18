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
    /// 15.04.15:
    ///     Some items with this spell:
    ///         [NanoPrograms/280162 Orbital Strike Root Protection]; [ResistNanoStrainSpell: [Type=53162 ID=0]]; Trgt=2 Delay=0 Count=1; A=146 B=100
    ///         [NanoPrograms/280162 Orbital Strike Root Protection]; [ResistNanoStrainSpell: [Type=53162 ID=0]]; Trgt=2 Delay=0 Count=1; A=147 B=100
    ///         [NanoPrograms/280162 Orbital Strike Root Protection]; [ResistNanoStrainSpell: [Type=53162 ID=0]]; Trgt=2 Delay=0 Count=1; A=705 B=100
    ///         [NanoPrograms/280162 Orbital Strike Root Protection]; [ResistNanoStrainSpell: [Type=53162 ID=0]]; Trgt=2 Delay=0 Count=1; A=707 B=100
    ///         [NanoPrograms/280162 Orbital Strike Root Protection]; [ResistNanoStrainSpell: [Type=53162 ID=0]]; Trgt=2 Delay=0 Count=1; A=833 B=100
    ///         [NanoPrograms/280162 Orbital Strike Root Protection]; [ResistNanoStrainSpell: [Type=53162 ID=0]]; Trgt=2 Delay=0 Count=1; A=834 B=100
    ///         [NanoPrograms/280162 Orbital Strike Root Protection]; [ResistNanoStrainSpell: [Type=53162 ID=0]]; Trgt=2 Delay=0 Count=1; A=679 B=100
    ///         [NanoPrograms/280162 Orbital Strike Root Protection]; [ResistNanoStrainSpell: [Type=53162 ID=0]]; Trgt=2 Delay=0 Count=1; A=891 B=100
    ///         [NanoPrograms/280162 Orbital Strike Root Protection]; [ResistNanoStrainSpell: [Type=53162 ID=0]]; Trgt=2 Delay=0 Count=1; A=892 B=100
    ///   
    ///     Conclusion:
    ///         A=nanostrain, B=percent resistance
    /// </remarks>
    [SpellId(53162)]
    [SpellFormat("Resist {NanoStrain} {|right|}{Resistance}{|/right|}")]
    public class ResistNanoStrainSpell : Spell
    {
        [StreamData(0)]
        [Parameter(SpellParameterType.NanoStrain)]
        public uint NanoStrain { get; set; }

        [StreamData(1)]
        [Interpolate]
        [PercentParameter]
        public int Resistance { get; set; }
    }
}