namespace DSA.Course._02_Bitwise.Videos
{
    internal static class _06_FindMissingNumberInArray
    {
        // without bitwise operator
        // Time complexity - O(n²)
        internal static void Way01()
        {
            int[] numbers = { 1, 5, 6, 3, 2 };
            int length = 6; // 4 is missing

            for (int i = 1; i <= length; i++)
            {
                bool isFound = false;
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (i == numbers[j])
                        isFound = true;
                }

                if (!isFound)
                {
                    Console.WriteLine($"{i} is missing in array.");
                    break;
                }
            }
        }

        // with bitwise operator - xor
        // Time complexity - O(n)
        internal static void Way02()
        {
            int[] numbers = { 1, 5, 6, 3, 2 };
            int length = 6; // 4 is missing

            int xorValue = 0;
            // first do xor of all values till length
            for (int i = 1; i <= length; i++)
                xorValue = xorValue ^ i;

            // Now do xor with values available in array.
            for (int i = 0; i < numbers.Length; i++)
                xorValue = xorValue ^ numbers[i];

            Console.WriteLine($"{xorValue} is missing in array.");
        }
    }
}
