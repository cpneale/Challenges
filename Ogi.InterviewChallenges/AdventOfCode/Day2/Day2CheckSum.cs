using Ogi.InterviewChallenges.AdventOfCode.Factories;

namespace Ogi.InterviewChallenges.AdventOfCode.Day2
{
    public class Day2CheckSum
    {

        public int CalculateCheckSum(string fileLocation)
        {
            IElfSpreadsheet spreadSheet = new ElfSpreadsheet(new DefaultElfSpreadsheetRowFactory());//should really inject this but cba

            spreadSheet.Open(fileLocation);

            return spreadSheet.CalculateCheckSum();
        }
    }
}
