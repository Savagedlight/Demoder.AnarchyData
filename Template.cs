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
using System.IO;
using Demoder.AnarchyData.TemplateData;

namespace Demoder.AnarchyData
{
    /// <summary>
    /// This is what RDB parsers and item sites usually call an "item". <br/>
    /// It's called a template because it's only one factor in determining what a "item" actually is.
    /// </summary>
    [Serializable]
    public class Template : Base
    {
        public TemplateMetaData MetaData { get; private set; }
        public List<TemplateDataBase> DataBlocks { get; set; }

        #region Constructors
        public Template(Base a) : base(a)
        {
            this.MetaData = new TemplateMetaData();
            this.MetaData.IsNano = (a.Identity.Type == (int)RdbRecordType.NanoProgram);
            this.DataBlocks = new List<TemplateDataBase>();
        }
        #endregion

        #region Methods
        /// <summary>
        /// Gets all spells of a given spell block
        /// </summary>
        /// <param name="action">Numeric ID of block</param>
        /// <returns></returns>
        public Spell[] GetSpells(uint action)
        {
            var block = (SpellData)this.DataBlocks.FirstOrDefault(b => b is SpellData && b.Identity.Instance == action);
            if (block == null)
            {
                return new Spell[0];
            }
            return block.Items;
        }
        #endregion

        #region Attack and Defense Skills
        public StatValue[] AttackSkills
        {
            get
            {
                var block = this.GetDataBlock<AtkDefData>();
                if (block == null) 
                { 
                    return new StatValue[0]; 
                }
                return block.Attack.ToArray();
            }
        }

        public StatValue[] DefenseSkills
        {
            get
            {
                var block = this.GetDataBlock<AtkDefData>();
                if (block == null) 
                { 
                    return new StatValue[0]; 
                }
                return block.Defense.ToArray();
            }
        }
        #endregion

        #region Other
        public AnimSoundData Animations { get { return (AnimSoundData)this.DataBlocks.FirstOrDefault(b => b is AnimSoundData && b.Identity.Type == 14); } }
        public AnimSoundData Sounds { get { return (AnimSoundData)this.DataBlocks.FirstOrDefault(b => b is AnimSoundData && b.Identity.Type == 20); } }
        /// <summary>
        /// Usually refered to as 'Attributes' in other parsers.
        /// </summary>
        /// <value>
        /// An array with <see cref="StatValue"/> of 0 or greater length, never null.
        /// </value>
        public StatValue[] Stats
        {
            get
            {
                var block = this.GetDataBlock<StatData>();
                if (block == null)
                {
                    return new StatValue[0];
                }
                return block.Items;
            }
        }

        /// <summary>
        /// Experimental.
        /// </summary>
        public ShopHashData ShopHash { get { return this.GetDataBlock<ShopHashData>(); } }
        #endregion

        #region LINQ accessors
        public T GetDataBlock<T>()
            where T : TemplateDataBase
        {
            return this.DataBlocks.FirstOrDefault(d => d is T) as T;
        }

        public T[] GetDataBlocks<T>()
            where T : TemplateDataBase
        {
            return (from d in this.DataBlocks
                   where d is T
                   select d as T).ToArray();
        }
        #endregion

        public override string ToString()
        {
            return String.Format("{0} {1}", 
                this.Identity,
                this.MetaData.Name);
        }
    }
}
