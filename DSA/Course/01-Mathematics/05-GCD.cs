using Helper;

namespace DSA.Course._01_Mathematics
{
    internal static class _05_GCD
    {
        // Time complexity: O(min(n1, n2))
        internal static void Way01()
        {
            int num1 = ConsoleHelper.ReadInteger();
            int num2 = ConsoleHelper.ReadInteger();

            int minNumber = Math.Min(num1, num2);
            while (minNumber > 0)
            {
                if (num1 % minNumber == 0 && num2 % minNumber == 0)
                    break;

                minNumber--;
            }

            Console.WriteLine($"Num1: {num1}, Num2: {num2}, GCD: {minNumber}");
        }

        internal static void Way02()
        {
            int num1 = ConsoleHelper.ReadInteger();
            int num2 = ConsoleHelper.ReadInteger();

            while (num1 != num2)
            {
                if (num1 > num2)
                    num1 -= num2;
                else
                    num2 -= num1;
            }

            Console.WriteLine($"GCD: {num1}");
        }

        // Based on Euclidean algorithm
        // Time complexity - O(log(min(n1, n2)))
        internal static void Way03()
        {
            int num1 = ConsoleHelper.ReadInteger();
            int num2 = ConsoleHelper.ReadInteger();
            int gcd = Way03GCD(num1, num2);

            Console.WriteLine($"Num1: {num1}, Num2: {num2}, GCD: {gcd}");
        }

        private static int Way03GCD(int num1, int num2)
        {
            if (num2 == 0)
                return num1;

            return Way03GCD(num2, num1 % num2);
        }
    }
}
