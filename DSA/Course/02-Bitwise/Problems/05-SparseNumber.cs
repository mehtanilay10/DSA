using Helper;

namespace DSA.Course._02_Bitwise.Problems
{
    //Number is sparse or not
    //Basic Accuracy: 50.72% Submissions: 32900 Points: 1
    //Given a number N.The task is to check whether it is sparse or not.A number is said to be a sparse number if no two or more consecutive bits are set in the binary representation.

    //Example 1:
    //------------------
    //Input: N = 2
    //Output: 1
    //Explanation: Binary Representation of 2 is 10, which is not having consecutive set bits. So, it is sparse number.

    //Example 2:
    //------------------
    //Input: N = 3
    //Output: 0
    //Explanation: Binary Representation of 3 is 11, which is having consecutive set bits in it. So, it is not a sparse number.

    //Your Task: The task is to complete the function checkSparse() that takes n as a parameter and returns 1 if the number is sparse else returns 0.

    //Expected Time Complexity: O(log N).
    //Expected Auxiliary Space: O(1).

    //Constraints:
    //1 <= N <= 106
    internal static class _05_SparseNumber
    {
        // without bitwise operator
        internal static void Way01()
        {
            int number = ConsoleHelper.ReadInteger();
            int previousBitValue = 0;
            int currentBitValue = 0;
            bool isSparse = true;

            while (number > 0)
            {
                previousBitValue = currentBitValue;
                currentBitValue = number % 2;
                number = number / 2;
                if (previousBitValue == 1 && currentBitValue == 1)
                    isSparse = false;
            }

            Console.WriteLine($"IsSparse - {isSparse}");
        }

        // with bitwise operators
        internal static void Way02()
        {
            int number = ConsoleHelper.ReadInteger();
            int previousBitValue = number & 1;
            int currentBitValue = 0;
            bool isSparse = true;

            while (number > 0)
            {
                number = number >> 1;
                currentBitValue = number & 1;
                if (previousBitValue == 1 && currentBitValue == 1)
                    isSparse = false;

                previousBitValue = currentBitValue;
            }

            Console.WriteLine($"IsSparse - {isSparse}");
        }

        internal static void Way03()
        {
            int number = ConsoleHelper.ReadInteger();
            bool isSparse = ((number & (number >> 1)) == 0);
            Console.WriteLine($"IsSparse - {isSparse}");
        }
    }
}
