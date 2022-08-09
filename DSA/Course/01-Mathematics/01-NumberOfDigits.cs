using Helper;

namespace DSA.Course._01_Mathematics
{
    internal static class _01_NumberOfDigits
    {
        internal static void Way01()
        {
            int number = ConsoleHelper.ReadInteger();
            int digits = 0;

            while (number > 0)
            {
                digits++;
                number = number / 10;
            }

            Console.WriteLine($"Digits: {digits}");
        }
        internal static void Way02()
        {
            double number = ConsoleHelper.ReadDouble();
            double digits = Math.Floor(Math.Log10(number) + 1);

            Console.WriteLine($"Digits: {digits}");
        }
    }
}
