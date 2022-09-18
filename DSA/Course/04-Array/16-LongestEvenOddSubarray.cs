namespace DSA.Course._04_Array
{
    internal static class _16_LongestEvenOddSubarray
    {
        // Time complexity - O(n)
        // Auxiliary Space - O(1)
        internal static void Way01()
        {
            int[] array = new int[] { 10, 12, 14, 7, 8 };

            int longestCount = 1;
            for (int i = 0; i < array.Length; i++)
            {
                bool islastDigitIsOdd = array[i] % 2 != 0;
                int currentCount = 1;
                i++;

                while (i < array.Length)
                {
                    if ((islastDigitIsOdd && array[i] % 2 == 0)
                        || (!islastDigitIsOdd && array[i] % 2 != 0))
                    {
                        i++;
                        currentCount++;
                        islastDigitIsOdd = !islastDigitIsOdd;
                    }
                    else
                    {
                        break;
                    }
                }

                longestCount = Math.Max(longestCount, currentCount);
            }

            Console.WriteLine($"Longest count: {longestCount}");
        }

        // Time complexity - O(n²)
        // Auxiliary Space - O(1)
        internal static void Way02()
        {
            int[] array = new int[] { 10, 12, 14, 7, 8 };

            int longestCount = 0;
            for (int i = 0; i < array.Length; i++)
            {
                int currentCount = 1;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if ((array[j] % 2 == 0 && array[j - 1] % 2 != 0)
                        || (array[j] % 2 != 0 && array[j - 1] % 2 == 0))
                        currentCount++;
                    else
                        break;
                }

                longestCount = Math.Max(longestCount, currentCount);
            }

            Console.WriteLine($"Longest count: {longestCount}");
        }


        // Time complexity - O(n)
        // Auxiliary Space - O(1)
        internal static void Way03()
        {
            int[] array = new int[] { 10, 12, 14, 7, 8 };

            int longestCount = 0;
            int currentCount = 1;
            for (int i = 1; i < array.Length; i++)
            {
                if ((array[i] % 2 == 0 && array[i - 1] % 2 != 0)
                    || (array[i] % 2 != 0 && array[i - 1] % 2 == 0))
                {
                    currentCount++;
                    longestCount = Math.Max(longestCount, currentCount);
                }
                else
                    currentCount = 0;
            }

            Console.WriteLine($"Longest count: {longestCount}");
        }
    }
}
