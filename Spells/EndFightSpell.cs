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

/* Generated using Demoder.RdbParser->SpellDebugger on 05.03.2014 00:03:14 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Demoder.AnarchyData;
using Demoder.AnarchyData.Attributes;
using Demoder.Common.Attributes;

namespace Demoder.AnarchyData.Spells
{
   /// <summary>
   /// See item 301160
   /// </summary>
   [SpellId(53253)]
   public class EndFightSpell : Spell
   {
      [StreamData(0)]
      public Target Target  { get; set; }

      [StreamData(1)]
      public EndFightModifier Modifier { get; set; }
   }
}
