using Ogi.InterviewChallenges.AdventOfCode.Factories;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Ogi.InterviewChallenges.AdventOfCode.Day2
{
    internal class ElfSpreadsheet : IElfSpreadsheet
    {
        private IElfSpreadsheetRowFactory _rowFactory;

        public IEnumerable<ElfSpreadsheetRow> Rows { get; set; }


        public ElfSpreadsheet(IElfSpreadsheetRowFactory rowFactory)
        {
            _rowFactory = rowFactory;
        }

        public void Open(string fileLocation)
        {
            if (!File.Exists(fileLocation))
                throw new FileNotFoundException();

            var lines = File.ReadAllLines(fileLocation);

            Rows = _rowFactory.Create(lines);
        }

        public int CalculateCheckSum()
        {
            return 
                Rows
                .Select(row => row.GetRowValueHigh() - row.GetRowValueLow())
                .Sum();
        }
    }
}
