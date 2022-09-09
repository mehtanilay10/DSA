using Helper;

namespace DSA.Course._04_Array
{
    internal static class _08_LeftRotateArrayByDPlaces
    {
        // Time complexity - O(n*d)
        // Auxiliary Space - O(1)
        internal static void Way01()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            int d = ConsoleHelper.ReadInteger();

            for (int i = 0; i < d; i++)
                array = Way01LeftRotateByOne(array);

            ConsoleHelper.PrintArray(array);
        }

        private static int[] Way01LeftRotateByOne(int[] array)
        {
            int temp = array[0];
            for (int i = 1; i < array.Length; i++)
                array[i - 1] = array[i];
            array[array.Length - 1] = temp;
            return array;
        }

        // Time complexity - O(n)
        // Auxiliary Space - O(d)
        internal static void Way02()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            int d = ConsoleHelper.ReadInteger();

            int[] tempArray = new int[d];

            // Copy to temp
            for (int i = 0; i < d; i++)
                tempArray[i] = array[i];

            // Shift to D place
            for (int i = d; i < array.Length; i++)
                array[i - d] = array[i];

            // Copy back from temp
            for (int i = 0; i < tempArray.Length; i++)
                array[i + array.Length - d] = tempArray[i];

            ConsoleHelper.PrintArray(array);
        }

        // Time complexity - O(n)
        // Auxiliary Space - O(1)
        internal static void Way03()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            int d = ConsoleHelper.ReadInteger();

            array = Way03ReverseArray(array, 0, d - 1);
            array = Way03ReverseArray(array, d, array.Length - 1);
            array = Way03ReverseArray(array, 0, array.Length - 1);

            ConsoleHelper.PrintArray(array);
        }

        private static int[] Way03ReverseArray(int[] array, int lowIndex, int highIndex)
        {
            while (lowIndex < highIndex)
            {
                int temp = array[highIndex];
                array[highIndex] = array[lowIndex];
                array[lowIndex] = temp;

                lowIndex++; highIndex--;
            }

            return array;
        }
    }
}
