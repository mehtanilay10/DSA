namespace DSA.Course._02_Bitwise.Videos
{
    internal static class _07_OddTwoOccurringInArray
    {
        // Without bitwise operators
        // Time complexity - O(n²)
        internal static void Way01()
        {
            int[] numbers = { 1, 1, 2, 2, 3, 4, 4, 5, 6, 6 };

            for (int i = 0; i < numbers.Length; i++)
            {
                int counts = 0;
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                        counts++;
                }

                if (counts % 2 != 0)
                    Console.WriteLine($"{numbers[i]} is odd in array.");
            }
        }

        internal static void Way02()
        {
            int[] numbers = { 1, 1, 2, 2, 3, 4, 4, 5, 6, 6 };
            int xorValue = 0;

            // Find xor of all values, after this now we will get xor of 2 odd values only
            // as same values will be converted to zero.
            for (int i = 0; i < numbers.Length; i++)
                xorValue = xorValue ^ numbers[i];

            // find right-most setted bit
            int rightMostSettedBit = xorValue ^ (~(xorValue - 1));
            int xorValue1 = 0, xorValue2 = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                // one of value must be give zero with right-most setted bit, and another will give some value.
                // so loop through again, and perform xor for both case
                if ((numbers[i] & rightMostSettedBit) != 0)
                    xorValue1 = xorValue1 ^ numbers[i];
                else
                    xorValue2 = xorValue2 ^ numbers[i];
            }

            Console.WriteLine($"Odd values in array are - [{xorValue1}, {xorValue2}]");
        }
    }
}
