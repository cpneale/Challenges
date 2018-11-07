using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ogi.InterviewChallenges.General;

namespace Ogi.InterviewChallenges.Tests.General
{
    public class AdventOfCodeTests
    {

        [DataTestMethod]
        [DataRow("1122", 3)]
        [DataRow("1111", 4)]
        [DataRow("1234", 0)]
        [DataRow("91212129", 9)]
        public void InverseCaptchaTest(string key, int expectedResult)
        {
                Assert.AreEqual(expectedResult, AdventOfCode.InverseCaptcha(key));
        }

        [DataTestMethod]
        [DataRow("1212", 0.5, 6)]
        [DataRow("1221", 0.5, 0)]
        [DataRow("123425", 0.5, 4)]
        [DataRow("123123", 0.5, 12)]
        [DataRow("12131415", 0.5, 4)]
        public void InverseCaptchaWithLookaheadFactorTest(string key, double lookAheadFactor, int expectedResult)
        {
            Assert.AreEqual(expectedResult, AdventOfCode.InverseCaptcha(key, lookAheadFactor));
        }

    }
}
