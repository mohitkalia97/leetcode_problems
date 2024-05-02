using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using leetCode;


namespace test
{
    [TestClass]
    public class RomanToIntegerTest
    {
        [DataTestMethod]
        [DataRow("III"   , 3)]
        [DataRow("LVIII" , 58)]
        [DataRow("MCMXCIV", 1994)]
        [DataRow("MCMXCVII", 1997)] // mybirthyear hehe

        public void RomanToIntTest(string s, int expected) {
            int result = RomanToInteger.RomanToInt(s);

            Assert.AreEqual(expected, result);
        }
    }
}
