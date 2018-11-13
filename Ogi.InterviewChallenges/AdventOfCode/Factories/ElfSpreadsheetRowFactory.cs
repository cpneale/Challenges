using Ogi.InterviewChallenges.AdventOfCode.Day2;
using System.Collections.Generic;
using System.Linq;

namespace Ogi.InterviewChallenges.AdventOfCode.Factories
{
    interface IElfSpreadsheetRowFactory
    {
        IEnumerable<ElfSpreadsheetRow> Create(IEnumerable<string> rows);
    }

    internal class DefaultElfSpreadsheetRowFactory : IElfSpreadsheetRowFactory
    {
        public IEnumerable<ElfSpreadsheetRow> Create(IEnumerable<string> rows)
        {
            return rows.Select(row => new ElfSpreadsheetRow(row));
        }
    }
}
