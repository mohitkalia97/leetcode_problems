using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using leetCode;

namespace test
{
    [TestClass]
    public class ValidAnagramTest
    {
        [DataTestMethod]
        [DynamicData(nameof(GetTestData),DynamicDataSourceType.Method)]
        public void isAnagramTest(string s, string t, bool ex)
        {

            bool res = ValidAnagram.IsAnagram(s,t);

            Assert.AreEqual(res, ex);
        }

        public static IEnumerable<object[]> GetTestData()
        {
            yield return new object[]
            {
                "anagram", "nagaram", true
            };
            yield return new object[]
            {
                "rat", "car", false
            };
        }
    }
}
