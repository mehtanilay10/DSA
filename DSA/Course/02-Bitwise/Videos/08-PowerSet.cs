using Helper;

namespace DSA.Course._02_Bitwise.Videos
{
    internal static class _08_PowerSet
    {
        internal static void Way01()
        {
            string text = ConsoleHelper.ReadString();
            int length = text.Length;
            int possibleCombination = (int)Math.Pow(2, length);

            for (int counter = 0; counter < possibleCombination; counter++)
            {
                for (int j = 0; j < length; j++)
                {
                    if ((counter & (1 << j)) != 0)
                        Console.Write(text[j]);
                }

                Console.WriteLine();
            }
        }
    }
}
