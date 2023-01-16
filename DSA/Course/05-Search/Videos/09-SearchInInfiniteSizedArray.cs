using Helper;

namespace DSA.Course._05_Search.Videos
{
    // Unbounded Binary Search
    // Given an infinite sized array, we need to write an efficient solution to search an element.
    // Here we are not going to use length as well as given number must be exist in array.
    internal static class _09_SearchInInfiniteSizedArray
    {
        // Time complexity - O(position)
        // Auxiliary Space - O(1)
        internal static void Way01()
        {
            int[] array = new int[] { 1, 2, 3, 5, 8, 10, 12, 15, 18, 20, 25, 30, 32, 35, 38, 45, 48, 50 };
            int number = ConsoleHelper.ReadInteger();

            int index = Way01FindIndex(array, number);
            if (index == -1)
                Console.WriteLine($"Not found number {number}");
            else
                Console.WriteLine($"{number} found on index {index}");
        }

        private static int Way01FindIndex(int[] array, int number)
        {
            int i = 0;
            while(true)
            {
                if (array[i] == number)
                    return i;
                if (array[i] > number)
                    return -1;
                i++;
            }
        }

        // Time complexity - O(Log(position))
        // Auxiliary Space - O(1)
        internal static void Way02()
        {
            int[] array = new int[] { 1, 2, 3, 5, 8, 10, 12, 15, 18, 20, 25, 30, 32, 35, 38, 45, 48, 50 };
            int number = ConsoleHelper.ReadInteger();

            int index = Way02FindIndex(array, number);
            if (index == -1)
                Console.WriteLine($"Not found number {number}");
            else
                Console.WriteLine($"{number} found on index {index}");
        }

        private static int Way02FindIndex(int[] array, int number)
        {
            if (array[0] == number)
                return 0;

            int i = 1;
            while (array[i] < number)
                i = i * 2;

            if (array[i] == number)
                return i;

            int index = Way02DoBinarySearch(array, number, (i / 2) + 1, i - 1);
            return index;
        }

        private static int Way02DoBinarySearch(int[] array, int number, int low, int high)
        {
            while (low <= high)
            {
                int mid = low + (high - low) / 2;
                if (array[mid] == number)
                    return mid;
                else if (array[mid] > number)
                    high = mid - 1;
                else
                    low = mid + 1;
            }

            return -1;
        }
    }
}
