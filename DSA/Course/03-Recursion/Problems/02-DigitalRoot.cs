using Helper;

namespace DSA.Course._03_Recursion.Problems
{
    //Digital Root
    //Easy  Accuracy: 53.0% Submissions: 35708  Points: 2
    //You are given a number n.You need to find the digital root of n. DigitalRoot of a number is the recursive sum of its digits until we get a single digit number.

    //Example 1:
    //--------------------
    //Input:
    //n = 1
    //Output:  1
    //Explanation: Digital root of 1 is 1

    //Example 2:
    //--------------------
    //Input:
    //n = 99999
    //Output: 9
    //Explanation: Sum of digits of 99999 is 45 which is not a single digit number, hence sum of digit of 45 is 9 which is a single digit number.

    //Your Task:
    //You don't need to read input or print anything. Your task is to complete the function digitalRoot that takes n as parameter and returns the digital root of n.

    //Expected Time Complexity: O((Num of Digits)2).
    //Expected Auxiliary Space: O(Num of Digits).

    //Constraints:
    //1 <= n <= 107
    internal static class _02_DigitalRoot
    {
        internal static void Way01()
        {
            int number = ConsoleHelper.ReadInteger();
            int digitalRoot = Way01FindRoot(number);
            Console.WriteLine($"Digital Root: {digitalRoot}");
        }

        private static int Way01FindRoot(int number)
        {
            int sum = Way01FindSum(number);
            if (sum < 10)
                return sum;

            return Way01FindRoot(sum);
        }

        private static int Way01FindSum(int number)
        {
            if (number == 0)
                return 0;

            int rem = number % 10;
            return rem + Way01FindSum(number / 10);
        }

        internal static void Way02()
        {
            int number = ConsoleHelper.ReadInteger();
            int digitalRoot = Way02FindRoot(number);
            Console.WriteLine($"Digital Root: {digitalRoot}");
        }

        private static int Way02FindRoot(int number)
        {
            if (number < 10)
                return number;
            if (number % 9 == 0)
                return 9;

            return number % 9;
        }
    }
}
