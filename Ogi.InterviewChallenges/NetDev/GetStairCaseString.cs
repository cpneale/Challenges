using System.Text;

namespace Ogi.InterviewChallenges.NetDev
{
    public static partial class StaticTestMethods
    {
        public static string GetStairCaseString(int height)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 1; i <= height; i++)
            {
                sb.AppendLine("".PadLeft(height - i).PadRight(height, '#'));
            }

            return sb.ToString();
        }
    }
}

