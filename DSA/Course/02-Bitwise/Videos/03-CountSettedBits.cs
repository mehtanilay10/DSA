using Helper;
namespace DSA.Course._02_Bitwise.Videos
{
    internal static class _03_CountSettedBits
    {
        // Time complexy - O(total bits in n)
        internal static void Way01()
        {
            int number = ConsoleHelper.ReadInteger();
            int counts = 0;

            while (number > 0)
            {
                if ((number & 1) == 1)
                    counts++;

                number = number >> 1;
            }

            Console.WriteLine($"SettedBits: {counts}");
        }

        // Time complexy - O(total bits in n)
        internal static void Way02()
        {
            int number = ConsoleHelper.ReadInteger();
            int counts = 0;

            while (number > 0)
            {
                if (number % 2 != 0)
                    counts++;

                number = number / 2;
            }

            Console.WriteLine($"SettedBits: {counts}");
        }

        // Time complexy - O(setted bits in n)
        // Algo name - Brian and Kerningham Algorithm
        internal static void Way03()
        {
            int number = ConsoleHelper.ReadInteger();
            int counts = 0;

            while (number > 0)
            {
                number = number & (number - 1);
                counts++;
            }

            Console.WriteLine($"SettedBits: {counts}");
        }

        // Time complexity - O(1)
        // Method - Lookup Table
        internal static void Way04()
        {
            int number = ConsoleHelper.ReadInteger();
            int counts = 0;
            int[] lookupTable = new int[256];

            for (int i = 0; i < 256; i++)
            {
                lookupTable[i] = (i & 1) + lookupTable[i / 2];
            }

            counts += lookupTable[number & 0xFF];
            number = number >> 8;

            counts += lookupTable[number & 0xFF];
            number = number >> 8;

            counts += lookupTable[number & 0xFF];
            number = number >> 8;

            counts += lookupTable[number & 0xFF];

            Console.WriteLine($"SettedBits: {counts}");
        }
    }
}
