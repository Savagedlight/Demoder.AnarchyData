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
    [Serializable]
    public class Criterion
    {
        /// <summary>
        /// This is Stat enum for Operator.Stat*, but other things for other operators.
        /// </summary>
        [StreamData(100)]
        public int Value1 { get; set; }

        /// <summary>
        /// This is the amount of skill for Operator.Stat*, but other things for other operators.
        /// </summary>
        [StreamData(200)]
        public int Value2 { get; set; }

        [StreamData(300)]
        public Operator Operator { get; set; }

        public override string ToString()
        {
            return String.Format("{0} {1} {2}", this.Value1, this.Value2, this.Operator);
        }
    }
}
