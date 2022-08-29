using Helper;

namespace DSA.Course._02_Bitwise.Videos
{
    internal static class _02_CheckKthBitSetOrNot
    {
        internal static void Way01()
        {
            int n = ConsoleHelper.ReadInteger("n");
            int k = ConsoleHelper.ReadInteger("k");

            bool isSet = ((n >> (k - 1)) & 1) == 1;
            Console.WriteLine($"N: {n}, K: {k}, IsBitSet: {isSet}");
        }

        internal static void Way02()
        {
            int n = ConsoleHelper.ReadInteger("n");
            int k = ConsoleHelper.ReadInteger("k");

            bool isSet = (n & 1 << (k - 1)) != 0;
            Console.WriteLine($"N: {n}, K: {k}, IsBitSet: {isSet}");
        }
    }
}
