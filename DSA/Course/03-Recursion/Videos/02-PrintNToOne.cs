﻿using Helper;

namespace DSA.Course._03_Recursion.Videos
{
    internal static class _02_PrintNToOne
    {
        // Time complexity - T(n) = T(n-1) + θ(1)
        // Space complexity - O(n)
        internal static void Way01()
        {
            int number = ConsoleHelper.ReadInteger();
            Way01Print(number);
        }

        private static void Way01Print(int number)
        {
            if (number == 0)
                return;

            Console.WriteLine(number);
            Way01Print(number - 1);
        }
    }
}
