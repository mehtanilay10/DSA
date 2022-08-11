using Helper;

namespace DSA.Course._01_Mathematics.Videos
{
    internal static class _06_LCM
    {
        // Time complexity - O(n1*n2-max(n1, n2))
        internal static void Way01()
        {
            int num1 = ConsoleHelper.ReadInteger();
            int num2 = ConsoleHelper.ReadInteger();

            int maxNumber = Math.Max(num1, num2);
            while (true)
            {
                if (maxNumber % num1 == 0 && maxNumber % num2 == 0)
                    break;

                maxNumber++;
            }

            Console.WriteLine($"Num1: {num1}, Num2: {num2}, LCM: {maxNumber}");
        }

        // Based on below formula
        // num1 * num2 = gcd(num1, num2) * lcm(num1, num2)
        // Time complexity - O(log(min(n1, n2)))
        internal static void Way02()
        {
            int num1 = ConsoleHelper.ReadInteger();
            int num2 = ConsoleHelper.ReadInteger();
            int gcd = Way02FindGCD(num1, num2);

            int lcm = (num1 * num2) / gcd;
            Console.WriteLine($"Num1: {num1}, Num2: {num2}, GCD: {gcd}, LCM: {lcm}");
        }

        private static int Way02FindGCD(int num1, int num2)
        {
            if (num2 == 0)
                return num1;

            return Way02FindGCD(num2, num1 % num2);
        }
    }
}
