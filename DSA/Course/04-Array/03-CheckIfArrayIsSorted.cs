namespace DSA.Course._04_Array
{
    internal static class _03_CheckIfArrayIsSorted
    {
        // Time complexity - O(n²)
        internal static void Way01()
        {
            int[] array = new int[] { 10, 12, 15, 18, 20, 30 };
            bool isSorted = true;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[i])
                    {
                        isSorted = false;
                        break;
                    }
                }
            }

            Console.WriteLine($"Is Sorted: {isSorted}");
        }

        // Time complexity - O(n)
        internal static void Way02()
        {
            int[] array = new int[] { 10, 12, 15, 18, 20, 10 };

            bool isSorted = true;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < array[i - 1])
                    isSorted = false;
            }

            Console.WriteLine($"Is Sorted: {isSorted}");
        }
    }
}
