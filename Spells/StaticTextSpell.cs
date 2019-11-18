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
    //18.5.0 --demoder
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// 18.05.00.02
    /// 3 example item entries. They're not in XMLDoc because of incompatible tags.
    /*
    ///     [NanoPrograms/292483 Pet Program Mission Reminder]; [S_53247: [Type=53247 ID=0]]; Trgt=2 Delay=300 Count=1; A=<img src=tdb://id:GFX_GUI_CONTROLCENTER_TARGET_ICON_SELF><font color='blue'>You can command the pet to hunt for you (/hunt)</font> B=0
    ///     [NanoPrograms/292330 Weapon Mission Reminder]; [S_53247: [Type=53247 ID=0]]; Trgt=2 Delay=0 Count=1; A=<img src=tdb://id:GFX_GUI_CONTROLCENTER_TARGET_ICON_SELF><font color='blue'>Open the wear window (CTRL+1).</font> B=0
    ///     [NanoPrograms/292330 Weapon Mission Reminder]; [S_53247: [Type=53247 ID=0]]; Trgt=2 Delay=100 Count=1; A=<img src=tdb://id:GFX_GUI_CONTROLCENTER_TARGET_ICON_SELF><font color='blue'>Pick up the weapon in your inventory and place it in the Right Hand slot under "Weapons".</font> B=0
    */
    /// </remarks>
    [SpellId(53247)]
    [SpellFormat("{Text}")]
    public class StaticTextSpell : Spell
    {
        [StreamData(0)]
        public string Text { get; set; }

        [StreamData(1)]
        public int B { get; set; }
    }
}
