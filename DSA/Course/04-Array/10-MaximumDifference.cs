namespace DSA.Course._04_Array
{
    internal static class _10_MaximumDifference
    {
        // Time complexity - O(n²)
        internal static void Way01()
        {
            int[] array = new int[] { 2, 4, 8, 3, 7, 6, 1, 5 };

            int maxDiff = array[1] - array[0];
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    maxDiff = Math.Max(maxDiff, array[j] - array[i]);
                }
            }

            Console.WriteLine($"Max diff: {maxDiff}");
        }

        // Time complexity - O(n)
        internal static void Way02()
        {
            int[] array = new int[] { 2, 4, 8, 3, 7, 6, 1, 5 };

            int maxDiff = array[1] - array[0];
            int minValue = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                maxDiff = Math.Max(maxDiff, array[i] - minValue);
                minValue = Math.Min(minValue, array[i]);
            }

            Console.WriteLine($"Max diff: {maxDiff}");
        }
    }
}
