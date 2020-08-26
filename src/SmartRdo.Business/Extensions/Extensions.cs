using System;
using System.ComponentModel;

namespace SmartRdo.Business.Extensions
{
    public static class Extensions
    {
        public static string ToDescription(this Enum val)
        {
            var attributes = (DescriptionAttribute[])val
                .GetType()
                .GetField(val.ToString())
                .GetCustomAttributes(typeof(DescriptionAttribute), false);
            return attributes.Length > 0 ? attributes[0].Description : val.ToString();
        }
       
    }
}
