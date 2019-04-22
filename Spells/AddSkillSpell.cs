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
    /*
     * This is apparently related to skill locks.
     * 
     */
    [SpellId(53028)]
    public class AddSkillSpell : Spell
    {
        /// <summary>
        /// Todo: Figure out what this does. Suspicion: This describes what is done with the skill.
        /// This is always 3, except for item 248209 which also has C=500
        /// </summary>
        [StreamData(0)]
        public int Amount { get; set; }

        /// <summary>
        /// Which skill is added
        /// </summary>
        [StreamData(1)]
        public Stat Skill { get; set; }

        /// <summary>
        /// Todo: Figure out what this actually does... Seems to mostly vary between 0 and 1, but some are 500 and 1200 as well.
        /// </summary>
        [StreamData(2)]
        public int C { get; set; }

    }
}