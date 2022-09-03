using Helper;

namespace DSA.Additional._02_Bitwise
{
    //Find most significant set bit of a number
    //Difficulty Level : Medium     Last Updated : 10 Aug, 2022
    //Given a number, find the greatest number less than the given a number which is the power of two or find the most significant bit number.

    //Example 1:
    //---------------------
    //Input : 10
    //Output : 8
    //Greatest number which is a Power of 2 less than 10 is 8 Binary representation of 10 is 1010 The most significant bit corresponds to decimal number 8.

    //Example 2:
    //---------------------
    //Input : 18
    //Output : 16
    internal class _02_FindMostSignificantSetBit
    {
        internal static void Way01()
        {
            int number = ConsoleHelper.ReadInteger();
            if (number == 0)
                Console.WriteLine("Number is Zero");
            else
            {
                int mostSignificantBitIndex = 0;
                number = number / 2;

                while (number != 0)
                {
                    number = number / 2;
                    mostSignificantBitIndex++;
                }

                int mostSignificantBitValue = (1 << mostSignificantBitIndex);
                Console.WriteLine($"Most Significant Bit - {mostSignificantBitValue}");
            }
        }

        internal static void Way02()
        {
            int number = ConsoleHelper.ReadInteger();
            if (number == 0)
                Console.WriteLine("Number is Zero");
            else
            {
                int mostSignificantBitIndex = (int)(Math.Log(number) / Math.Log(2));
                int mostSignificantBitValue = (1 << mostSignificantBitIndex);
                Console.WriteLine($"Most Significant Bit - {mostSignificantBitValue}");
            }
        }
    }
}
