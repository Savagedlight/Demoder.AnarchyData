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
    [SpellId(53068)]
    public class RestrictActionSpell : Spell
    {
        [StreamData(0)]
        public ActionFlag Action { get; set; }

        /* 
         * 18.04.15
         * Observation:
         * Nano: NoNoAttack (ID:242890): -1 (Fighting) (This nano prevents people from attacking whatever this is running on)
         * Nano: Phasefront Phantom - The Jubilee Bunny (ID:288812): 0 (This prevents whomever it is running on from attacking)
         * Item: Ganumedes Personal Jetpack (ID: 289989): 0
         * 
         * Pattern:
         * If B is -1, immunity against.
         * If B is 0: Disallow
         * If B is > 0: Unknown.
         */
        [StreamData(1)]
        public int B { get; set; }

    }
}