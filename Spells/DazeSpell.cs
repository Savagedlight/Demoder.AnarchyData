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
    /// 18.04.15:
    ///     Only item with this spell is from v11:
    ///     [NanoPrograms/95753 Daze Spell Test]; [Daze: [Type=53128 ID=0]]; Trgt=3 Delay=0 Count=1;
    ///     
    /// TODO: Check if anyone knows what this does.
    /// </remarks>
    [SpellId(53128)]
    [SpellFormat("Daze.")]
    public class DazeSpell : Spell
    {
    }
}