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
    [SpellId(53117)]
    public class TauntNpcSpell : Spell
    {
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Examples of items/nanos where A is not 0:
        ///   [NanoPrograms/263630 Inspire Ire]; [TauntNpcSpell: [Type=53117 ID=0]]; Trgt=3 Delay=0 Count=1; A=3000 B=3000 Amount=25 D=0 E=0
        ///     Item description:   In combat when wielding melee weapons, you will occasionally perform an additional strike with your weapon.
        ///   [NanoPrograms/263638 Inspire Hate]; [TauntNpcSpell: [Type=53117 ID=0]]; Trgt=3 Delay=0 Count=1; A=900 B=900 Amount=25 D=0 E=0
        ///     Item description: In combat when wielding melee weapons, you will occasionally perform an additional strike with your weapon.
        ///   
        /// </remarks>
        [StreamData(0)]
        public int A { get; set; }

        /// <summary>
        /// </summary>
        /// <remaks>
        /// Examples of items where B is not 0: Same as A.
        /// </remaks>
        /// <seealso cref="A"/>
        [StreamData(1)]
        public int B { get; set; }

        [StreamData(2)]
        [Interpolate]
        public int Amount { get; set; }


        /// <summary>
        /// Duration of taunt, in seconds.
        /// </summary>
        /// <remarks>
        /// Examples of items/nanos where D (Duration) is not 0:
        ///   [NanoPrograms/229096 Annoying Insult]; [TauntNpcSpell: [Type=53117 ID=0]]; Trgt=3 Delay=0 Count=1; A=0 B=0 Amount=1950 D=60 E=0
        ///     Item description: Attempts to make the target aggro on the caster. This is a timed nano, and has a duration of 60 seconds. After those 60 seconds, the target will loose the hate it got from the nano.
        ///     Conclusion: D=Duration of taunt in seconds.
        ///   
        ///   [NanoPrograms/229098 Aggressive Insult]; [TauntNpcSpell: [Type=53117 ID=0]]; Trgt=3 Delay=0 Count=1; A=0 B=0 Amount=2250 D=80 E=0
        ///     Item description: Attempts to make the target aggro on the caster. This is a timed nano, and has a duration of 80 seconds. After those 80 seconds, the target will loose the hate it got from the nano.
        ///     Conclusion: D=Duration of taunt in seconds.
        /// 
        ///   [NanoPrograms/229100 Disruptive Insult]; [TauntNpcSpell: [Type=53117 ID=0]]; Trgt=3 Delay=0 Count=1; A=0 B=0 Amount=2700 D=90 E=0
        ///     Item description: Attempts to make the target aggro on the caster. This is a timed nano, and has a duration of 90 seconds. After those 90 seconds, the target will loose the hate it got from the nano.
        ///     Conclusion: D=Duration of taunt in seconds.</remarks>
        [StreamData(3)]
        [Interpolate]
        [DurationParameter]
        public int Duration { get; set; }
        
        /*
         * Example of items/nanos where E is not 0: None.
         */
        [StreamData(3)]
        public int E { get; set; }
    }
}