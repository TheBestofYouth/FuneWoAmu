
namespace LeetCode.PoorPigs
{
    public class Solution
    {
        public int PoorPigs(int buckets, int minutesToDie, int minutesToTest)
        {
            if (buckets <= 1)
                return 0;

            var NumberPerDim = minutesToTest / minutesToDie + 1;
            var currentCount = 1;
            int testedNumber = NumberPerDim;

            while (testedNumber < buckets)
            {
                currentCount++;
                testedNumber *= NumberPerDim;
            }

            return currentCount;
        }
    }
}
