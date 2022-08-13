using Helper;

namespace DSA.Course._01_Mathematics.Problems
{
    //11. Modular Multiplicative Inverse
    //Easy Accuracy: 48.28% Submissions: 51492 Points: 2
    //Given two integers ‘a’ and ‘m’. The task is to find the smallest modular multiplicative inverse of ‘a’ under modulo ‘m’.

    //Example 1:
    //------------------------------
    //Input:
    //a = 3
    //m = 11
    //Output: 4
    //Explanation: Since(4*3) mod 11 = 1, 4 is modulo inverse of 3. One might think,
    //15 also as a valid output as "(15*3) mod 11"  is also 1, but 15 is not in ring {0, 1, 2, ... 10}, so not valid.

    //Example 2:
    //------------------------------
    //Input:
    //a = 10
    //m = 17
    //Output: 12
    //Explanation: Since(12 * 10) mod 17 = 1, 12 is the modulo inverse of 10.

    //Your Task:
    //You don't need to read input or print anything. Your task is to complete the function function modInverse() that takes a and m as input parameters and returns modular multiplicative inverse of ‘a’ under modulo ‘m’. If the modular multiplicative inverse doesn't exist return -1.

    //Expected Time Complexity : O(m)
    //Expected Auxilliary Space : O(1)

    //Constraints:
    //1 <= a <= 104
    //1 <= m <= 104
    internal class _09_ModularMultiplicativeInverse
    {
        internal static void Way01()
        {
            int a = ConsoleHelper.ReadInteger("a");
            int m = ConsoleHelper.ReadInteger("m");
            int b = Way01FindMultiplicativeInverse(a, m);
            Console.WriteLine(b);
        }

        private static int Way01FindMultiplicativeInverse(int a, int m)
        {
            for (int b = 1; b < m; b++)
            {
                if (((a * b) % m) == 1)
                    return b;
            }

            return -1;
        }
    }
}
