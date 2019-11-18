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
    ///     [NanoPrograms/284405 PF Racing Nano Nineth]; [PlayfieldNanoSpell: [Type=53228 ID=0]]; Trgt=2 Delay=0 Count=1; A=284406
    ///     [Items/293300 Solve Mission Playfield XSPF]; [PlayfieldNanoSpell: [Type=53228 ID=0]]; Trgt=2 Delay=0 Count=1; A=293303
    ///     [Items/281592 Solve Mission Playfield 8QDR]; [PlayfieldNanoSpell: [Type=53228 ID=0]]; Trgt=2 Delay=0 Count=1; A=281591
    /// </remarks>
    [SpellId(53228)]
    [SpellFormat("Cast {NanoID} on playfield.")]
    public class PlayfieldNanoSpell : Spell
    {
        /// <summary>
        /// 
        /// </summary>
        [StreamData(0)]
        [NanoIdParameter]
        public uint NanoID { get; set; }
    }
}