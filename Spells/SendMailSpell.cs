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

/* Generated using Demoder.RdbParser->SpellDebugger on 31.01.2014 21:10:38 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Demoder.AnarchyData;
using Demoder.AnarchyData.Attributes;
using Demoder.Common.Attributes;

namespace Demoder.AnarchyData.Spells
{
    [SpellId(53252)]
    [SpellFormat("Send mail.")]
    public class SendMailSpell : Spell
    {
        [StreamData(0)]
        public string Auto0 { get; set; }

        [StreamData(1)]
        public string Auto1 { get; set; }

        [StreamData(2)]
        public string Auto2 { get; set; }

        [StreamData(3)]
        public Hash Auto3 { get; set; }

        [StreamData(4)]
        public int Auto4 { get; set; }

        [StreamData(5)]
        public int Auto5 { get; set; }

        [StreamData(6)]
        public int Auto6 { get; set; }

    }
}
