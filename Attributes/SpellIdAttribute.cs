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

namespace Demoder.AnarchyData.Attributes
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple=false, Inherited=true)]
    public class SpellIdAttribute : Attribute
    {
        /// <summary>
        /// Spell ID
        /// </summary>
        public uint ID { get; private set; }

        /// <summary>
        /// Spell version
        /// </summary>
        public uint SpellVersion { get; private set; }

        public Version PatchVersion { get; private set; }


        /// <summary>
        /// Sets this as the default spell definition
        /// </summary>
        /// <param name="id"></param>
        public SpellIdAttribute(uint id)
        {
            this.ID = id;
            this.SpellVersion = 4;
            this.PatchVersion = new Version(0, 0, 0, 0);

        }
        /// <summary>
        /// Defines a spell
        /// </summary>
        /// <param name="id">Spell ID</param>
        /// <param name="version">Spell version</param>
        public SpellIdAttribute(uint id, uint version)
        {
            if (version <= 4)
            {
                throw new Exception("Versions equal to 4 or less should be assigned using patch.");
            }
            this.ID = id;
            this.SpellVersion = version;
            this.PatchVersion = new Version(18,5,0,0);
        }

        public SpellIdAttribute(uint id, string patch)
        {
            this.ID = id;
            this.SpellVersion = 4;
            this.PatchVersion = new Version(patch);
            if (this.PatchVersion >= new Version(18, 5, 0, 0))
            {
                throw new Exception("Patches after than 18.5 should be assigned using version ID");
            }
            
        }
    }
}
