using Helper;

namespace DSA.Course._04_Array
{
    internal static class _04_ReverseAnArray
    {
        // Time complexity - O(n)
        // Auxiliary Space - O(n)
        internal static void Way01()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            int[] reverseArray = new int[array.Length];

            int j = 0;
            for (int i = array.Length - 1; i >= 0; i--)
            {
                reverseArray[j++] = array[i];
            }

            ConsoleHelper.PrintArray(reverseArray);
        }

        // Time complexity - O(n)
        // Auxiliary Space - O(1)
        internal static void Way02()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7 };

            for (int lowerIndex = 0, higherIndex = array.Length - 1; lowerIndex < higherIndex; lowerIndex++, higherIndex--)
            {
                int temp = array[lowerIndex];
                array[lowerIndex] = array[higherIndex];
                array[higherIndex] = temp;
            }

            ConsoleHelper.PrintArray(array);
        }
    }
}
