using Helper;

namespace DSA.Course._03_Recursion.Videos
{
    internal static class _01_DecimalToBinary
    {
        internal static void Way01()
        {
            int number = ConsoleHelper.ReadInteger();
            Way01GenerateBinary(number);
            Console.WriteLine();
        }

        private static void Way01GenerateBinary(int n)
        {
            if (n == 0)
                return;

            Way01GenerateBinary(n / 2);
            Console.Write(n % 2);
        }
    }
}
