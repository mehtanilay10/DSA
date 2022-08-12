using Helper;

namespace DSA.Course._01_Mathematics.Problems
{
    //8. Exactly 3 Divisors
    //Easy Accuracy: 44.86% Submissions: 83780 Points: 2
    //Given a positive integer value N.The task is to find how many numbers less than or equal to N have numbers of divisors exactly equal to 3.

    //Example 1:
    //--------------------------
    //Input:
    //N = 6
    //Output: 1
    //Explanation: The only number less than 6 with
    //3 divisors is 4.

    //Example 2:
    //--------------------------
    //Input:
    //N = 10
    //Output: 2
    //Explanation: 4 and 9 have 3 divisors.

    //Your Task:
    //You don't need to read input or print anything. Your task is to complete the function exactly3Divisors() that takes N as input parameter and returns count of numbers less than or equal to N with exactly 3 divisors.

    //Expected Time Complexity : O(N1/2 * N1/4)
    //Expected Auxilliary Space :  O(1)

    //Constraints :
    //1 <= N <= 109
    internal static class _06_Exactly3Divisors
    {
        // Number which are exact square-root as well as prime number had Exact 3 divisiors
        internal static void Way01()
        {
            int number = ConsoleHelper.ReadInteger();
            int counts = 0;
            for (int i = 2; i * i <= number; i++)
            {
                if (Way01IsPrime(i))
                    counts++;
            }

            Console.WriteLine(counts);
        }

        private static bool Way01IsPrime(int n)
        {
            if (n == 1)
                return false;
            else if (n == 2 || n == 3)
                return true;
            else if (n % 2 == 0 || n % 3 == 0)
                return false;
            else
            {
                for (int i = 5; i * i <= n; i += 6)
                {
                    if (n % i == 0 || n % (i + 2) == 0)
                        return false;
                }
            }

            return true;
        }
    }
}
