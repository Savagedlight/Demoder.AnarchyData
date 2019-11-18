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
    [SpellId(53057)]
    [SpellFormat("Float text: {Text}")]
    public class HeadTextSpell : Spell
    {
        [StreamData(0)]
        public string Text { get; set; }

        /// <summary>
        /// There seems to be 13 colours, where only 8 are being used.
        /// 
        /// 1: items 208516 and 285741
        /// 2 (Aggression Enhancer): Blue
        /// 3 (Book: On Item Creations): Egg white
        /// 4: Items 208527
        /// 5 (Flurry of Blows): Yellow/gold
        /// 9: Items 294702 294892
        /// 12: Items 46237 46238 46239 46240 46241 46242 46243 46244 46245
        ///           46245 46246 46247 46248 46248 46249 270362 270362 
        ///           270362 270362 270362 270362 270362 294918
        /// 13: Items 273041 273057 273229 274218 284508
        ///           46225 46226 46227 46228 46229 46230
        /// 
        /// </summary>
        [StreamData(1)]
        public int Color { get; set; }
    }
}