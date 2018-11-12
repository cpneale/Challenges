namespace Ogi.InterviewChallenges.AdventOfCode.Day2
{
    public class Day2CheckSum
    {
        private IElfSpreadsheet _spreadSheet;

        public Day2CheckSum(IElfSpreadsheet spreadsheet)
        {
            _spreadSheet = spreadsheet;
        }

        public int CalculateCheckSum(string fileLocation)
        {
            _spreadSheet.Open(fileLocation);

            return _spreadSheet.CalculateCheckSum();
        }
    }
}
