using System;
using System.Linq;

namespace Ogi.InterviewChallenges.NetDev
{
    public static partial class StaticTestMethods
    {
        public static string ReverseStringFlashy(string originalString)
        {
            if (originalString == null)
                throw new ArgumentNullException(nameof(originalString));

            return new string(originalString.Reverse().ToArray());
        }
    }
}

