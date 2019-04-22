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
    /// Some items with this spell:
    ///    [Items/284394 Fourth Checkpoint]; [TextSpell: [Type=53134 ID=0]]; Trgt=2 Delay=0 Count=1; A=Checkpoint! B= C={ 0, 0, 0, 0 }
    ///    [Items/120802 Random Name Generation Terminal]; [TextSpell: [Type=53134 ID=0]]; Trgt=2 Delay=0 Count=1; A=You have been given a new first and last name. B=You have been given a new name. C={ 10, 0, 0, 0 }
    ///    [Items/287795 Twelvth Checkpoint]; [TextSpell: [Type=53134 ID=0]]; Trgt=2 Delay=0 Count=1; A=Checkpoint! B= C={ 0, 0, 0, 0 }
    /// </remarks>
    [SpellId(53134)]
    [SpellFormat("Text: {Text}")]
    public class TextSpell : Spell
    {
        /// <summary>
        /// Echoed to chat
        /// </summary>
        /// <remarks>
        /// Was echoed to chat window when using item Random Name Generator (ID: 203911) as white text.
        /// </remarks>
        [StreamData(0)]
        public string Text { get; set; }

        /// <summary>
        /// Ignored?
        /// </summary>
        /// <remarks>
        /// Was echoed to chat nor displayed ingame when using item Random Name Generator (ID: 203911), even though it has a value.
        /// </remarks>
        [StreamData(1)]
        public string Text2 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 18.04.15:
        ///    Seems to have values of either 0 or 10.
        ///    Only three items have a value of 10: 
        ///      [Items/120802 Random Name Generation Terminal]; [TextSpell: [Type=53134 ID=0]]; Trgt=2 Delay=0 Count=1; A=You have been given a new first and last name. B=You have been given a new name. C={ 10, 0, 0, 0 }
        ///      [Items/120827 Click me to crash the client]; [TextSpell: [Type=53134 ID=0]]; Trgt=2 Delay=0 Count=1; A= B=You have been given a new name. C={ 10, 0, 0, 0 }
        ///      [Items/203911 Random Name Generator]; [TextSpell: [Type=53134 ID=0]]; Trgt=2 Delay=0 Count=1; A=You have been given a new first and last name. B=You have been given a new name. C={ 10, 0, 0, 0 }
        ///      
        ///    When using the item Random Name Generator (ID: 203911) as white text, text was echoed to chat with a white colour.
        ///    This does not match the colour codes used in HeadTextSpell, so this may mean something else.
        /// </remarks>
        [StreamData(2)]
        public int C { get; set; }
    }
}