using Helper;

namespace DSA.Course._05_Search.Videos
{
    internal static class _04_IndexOfFirstOccurrenceInSorted
    {
        // Time complexity - O(n)
        // Auxiliary Space - O(1)
        internal static void Way01()
        {
            int[] array = new int[] { 1, 2, 2, 2, 3, 3, 3, 4 };
            int number = ConsoleHelper.ReadInteger();

            int index = Way01FindIndex(array, number);
            if (index == -1)
                Console.WriteLine($"{number} not found.");
            else
                Console.WriteLine($"{number} first found on index {index}.");
        }

        private static int Way01FindIndex(int[] array, int number)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == number)
                    return i;
            }

            return -1;
        }

        // Time complexity - O(log n)
        // Auxiliary Space - O(1)
        internal static void Way02()
        {
            int[] array = new int[] { 1, 2, 2, 2, 3, 3, 3, 4 };
            int number = ConsoleHelper.ReadInteger();

            int index = Way02FindIndex(array, number);
            if (index == -1)
                Console.WriteLine($"{number} not found.");
            else
                Console.WriteLine($"{number} first found on index {index}.");
        }

        private static int Way02FindIndex(int[] array, int number)
        {
            int low = 0;
            int high = array.Length - 1;

            while (low <= high)
            {
                int mid = low + ((high - low) / 2);
                
                if (array[mid] < number)
                    low = mid + 1;
                else if (array[mid] > number)
                    high = mid - 1;
                else if (array[mid] == number)
                {
                    if (mid == 0 || array[mid - 1] != array[mid])
                        return mid;
                    else 
                        high = mid - 1;
                }
            }

            return -1;
        }
    }
}
