using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace TaskLib
{
    public static class PhoneNumber
    {
        public static string FormatPhoneNumber(string S)
        {
            var res1 = Regex.Replace(S, @"[^0-9]", "");
            return Regex.Replace(res1, ".{3}", "$0-");
        }

    }
}
