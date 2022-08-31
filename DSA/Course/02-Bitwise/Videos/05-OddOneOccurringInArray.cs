using Helper;

namespace DSA.Course._02_Bitwise.Videos
{
    internal static class _05_OddOneOccurringInArray
    {
        // Without bitwise operators
        // Time complexity - O(n²)
        internal static void Way01()
        {
            int[] numbers = { 1, 1, 2, 2, 3, 4, 4, 4, 4 };

            for (int i = 0; i < numbers.Length; i++)
            {
                int counts = 0;
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                        counts++;
                }

                if (counts % 2 != 0)
                {
                    Console.WriteLine($"{numbers[i]} is odd one in array.");
                    break;
                }
            }
        }

        // With bitwise xor
        // xor of 2 same number will be zero, so in the end odd value will be remain if we perform xor of all numbers
        // Time complexity - O(n)
        internal static void Way02()
        {
            int[] numbers = { 1, 1, 2, 2, 3, 3, 4, 4, 4 };

            int xorValue = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                xorValue = xorValue ^ numbers[i];
            }

            Console.WriteLine($"{xorValue} is odd one in array.");
        }
    }
}
