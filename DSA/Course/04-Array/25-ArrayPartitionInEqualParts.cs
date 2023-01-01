namespace DSA.Course._04_Array
{
    internal static class _25_ArrayPartitionInEqualParts
    {
        // Time complexity - O(n)
        // Auxiliary Space - O(n)
        internal static void Way01()
        {
            int[] array = new int[] { 5, 2, 6, 1, 1, 1, 1, 4 };

            int sum = 0;
            int[] prefixSum = new int[array.Length];
            prefixSum[0] = array[0];
            sum = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                sum += array[i];
                prefixSum[i] = prefixSum[i - 1] + array[i];
            }

            int expectedSumOfSubArray = sum / 3;
            int counts = 0;
            for (int i = 0; i < prefixSum.Length; i++)
            {
                if (prefixSum[i] % expectedSumOfSubArray == 0)
                    counts++;
            }

            Console.WriteLine($"Is 3 equal sub array exists: {counts == 3}");
        }

        // Time complexity - O(n)
        // Auxiliary Space - O(1)
        internal static void Way02()
        {
            int[] array = new int[] { 5, 2, 6, 1, 1, 1, 1, 4 };

            int sum = 0;
            for (int i = 0; i < array.Length; i++)
                sum += array[i];

            int expectedSumOfSubArray = sum / 3;
            int counts = 0;
            int currentSum = sum;

            for (int i = 0; i < array.Length; i++)
            {
                currentSum = currentSum - array[i];
                if (currentSum % expectedSumOfSubArray == 0)
                    counts++;
            }

            Console.WriteLine($"Is 3 equal sub array exists: {counts == 3}");
        }
    }
}
