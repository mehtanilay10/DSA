using Helper;

namespace DSA.Course._05_Search.Videos
{
    internal static class _10_SearchInSortedRotatedArray
    {
        // Time complexity - O(Log(n))
        // Auxiliary Space - O(1)
        internal static void Way01()
        {
            int[] array = new int[] { 8, 10, 12, 15, 2, 3, 5, 7 };
            int number = ConsoleHelper.ReadInteger();

            int index = Way01FindIndex(array, number);
            if (index == -1)
                Console.WriteLine($"Not found {number}");
            else
                Console.WriteLine($"Found {number} on index {index}");
        }

        private static int Way01FindIndex(int[] array, int number)
        {
            int low = 0;
            int high = array.Length - 1;

            while (low <= high)
            {
                int mid = low + (high - low) / 2;
                if (array[mid] == number)
                    return mid;
                if (array[low] < array[mid])
                {
                    if (array[low] <= number && number <= array[mid])
                        high = mid - 1;
                    else
                        low = mid + 1;
                }
                else
                {
                    if (array[mid] <= number && number <= array[high])
                        low = mid + 1;
                    else
                        high = mid - 1;
                }
            }

            return -1;
        }
    }
}
