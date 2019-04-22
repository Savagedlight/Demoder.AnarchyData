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
using Demoder.Common; 

namespace Demoder.AnarchyData.Spells
{
    /// <summary>
    /// Version: 18.01.00.00
    /// </summary>
    /// <remarks>
    /// 18.04.15
    ///     [Items/281588 Private City Guest Key Generator]; [CreateCityGuestKeySpell: [Type=53235 ID=0]]; Trgt=2 Delay=0 Count=1; A=100001 B=71546 C=-1073544561
    /// </remarks>
    [SpellId(53235)]
    [SpellFormat("Create city guest key for {Playfield}.")]
    public class CreateCityGuestKeySpell : Spell
    {
        [StreamData(0)]
        [Hide]
        public int RdbType { get; set; }

        [StreamData(1)]
        [PlayfieldParameter]
        public uint Playfield { get; set; }

        /// <summary>
        /// Might be flags.
        /// </summary>
        [StreamData(2)]
        [Hide]
        public BitFlag Flags { get; set; }
    }
}