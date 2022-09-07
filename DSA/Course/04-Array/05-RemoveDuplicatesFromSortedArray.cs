using Helper;

namespace DSA.Course._04_Array
{
    internal static class _05_RemoveDuplicatesFromSortedArray
    {
        // Time complexity - O(n)
        // Auxiliary Space - O(1)
        internal static void Way01()
        {
            int[] array = new int[] { 10, 12, 12, 15, 18, 18, 20 };
            int size = array.Length;

            // Move each variable 1 step ahead if duplicate
            for (int i = 0, j = 1; j < array.Length; i++, j++)
            {
                if (array[i] == array[j])
                {
                    j++;
                    size--;
                }
                array[i + 1] = array[j];
            }

            // set value=0 for last duplicated indexes
            for (int i = size; i < array.Length; i++)
                array[i] = 0;

            ConsoleHelper.PrintArray(array);
            Console.WriteLine($"New size: {size}");
        }

        // Time complexity - O(n)
        // Auxiliary Space - O(1)
        internal static void Way02()
        {
            int[] array = new int[] { 10, 12, 12, 15, 18, 18, 20 };
            int j = 1;

            // Move each variable 1 step ahead if duplicate
            for (int i = 1; j < array.Length; i++)
            {
                if (array[i] != array[j - 1])
                {
                    array[j] = array[i];
                    j++;
                }
            }

            // set value=0 for last duplicated indexes
            for (int i = j; i < array.Length; i++)
                array[i] = 0;

            ConsoleHelper.PrintArray(array);
            Console.WriteLine($"New size: {j}");
        }

        // Time complexity - O(n)
        // Auxiliary Space - O(n)
        internal static void Way03()
        {
            int[] array = new int[] { 10, 12, 12, 15, 18, 18, 20 };
            int[] tempArr = new int[array.Length];
            int j = 1;
            tempArr[0] = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (tempArr[j - 1] != array[i])
                {
                    tempArr[j] = array[i];
                    j++;
                }
            }

            ConsoleHelper.PrintArray(tempArr);
            Console.WriteLine($"New size: {j}");
        }
    }
}
