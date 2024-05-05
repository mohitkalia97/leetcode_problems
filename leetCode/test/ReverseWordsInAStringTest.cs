using leetCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    [TestClass]
    public class ReverseWordsInAStringTest
    {
        [DataTestMethod]
        [DataRow("the sky is blue", "blue is sky the")]
        [DataRow("  hello world   ", "world hello")]
        [DataRow("a good   example", "example good a")] 

        public void ReverseWordsTest(string s, string expected)
        {
            string result = ReverseWordsInAString.ReverseWords(s);

            Assert.AreEqual(expected, result);
        }
    }
}
