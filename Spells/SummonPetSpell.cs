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
    /// 15.04.15:
    ///     Some items with this spell:
    ///     [NanoPrograms/295322 Boom Ball Pet]; [SummonPetSpell: [Type=53167 ID=0]]; Trgt=1 Delay=0 Count=1; A=KG2Z B=1 C=1800                 D={ 0, 1, 0, 0, 0, 0, 1, 127, 0, 0, 10, 0, 0 }
    ///     [Items/286117 GM Pet Shell: Lord of the Mini-Void]; [SummonPetSpell: [Type=53167 ID=0]]; Trgt=2 Delay=0 Count=1; A=LFOM B=5 C=-1    D={ 0, 2, 0, 0, 0, 100001, 1, 215, 0, 0, 4, 0, 0 }
    ///     [NanoPrograms/285056 Winter Leet Pet]; [SummonPetSpell: [Type=53167 ID=0]]; Trgt=1 Delay=0 Count=1; A=4P1D B=1 C=1800               D={ 0, 1, 0, 0, 0, 0, 1, 127, 0, 0, 10, 0, 0 }
    ///     
    ///     [Items/43328 Engineer Robot Shell]; [SummonPetSpell: [Type=53167 ID=0]]; Trgt=2 Delay=0 Count=1; A=PT01 B=1 C=-1                    D={ 0, 2, 0, 0, 0, 100001, 1, 130, 131, 0, 7, 7, 0 }
    ///     [Items/46083 Engineer Robot Shell]; [SummonPetSpell: [Type=53167 ID=0]]; Trgt=2 Delay=0 Count=1; A=PT01 B=200 C=-1                  D={ 0, 2, 0, 0, 0, 100001, 1, 130, 131, 0, 873, 873, 0 }
    ///     [Items/46343 Bureaucrat Droid Shell]; [SummonPetSpell: [Type=53167 ID=0]]; Trgt=2 Delay=0 Count=1; A=PT02 B=200 C=7200              D={ 0, 2, 0, 0, 0, 100001, 1, 131, 130, 27, 785, 785, 140 }
    ///     [Items/46344 Bureaucrat Droid Shell]; [SummonPetSpell: [Type=53167 ID=0]]; Trgt=2 Delay=0 Count=1; A=PT02 B=2 C=7200                D={ 0, 2, 0, 0, 0, 100001, 1, 131, 130, 27, 13, 13, 5 }
    ///     [Items/96198 Bureaucrat Helper-Droid Shell]; [SummonPetSpell: [Type=53167 ID=0]]; Trgt=2 Delay=0 Count=1; A=PT31 B=10 C=7200        D={ 0, 2, 0, 0, 0, 100001, 1, 131, 130, 27, 51, 51, 12 }
    ///     [Items/96199 Bureaucrat Helper-Droid Shell]; [SummonPetSpell: [Type=53167 ID=0]]; Trgt=2 Delay=0 Count=1; A=PT31 B=50 C=7200        D={ 0, 2, 0, 0, 0, 100001, 1, 131, 130, 27, 219, 219, 45 }
    ///     
    ///     [Items/156281 Kamikaze Robot II Shell]; [SummonPetSpell: [Type=53167 ID=0]]; Trgt=2 Delay=0 Count=1; A=BMBT B=40 C=50               D={ 0, 2, 0, 0, 0, 130001, 1, 0, 0, 0, 0, 0, 0 }
    ///     [Items/156282 Kamikaze Robot I Shell]; [SummonPetSpell: [Type=53167 ID=0]]; Trgt=2 Delay=0 Count=1; A=BBBT B=40 C=50                D={ 0, 2, 0, 0, 0, 130001, 1, 0, 0, 0, 0, 0, 0 }
    ///     
    ///     [Items/163521 GM Pet Shell: Season Enforcer]; [SummonPetSpell: [Type=53167 ID=0]]; Trgt=2 Delay=0 Count=1; A=H126 B=134 C=-1        D={ 0, 2, 0, 0, 0, 100001, 1, 215, 0, 0, 4, 0, 0 }
    ///     
    ///     [Items/203110 Inactive Cyborg Service Tower]; [SummonPetSpell: [Type=53167 ID=0]]; Trgt=2 Delay=0 Count=1; A=CRSE B=225 C=-1        D={ 0, 2, 0, 0, 0, 0, 1, 130, 125, 54, 249, 561, 199 }
    ///     [Items/203111 Inactive Nano Service Tower]; [SummonPetSpell: [Type=53167 ID=0]]; Trgt=2 Delay=0 Count=1; A=NNSR B=300 C=-1          D={ 0, 2, 0, 0, 0, 0, 1, 130, 125, 54, 399, 749, 199 }
    ///     [Items/204185 Inactive Feeble Service Tower]; [SummonPetSpell: [Type=53167 ID=0]]; Trgt=2 Delay=0 Count=1; A=FBSE B=15 C=-1         D={ 0, 2, 0, 0, 0, 0, 1, 130, 125, 54, 74, 44, 14 }
    ///     
    ///     [NanoPrograms/289971 Termileetz00r]; [SummonPetSpell: [Type=53167 ID=0]]; Trgt=1 Delay=0 Count=1; A=TERM B=1 C=1800                 D={ 0, 1, 0, 0, 0, 140001, 1, 127, 0, 0, 10, 0, 0 }
    ///     
    ///     [NanoPrograms/43721 Greater Frenzy Embodiment]; [SummonPetSpell: [Type=53167 ID=0]]; Trgt=1 Delay=0 Count=1; A=PT54 B=125 C=7200    D={ 0, 2, 0, 0, 0, 100001, 1, 131, 130, 0, 675, 675, 0 }
    ///     [NanoPrograms/43722 Greater Fury Externalization]; [SummonPetSpell: [Type=53167 ID=0]]; Trgt=1 Delay=0 Count=1; A=PT51 B=25 C=7200  D={ 0, 2, 0, 0, 0, 100001, 1, 131, 130, 0, 137, 137, 0 }
    ///     [NanoPrograms/43723 Greater Rage Materialization]; [SummonPetSpell: [Type=53167 ID=0]]; Trgt=1 Delay=0 Count=1; A=PT52 B=52 C=7200  D={ 0, 2, 0, 0, 0, 100001, 1, 131, 130, 0, 257, 257, 0 }
    ///     [NanoPrograms/43724 Greater Wrath Incarnation]; [SummonPetSpell: [Type=53167 ID=0]]; Trgt=1 Delay=0 Count=1; A=PT53 B=84 C=7200     D={ 0, 2, 0, 0, 0, 100001, 1, 131, 130, 0, 434, 434, 0 }
    ///     
    ///     // MP heal pet nano.
    ///     [NanoPrograms/125746 Calling of Belamorte]; [SummonPetSpell: [Type=53167 ID=0]]; Trgt=1 Delay=0 Count=1; A=MT09 B=192 C=7200        D={ 0, 3, 0, 0, 0, 110001, 1, 131, 128, 0, 849, 849, 0 }
    ///     [NanoPrograms/125746 Calling of Belamorte]; [SummonPetSpell: [Type=53167 ID=0]]; Trgt=1 Delay=0 Count=1; A=CULP B=192 C=7200        D={ 0, 3, 0, 0, 0, 110001, 1, 131, 128, 0, 849, 849, 0 }
    ///     [NanoPrograms/125746 Calling of Belamorte]; [SummonPetSpell: [Type=53167 ID=0]]; Trgt=1 Delay=0 Count=1; A=JZSX B=192 C=7200        D={ 0, 3, 0, 0, 0, 110001, 1, 131, 128, 0, 849, 849, 0 }
    ///     [NanoPrograms/125746 Calling of Belamorte]; [SummonPetSpell: [Type=53167 ID=0]]; Trgt=1 Delay=0 Count=1; A=FPJG B=192 C=7200        D={ 0, 3, 0, 0, 0, 110001, 1, 131, 128, 0, 849, 849, 0 }
    ///     [NanoPrograms/125746 Calling of Belamorte]; [SummonPetSpell: [Type=53167 ID=0]]; Trgt=1 Delay=0 Count=1; A=BSLX B=192 C=7200        D={ 0, 3, 0, 0, 0, 110001, 1, 131, 128, 0, 849, 849, 0 }
    ///     [NanoPrograms/125746 Calling of Belamorte]; [SummonPetSpell: [Type=53167 ID=0]]; Trgt=1 Delay=0 Count=1; A=RJWL B=192 C=7200        D={ 0, 3, 0, 0, 0, 110001, 1, 131, 128, 0, 849, 849, 0 }
    ///     [NanoPrograms/125746 Calling of Belamorte]; [SummonPetSpell: [Type=53167 ID=0]]; Trgt=1 Delay=0 Count=1; A=UKCW B=192 C=7200        D={ 0, 3, 0, 0, 0, 110001, 1, 131, 128, 0, 849, 849, 0 }
    /// </remarks>
    [SpellId(53167)]
    public class SummonPetSpell : Spell
    {
        [StreamData(0)]
        public Hash Item {get;set;}
        
        [StreamData(1)]
        [Interpolate]
        public uint Level { get; set; }
        
        /// <summary>
        /// How long does the pet live?
        /// </summary>
        /// <remarks>
        /// 18.04.15:
            /// Belamorte has C=7200, and it is common knowledge that Belamorte last for 2 hours. 7200/3600 = 2;
            /// 
        /// </remarks>
        [StreamData(3)]
        [Interpolate]
        [DurationParameter]
        public int Lifetime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Hide]
        [StreamData(4)]
        public int D0 { get; set; }
        
        [Hide]
        [StreamData(5)]
        public int D1 { get; set; }

        [Hide]
        [StreamData(6)]
        public int D2 { get; set; }

        [Hide]
        [StreamData(7)]
        public int D3 { get; set; }

        [Hide]
        [StreamData(8)]
        public int D4 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// might be a bitflag value.
        /// </remarks>
        [Hide]
        [StreamData(9)]
        public int D5 { get; set; }

        [Hide]
        [StreamData(10)]
        public int D6 { get; set; }

        [Hide]
        [StreamData(11)]
        public int D7 { get; set; }

        [Hide]
        [StreamData(12)]
        public int D8 { get; set; }

        [Hide]
        [StreamData(13)]
        public int D9 { get; set; }

        [Hide]
        [StreamData(14)]
        public int D10 { get; set; }

        [Hide]
        [StreamData(15)]
        public int D11 { get; set; }

        [Hide]
        [StreamData(16)]
        public int D12 { get; set; }
    }
}