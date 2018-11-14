using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ogi.InterviewChallenges.AdventOfCode.Day2;

namespace Ogi.InterviewChallenges.Tests.AdventOfCode.Day2
{
    [TestClass]
    public class GivenAnElfSpreadsheetRowModulo
    {
        [TestMethod]
        public void WhenGetRowCheckSumIsCalled_ThenItReturnsTheCorrectValue()
        {
            var sut = new ElfSpreadsheetRowModulo("5\t9\t2\t8");
            var rowCheckSum = sut.GetRowCheckSum();
            Assert.AreEqual(8/2, rowCheckSum);
        }
    }
}
