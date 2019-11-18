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
using Demoder.AnarchyData.Attributes;
using Demoder.Common.Attributes;

namespace Demoder.AnarchyData.Spells
{
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>Related to breed change</remarks>
    [SpellId(53239)]
    [SpellFormat("Change gender: {Gender}.")]
    public class GenderChangeSpell : Spell
    {
        [StreamData(11)]
        public Gender Gender { get; set; }
    }
}
