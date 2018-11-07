using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ogi.InterviewChallenges.NetDev
{
    public static partial class StaticTestMethods
    {
        public static string GetGraphString(Dictionary<int, int> graphData)
        {
            StringBuilder sb = new StringBuilder();
            var orderedGraphData = graphData.OrderBy(kv => kv.Key);
            var maxDataPoint = graphData.Max(kv => kv.Value);

            for (int i = maxDataPoint; i > 0; i--)
            {
                foreach (var item in orderedGraphData)
                {
                    sb.Append((item.Value >= i) ? '#' : ' ');
                }
                sb.AppendLine();
            }

            return sb.ToString();
        }
    }
}

