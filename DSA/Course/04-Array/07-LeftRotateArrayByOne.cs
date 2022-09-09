using Helper;

namespace DSA.Course._04_Array
{
    internal static class _07_LeftRotateArrayByOne
    {
        // Time complexity - O(n)
        // Auxiliary Space - O(1)
        internal static void Way01()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5 };

            int temp = array[0];
            for (int i = 1; i < array.Length; i++)
                array[i - 1] = array[i];
            array[array.Length - 1] = temp;

            ConsoleHelper.PrintArray(array);
        }
    }
}
