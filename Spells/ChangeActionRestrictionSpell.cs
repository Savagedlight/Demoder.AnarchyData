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
    [SpellId(53067)]
    public class ChangeActionRestrictionSpell : Spell
    {
        [StreamData(0)]
        public ActionFlag Action { get; set; }

        /*
         * Observation: 
         * Nano: Stationary Surgery Clinic Effect (ID:157490): 0
         * Item: Portable Surgery Clinic (ID:43552): 30
         * Nano: NoNoAttack (ID:242890): -1
         * Nano: BreakOut (ID:227778), Slip Away (ID:227774): 0
         * 
         * Possible pattern:
         * 0: Remove restriction indefinitely (or until parent(nano) expires)
         * -1: Enable restriction indefinitely (or until parent(nano) expires)
         * Anything else: 
         *  Temporarily remove restriction for X seconds
         */

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// if -1: Restrict action indefinitely
        /// if 0: Unrestrict action
        /// if >0: Urestrict action for Duration seconds.
        /// </remarks>
        [StreamData(1)]
        [DurationParameter]
        [Interpolate]
        public int Duration { get; set; }
    }
}