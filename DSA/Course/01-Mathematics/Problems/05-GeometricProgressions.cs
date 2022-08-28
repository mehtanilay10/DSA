using Helper;

namespace DSA.Course._01_Mathematics.Problems
{
    //6. GP Term
    //Easy Accuracy: 44.39% Submissions: 100k+ Points: 2
    //Given the first 2 terms A and B of a Geometric Series.The task is to find the Nth term of the series.

    //Example 1:
    //-----------------------------
    //Input:
    //A = 2
    //B = 3
    //N = 1
    //Output: 2
    //Explanation: The first term is already given in the input as 2

    //Example 2:
    //-----------------------------
    //Input:
    //A = 1
    //B = 2
    //N = 2
    //Output: 2
    //Explanation: Common ratio = 2, Hence second term is 2.
    //Your Task:
    //You don't need to read input or print anything. Your task is to complete the function termOfGP() that takes A, B and N as parameter and returns Nth term of GP. The return value should be double that would be automatically converted to floor by the driver code.

    //Expected Time Complexity : O(logN)
    //Expected Auxilliary Space : O(1)

    //Constraints:
    //-100 <= A <= 100
    //-100 <= B <= 100
    //1 <= N <= 5
    internal static class _05_GeometricProgressions
    {
        // There is formula for this - A + ((B/A)^(N-1))
        internal static void Way01()
        {
            int a = ConsoleHelper.ReadInteger("A");
            int b = ConsoleHelper.ReadInteger("B");
            int n = ConsoleHelper.ReadInteger();

            // Multiplied with 1.0 just for typecasting
            double diff = b * 1.0 / a;
            double value = Math.Floor(a * Math.Pow(diff, n - 1));

            Console.WriteLine(value);
        }
    }
}
