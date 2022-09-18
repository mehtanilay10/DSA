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
    }
}
