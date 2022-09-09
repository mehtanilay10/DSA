using Helper;

namespace DSA.Course._04_Array
{
    internal static class _06_MoveZerosToEnd
    {
        // Time complexity - O(n)
        // Auxiliary Space - O(1)
        internal static void Way01()
        {
            int[] array = new int[] { 10, 20, 0, 30, 0, 40, 0, 50, 0, 0 };

            int j = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != 0)
                    array[j++] = array[i];
            }

            while (j < array.Length)
                array[j++] = 0;

            ConsoleHelper.PrintArray(array);
        }

        // Time complexity - O(n)
        // Auxiliary Space - O(1)
        internal static void Way02()
        {
            int[] array = new int[] { 10, 20, 0, 30, 0, 40, 0, 50, 0, 0 };

            for (int i = 0, j = 0; i < array.Length; i++)
            {
                if (array[i] != 0)
                {
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    j++;
                }
            }

            ConsoleHelper.PrintArray(array);
        }
    }
}
