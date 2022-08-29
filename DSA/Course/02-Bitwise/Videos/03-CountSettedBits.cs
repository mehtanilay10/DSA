using Helper;
namespace DSA.Course._02_Bitwise.Videos
{
    internal static class _03_CountSettedBits
    {
        internal static void Way01()
        {
            int number = ConsoleHelper.ReadInteger();
            int counts = 0;

            while (number > 0)
            {
                if ((number & 1) == 1)
                    counts++;

                number = number >> 1;
            }

            Console.WriteLine($"SettedBits: {counts}");
        }

        internal static void Way02()
        {
            int number = ConsoleHelper.ReadInteger();
            int counts = 0;

            while (number > 0)
            {
                if (number % 2 != 0)
                    counts++;

                number = number / 2;
            }

            Console.WriteLine($"SettedBits: {counts}");
        }
    }
}
