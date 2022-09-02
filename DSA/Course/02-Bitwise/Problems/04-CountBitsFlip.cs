using Helper;

namespace DSA.Course._02_Bitwise.Problems
{
    //Bit Difference
    //Basic Accuracy: 63.36%    Submissions: 43393  Points: 1
    //You are given two numbers A and B.The task is to count the number of bits needed to be flipped to convert A to B.

    //Example 1:
    //-------------------
    //Input: A = 10, B = 20
    //Output: 4
    //Explanation:
    //A  = 01010
    //B  = 10100
    //As we can see, the bits of A that need to be flipped are 01010. If we flip these bits, we get 10100, which is B.

    //Example 2:
    //-------------------
    //Input: A = 20, B = 25
    //Output: 3
    //Explanation:
    //A  = 10100
    //B  = 11001
    //As we can see, the bits of A that need to be flipped are 10100. If we flip these bits, we get 11001, which is B.

    //Your Task: The task is to complete the function countBitsFlip() that takes A and B as parameters and returns the count of the number of bits to be flipped to convert A to B.

    //Expected Time Complexity: O(log N).
    //Expected Auxiliary Space: O(1).

    //Constraints:
    //1 ≤ A, B ≤ 106
    internal static class _04_CountBitsFlip
    {
        // with modulo & bitwise operator
        internal static void Way01()
        {
            int a = ConsoleHelper.ReadInteger("A");
            int b = ConsoleHelper.ReadInteger("B");
            int counter = 0;

            while (a > 0 || b > 0)
            {
                if ((a % 2) != (b % 2))
                    counter++;

                a = a >> 1;
                b = b >> 1;
            }

            Console.WriteLine($"{counter} bits need to change.");
        }

        // with bitwise xor, and, right shift
        internal static void Way02()
        {
            int a = ConsoleHelper.ReadInteger("A");
            int b = ConsoleHelper.ReadInteger("B");

            int counter = 0;
            int xorValue = a ^ b;

            while (xorValue > 0)
            {
                if ((xorValue & 1) != 0)
                    counter++;

                xorValue = xorValue >> 1;
            }

            Console.WriteLine($"{counter} bits need to change.");
        }

        // based on brian Carrington algorithm
        internal static void Way03()
        {
            int a = ConsoleHelper.ReadInteger("A");
            int b = ConsoleHelper.ReadInteger("B");

            int counter = 0;
            int xorValue = a ^ b;

            while (xorValue > 0)
            {
                xorValue = xorValue & (xorValue - 1);
                counter++;
            }

            Console.WriteLine($"{counter} bits need to change.");
        }
    }
}
