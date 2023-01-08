using Helper;

namespace DSA.Course._05_Search.Videos
{
    internal static class _03_BinarySearchRecursive
    {
        //  Time complexity - O(log n)
        // Auxiliary Space - O(log n)
        internal static void Way01()
        {
            int[] array = new int[] { 1, 3, 4, 5, 7, 8, 10 };
            int number = ConsoleHelper.ReadInteger();

            int index = Way01BinarySearch(array, number, 0, array.Length - 1);
            if (index == -1)
                Console.WriteLine($"{number} not found.");
            else
                Console.WriteLine($"{number} found on index {index}.");
        }

        private static int Way01BinarySearch(int[] array, int number, int lowerIndex, int higherIndex)
        {
            if (higherIndex < lowerIndex)
                return -1;

            int middleIndex = lowerIndex + (higherIndex - lowerIndex) / 2;
            if (array[middleIndex] == number)
                return middleIndex;

            if (array[middleIndex] > number)
                return Way01BinarySearch(array, number, lowerIndex, middleIndex - 1);
            else
                return Way01BinarySearch(array, number, middleIndex + 1, higherIndex);
        }
    }
}
