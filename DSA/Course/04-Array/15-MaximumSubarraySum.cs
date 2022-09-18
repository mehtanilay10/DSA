namespace DSA.Course._04_Array
{
    internal static class _15_MaximumSubarraySum
    {
        // Time complexity - O(n²)
        // Auxiliary Space - O(1)
        internal static void Way01()
        {
            int[] array = { 2, 3, -8, 7, -1, 2, 3 };

            int maxSum = int.MinValue;

            for (int i = 0; i < array.Length; i++)
            {
                int currentSum = 0;
                for (int j = i; j < array.Length; j++)
                {
                    currentSum = currentSum + array[j];
                    maxSum = Math.Max(maxSum, currentSum);
                }
            }

            Console.WriteLine($"Maximum subarray sum: {maxSum}");
        }

        // Time complexity - O(n)
        // Auxiliary Space - O(1)
        internal static void Way02()
        {
            int[] array = { 2, 3, -8, 7, -1, 2, 3 };

            int currentMaxSum = array[0];
            int maxSum = currentMaxSum;

            for (int i = 1; i < array.Length; i++)
            {
                currentMaxSum = Math.Max(array[i], currentMaxSum + array[i]);
                maxSum = Math.Max(maxSum, currentMaxSum);
            }

            Console.WriteLine($"Maximum subarray sum: {maxSum}");
        }
    }
}
