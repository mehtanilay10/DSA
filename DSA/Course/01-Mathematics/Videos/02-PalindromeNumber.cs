using Helper;

namespace DSA.Course._01_Mathematics.Videos
{
    internal static class _02_PalindromeNumber
    {
        internal static void Way01()
        {
            int number = ConsoleHelper.ReadInteger();
            int temp = number;
            int reverseNumber = 0;

            while (temp > 0)
            {
                int reminder = temp % 10;
                reverseNumber = (reverseNumber * 10) + reminder;
                temp /= 10;
            }

            Console.WriteLine($"Is Palindrome: {number == reverseNumber}");
        }
    }
}
