namespace DSA.Course._04_Array
{
    internal static class _14_MaximumConsecutiveOnes
    {
        internal static void Way01()
        {
            int[] array = new int[] { 1, 0, 1, 1, 0, 1, 1, 1, 1 };
            int maxConsecutive = 0;
            int currentConsecutive = 0;

            for (int i = 0; i < array.Length; i++)
            {
                while (i < array.Length && array[i] == 1)
                {
                    currentConsecutive++;
                    i++;
                }

                maxConsecutive = Math.Max(maxConsecutive, currentConsecutive);
                currentConsecutive = 0;
            }

            maxConsecutive = Math.Max(maxConsecutive, currentConsecutive);
            Console.WriteLine($"Maximum Consecutive: {maxConsecutive}");
        }

        internal static void Way02()
        {
            int[] array = new int[] { 1, 0, 1, 1, 0, 1, 0, 1, 1, 1, 0 };

            int maxConsecutive = 0;

            for (int i = 0; i < array.Length; i++)
            {
                int currentConsecutive = 0;
                for (int j = i; j < array.Length; j++)
                {
                    if (array[j] == 1) currentConsecutive++;
                    else break;
                }
                maxConsecutive = Math.Max(maxConsecutive, currentConsecutive);
            }

            Console.WriteLine($"Maximum Consecutive: {maxConsecutive}");
        }

        // Time complexity - O(n)
        // Auxiliary Space - O(1)
        internal static void Way03()
        {
            int[] array = new int[] { 1, 0, 1, 1, 0, 1, 1, 1 };
            int maxConsecutive = 0;
            int currentConsecutive = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == 0)
                    currentConsecutive = 0;
                else
                {
                    currentConsecutive++;
                    maxConsecutive = Math.Max(maxConsecutive, currentConsecutive);
                }
            }

            Console.WriteLine($"Maximum Consecutive: {maxConsecutive}");
        }
    }
}
