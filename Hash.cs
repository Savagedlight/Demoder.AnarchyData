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

namespace Demoder.AnarchyData
{
    public class Hash
    {
        public string Text {get; private set; }
        public Hash(string hash)
        {
            if (hash.Length != 4) { throw new ArgumentException("Hash must be exactly 4 characters long.", hash); }
            this.Text = (string)hash.Clone();
        }

        public static implicit operator string (Hash hash)
        {
            return (string)hash.Text.Clone();
        }

        public static explicit operator Hash(string str)
        {
            return new Hash(str);
        }

        public override string ToString()
        {
            return (string)this.Text.Clone();
        }
    }
}
