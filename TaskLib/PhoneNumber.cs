using System.Text.RegularExpressions;

namespace TaskLib
{
    public static class PhoneNumber
    {
        public static string FormatPhoneNumber(string s)
        {
            var res1 = Regex.Replace(s, @"[^0-9]", "");
            return Regex.Replace(res1, ".{3}", "$0-");
        }

    }
}
