using Helper;

namespace DSA.Course._03_Recursion.Problems
{
    //Find the Safe Position
    //Medium     Accuracy: 57.74%       Submissions: 39K+       Points: 4

    //There are n people standing in a circle (numbered clockwise 1 to n) waiting to be executed. The counting begins at point 1 in the circle and proceeds around the circle in a fixed direction (clockwise). In each step, a certain number of people are skipped and the next person is executed. The elimination proceeds around the circle (which is becoming smaller and smaller as the executed people are removed), until only the last person remains, who is given freedom.
    //Given the total number of persons n and a number k which indicates that k-1 persons are skipped and kth person is killed in circle. The task is to choose the place in the initial circle so that you are the last one remaining and so survive.

    //Example 1:
    //--------------------
    //Input:
    // n = 2
    // k = 1
    //Output:
    // 2
    //Explanation: Here, n = 2 and k = 1, then safe position is 2 as the person at 1st position will be killed.

    //Example 2:
    //--------------------
    //Input:
    // n = 4
    // k = 2
    //Output:
    // 1
    //Explanation: The safe position is 1.

    //Your Task:
    //You don't need to read input or print anything. Your task is to complete the function safePos() which takes an Integer n as input and returns the safe position.

    //Expected Time Complexity: O(n*n)
    //Expected Auxiliary Space: O(n)

    //Constraints:
    //1 <= n,k <= 500
    internal static class _07_FindSafePosition
    {
        // T(n) = T(n-1) + C
        // Time complexity - O(n)
        // Auxiliary Space - O(n)
        internal static void Way01()
        {
            int number = ConsoleHelper.ReadInteger();
            int k = ConsoleHelper.ReadInteger("k");
            int safePosition = Way01Kill(number, k);
            Console.WriteLine($"Safe position - {safePosition}");
        }

        private static int Way01Kill(int number, int k)
        {
            if (number == 1)
                return 1;

            return ((Way01Kill(number - 1, k) + k - 1) % number + 1);
        }

        // Time complexity - O(n)
        // Auxiliary Space - O(1)
        internal static void Way02()
        {
            int number = ConsoleHelper.ReadInteger();
            int k = ConsoleHelper.ReadInteger("k");
            int safePosition = Way02Kill(number, k);
            Console.WriteLine($"Safe position - {safePosition}");
        }

        private static int Way02Kill(int number, int k)
        {
            int safePosition = 0;
            for (int i = 1; i <= number; i++)
                safePosition = (safePosition + k) % (i);
            return safePosition + 1;
        }
    }
}
