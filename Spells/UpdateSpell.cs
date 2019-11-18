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

/* Generated using Demoder.RdbParser->SpellDebugger on 08.08.2012 20:26:33 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Demoder.AnarchyData;
using Demoder.AnarchyData.Attributes;
using Demoder.Common.Attributes;

namespace Demoder.AnarchyData.Spells
{
    /// <summary>
    /// Used to trick the system into accepting the values previously defined by SetSpell.
    /// </summary>
    [SpellId(53189)]
    [SpellFormat("Update {Skill}.")]
    public class UpdateSpell : Spell
    {
        [StreamData(0)]
        public Stat Skill { get; set; }

        /// <summary>
        /// Not actually used
        /// </summary>
        [StreamData(1)]
        public int Amount { get; set; }
    }
}
