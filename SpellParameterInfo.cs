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

using Demoder.AnarchyData.Attributes;
using Demoder.Common.Extensions;
using Demoder.Common.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Demoder.AnarchyData
{
    public class SpellParameterInfo
    {
        public PropertyInfo Property { get; internal set; }
        public SpellParameterType ParameterType { get; internal set; }
        public string ParameterArgument { get; internal set; }
        public object ParameterValue { get; internal set; }
        public bool Interpolate { get; internal set; }
        public bool Hide { get; internal set; }
        public string BelongsTo { get; internal set; }

        public static SpellParameterInfo[] Generate(Spell spell)
        {
            var infos = Generate(spell.GetType());
            foreach (var info in infos)
            {
                info.ParameterValue = info.Property.GetValue(spell, null);
            }
            return infos;
        }

        public static SpellParameterInfo[] Generate(Type type)
        {
            List<SpellParameterInfo> infos = new List<SpellParameterInfo>();
            StreamDataInfo[] parameters = StreamDataInfo.GetProperties(type);
            foreach (var param in parameters)
            {
                SpellParameterInfo info = new SpellParameterInfo();
                Type paramType = param.PropertyInfo.PropertyType;
                info.ParameterType = GetParamType(paramType);
                info.Property = param.PropertyInfo;

                // Add extra parameter info
                switch (info.ParameterType)
                {
                    case SpellParameterType.Enum:
                        info.ParameterArgument = paramType.Name;
                        break;
                    case SpellParameterType.BitFlag:
                        info.ParameterArgument = paramType.Name;
                        break;
                    default:
                        info.ParameterArgument = "";
                        break;
                }

                ParameterAttribute attr = info.Property.GetAttribute<ParameterAttribute>();
                if (attr != null)
                {
                    info.ParameterType = attr.ParameterType;
                    info.ParameterArgument = attr.Parameter;
                }

                info.Interpolate = param.Attributes.Count(a => a.GetType() == typeof(InterpolateAttribute)) != 0;
                info.Hide = param.Attributes.Count(a => a.GetType() == typeof(HideAttribute)) != 0;

                BelongsToAttribute belongsTo = (BelongsToAttribute)param.Attributes.FirstOrDefault(a => a is BelongsToAttribute);
                if (belongsTo == null)
                {
                    info.BelongsTo = String.Empty;
                }
                else
                {
                    info.BelongsTo = belongsTo.Value;
                }

                if (info.ParameterType == SpellParameterType.Invalid)
                {
                    throw new Exception(String.Format("Unhandled parameter: {0} -> {1}", type.FullName, param.GetType().Name));
                }
                infos.Add(info);
            }
            return infos.ToArray();
        }

        public static SpellParameterType GetParamType(Type paramType)
        {
            if (paramType == typeof(Int32))
            {
                return SpellParameterType.Int32;
            }
            else if (paramType == typeof(UInt32))
            {
                return SpellParameterType.UInt32;
            }
            else if (paramType == typeof(Hash))
            {
                return SpellParameterType.Hash;
            }
            else if (paramType == typeof(string))
            {
                return SpellParameterType.String;
            }
            else if (paramType == typeof(bool))
            {
                return SpellParameterType.Bool;
            }
            else if (paramType == typeof(Stat))
            {
                return SpellParameterType.Stat;
            }
                
            #region Flags and Enums
            else if (paramType.IsEnum)
            {
                if (paramType.GetAttribute<FlagsAttribute>() == null)
                {
                    return SpellParameterType.Enum;
                }
                else
                {
                    return SpellParameterType.BitFlag;
                }
            }
            #endregion

            return SpellParameterType.Invalid;
        }
    }
}
