namespace DSA.Course._04_Array
{
    internal static class _11_FrequenciesInSortedArray
    {
        // Time complexity - O(n)
        // Auxiliary Space - O(1)
        internal static void Way01()
        {
            int[] array = new int[] { 1, 1, 1, 2, 2, 3, 4, 4 };

            int currentNumber = array[0];
            int currentCount = 1;
            for (int i = 1; i < array.Length; i++)
            {
                if (currentNumber != array[i])
                {
                    Console.WriteLine($"Number: {currentNumber}, Count: {currentCount}");
                    currentNumber = array[i];
                    currentCount = 1;
                }
                else
                {
                    currentCount++;
                }
            }

            Console.WriteLine($"Number: {currentNumber}, Count: {currentCount}");
        }

        // Time complexity - O(n)
        // Auxiliary Space - O(1)
        internal static void Way02()
        {
            int[] array = new int[] { 1, 1, 1, 2, 2, 3, 4, 4 };

            int i = 1;
            int counts = 1;

            while (i < array.Length)
            {
                while (i < array.Length && array[i] == array[i - 1])
                {
                    counts++;
                    i++;
                }
                Console.WriteLine($"Number: {array[i - 1]}, Count: {counts}");

                i++;
                counts = 1;
            }

            if (array.Length == 1 || array[array.Length - 1] != array[array.Length - 2])
                Console.WriteLine($"Number: {array[array.Length - 1]}, Count: {counts}");
        }
    }
}
