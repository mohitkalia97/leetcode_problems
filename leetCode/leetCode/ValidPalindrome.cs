using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace leetCode
{
    public class ValidPalindrome
    {
        public static bool IsPalindrome(string s)
        {
            s = s.ToLower();
            Regex rgx = new Regex("[^a-zA-Z0-9]");
            s = rgx.Replace(s, "");

            for (int i = 0, j = s.Length-1; i < s.Length; i++, j--)
            {
                if (s[i] != s[j]) return false;
            }

            return true;

        }
    }
}