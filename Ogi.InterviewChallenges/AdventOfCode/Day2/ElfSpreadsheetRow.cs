using System;
using System.Linq;

namespace Ogi.InterviewChallenges.AdventOfCode.Day2
{
    public class ElfSpreadsheetRow : IElfSpreadsheetRow
    {
        public string Data { get; set; }

        public ElfSpreadsheetRow(string data)
        {
            Data = data;
        }

        public ElfSpreadsheetRow()
        {

        }

        public int GetRowValueHigh()
        {
            int rslt = 0;

            rslt = Data.Split('\t').Select(d => int.TryParse(d, out int x) ? x : 0).Max();

            return rslt;
        }

        public int GetRowValueLow()
        {
            int rslt = 0;

            rslt = Data.Split('\t').Select(d => int.TryParse(d, out int x) ? x : 0).Min();

            return rslt;
        }

        public int GetRowCheckSum()
        {
            return GetRowValueHigh() - GetRowValueLow();
        }
    }
}
