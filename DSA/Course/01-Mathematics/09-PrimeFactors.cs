using Helper;

namespace DSA.Course._01_Mathematics
{
    internal static class _09_PrimeFactors
    {
        // Time complexity - O(n² logn)
        internal static void Way01()
        {
            int number = ConsoleHelper.ReadInteger();

            for (int i = 2; i < number; i++)
            {
                if (number % i == 0 && Way01IsPrime(i))
                {
                    int temp = i;
                    while (number % temp == 0)
                    {
                        Console.WriteLine(i);
                        temp *= i;
                    }
                }
            }
        }

        private static bool Way01IsPrime(int number)
        {
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

            return isPrime;
        }

        // Based on 6N-1 & 6N+1 concept
        // Time complexity - O(√n)
        internal static void Way02()
        {
            int number = ConsoleHelper.ReadInteger();

            if (number <= 1)
                return;
            while (number % 2 == 0)
            {
                Console.WriteLine("2");
                number /= 2;
            }
            while (number % 3 == 0)
            {
                Console.WriteLine("3");
                number /= 3;
            }
            for (int i = 5; i * i <= number; i += 6)
            {
                while (number % i == 0)
                {
                    Console.WriteLine(i);
                    number /= i;
                }
                while (number % (i + 2) == 0)
                {
                    Console.WriteLine(i + 2);
                    number /= (i + 2);
                }
            }
            if (number > 3)
                Console.WriteLine(number);
        }
    }
}
