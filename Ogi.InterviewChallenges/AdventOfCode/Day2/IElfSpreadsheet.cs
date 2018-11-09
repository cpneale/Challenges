﻿using System.Collections.Generic;

namespace Ogi.InterviewChallenges.AdventOfCode.Day2
{
    internal interface IElfSpreadsheet
    {
        IEnumerable<ElfSpreadsheetRow> Rows { get; set; }

        int CalculateCheckSum();
        void Open(string fileLocation);
    }
}