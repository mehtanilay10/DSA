using Helper;

namespace DSA.Course._03_Recursion.Videos
{
    internal static class _05_FibonacciNumber
    {
        internal static void Way01()
        {
            int number = ConsoleHelper.ReadInteger();
            int firstValue = 0;
            int secondValue = 1;
            int fibo = Way01Fibonacci(firstValue, secondValue, number);
            Console.WriteLine($"Fibonacci value - {fibo}");
        }

        private static int Way01Fibonacci(int firstValue, int secondValue, int number)
        {
            if (number == 0)
                return 0;
            if (number == 1)
                return secondValue;

            int nextNumber = firstValue + secondValue;
            return Way01Fibonacci(secondValue, nextNumber, number - 1);
        }

        internal static void Way02()
        {
            int number = ConsoleHelper.ReadInteger();
            int fibbo = Way02Fibonacci(number);
            Console.WriteLine($"Fibonacci - {fibbo}");
        }

        private static int Way02Fibonacci(int number)
        {
            if (number == 0 || number == 1)
                return number;

            return Way02Fibonacci(number - 1) + Way02Fibonacci(number - 2);
        }
    }
}
