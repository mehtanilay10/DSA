using Helper;
namespace DSA.Course._03_Recursion.Problems
{
    //Power Of Numbers
    //Easy  Accuracy: 49.24%    Submissions: 100k+  Points: 2
    //Given a number and its reverse.Find that number raised to the power of its own reverse.
    //Note: As answers can be very large, print the result modulo 109 + 7.

    //Example 1:
    //------------------
    //Input:
    //N = 2
    //Output: 4
    //Explanation: The reverse of 2 is 2 and after raising power of 2 by 2 we get 4 which gives remainder as 4 by dividing 1000000007.

    //Example 2:
    //------------------
    //Input:
    //N = 12
    //Output: 864354781
    //Explanation: The reverse of 12 is 21 and 1221 , when divided by 1000000007 gives remainder as 864354781.

    //Your Task:
    //You don't need to read input or print anything. You just need to complete the function pow() that takes two parameters N and R denoting the input number and its reverse and returns power of (N to R)mod(109 + 7).

    //Expected Time Complexity: O(LogN).
    //Expected Auxiliary Space: O(LogN).

    //Constraints:
    //1 <= N <= 109
    internal static class _05_PowerOfNumbers
    {
        private static long MOD = (long)Math.Pow(10, 9) + 7;

        // This algorithm is based on Exponentiation
        // We will divide power and multiple with smaller one.
        // For example, if we started with 10^20.
        // This can be written as 10^10 * 10^10, and further can be written as 10^5 * 10^5 * 10^5 * 10^5
        // If there is odd number we will use even value and seperatly multiple with number itself.
        // For example, if we started with 10^21.
        // This can be written as 10^10 * 10^10 * 10
        internal static void Way01()
        {
            int number = ConsoleHelper.ReadInteger();
            int reverse = ConsoleHelper.ReadInteger("Reverse Number");

            long result = Way01FindPower(number, reverse);
            Console.WriteLine($"Result: {result}");
        }

        // Here we need to perform mod after each & every calculation, otherwise we might get overflow.
        private static long Way01FindPower(int number, int power)
        {
            if (power == 0)
                return 1;

            long temp = Way01FindPower(number, power / 2) % MOD;
            temp = (temp * temp) % MOD;
            if (power % 2 == 0)
                return temp;
            else
                return (temp * number) % MOD;
        }
    }
}
