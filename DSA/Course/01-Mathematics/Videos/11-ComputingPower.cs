using Helper;

namespace DSA.Course._01_Mathematics.Videos
{
    internal class _11_ComputingPower
    {
        //Time complexity - O(n)
        internal static void Way01()
        {
            int number = ConsoleHelper.ReadInteger();
            int power = ConsoleHelper.ReadInteger("Power");

            int value = 1;
            for (int i = 0; i < power; i++)
            {
                value *= number;
            }

            Console.WriteLine($"Number: {number}, Power: {power}, Value: {value}");
        }

        // Time complexity - T(n) = T(n/2) + O(1)
        // Auxilary space - O(n)
        internal static void Way02()
        {
            int number = ConsoleHelper.ReadInteger();
            int power = ConsoleHelper.ReadInteger("Power");

            int value = Way02Power(number, power);
            Console.WriteLine($"Number: {number}, Power: {power}, Value: {value}");
        }

        private static int Way02Power(int number, int power)
        {
            if (power == 1)
                return 1;

            int val = Way02Power(number, power / 2);
            val = val * val;

            if (power % 2 == 0)
                return val;
            else
                return val * number;
        }

        // Time complexity - O(log n)
        // Auxilary space - O(1)
        // Based on Binary Exponentiation
        internal static void Way03()
        {
            int number = ConsoleHelper.ReadInteger();
            int power = ConsoleHelper.ReadInteger("Power");
            int value = 1;

            while (power > 0)
            {
                if ((power & 1) == 1)
                    value = value * number;

                power = power >> 1;
                number = number * number;
            }

            Console.WriteLine(value);
        }
    }
}
