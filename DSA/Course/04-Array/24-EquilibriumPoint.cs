namespace DSA.Course._04_Array
{
    internal static class _24_EquilibriumPoint
    {
        // Time complexity - O(n²)
        // Auxiliary Space - O(1)
        internal static void Way01()
        {
            int[] array = new int[] { 3, 4, 8, -9, 20, 6 };
            bool hasEquilibriumPoint = false;

            for (int i = 0; i < array.Length; i++)
            {
                int leftSideSum = 0;
                int rightSideSum = 0;

                for (int j = 0; j < i; j++)
                    leftSideSum += array[j];
                for (int j = i + 1; j < array.Length; j++)
                    rightSideSum += array[j];

                if (leftSideSum == rightSideSum)
                {
                    hasEquilibriumPoint = true;
                    break;
                }
            }

            Console.WriteLine($"HasEquilibriumPoint: {hasEquilibriumPoint}");
        }

        // Time complexity - O(n)
        // Auxiliary Space - O(n)
        internal static void Way02()
        {
            int[] array = new int[] { 5, 6, 5, 2, -2 };
            bool hasEquilibriumPoint = false;

            int[] prefixSumArray = new int[array.Length];
            prefixSumArray[0] = array[0];
            for (int i = 1; i < array.Length; i++)
                prefixSumArray[i] = prefixSumArray[i - 1] + array[i];

            int[] suffixSumArray = new int[array.Length];
            suffixSumArray[array.Length - 1] = array[array.Length - 1];
            for (int i = array.Length - 2; i >= 0; i--)
                suffixSumArray[i] = suffixSumArray[i + 1] + array[i];

            for (int i = 0; i < array.Length; i++)
            {
                if (prefixSumArray[i] == suffixSumArray[i])
                {
                    hasEquilibriumPoint = true;
                    break;
                }
            }

            Console.WriteLine($"HasEquilibriumPoint: {hasEquilibriumPoint}");
        }

        // Time complexity - O(n)
        // Auxiliary Space - O(1)
        internal static void Way03()
        {
            int[] array = new int[] { 3, 4, 8, -9, 20, 6 };
            bool hasEquilibriumPoint = false;
            int rightSideSum = 0;

            for (int i = 0; i < array.Length; i++)
                rightSideSum += array[i];

            int leftSideSum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                rightSideSum = rightSideSum - array[i];

                if (leftSideSum == rightSideSum)
                {
                    hasEquilibriumPoint = true;
                    break;
                }

                leftSideSum = leftSideSum + array[i];
            }

            Console.WriteLine($"HasEquilibriumPoint: {hasEquilibriumPoint}");
        }

    }
}
