using Microsoft.VisualStudio.Services.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace leetCode
{
    public class ValidAnagram 
    {
        public static bool IsAnagram(string s, string t)
        {
            Dictionary<char, int> dic = new Dictionary<char, int>();

            if(s.Length != t.Length) return false;

            foreach (var letter in s)
            {
                if (dic.ContainsKey(letter))
                {
                    dic[letter]++;
                }
                else
                {
                    dic[letter] = 1;
                }
            }

            foreach (var letter in t)
            {
                if(!dic.ContainsKey(letter) || dic[letter] == 0)
                {
                    return false;
                }

                dic[letter]--;
            }
            return true;
        }
    }
}
