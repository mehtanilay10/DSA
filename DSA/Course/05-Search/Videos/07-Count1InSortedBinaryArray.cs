using Helper;

namespace DSA.Course._05_Search.Videos
{
    internal static class _07_Count1InSortedBinaryArray
    {
        // Time complexity - O(n)
        // Auxiliary Space - O(1)
        internal static void Way01()
        {
            int[] array = new int[] { 0, 0, 0, 1, 1, 1, 1, 1 };
            int number = 1;

            int counts = Way01FindCounts(array, number);
            if (counts == 0)
                Console.WriteLine($"{number} not found.");
            else
                Console.WriteLine($"{number} found {counts} time(s).");
        }

        private static int Way01FindCounts(int[] array, int number)
        {
            int counts = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == 1)
                    counts++;
            }

            return counts;
        }

        // Time complexity - O(Log(n))
        // Auxiliary Space - O(1)
        internal static void Way02()
        {
            int[] array = new int[] { 0, 0, 0, 1, 1, 1, 1, 1 };
            int number = 1;

            int counts = Way02FindCounts(array, number);
            if (counts == 0)
                Console.WriteLine($"{number} not found.");
            else
                Console.WriteLine($"{number} found {counts} time(s).");
        }

        private static int Way02FindCounts(int[] array, int number)
        {
            if (array[0] == 1)
                return array.Length;

            if (array[array.Length - 1] == 0)
                return 0;

            int firstOccurenceIndex = Way02FindFirstOccurrence(array, number);
            if (firstOccurenceIndex == -1)
                return 0;
            else
                return array.Length - firstOccurenceIndex;
        }

        private static int Way02FindFirstOccurrence(int[] array, int number)
        {
            int low = 0;
            int high = array.Length - 1;

            while (low <= high)
            {
                int mid = low + ((high - low) / 2);

                if (number > array[mid])
                    low = mid + 1;
                else if (number < array[mid])
                    high = mid - 1;
                else
                {
                    if (mid == 0 || array[mid - 1] != number)
                        return mid;
                    else
                        high = mid - 1;
                }
            }

            return -1;
        }
    }
}
