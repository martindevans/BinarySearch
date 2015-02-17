using System;

namespace BinarySearch
{
    public static class BinarySearch
    {
        /// <summary>
        /// Perform a binary search
        /// </summary>
        /// <param name="minIndex">The minimum index allowed</param>
        /// <param name="maxIndex">The maximum index allowed</param>
        /// <param name="compareToResult">Compare the item at the given index to the desired result (-1 less than, 0 equal to, 1 greater than)</param>
        /// <returns></returns>
        public static int? Find(int minIndex, int maxIndex, Func<int, int> compareToResult)
        {
            int high = maxIndex;
            int low = minIndex;

            while (high >= low)
            {
                var mid = low + ((high - low) / 2);

                var c = compareToResult(mid);

                //Found it!
                if (c == 0)
                    return mid;

                if (c > 0)
                    low = mid + 1;
                else
                    high = mid - 1;
            }

            //Not found :(
            return null;
        }
    }
}
