using Helper;

namespace DSA.Course._05_Search.Videos
{
    internal static class _06_CountOccurrencesInSorted
    {
        // Time complexity - O(n)
        // Auxiliary Space - O(1)
        internal static void Way01()
        {
            int[] array = new int[] { 1, 2, 2, 2, 3, 3, 3, 4 };
            int number = ConsoleHelper.ReadInteger();

            int counts = Way01FindCount(array, number);
            if (counts == 0)
                Console.WriteLine($"{number} not found.");
            else
                Console.WriteLine($"{number} first found {counts} time(s).");
        }

        private static int Way01FindCount(int[] array, int number)
        {
            int counts = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == number)
                {
                    while (i < array.Length && array[i] == number)
                    {
                        i++;
                        counts++;
                    }
                    break;
                }
            }

            return counts;
        }

        // Time complexity - O(n)
        // Auxiliary Space - O(1)
        internal static void Way02()
        {
            int[] array = new int[] { 1, 2, 2, 2, 3, 3, 3, 4 };
            int number = ConsoleHelper.ReadInteger();

            int firstIndex = Way02FindFirstIndex(array, number);
            if (firstIndex == -1)
                Console.WriteLine($"{number} not found.");
            else
            {
                int lastIndex = Way02FindLastIndex(array, number);
                int counts = lastIndex - firstIndex + 1;
                Console.WriteLine($"{number} first found {counts} time(s).");
            }
        }

        private static int Way02FindFirstIndex(int[] array, int number)
        {
            int low = 0;
            int high = array.Length - 1;

            while (low <= high)
            {
                int mid = low + ((high - low) / 2);
                if (array[mid] > number)
                    high = mid - 1;
                else if (array[mid] < number)
                    low = mid + 1;
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

        private static int Way02FindLastIndex(int[] array, int number)
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
                else
                {
                    if (mid == array.Length - 1 || array[mid + 1] != number)
                        return mid;
                    else
                        high = mid - 1;
                }
            }

            return -1;
        }

        // Time complexity - O(Log(n) + k)
        // Auxiliary Space - O(1)
        internal static void Way03()
        {
            int[] array = new int[] { 1, 2, 2, 2, 3, 3, 3, 4 };
            int number = ConsoleHelper.ReadInteger();

            int firstIndex = Way03FindFirstIndex(array, number);
            if (firstIndex == -1)
                Console.WriteLine($"{number} not found.");
            else
            {
                int counts = 0;
                while(firstIndex < array.Length && array[firstIndex] == number)
                {
                    counts++;
                    firstIndex++;
                }
                Console.WriteLine($"{number} first found {counts} time(s).");
            }
        }

        private static int Way03FindFirstIndex(int[] array, int number)
        {
            int low = 0;
            int high = array.Length - 1;

            while (low <= high)
            {
                int mid = low + ((high - low) / 2);
                if (array[mid] > number)
                    high = mid - 1;
                else if (array[mid] < number)
                    low = mid + 1;
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
