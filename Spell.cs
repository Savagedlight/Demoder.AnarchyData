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
using System.Reflection;
using Demoder.Common.Attributes;
using Demoder.Common.Serialization;
using Demoder.Common;
using Demoder.AnarchyData.Attributes;
using Demoder.Common.Extensions;

namespace Demoder.AnarchyData
{
    /// <summary>
    /// Type is generally refered to as spell ID in other RDB parsers.
    /// Instance seems to always be 0
    /// </summary>
    [Serializable]
    public class Spell : Base
    {
        #region Header info
        /*
         * Observation:
         * Up to and including 18.4.15, spells have all changed versions at the same time.
         * Here's a list of the first client version that a spell version was observed:
         * 1: 
         * 2: 
         * 3: 
         * 4: 17.01.01
         */
        /// <summary>
        /// Spell version
        /// </summary>
        public uint Version { get; set; }

        /// <summary>
        /// Metadata stored from spell definitions.
        /// </summary>
        public Version Patch { get; set; }
        #endregion

        /// <summary>
        /// Requirements for the spell (if any)
        /// </summary>
        public Criterion[] Criteria { get; set; }

        #region Activation info
        /// <summary>
        /// The target in which this function is applied to. TODO: Convert to enum
        /// </summary>
        public Target Target { get; set; }

        /// <summary>
        /// How many times this function occurs on the target
        /// </summary>
        public int TickCount { get; set; }

        /// <summary>
        /// Interval between ticks in milliseconds
        /// </summary>
        public int TickInterval { get; set; }
        #endregion

        /*
         * 18.04.15
         * Is 9 for everything except FearSpell and StunSpell.
         * These two spells have varying numbers here.
         * 
         */
        public int Unknown2 { get; set; }

        public override string ToString()
        {
            return this.Identity.ToString();
        }
    }
}

