namespace Ogi.InterviewChallenges.AdventOfCode.Day2
{
    public interface IElfSpreadsheetRow
    {
        string Data { get; set; }

        int GetRowCheckSum();
        //int GetRowValueHigh();
        //int GetRowValueLow();
    }
}