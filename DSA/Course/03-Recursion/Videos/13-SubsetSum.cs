namespace DSA.Course._03_Recursion.Videos
{
    internal static class _13_SubsetSum
    {
        #region Way01

        internal static void Way01()
        {
            int[] numbers = new[] { 10, 5, 2, 3, 6, 8, 0 };
            int sum = 8;
            int counts = Way01CheckSum(numbers, new int[] { }, 0, sum);
            Console.WriteLine($"Counts = {counts}");
        }

        private static int Way01CheckSum(int[] numbers, int[] currentArray, int maxItems, int expectedSumValue)
        {
            if (numbers.Length == maxItems)
            {
                int sum = Way01DoSum(currentArray);
                return sum == expectedSumValue ? 1 : 0;
            }

            return Way01CheckSum(numbers, currentArray, maxItems + 1, expectedSumValue)
                 + Way01CheckSum(numbers, Way01AddItemInArray(currentArray, numbers[maxItems]), maxItems + 1, expectedSumValue);
        }

        // Peform summation of all items in array
        private static int Way01DoSum(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];
            }
            return sum;
        }

        // Returns new array by adding item at the end
        private static int[] Way01AddItemInArray(int[] arr, int value)
        {
            int[] items = new int[arr.Length + 1];
            for (int i = 0; i < arr.Length; i++)
            {
                items[i] = arr[i];
            }
            items[items.Length - 1] = value;
            return items;
        }

        #endregion

        #region Way02

        // Time complexity - O(2^n)
        internal static void Way02()
        {
            int[] numbers = new[] { 10, 5, 2, 3, 6, 8, 0 };
            int sum = 8;
            int counts = Way02CheckSum(numbers, numbers.Length, sum);
            Console.WriteLine($"Counts = {counts}");
        }

        private static int Way02CheckSum(int[] numbers, int length, int sum)
        {
            if (length == 0)
                return sum == 0 ? 1 : 0;

            return Way02CheckSum(numbers, length - 1, sum)
                + Way02CheckSum(numbers, length - 1, sum - numbers[length - 1]);
        }

        #endregion
    }
}
