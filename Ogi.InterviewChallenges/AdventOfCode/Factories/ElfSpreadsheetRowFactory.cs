using Ogi.InterviewChallenges.AdventOfCode.Day2;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace Ogi.InterviewChallenges.AdventOfCode.Factories
{
    interface IElfSpreadsheetRowFactory
    {
        IEnumerable<T> Create<T>(IEnumerable<string> rows) where T : class, IElfSpreadsheetRow, new();
    }

    internal class DefaultElfSpreadsheetRowFactory : IElfSpreadsheetRowFactory
    {
       
        public IEnumerable<T> Create<T>(IEnumerable<string> rows) where T : class, IElfSpreadsheetRow, new()
        {
            return rows.Select(row => new T() { Data = row });
        }
    }
}
