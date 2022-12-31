namespace DSA.Course._04_Array
{
    internal static class _19_MinimumConsecutiveFlips
    {
        // Time complexity - O(n²)
        // Auxiliary Space - O(1)
        internal static void Way01()
        {
            int[] array = new int[] { 1, 1 };

            #region Step-1 [Identify value need to change]

            int valueChangedFromZeroToOne = 0;
            int valueChangedFromOneToZero = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] == 1 && array[i - 1] == 0)
                    valueChangedFromZeroToOne++;
                else if (array[i] == 0 && array[i - 1] == 1)
                    valueChangedFromOneToZero++;
            }

            // If all numbers are same then just return
            if (valueChangedFromOneToZero == 0 && valueChangedFromZeroToOne == 0)
            {
                Console.WriteLine($"Array already contains consecutive values.");
                return;
            }

            int valueNeedsToChange = valueChangedFromOneToZero > valueChangedFromZeroToOne ? 0 : 1;
            Console.WriteLine($"Value needs to change: {valueNeedsToChange}");

            #endregion

            #region Step 2 [Identify Indexes]

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == valueNeedsToChange)
                {
                    int startIndex = i;
                    while (i + 1 < array.Length && array[i + 1] == valueNeedsToChange)
                        i++;

                    if (startIndex == i)
                        Console.WriteLine($"On index {startIndex}");
                    else
                        Console.WriteLine($"From index {startIndex} to {i}");
                }
            }

            #endregion
        }

        // Time complexity - O(n)
        // Auxiliary Space - O(1)
        internal static void Way02()
        {
            int[] array = new int[] { 1, 0, 0, 1, 1, 0, 1, 0 };

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] != array[i - 1])
                {
                    if (array[i] != array[0])
                        Console.Write($"From {i}");
                    else
                        Console.WriteLine($" to {i - 1}");
                }
            }

            if (array[array.Length - 1] != array[0])
                Console.WriteLine($" to {array.Length - 1}");
        }
    }
}
