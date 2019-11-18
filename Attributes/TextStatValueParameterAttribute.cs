using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demoder.AnarchyData.Attributes
{
    public class TextStatValueParameterAttribute : ParameterAttribute
    {
        public TextStatValueParameterAttribute()
            : base(SpellParameterType.TextStatValue)
        {

        }
    }
}
