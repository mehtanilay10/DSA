using Helper;

namespace DSA.Course._03_Recursion.Videos
{
    internal static class _10_GenerateSubset
    {
        internal static void Way01()
        {
            string text = ConsoleHelper.ReadString();
            Way01Subsets(text);
        }

        private static void Way01Subsets(string text, string currentText = "", int maxChars = 0)
        {
            if (text.Length == maxChars)
            {
                Console.WriteLine(currentText);
                return;
            }

            Way01Subsets(text, currentText, maxChars + 1);
            Way01Subsets(text, currentText + text[maxChars], maxChars + 1);
        }
    }
}
