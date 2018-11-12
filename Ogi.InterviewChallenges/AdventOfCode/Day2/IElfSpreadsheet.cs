using System.Collections.Generic;

namespace Ogi.InterviewChallenges.AdventOfCode.Day2
{
    public interface IElfSpreadsheet
    {
        IEnumerable<ElfSpreadsheetRow> Rows { get; set; }

        int CalculateCheckSum();
        void Open(string fileLocation);
    }
}