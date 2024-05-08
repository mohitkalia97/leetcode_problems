using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace leetCode
{
    public  class RomanToInteger
    {
        public static int RomanToInt(string s)
        {

            Dictionary<char, int> dic = new Dictionary<char, int>() {
            { 'I',  1    },
            { 'V',  5    },
            { 'X',  10   },
            { 'L',  50   },
            { 'C',  100  },
            { 'D',  500  },
            { 'M',  1000 }

            };

            int count = 0;
            int current;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                current = dic[s[i]];
                if (i < s.Length - 1 && dic[s[i + 1]] > current)
                {
                    count -= current;
                }
                else
                {
                    count += current;
                }
            }
            return count;
        }
    }
}
