using Helper;

namespace DSA.Additional._02_Bitwise
{
    // Swap 2 numbers without using additional variable
    internal static class _01_SwapTwoNumbers
    {
        // with bitwise operator
        internal static void Way01()
        {
            int n1 = ConsoleHelper.ReadInteger("n1");
            int n2 = ConsoleHelper.ReadInteger("n2");

            n1 = n1 ^ n2;
            n2 = n2 ^ n1;
            n1 = n1 ^ n2;

            Console.WriteLine($"N1 - {n1}, N2 - {n2}");
        }

        // without bitwise operator
        internal static void Way02()
        {
            int n1 = ConsoleHelper.ReadInteger("n1");
            int n2 = ConsoleHelper.ReadInteger("n2");

            n1 = n1 - n2;
            n2 = n2 - n1;
            n1 = n1 - n2;

            Console.WriteLine($"N1 - {n1}, N2 - {n2}");
        }
    }
}
