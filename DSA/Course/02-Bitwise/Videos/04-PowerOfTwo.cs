using Helper;

namespace DSA.Course._02_Bitwise.Videos
{
    internal static class _04_PowerOfTwo
    {
        // Not based on bitwise operations
        internal static void Way01()
        {
            int number = ConsoleHelper.ReadInteger();

            if (number == 0)
                Console.WriteLine("Number is Zero.");
            else
            {
                bool isDivisibleByTwo = true;
                while (number != 1 && isDivisibleByTwo)
                {
                    if (number % 2 != 0)
                        isDivisibleByTwo = false;

                    number = number / 2;
                }

                Console.WriteLine($"IsDivisibleByTwo: {isDivisibleByTwo}");
            }
        }

        // By counting number of setted bits
        internal static void Way02()
        {
            int number = ConsoleHelper.ReadInteger();

            if (number == 0)
                Console.WriteLine("Number is Zero.");
            else
            {
                int counts = Way02GetSettedBitCounts(number);
                bool isDivisibleByTwo = counts == 1;

                Console.WriteLine($"IsDivisibleByTwo: {isDivisibleByTwo}");
            }
        }

        private static int Way02GetSettedBitCounts(int number)
        {
            int counts = 0;

            while (number > 0)
            {
                number = number & (number - 1);
                counts++;
            }

            return counts;
        }

        // By just bitwise and operation
        internal static void Way03()
        {
            int number = ConsoleHelper.ReadInteger();

            if (number == 0)
                Console.WriteLine("Number is Zero.");
            else
            {
                bool isDivisibleByTwo = (number & (number - 1)) == 0;
                Console.WriteLine($"IsDivisibleByTwo: {isDivisibleByTwo}");
            }
        }
    }
}
