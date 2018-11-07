using System;
using System.Linq;

namespace Ogi.InterviewChallenges.NetDev
{
    public static partial class StaticTestMethods
    {
        public static string RotateString(string originalString)
        {
            if (originalString == null)
                throw new ArgumentNullException(nameof(originalString));

            return
                originalString
               .Split(' ')
               .Aggregate("", (current, next) => $"{current} {ReverseStringFlashy(next)}")
               .Trim();
        }
    }
}

