using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ogi.InterviewChallenges.AdventOfCode.Day2;
using Moq;

namespace Ogi.InterviewChallenges.Tests.AdventOfCode.Day2
{
    [TestClass]
    public class GivenADay2CheckSum
    {
        const string FileLocationTest = @"C:\temp\DoesntReallyMatter.elf";

        Mock<IElfSpreadsheet> _mockElfSpreadsheet = new Mock<IElfSpreadsheet>();
        
        [DataTestMethod]
        [DataRow(1551)]
        [DataRow(47136)]
        public void WhenCalculateChecksumIsCalled_ThenItReturnsTheCorrectValue(int checkSum)
        {
            _mockElfSpreadsheet.SetupSequence(x => x.CalculateCheckSum())
                .Returns(checkSum);

            Day2CheckSum sut = new Day2CheckSum(_mockElfSpreadsheet.Object);
            Assert.AreEqual(checkSum, sut.CalculateCheckSum(FileLocationTest));
        }
    }
}
