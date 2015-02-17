using System;

namespace BinarySearch
{
    public static class Binary
    {
        /// <summary>
        /// Perform a binary search
        /// </summary>
        /// <param name="minIndex">The minimum index allowed</param>
        /// <param name="maxIndex">The maximum index allowed</param>
        /// <param name="compareToResult">Compare the item at the given index to the desired result (-1 less than, 0 equal to, 1 greater than)</param>
        /// <returns></returns>
        public static int? Search(ref int minIndex, ref int maxIndex, Func<int, int> compareToResult)
        {
            while (maxIndex >= minIndex)
            {
                var mid = minIndex + ((maxIndex - minIndex) / 2);

                var c = compareToResult(mid);

                //Found it!
                if (c == 0)
                    return mid;

                if (c > 0)
                    minIndex = mid + 1;
                else
                    maxIndex = mid - 1;
            }

            //Not found :(

            //Swap min and max into right order
            var tmp = maxIndex;
            maxIndex = minIndex;
            minIndex = tmp;

            return null;
        }

        /// <summary>
        /// Perform a binary search
        /// </summary>
        /// <param name="minIndex">The minimum index allowed</param>
        /// <param name="maxIndex">The maximum index allowed</param>
        /// <param name="compareToResult">Compare the item at the given index to the desired result (-1 less than, 0 equal to, 1 greater than)</param>
        /// <returns></returns>
        public static int? Search(int minIndex, int maxIndex, Func<int, int> compareToResult)
        {
            return Search(ref minIndex, ref maxIndex, compareToResult);
        }
    }
}
