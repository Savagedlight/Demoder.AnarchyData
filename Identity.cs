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
using System.Xml.Serialization;

namespace Demoder.AnarchyData
{
    public class Identity : ICloneable, IEqualityComparer<Identity>
    {
        [StreamData(0)]
        [XmlAttribute("type")]
        public uint Type { get; set; }
        [StreamData(1)]
        [XmlAttribute("instance")]
        public uint Instance { get; set; }

        public Identity()
        {

        }

        public Identity(Identity identity)
        {
            this.Type = identity.Type;
            this.Instance = identity.Instance;
        }

        public Identity(uint type, uint instance)
        {
            this.Type = type;
            this.Instance = instance;
        }

        public override string ToString()
        {
            return String.Format("[Type={0} ID={1}]", this.Type, this.Instance);
        }

        object ICloneable.Clone()
        {
            return this.Clone();
        }

        public Identity Clone()
        {
            return new Identity(this);
        }

        public override int GetHashCode()
        {
            return this.GetHashCode(this);
        }


        public override bool Equals(object obj)
        {
            if (obj is Identity)
            {
                return this.Equals(this, (Identity)obj);

            }
            return base.Equals(obj);
        }


        public bool Equals(Identity x, Identity y)
        {
            if (x.Instance != y.Instance) { return false; }
            if (x.Type != y.Type) { return false; }
            return true;
        }

        public int GetHashCode(Identity obj)
        {
            // XOR
            return (int)(obj.Type ^ obj.Instance);
        }
    }
}
