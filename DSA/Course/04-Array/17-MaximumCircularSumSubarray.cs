namespace DSA.Course._04_Array
{
    internal static class _17_MaximumCircularSumSubarray
    {
        // Time complexity - O(n²)
        // Auxiliary Space - O(1)
        internal static void Way01()
        {
            int[] array = new int[] { 5, -2, 3, -4 };
            int maxSum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                int currentSum = array[i];
                int currentMaxSum = array[i];
                for (int j = 1; j < array.Length; j++)
                {
                    int index = (i + j) % array.Length;
                    currentSum = currentSum + array[index];
                    currentMaxSum = Math.Max(currentMaxSum, currentSum);
                }

                maxSum = Math.Max(maxSum, currentMaxSum);
            }

            Console.WriteLine($"Max sum: {maxSum}");
        }

        // Time complexity - O(n)
        // Auxiliary Space - O(1)
        internal static void Way02()
        {
            int[] array = new int[] { 5, 3, -2, 4, -6, 1 };

            int normalMaxSum = Way02GetNormalMaxSum(array);
            if (normalMaxSum < 0)
            {
                // If all values are negative then that will be same as normalMaxSum
                Console.WriteLine($"Max sum: {normalMaxSum}");
                return;
            }

            int arraySum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                arraySum = arraySum + array[i];
                array[i] = -array[i]; // Negate value for finding min sum
            }

            int normalMinSum = Way02GetNormalMaxSum(array);
            int maxSum = Math.Max(normalMaxSum, (arraySum + normalMinSum));
            Console.WriteLine($"Max sum: {maxSum}");
        }

        private static int Way02GetNormalMaxSum(int[] array)
        {
            int currentMaxSum = array[0];
            int maxSum = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                currentMaxSum = Math.Max(array[i], currentMaxSum + array[i]);
                maxSum = Math.Max(maxSum, currentMaxSum);
            }

            return maxSum;
        }
    }
}
