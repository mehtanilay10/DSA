using Helper;

namespace DSA.Additional._05_Search
{
    internal class _01_TernarySearch
    {
        // Time complexity - O(Log3N)
        // Auxiliary Space - O(1)

        internal static void Way01()
        {
            int[] array = new int[] { 1, 2, 3, 5, 8, 10, 11, 12, 15, 18 };
            int number = ConsoleHelper.ReadInteger();

            int index = Way01Search(array, number);
            if (index == -1)
                Console.WriteLine($"Not found {number}");
            else
                Console.WriteLine($"{number} found on index {index}.");
        }

        private static int Way01Search(int[] array, int number)
        {
            int low = 0;
            int high = array.Length - 1;

            while (low <= high)
            {
                int mid1 = low + ((high - low) / 3);
                int mid2 = high - ((high - low) / 3);

                if (array[mid1] == number)
                    return mid1;
                else if (array[mid2] == number)
                    return mid2;

                if (number < array[mid1])
                    high = mid1 - 1;
                else if (number > array[mid2])
                    low = mid2 + 1;
                else
                {
                    low = mid1 + 1;
                    high = mid2 - 1;
                }
            }

            return -1;
        }
    }
}
