using Ogi.InterviewChallenges.AdventOfCode.Factories;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Ogi.InterviewChallenges.AdventOfCode.Day2
{
    internal class ElfSpreadsheetModulo : IElfSpreadsheet
    {
        private IElfSpreadsheetRowFactory _rowFactory;

        public IEnumerable<IElfSpreadsheetRow> Rows { get; set; }


        public ElfSpreadsheetModulo(IElfSpreadsheetRowFactory rowFactory)
        {
            _rowFactory = rowFactory;
        }

        public void Open(string fileLocation)
        {
            if (!File.Exists(fileLocation))
                throw new FileNotFoundException();

            var lines = File.ReadAllLines(fileLocation);

            Rows = _rowFactory.Create<ElfSpreadsheetRowModulo>(lines);
        }

        public int CalculateCheckSum()
        {
            return 
                Rows
                .Select(row => row.GetRowCheckSum())
                .Sum();
        }


    }
}
