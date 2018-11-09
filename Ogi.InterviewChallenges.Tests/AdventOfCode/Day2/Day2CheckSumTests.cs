using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ogi.InterviewChallenges.AdventOfCode.Day2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ogi.InterviewChallenges.Tests.AdventOfCode.Day2
{
    [TestClass]
    public class GivenADay2CheckSum
    {
        const string FileLocationTest = @"C:\temp\ElfSpreadsheet-Test.elf";
        const string FileLocation = @"C:\temp\ElfSpreadsheet.elf";

        [TestMethod]
        public void WhenCalculateChecksumIsCalled_ThenItReturnsTheCorrectValue()
        {
            Day2CheckSum sut = new Day2CheckSum();
            Assert.AreEqual(1551, sut.CalculateCheckSum(FileLocationTest));
        }

        [TestMethod]
        public void WhenCalculateChecksumIsCalledAgain_ThenItReturnsTheCorrectValue()
        {
            Day2CheckSum sut = new Day2CheckSum();
            Assert.AreEqual(47136, sut.CalculateCheckSum(FileLocation));
        }
    }
}
