using Helper;

namespace DSA.Course._01_Mathematics.Videos
{
    internal static class _07_PrimeNumber
    {
        // Time complexity - O(n)
        internal static void Way01()
        {
            int number = ConsoleHelper.ReadInteger();
            bool isPrime = true;

            if (number == 1)
                isPrime = false;

            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            Console.WriteLine($"Number: {number}, Is it prime: {isPrime}");
        }

        // Optimized loop by just skipping unnecessary values
        // Time complexity - O(√n)
        internal static void Way02()
        {
            int number = ConsoleHelper.ReadInteger();
            bool isPrime = true;

            if (number == 1)
                isPrime = false;

            for (int i = 2; i * i < number; i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            Console.WriteLine($"Number: {number}, Is it prime: {isPrime}");
        }

        // Remove all numbers which are dividable by 2 & 3
        // Time complexity - O(√n)
        internal static void Way03()
        {
            int number = ConsoleHelper.ReadInteger();
            bool isPrime = true;

            if (number == 1)
                isPrime = false;
            else if (number == 2 || number == 3)
                isPrime = true;
            else if (number % 2 == 0 || number % 3 == 0)
                isPrime = false;
            else
            {
                // Now we just have to loop through only 6N+1 & 6N-1 items
                for (int i = 5; i * i < number; i += 6)
                {
                    if (number % i == 0 || (number + 2) % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }

            Console.WriteLine($"Number: {number}, Is it prime: {isPrime}");
        }
    }
}
