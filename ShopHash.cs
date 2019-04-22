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

namespace Demoder.AnarchyData
{
    public class ShopHashEntry
    {
        /// <summary>
        /// Cluster to spawn
        /// </summary>
        public Hash Hash { get; set; }
        /// <summary>
        /// Minimum level of item
        /// </summary>
        public short MinLevel { get; set; }
        /// <summary>
        /// Maximum level of item
        /// </summary>
        public short MaxLevel { get; set; }
        /// <summary>
        /// Number of items
        /// </summary>
        public short Count { get; set; }

        public byte[] Unknown { get; set; }

        /// <summary>
        /// Price/Cost modifier (percent?)
        /// </summary>
        /// <remarks>
        /// Was tagged as cost modifier, but as of 2013-02-19, it's tagged as SpawnChance.
        /// This because shop booths have a custom stat for CostModifier, and most items have a value of 100 here.
        /// </remarks>
        public int SpawnChance { get; set; }
    }
}
