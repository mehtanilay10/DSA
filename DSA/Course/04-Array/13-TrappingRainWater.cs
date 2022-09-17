namespace DSA.Course._04_Array
{
    internal static class _13_TrappingRainWater
    {
        // Time complexity - O(n²)
        // Auxiliary Space - O(1)
        internal static void Way01()
        {
            int[] array = new int[] { 5, 0, 4, 2, 5 };

            int totalCapacity = 0;

            for (int i = 1; i < array.Length - 1; i++)
            {
                int leftMaxValue = array[i];
                for (int j = 0; j < i; j++)
                    leftMaxValue = Math.Max(leftMaxValue, array[j]);

                int rightMaxValue = array[i];
                for (int j = i + 1; j < array.Length; j++)
                    rightMaxValue = Math.Max(rightMaxValue, array[j]);

                totalCapacity += Math.Min(leftMaxValue, rightMaxValue) - array[i];
            }

            Console.WriteLine($"Total capacity: {totalCapacity}");
        }

        // Time complexity - O(n)
        // Auxiliary Space - O(n)
        internal static void Way02()
        {
            int[] array = new int[] { 5, 3, 2, 2, 4, 6 };

            int[] leftMaxValues = new int[array.Length];
            int[] rightMaxValues = new int[array.Length];
            int totalCapacity = 0;

            leftMaxValues[0] = array[0];
            for (int i = 1; i < array.Length; i++)
                leftMaxValues[i] = Math.Max(array[i], leftMaxValues[i - 1]);

            rightMaxValues[array.Length - 1] = array[array.Length - 1];
            for (int i = array.Length - 2; i >= 0; i--)
                rightMaxValues[i] = Math.Max(array[i], leftMaxValues[i + 1]);

            for (int i = 1; i < array.Length; i++)
                totalCapacity = totalCapacity + Math.Min(leftMaxValues[i], rightMaxValues[i]) - array[i];

            Console.WriteLine($"Total capacity: {totalCapacity}");
        }
    }
}
