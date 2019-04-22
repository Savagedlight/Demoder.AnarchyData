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
using Demoder.Common;

namespace Demoder.AnarchyData
{
    public static class Utility
    {
        public static string ItemSlotString(ItemClass equipmentPage, BitFlag flags)
        {
            switch (equipmentPage)
            {
                case ItemClass.Weapon:
                    return ((WeaponSlot)flags).ToString();
                case ItemClass.Armor:
                    return ((ArmorSlot)flags).ToString();
                case ItemClass.Implant:
                case ItemClass.Spirit:
                    return ((ImplantSlot)flags).ToString();
                default:
                    return flags.ToString();
            }
        }

        public static string ItemSlotString(TemplateGuessedType equipmentPage, BitFlag flags)
        {
            switch (equipmentPage)
            {
                case TemplateGuessedType.Weapon:
                case TemplateGuessedType.Utility:
                    return ((WeaponSlot)flags).ToString();
                case TemplateGuessedType.Armor:
                    return ((ArmorSlot)flags).ToString();
                case TemplateGuessedType.Implant:
                case TemplateGuessedType.Spirit:
                    return ((ImplantSlot)flags).ToString();
                default:
                    return flags.ToString();
            }
        }

        public static string ItemSlotPosString(TemplateGuessedType equipmentPage, BitFlag val)
        {
            switch (equipmentPage)
            {
                case TemplateGuessedType.Weapon:
                case TemplateGuessedType.Utility:
                    return ((WeaponSlotPosition)val).ToString();
                case TemplateGuessedType.Armor:
                    return ((ArmorSlotPosition)val).ToString();
                case TemplateGuessedType.Implant:
                case TemplateGuessedType.Spirit:
                    return ((ImplantSlotPosition)val).ToString();
                default:
                    return val.ToString();
            }
        }
    }
}
