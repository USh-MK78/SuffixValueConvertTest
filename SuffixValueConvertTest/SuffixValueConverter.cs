using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuffixValueConvertTest
{
    public class SuffixValueConverter
    {
        public static T ToValue<T>(string SuffixValue)
        {
            object i = new object();
            if (SuffixValue.Contains("U")) i = Convert.ToUInt32(SuffixValue.Replace("U", ""));
            if (SuffixValue.Contains("u")) i = Convert.ToUInt32(SuffixValue.Replace("u", ""));
            if (SuffixValue.Contains("F")) i = Convert.ToSingle(SuffixValue.Replace("F", ""));
            if (SuffixValue.Contains("f")) i = Convert.ToSingle(SuffixValue.Replace("f", ""));
            if (SuffixValue.Contains("L")) i = Convert.ToInt64(SuffixValue.Replace("L", ""));
            if (SuffixValue.Contains("l")) i = Convert.ToInt64(SuffixValue.Replace("l", ""));
            if (SuffixValue.Contains("UL")) i = Convert.ToUInt64(SuffixValue.Replace("UL", ""));
            if (SuffixValue.Contains("ul")) i = Convert.ToUInt64(SuffixValue.Replace("ul", ""));
            if (SuffixValue.Contains("LU")) i = Convert.ToUInt64(SuffixValue.Replace("LU", ""));
            if (SuffixValue.Contains("lu")) i = Convert.ToUInt64(SuffixValue.Replace("lu", ""));
            if (SuffixValue.Contains("D")) i = Convert.ToDouble(SuffixValue.Replace("D", ""));
            if (SuffixValue.Contains("d")) i = Convert.ToDouble(SuffixValue.Replace("d", ""));
            if (SuffixValue.Contains("M")) i = Convert.ToDecimal(SuffixValue.Replace("M", ""));
            if (SuffixValue.Contains("m")) i = Convert.ToDecimal(SuffixValue.Replace("m", ""));

            return (T)i;
        }

        public enum SuffixType
        {
            U,
            u,
            F,
            f,
            L,
            l,
            UL,
            ul,
            LU,
            lu,
            D,
            d,
            M,
            m
        }

        public static string ToSuffixValue<T>(T data, SuffixType suffixType)
        {
            string s = data.ToString() + suffixType.ToString();
            return s;
        }
    }
}
