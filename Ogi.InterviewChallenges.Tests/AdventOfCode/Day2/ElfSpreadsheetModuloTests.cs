using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Ogi.InterviewChallenges.AdventOfCode.Day2;
using Ogi.InterviewChallenges.AdventOfCode.Factories;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Ogi.InterviewChallenges.Tests.AdventOfCode.Day2
{
    [TestClass]
    public class GivenAnElfSpreadsheetModulo
    {
        private const string FileLocation = @"C:\temp\ElfSpreadsheet.elf";
        private const string InvalidFileLocation = @"C:\temp\NotExistingSpreadsheet.elf";
        private ElfSpreadsheetModulo _spreadSheet;
        private Mock<IElfSpreadsheetRowFactory> _mockFactory;
        private List<ElfSpreadsheetRowModulo> _rows;

        [TestInitialize]
        public void Setup()
        {
            var rowOne = new Mock<ElfSpreadsheetRowModulo>();
            var rowTwo = new Mock<ElfSpreadsheetRowModulo>();

            rowOne.Setup(r => r.GetRowCheckSum()).Returns(10);
            rowTwo.Setup(r => r.GetRowCheckSum()).Returns(10);

            _rows = new List<ElfSpreadsheetRowModulo>() {
                rowOne.Object,
                rowTwo.Object
            };

            _mockFactory = new Mock<IElfSpreadsheetRowFactory>();
            _mockFactory.Setup(x => x.Create<ElfSpreadsheetRowModulo>(It.IsAny<IEnumerable<string>>())).Returns(_rows);
            _spreadSheet = new ElfSpreadsheetModulo(_mockFactory.Object);
        }

        [TestMethod]
        public void WhenICreateAnElfSpreadsheetModulo_ThenItDoesNotThrow()
        {
            Assert.IsNotNull(_spreadSheet);
        }

        [TestMethod]
        public void WhenIOpenAnElfSpreadSheetModulo_ThenItDoesNotThrowAnException()
        {
            _spreadSheet.Open(FileLocation);
        }

        [TestMethod]
        public void WhenIOpenAnElfSpreadSheetModuloThatDoesNotExist_ThenItThrowAnException()
        {
            Action act = () => _spreadSheet.Open(InvalidFileLocation);
            Assert.ThrowsException<FileNotFoundException>(act);
        }

        [TestMethod]
        public void WhenIOpenASpreadsheetModulo_ThenItHasTheCorrectNumberOfRows()
        {
            _spreadSheet.Open(FileLocation);
            Assert.AreEqual(_spreadSheet.Rows.Count(), _rows.Count);
        }

        [TestMethod]
        public void WhenCalculateCheckSumIsCalled_ThenTheCorrectSumIsReturned() 
        {
            _spreadSheet.Open(FileLocation);
            Assert.AreEqual(_rows.Sum(r => r.GetRowCheckSum()), _spreadSheet.CalculateCheckSum());
        }

    }
}
