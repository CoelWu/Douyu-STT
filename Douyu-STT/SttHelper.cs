using System;
using System.Collections.Generic;
using System.Text;

namespace Douyu.STT
{
    public static class STTHelper
    {
        public static string ConvertTo(this string value)
        {
            return value.Replace("@", "@A").Replace("/", "@S");
        }

        public static string ConvertBy(this string value)
        {
            return value.Replace("@S", "/").Replace("@A", "@");
        }
    }
}
