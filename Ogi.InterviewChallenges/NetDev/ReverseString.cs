using System;

namespace Ogi.InterviewChallenges.NetDev
{
    public static partial class StaticTestMethods
    {
        public static string ReverseString(string originalString)
        {
            if (originalString == null)
                throw new ArgumentNullException(nameof(originalString));

            string s = "";

            for (int i = originalString.Length - 1; i >= 0; i--)
            {
                s += originalString[i];
            }

            return s;
        }
    }
}

