using System;
using System.Collections.Generic;
using System.Linq;

namespace Ogi.InterviewChallenges.AdventOfCode.Day2
{
    public class ElfSpreadsheetRowModulo : IElfSpreadsheetRow
    {
        public string Data { get; set; }

        public ElfSpreadsheetRowModulo(string data)
        {
            Data = data;
        }

        public ElfSpreadsheetRowModulo()
        {

        }

        public virtual int GetRowCheckSum()
        {
            var fields = Data
                .Split('\t')
                .Where(d => int.TryParse(d, out int x))
                .Select(d => int.Parse(d))
                .OrderBy(d => d)
                .ToList();

            List<Tuple<int, int>> mods = ExtractModulos(fields);

            return mods.Select(t => t.Item2 / t.Item1).FirstOrDefault();
        }

        private static List<Tuple<int, int>> ExtractModulos(List<int> fields)
        {
            List<Tuple<int, int>> mods = new List<Tuple<int, int>>();

            for (int i = 0; i < fields.Count() - 1; i++)
            {
                for (int j = i + 1; j < fields.Count(); j++)
                {
                    if (fields[j] % fields[i] == 0)
                    {
                        mods.Add(Tuple.Create(fields[i], fields[j]));
                        goto jumpout;
                    }
                }
            }
            jumpout:
            return mods;
        }
    }
}
