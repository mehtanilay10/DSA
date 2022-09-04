using Helper;

namespace DSA.Course._03_Recursion.Problems
{
    //Power Using Recursion
    //Basic Accuracy: 63.0% Submissions: 24434  Points: 1
    //You are given two numbers n and p.You need to find np.

    //Example 1:
    //-----------------------
    //Input:
    //n = 9 p = 9
    //Output: 387420489
    //Explanation: 387420489 is the value obtained when 9 is raised to the power of 9.

    //Example 2:
    //-----------------------
    //Input:
    //n = 2 p = 9
    //Output: 512
    //Explanation: 512 is the value obtained when 2 is raised to the power of 9.

    //Your Task:
    //You don't need to read input or print anything. You only need to complete the function RecursivePower() that takes n and p as parameters and returns np.

    //Expected Time Complexity: O(p).
    //Expected Auxiliary Space: O(p).

    //Constraints:
    //1 <= n <= 9
    //0 <=  p <= 9
    internal static class _04_Power
    {
        internal static void Way01()
        {
            int number = ConsoleHelper.ReadInteger();
            int power = ConsoleHelper.ReadInteger("Power");

            int result = Way01Power(number, power);

            Console.WriteLine($"Result: {result}");
        }

        private static int Way01Power(int number, int power)
        {
            if (power == 0)
                return 1;

            return number * Way01Power(number, power - 1);
        }
    }
}
