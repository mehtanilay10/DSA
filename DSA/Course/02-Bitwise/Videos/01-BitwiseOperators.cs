namespace DSA.Course._02_Bitwise.Videos
{
    internal static class _01_BitwiseOperators
    {
        /// <summary>
        /// Bitwise operator examples
        /// x = 7 [0111]
        /// y = 9 [1001]
        /// z = 42 [101010]
        /// </summary>
        internal static void Way01()
        {
            int x = 7;
            int y = 9;

            int bitwiseAnd = x & y; // If both bits are 1 then 1, else 0
            // 0111 & 1001 => 0001 => 1
            Console.WriteLine($"x & y = {bitwiseAnd}");

            int bitwiseOr = x | y; // If any bit is 1 then 1, else 0
            // 0111 | 1001 => 1111 => 15
            Console.WriteLine($"x | y = {bitwiseOr}");

            int bitwiseXor = x ^ y; // If both bits are different then 1, else 0
            // 0111 ^ 1001 => 1110 => 14
            Console.WriteLine($"x ^ y = {bitwiseXor}");

            uint z = 42;    // For RightShift/LeftShift/Not operation unsign data type recommanded

            uint rightShift = z >> 2;
            // 101010 >> 2 => 001010 => 10
            Console.WriteLine($"z >> 2 = {rightShift}");

            uint leftShift = z << 2;
            // 101010 << 2 => 10101000 => 168
            Console.WriteLine($"z << 2 = {leftShift}");

            uint bitwiseNot = ~z;
            // ~101010 => 111...010101 => (2^32-1)-42 => 4294967296-43 => 4294967253
            Console.WriteLine($"~z = {bitwiseNot}");
        }
    }
}
