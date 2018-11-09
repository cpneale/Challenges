using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ogi.InterviewChallenges.AdventOfCode.Day2;

namespace Ogi.InterviewChallenges.Tests.AdventOfCode.Day2
{
    [TestClass]
    public class GivenAnElfSpreadsheetRow
    {
        [TestMethod]
        public void WhenGetRowValueHighIsCalled_ThenItReturnsTheCorrectValue()
        {
            ElfSpreadsheetRow sut = new ElfSpreadsheetRow("4347\t3350");
            var hiValue = sut.GetRowValueHigh();
            Assert.AreEqual(4347, hiValue);
        }

        [TestMethod]
        public void WhenGetRowValueLowIsCalled_ThenItReturnsTheCorrectValue()
        {
            ElfSpreadsheetRow sut = new ElfSpreadsheetRow("4347\t3350");
            var lowValue = sut.GetRowValueLow();
            Assert.AreEqual(3350, lowValue);
        }
    }
}
