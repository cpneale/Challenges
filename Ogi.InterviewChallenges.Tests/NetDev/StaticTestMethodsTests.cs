using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;
using System.Collections.Generic;

namespace Ogi.InterviewChallenges.NetDev.Tests
{
    [TestClass()]
    public class StaticTestMethodsTests
    {
        [TestInitialize()]
        public void Setup()
        {
        }

        [TestMethod()]
        public void RotateStringTest()
        {
            string theString = "the end of the world", expectedResult = "eht dne fo eht dlrow";

            var o = StaticTestMethods.RotateString(theString);

            Assert.AreEqual(expectedResult, o);
        }


        [TestMethod()]
        public void ReverseStringTest()
        {
            string theString = "opengi", expectedResult = "ignepo";

            var r = StaticTestMethods.ReverseString(theString);

            Assert.AreEqual(r, expectedResult);
        }


        [TestMethod()]
        public void ReverseStringWithBuilderTest()
        {
            string theString = "opengi", expectedResult = "ignepo";

            var r = StaticTestMethods.ReverseStringFlashy(theString);

            Assert.AreEqual(r, expectedResult);
        }

        [TestMethod()]
        public void ReverseStringWithLoopTest()
        {
            string theString = "opengi", expectedResult = "ignepo";

            var r = StaticTestMethods.ReverseStringWithBuilder(theString);

            Assert.AreEqual(r, expectedResult);
        }

        [TestMethod()]
        public void GetStairCaseStringTest()
        {
            StringBuilder sb = new StringBuilder();

            sb
                .AppendLine("  #")
                .AppendLine(" ##")
                .AppendLine("###");

            Assert.AreEqual(sb.ToString(), StaticTestMethods.GetStairCaseString(3));

        }


        [TestMethod()]
        public void ContainsUniqueCharsTest()
        {
            string uniqueStringToTest = "abcdef";
            string nonUniqueStringToTest = "abcdeff";

            Assert.IsTrue(StaticTestMethods.ContainsUniqueChars(uniqueStringToTest));
            Assert.IsFalse(StaticTestMethods.ContainsUniqueChars(nonUniqueStringToTest));
        }

        [TestMethod()]
        public void GetGraphStringAscendingTest()
        {
            Dictionary<int, int> graphData = 
                new Dictionary<int, int>()
                {
                    {0,1},
                    {1,2},
                    {2,3},
                };


            StringBuilder sb = new StringBuilder();

            sb
                .AppendLine("  #")
                .AppendLine(" ##")
                .AppendLine("###");

            Assert.AreEqual(sb.ToString(), StaticTestMethods.GetGraphString(graphData));

        }

        [TestMethod()]
        public void GetGraphStringRiseAndFallTest()
        {
            Dictionary<int, int> graphData =
                new Dictionary<int, int>()
                {
                    {0,1},
                    {1,0},
                    {2,3},
                    {3,6},
                    {4,3},
                };


            StringBuilder sb = new StringBuilder();

            sb
                .AppendLine("   # ")
                .AppendLine("   # ")
                .AppendLine("   # ")
                .AppendLine("  ###")
                .AppendLine("  ###")
                .AppendLine("# ###");

            Assert.AreEqual(sb.ToString(), StaticTestMethods.GetGraphString(graphData));

        }

        [DataTestMethod]
        [DataRow("1122",3)]
        [DataRow("1111",4)]
        [DataRow("1234",0)]
        [DataRow("91212129",9)]
        public void InverseCaptchaTest(string key, int expectedResult)
        {
            Assert.AreEqual(expectedResult, StaticTestMethods.InverseCaptcha(key));
        }

        [DataTestMethod]
        [DataRow("1212", 0.5, 6)]
        [DataRow("1221", 0.5, 0)]
        [DataRow("123425", 0.5, 4)]
        [DataRow("123123", 0.5, 12)]
        [DataRow("12131415", 0.5, 4)]
        public void InverseCaptchaWithLookaheadFactorTest(string key, double lookAheadFactor, int expectedResult)
        {
            Assert.AreEqual(expectedResult, StaticTestMethods.InverseCaptcha(key, lookAheadFactor));
        }

    }
}