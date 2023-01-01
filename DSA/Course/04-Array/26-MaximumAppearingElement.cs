namespace DSA.Course._04_Array
{
    internal static class _26_MaximumAppearingElement
    {
        // Time complexity - O(n * max)
        // Auxiliary Space - O(max)
        internal static void Way01()
        {
            const int MAX_ELEMENTS = 100;
            int[] leftIndexes = new int[] { 1, 2, 5, 15 };
            int[] rightIndexes = new int[] { 5, 8, 7, 18 };

            int[] counts = new int[MAX_ELEMENTS];
            for (int i = 0; i < rightIndexes.Length; i++)
            {
                for (int j = leftIndexes[i]; j <= rightIndexes[i]; j++)
                    counts[j] += 1;
            }

            int maxCountIndex = 0;
            for (int i = 0; i < MAX_ELEMENTS; i++)
            {
                if (counts[i] > counts[maxCountIndex])
                    maxCountIndex = i;
            }

            Console.WriteLine($"MaximumAppearingElement: {maxCountIndex} ({counts[maxCountIndex]} time(s))");
        }

        // Time complexity - O(n + max)
        // Auxiliary Space - O(max)
        internal static void Way02()
        {
            const int MAX_ELEMENTS = 100;
            int[] leftIndexes = new int[] { 1, 2, 5, 15 };
            int[] rightIndexes = new int[] { 5, 8, 7, 18 };
            int[] counts = new int[MAX_ELEMENTS + 1];

            // Mark starting & ending indexes
            for (int i = 0; i < rightIndexes.Length; i++)
            {
                counts[leftIndexes[i]]++;
                counts[rightIndexes[i] + 1]--;
            }

            // Find prefix sum of that
            int[] prefixArray = new int[counts.Length];
            prefixArray[0] = counts[0];
            for (int i = 1; i < counts.Length; i++)
                prefixArray[i] = prefixArray[i - 1] + counts[i];

            // Identify max prefix sum index
            int maxCountIndex = 0;
            for (int i = 0; i < prefixArray.Length; i++)
            {
                if (prefixArray[i] > prefixArray[maxCountIndex])
                    maxCountIndex = i;
            }

            Console.WriteLine($"MaximumAppearingElement: {maxCountIndex} ({prefixArray[maxCountIndex]} time(s))");
        }
    }
}
