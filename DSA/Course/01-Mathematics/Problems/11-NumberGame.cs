using Helper;

namespace DSA.Course._01_Mathematics.Problems
{
    //Number Game
    //Easy      Accuracy: 35.45%        Submissions: 7K+    Points: 2

    //Given a number n the task is to find the minimum number which is divisible by all numbers from 1 to n. Print the answer modulo (109+7).

    //Example 1:
    //--------------------
    //Input:
    // n = 3
    //Output: 6 
    //Explanation: When n = 3 then the minimum number that is divisible by all the number till 3 is 6.

    //Example 2:
    //--------------------
    //Input:
    //n = 4
    //Output: 12
    //Explanation: When n = 4 then the minimum number that is divisible by all the number till 4 is 12.

    //Your Task:
    //You don't need to read input or print anything. Your task is to complete the function numGame() which takes an Integer n as input and returns the answer.

    //Expected Time Complexity: O(n*log(n))
    //Expected Auxiliary Space: O(1)

    //Constraints:
    //1 <= n <= 10^5
    internal class _11_NumberGame
    {
        // Time Complexity: O(n*log(n))
        // Auxiliary Space: O(1)
        internal static void Way01()
        {
            long number = ConsoleHelper.ReadLong();
            long result = 1;
            long divison = (long)Math.Pow(10, 9) + 7L;

            for (long i = 2; i <= number; i++)
            {
                long gcd = Way01FindGCD(result, i);
                result = (result * i / gcd) % divison;
            }
            Console.WriteLine($"Result: {result}");
        }

        private static long Way01FindGCD(long n1, long n2)
        {
            if (n2 == 0)
                return n1;

            return Way01FindGCD(n2, n1 % n2);
        }
    }
}
