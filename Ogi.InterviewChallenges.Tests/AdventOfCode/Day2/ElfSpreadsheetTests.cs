using System;
using System.IO;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ogi.InterviewChallenges.AdventOfCode.Factories;
using Moq;
using AutoFixture;
using System.Collections.Generic;
using Ogi.InterviewChallenges.AdventOfCode.Day2;

namespace Ogi.InterviewChallenges.Tests.AdventOfCode
{
    [TestClass]
    public class ElfSpreadsheetTests
    {
        private const string FileLocation = @"C:\temp\ElfSpreadsheet.elf";
        private const string InvalidFileLocation = @"C:\temp\NotExistingSpreadsheet.elf";
        private ElfSpreadsheet _spreadSheet;
        private Mock<IElfSpreadsheetRowFactory> _mockFactory;
        private Fixture _fixture;
        private List<ElfSpreadsheetRow> _rows;

        [TestInitialize]
        public void Setup()
        {
            /*
             * file contents
             * 4347	3350
             * 648	94
             */
            _rows = new List<ElfSpreadsheetRow>() {
                new ElfSpreadsheetRow("4347\t3350"),
                new ElfSpreadsheetRow("648\t94")
            };

            _mockFactory = new Mock<IElfSpreadsheetRowFactory>();
            _mockFactory.Setup(x => x.Create<ElfSpreadsheetRow>(It.IsAny<IEnumerable<string>>())).Returns(_rows);
            _spreadSheet = new ElfSpreadsheet(_mockFactory.Object);
        }

        [TestMethod]
        public void WhenICreateAnElfSpreadsheet_ThenItDoesNotThrow()
        {
            Assert.IsNotNull(_spreadSheet);
        }

        [TestMethod]
        public void WhenIOpenAnElfSpreadSheet_ThenItDoesNotThrowAnException()
        {
            _spreadSheet.Open(FileLocation); 
        }

        [TestMethod]
        public void WhenIOpenAnElfSpreadSheetThatDoesNotExist_ThenItThrowAnException()
        {
            Action act = () => _spreadSheet.Open(InvalidFileLocation);
            Assert.ThrowsException<FileNotFoundException>(act);
        }

        [TestMethod]
        public void WhenIOpenASpreadsheet_ThenItHasTheCorrectNumberOfRows()
        {
            _spreadSheet.Open(FileLocation);
            Assert.AreEqual(_spreadSheet.Rows.Count(), _rows.Count);
        }

        [TestMethod]
        public void WhenCalculateCheckSumIsCalled_ThenTheCorrectSumIsReturned()
        {
            /*
             * file contents
             * 4347	3350
             * 648	94
             */
            _spreadSheet.Open(FileLocation);
            Assert.AreEqual((4347 - 3350) + (648 - 94), _spreadSheet.CalculateCheckSum());
        }
    }
}
