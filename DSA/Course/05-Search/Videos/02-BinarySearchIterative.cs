using Helper;

namespace DSA.Course._05_Search.Videos
{
    internal static class _02_BinarySearchIterative
    {
        // Time complexity - O(log n)
        // Auxiliary Space - O(1)
        internal static void Way01()
        {
            int[] array = new int[] { 1, 3, 4, 5, 7, 8, 10 };
            int number = ConsoleHelper.ReadInteger();

            int index = Way01BinarySearch(array, number);
            if (index == -1)
                Console.WriteLine($"{number} not found.");
            else
                Console.WriteLine($"{number} found on index {index}.");
        }

        private static int Way01BinarySearch(int[] array, int number)
        {
            int lowerIndex = 0;
            int higherIndex = array.Length - 1;
            int middleIndex = lowerIndex + (higherIndex - lowerIndex) / 2;

            while (lowerIndex <= higherIndex)
            {
                if (array[middleIndex] == number)
                    return middleIndex;

                if (array[middleIndex] > number)
                    higherIndex = middleIndex - 1;
                else if (array[middleIndex] < number)
                    lowerIndex = middleIndex + 1;
            }

            return -1;
        }
    }
}
