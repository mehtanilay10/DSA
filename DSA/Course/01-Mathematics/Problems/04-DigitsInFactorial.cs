using Helper;

namespace DSA.Course._01_Mathematics.Problems
{
    //5. Digits In Factorial
    //Easy Accuracy: 48.64% Submissions: 90946 Points: 2
    //Given an integer N.Find the number of digits that appear in its factorial.
    //Factorial is defined as, factorial(n) = 1 * 2 * 3 * 4……..*N and factorial(0) = 1.

    //Example 1:
    //----------------------
    //Input: N = 5
    //Output: 3
    //Explanation: Factorial of 5 is 120.
    //Number of digits in 120 is 3 (1, 2, and 0)

    //Example 2:
    //----------------------
    //Input: N = 120
    //Output: 199
    //Explanation: The number of digits in
    //120! is 199

    //Your Task:
    //You don't need to read input or print anything. Your task is to complete the function digitsInFactorial() that takes N as input parameter and returns number of digits in factorial of N.

    //Expected Time Complexity : O(N)
    //Expected Auxilliary Space : O(1)

    //Constraints:
    //1 ≤ N ≤ 105
    internal static class _04_DigitsInFactorial
    {
        // There is formula for this - f(x) = n * log10((n/ e)) + log10(2*pi*n)/2
        internal static void Way01()
        {
            int number = ConsoleHelper.ReadInteger();

            double part2 = Math.Log10(number / Math.E);
            double part3 = Math.Log10(2 * Math.PI * number) / 2.0;
            double counts = (number * part2 + part3);

            Console.WriteLine(Math.Floor(counts) + 1);
        }

        // There is formula for this - floor(log10(N)+1);
        internal static void Way02()
        {
            int number = ConsoleHelper.ReadInteger();
            double digits = 1;

            for (int i = number; i >= 1; i--)
                digits += Math.Log10(i);

            Console.WriteLine(Math.Floor(digits));
        }
    }
}
