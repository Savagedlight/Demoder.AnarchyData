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
    /// 18.14.15:
    ///    Items with this spell:
    ///    [Items/281160 Orbital Apartment Door]; [CreateApartmentSpell: [Type=53137 ID=0]]; Trgt=1 Delay=0 Count=1; A=6001
    ///    [Items/118262 New Citizens Omni-Tek Apartment Complex]; [CreateApartmentSpell: [Type=53137 ID=0]]; Trgt=1 Delay=0 Count=1; A=1406
    ///    [Items/118263 New Citizen Neutral Apartment Complex]; [CreateApartmentSpell: [Type=53137 ID=0]]; Trgt=1 Delay=0 Count=1; A=1407
    ///    [Items/118264 New Clan Citizens Apartment Complex]; [CreateApartmentSpell: [Type=53137 ID=0]]; Trgt=1 Delay=0 Count=1; A=1405
    ///    [Items/225624 Jobe Apartment Door]; [CreateApartmentSpell: [Type=53137 ID=0]]; Trgt=1 Delay=0 Count=1; A=4327
    ///    [Items/225625 Jobe Luxury Apartment Door]; [CreateApartmentSpell: [Type=53137 ID=0]]; Trgt=1 Delay=0 Count=1; A=4534
    /// </remarks>
    [SpellId(53137)]
    [SpellFormat("Create apartment in {Playfield}.")]
    public class CreateApartmentSpell : Spell
    {
        /// <summary>
        /// Playfield ID of the apartment.
        /// </summary>
        /// <remarks>
        /// 18.14.15:
        ///     Walking into a Omni-Tek backyard appartment complex spawns an item: Ownership Access Card, 
        ///     and shift+f9 output looks like the following:
        ///        Extended location information:
        ///        - 189.0, 161.9, 0.0 (189.0 161.9 y 0.0 2629202)
        ///        - Pf Proxy: Model=51101:26482691 GS=0 SG=0 R=2629202, resource: 1406
        ///        - zone: 0, area: "omniapartment"
        ///        Server id: 3121, character id: 50000:1147648203, time: 2012-05-24 07:44:25 (UTC)
        ///        Version: 18.4.15_EP1, map id: 18.4.15.2_07.02.2012_15.41.26, build: 49987.
        ///     
        ///     Looking at the item [Items/118262 New Citizens Omni-Tek Apartment Complex]; [CreateApartmentSpell: [Type=53137 ID=0]]; Trgt=1 Delay=0 Count=1; A=1406
        ///     you see that A == resorurce (1406).
        ///     
        ///     Conclusion: A defines which playfield the spawned key is associated with.
        /// </remarks>
        [StreamData(0)]
        [PlayfieldParameter]
        public uint Playfield { get; set; }
    }
}