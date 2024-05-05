using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

//Example 1:

//Input: s = "the sky is blue"
//Output: "blue is sky the"
//Example 2:

//Input: s = "  hello world  "
//Output: "world hello"
//Explanation: Your reversed string should not contain leading or trailing spaces.
//Example 3:

//Input: s = "a good   example"
//Output: "example good a"
//Explanation: You need to reduce multiple spaces between two words to a single space in the reversed string.

namespace leetCode
{
    public class ReverseWordsInAString
    {
            public static string ReverseWords(string s)
            {
                string[] wordsArray = s.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                Array.Reverse(wordsArray);
                string result = String.Join(" ", wordsArray);
                return result;
            }
    }
}
