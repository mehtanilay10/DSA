using Helper;

namespace DSA.Course._01_Mathematics.Videos
{
    internal class _10_PrimeRange
    {
        // Time complexity - O(n * √n)
        internal static void Way01()
        {
            int number = ConsoleHelper.ReadInteger();
            for (int i = 2; i <= number; i++)
            {
                if (Way01IsPrime(i))
                    Console.WriteLine(i);
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

        // Algo Name: Sieve of Eratosthenes
        // Time complexity - O(n loglog n)
        internal static void Way02()
        {
            int number = ConsoleHelper.ReadInteger();
            bool[] isPrimeArray = new bool[number + 1];
            Array.Fill(isPrimeArray, true); // Set default value True

            for (int i = 2; i * i <= number; i++)
            {
                if (isPrimeArray[i])
                {
                    for (int j = i * 2; j <= number; j += i)
                    {
                        isPrimeArray[j] = false;
                    }
                }
            }

            // Print out prime numbers only
            for (int i = 2; i <= number; i++)
                Console.WriteLine($"Number: {i}, IsPrime: {isPrimeArray[i]}");
        }
    }
}
