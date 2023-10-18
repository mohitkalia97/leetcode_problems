using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using leetCode;

namespace test
{
    [TestClass]
    public class ValidParanthesesTest
    {
        [DataTestMethod]
        [DataRow ("()",true)]
        [DataRow ("()[]{}", true)]
        [DataRow ("(]", false)]

        public void IsValidTest(string s, bool expected)
        {
            bool result = ValidParantheses.IsValid(s);

            Assert.AreEqual(result, expected);
        }
    }

}
