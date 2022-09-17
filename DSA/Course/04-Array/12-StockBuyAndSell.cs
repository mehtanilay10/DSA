namespace DSA.Course._04_Array
{
    internal static class _12_StockBuyAndSell
    {
        internal static void Way01()
        {
            int[] array = new int[] { 5, 8, 3, 1, 7, 2, 1 };
            int maxProfit = Way01FindMaxProfit(array, 0, array.Length - 1);
            Console.WriteLine($"Total Profit: {maxProfit}");
        }

        private static int Way01FindMaxProfit(int[] array, int startIndex, int endIndex)
        {
            int totalMaxProfit = 0;
            if (endIndex <= startIndex)
                return totalMaxProfit;

            for (int i = startIndex; i < endIndex; i++)
            {
                for (int j = i + 1; j <= endIndex; j++)
                {
                    if (array[j] > array[i])
                    {
                        int currentMaxProfit = array[j] - array[i]
                            + Way01FindMaxProfit(array, startIndex, i - 1)
                            + Way01FindMaxProfit(array, j + 1, endIndex);
                        totalMaxProfit = Math.Max(currentMaxProfit, totalMaxProfit);
                    }
                }
            }

            return totalMaxProfit;
        }

        // Time complexity - O(n)
        // Auxiliary Space - O(1)
        internal static void Way02()
        {
            int[] array = new int[] { 2, 5, 3, 1, 6, 9 };
            int totalProfit = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[i - 1])
                    totalProfit = totalProfit + array[i] - array[i - 1];
            }

            Console.WriteLine($"Total Profit: {totalProfit}");
        }
    }
}
