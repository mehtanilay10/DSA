namespace DSA.Course._04_Array
{
    internal static class _21_SubarrayWithGivenSum
    {
        // Time complexity - O(n²)
        // Auxiliary Space - O(1)
        internal static void Way01()
        {
            int[] array = new int[] { 5, 8, 3, 6, 4, 2 };
            int expectedSum = 7;
            bool isFound = false;

            for (int i = 0; i < array.Length; i++)
            {
                int currentSum = array[i];
                for (int j = i + 1; j < array.Length && currentSum < expectedSum; j++)
                    currentSum += array[j];

                if (currentSum == expectedSum)
                    isFound = true;
            }

            Console.WriteLine($"IsFound: {isFound}");
        }

        // Time complexity - O(n)
        // Auxiliary Space - O(1)
        internal static void Way02()
        {
            int[] array = new int[] { 8, 5, 3, 4, 7, 2 };
            int expectedSum = 12;

            int currentWindowSum = 0;
            bool isFound = false;

            int startingIndex = 0, endingIndex = 0;
            bool shouldSubtractStartIndexValue = false, shouldAddEndIndexValue = true;

            while (startingIndex < array.Length && endingIndex < array.Length)
            {
                if (shouldAddEndIndexValue)
                    currentWindowSum = currentWindowSum + array[endingIndex];

                if (shouldSubtractStartIndexValue)
                    currentWindowSum = currentWindowSum - array[startingIndex - 1];

                if (currentWindowSum == expectedSum)
                {
                    isFound = true;
                    break;
                }

                if (currentWindowSum > expectedSum)
                {
                    startingIndex++;
                    shouldAddEndIndexValue = false;
                    shouldSubtractStartIndexValue = true;
                }
                else
                {
                    endingIndex++;
                    shouldAddEndIndexValue = true;
                    shouldSubtractStartIndexValue = false;
                }
            }

            Console.WriteLine($"IsFound: {isFound}");
        }

        // Time complexity - O(n)
        // Auxiliary Space - O(1)
        internal static void Way03()
        {
            int[] array = new int[] { 5, 8, 3, 6, 7, 2, 4 };
            int expectedSum = 13;

            int startIndex = 0;
            int currentSum = 0;
            bool isFound = false;

            for (int endIndex = 0; endIndex < array.Length; endIndex++)
            {
                currentSum += array[endIndex];

                if (currentSum == expectedSum)
                {
                    isFound = true;
                    break;
                }

                while (currentSum > expectedSum)
                {
                    currentSum -= array[startIndex];
                    startIndex++;
                }
            }

            Console.WriteLine($"IsFound: {isFound}");
        }
    }
}
