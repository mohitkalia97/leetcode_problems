using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

An input string is valid if:

Open brackets must be closed by the same type of brackets.
Open brackets must be closed in the correct order.
Every close bracket has a corresponding open bracket of the same type.
 

Example 1:

Input: s = "()"
Output: true
Example 2:

Input: s = "()[]{}"
Output: true
Example 3:

Input: s = "(]"
Output: false
 

Constraints:

1 <= s.length <= 104
s consists of parentheses only '()[]{}'.
 */

namespace leetCode
{
    public  class ValidParantheses
    {
            public static bool IsValid(string s)
            {
            Stack<Char> stack = new Stack<Char>();

            foreach (char c in s)
            {
                if(c == '(' ||  c == '[' || c == '{')
                {
                    stack.Push(c);
                }

                else if (c == ')' || c == ']' || c == '}') {

                    if(stack.Count == 0) { return false; };

                    char parantheseOnStack = stack.Pop();

                    if(c==')' &&  parantheseOnStack != '(')
                    {
                        return false;
                    }

                    if(c==']' && parantheseOnStack != '[')
                    {
                        return false;
                    }
                    if(c=='}' && parantheseOnStack != '{')
                    {
                        return false;
                    }
                }
            }
            return stack.Count() == 0;
            }
    }
}
