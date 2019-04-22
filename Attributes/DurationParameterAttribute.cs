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
using System.Globalization;
using System.Linq;
using System.Text;

namespace Demoder.AnarchyData.Attributes
{
    /// <summary>
    /// Applied to integers which represent a duration in seconds.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class DurationParameterAttribute : ParameterAttribute
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="multiplier">Apply this multiplier to value to get seconds.</param>
        /// <example>
        /// If value is 105, this will represent 1.05 seconds.
        /// <code>
        /// [DurationParameter(0.01)]
        /// public int Duration {get; set; }
        /// </code>
        /// </example>
        public DurationParameterAttribute(double multiplier=1)
            : base(SpellParameterType.Duration, multiplier.ToString(CultureInfo.InvariantCulture))
        {
        }
    }
}
