using System;

namespace Ogi.InterviewChallenges.NetDev
{
    public static partial class StaticTestMethods
    {      
        //from https://adventofcode.com/2017/day/1
        //in progress
        public static int InverseCaptcha(string key, double lookAheadFactor = 0.0)
        {
            int rslt = 0;

            for (int i = 0; i < key.Length; i++)
            {
                int nextDigit = GetNextDigit(key.Length, lookAheadFactor, i);

                if (key[i] == key[nextDigit])
                    if (int.TryParse(key[i].ToString(), out int x))
                        rslt += x;
            }

            return rslt;
        }

        private static int GetNextDigit(int keyLength, double lookAheadFactor, int currentPosition)
        {
            if (lookAheadFactor > 1.0)
                throw new ArgumentException($"{nameof(lookAheadFactor)} cannot be more than 1");

            if (lookAheadFactor <= 0)
                return currentPosition == keyLength - 1 ? 0 : currentPosition + 1;

            var lookAhead = (int)(keyLength * lookAheadFactor);

            return Math.Abs(currentPosition + lookAhead - (currentPosition >= lookAhead ? keyLength : 0));
        }
    }
}

