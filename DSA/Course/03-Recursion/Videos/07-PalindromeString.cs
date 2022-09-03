using Helper;

namespace DSA.Course._03_Recursion.Videos
{
    internal static class _07_PalindromeString
    {
        // T(n) = T(n-2) + θ(1)
        // Time complexity - O(n)
        // Auxiliary Space - O(n)
        internal static void Way01()
        {
            string text = ConsoleHelper.ReadString();
            int startIndex = 0;
            int endIndex = text.Length - 1;

            bool isPalindrome = Way01IsPalindrome(text, startIndex, endIndex);
            Console.WriteLine($"IsPalindrome - {isPalindrome}");
        }

        private static bool Way01IsPalindrome(string text, int startIndex, int endIndex)
        {
            if (startIndex >= endIndex)
                return true;

            if (text[startIndex] != text[endIndex])
                return false;

            return Way01IsPalindrome(text, startIndex + 1, endIndex - 1);
        }
    }
}
