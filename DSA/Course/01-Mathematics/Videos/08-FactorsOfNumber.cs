using Helper;

namespace DSA.Course._01_Mathematics.Videos
{
    internal static class _08_FactorsOfNumber
    {
        // Time complexity - O(n)
        internal static void Way01()
        {
            int number = ConsoleHelper.ReadInteger();
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                    Console.WriteLine(i);
            }
        }

        // Based on factor paring (Resule will be not in sorted order)
        // Time complexity - O(√n)
        internal static void Way02()
        {
            int number = ConsoleHelper.ReadInteger();

            for (int i = 1; i * i < number; i++)
            {
                if (number % i == 0)
                {
                    Console.WriteLine(i);

                    if (i != number / i)
                        Console.WriteLine(number / i);
                }
            }
        }

        // Based on factor paring (Resule will be in sorted order)
        // Time complexity - O(√n)
        internal static void Way03()
        {
            int number = ConsoleHelper.ReadInteger();
            int i = 1;
            for (; i * i < number; i++)
            {
                if (number % i == 0)
                    Console.WriteLine(i);
            }
            for (; i > 0; i--)
            {
                if (number % i == 0)
                    Console.WriteLine(number / i);
            }
        }
    }
}
