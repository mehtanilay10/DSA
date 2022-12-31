namespace DSA.Course._04_Array
{
    internal static class _20_SlidingWindowTechnique
    {
        // Time complexity - O(n*k)
        // Auxiliary Space - O(1)
        internal static void Way01()
        {
            int[] array = new int[] { 5, 6, 2, -5, 8, 4, 3 };
            int windowSize = 3;
            int overallWindowMaxSum = int.MinValue;

            for (int i = 0; i <= array.Length - windowSize; i++)
            {
                int currentWindowSum = 0;
                for (int j = 0; j < windowSize; j++)
                    currentWindowSum += array[i + j];

                overallWindowMaxSum = Math.Max(overallWindowMaxSum, currentWindowSum);
            }

            Console.WriteLine($"Max sum within window is {overallWindowMaxSum}");
        }

        // Time complexity - O(n*k)
        // Auxiliary Space - O(1)
        internal static void Way02()
        {
            int[] array = new int[] { 5, 6, 2, -5, 8, 4, 3 };
            int windowSize = 3;
            int windowMaxSum = 0;

            for (int i = 0; i < windowSize; i++)
                windowMaxSum += array[i];

            for (int i = windowSize; i <= array.Length - windowSize; i++)
            {
                int currentWindowSum = windowMaxSum + array[i] - array[i - windowSize];
                windowMaxSum = Math.Max(windowMaxSum, currentWindowSum);
            }

            Console.WriteLine($"Max sum within window is {windowMaxSum}");
        }
    }
}
