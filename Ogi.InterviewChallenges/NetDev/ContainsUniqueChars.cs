using System.Linq;

namespace Ogi.InterviewChallenges.NetDev
{
    public static partial class StaticTestMethods
    {
        public static bool ContainsUniqueChars(string stringToTest)
        {
            string uniqueString = string.Join("", stringToTest.Distinct().ToArray());

            return (stringToTest.Count() == uniqueString.Count());
        }
    }
}

