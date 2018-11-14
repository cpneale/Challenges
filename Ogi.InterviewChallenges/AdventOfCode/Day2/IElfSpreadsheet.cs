using System.Collections.Generic;

namespace Ogi.InterviewChallenges.AdventOfCode.Day2
{
    public interface IElfSpreadsheet
    {
        IEnumerable<IElfSpreadsheetRow> Rows { get; set; }

        int CalculateCheckSum();
        void Open(string fileLocation);
    }
}