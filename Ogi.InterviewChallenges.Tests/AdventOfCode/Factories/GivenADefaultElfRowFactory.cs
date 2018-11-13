using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ogi.InterviewChallenges.AdventOfCode.Day2;
using Ogi.InterviewChallenges.AdventOfCode.Factories;

namespace Ogi.InterviewChallenges.Tests.AdventOfCode.Factories
{
    [TestClass]
    public class GivenADefaultElfRowFactory
    {
        private List<string> _rows;

        [TestInitialize]
        public void Setup()
        {
            _rows = new List<string>()
            {
                "4347\t3350",
                "648\t94"
            };
        }

        //[DataTestMethod]
        //[DataRow(CheckSumAlgorithm.FullRow)]
        //[DataRow(CheckSumAlgorithm.Modulo)]
        //public void WhenCreateIsCalled_ThenItReturnsTheCorrectObject(CheckSumAlgorithm algorithmType)
        //{
        //    DefaultElfSpreadsheetRowFactory sut = new DefaultElfSpreadsheetRowFactory();

        //    var rows = sut.Create(_rows, algorithmType);

        //    Assert.IsInstanceOfType(rows, typeof(IEnumerable<IElfSpreadsheetRow>));
        //    Assert.AreEqual(rows.Count(), _rows.Count);
        //}

        [TestMethod]
        public void WhenCreateIsCalled_ThenItReturnsTheCorrectObject()
        {
            DefaultElfSpreadsheetRowFactory sut = new DefaultElfSpreadsheetRowFactory();

            var rows = sut.Create<ElfSpreadsheetRow>(_rows);

            Assert.IsInstanceOfType(rows, typeof(IEnumerable<IElfSpreadsheetRow>));
            Assert.AreEqual(rows.Count(), _rows.Count);
            Assert.IsTrue(rows.All(r => r.Data != null));
        }
    }
}
