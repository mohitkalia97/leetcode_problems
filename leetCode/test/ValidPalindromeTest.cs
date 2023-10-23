using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using leetCode;

namespace test
{
    [TestClass]
    public class ValidPalindromeTest
    {
        [DataTestMethod]
        [DataRow("A man, a plan, a canal: Panama", true)]
        [DataRow("race a car", false)]
        [DataRow(" ", true)]
        public void IsPalindromeTest(string s, bool expected) 
        {
            bool res = ValidPalindrome.IsPalindrome(s);

            Assert.AreEqual(res, expected); 
        }
    }
}
