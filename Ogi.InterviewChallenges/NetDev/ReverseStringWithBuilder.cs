using System;
using System.Text;

namespace Ogi.InterviewChallenges.NetDev
{
    public static partial class StaticTestMethods
    {
        public static string ReverseStringWithBuilder(string originalString)
        {
            if (originalString == null)
                throw new ArgumentNullException(nameof(originalString));

            StringBuilder sb = new StringBuilder(originalString.Length - 1);

            for (int i = originalString.Length - 1; i >= 0; i--)
            {
                sb.Append(originalString[i]);
            }

            return sb.ToString();
        }
    }
}

