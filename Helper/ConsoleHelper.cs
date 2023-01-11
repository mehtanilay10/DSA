namespace Helper
{
    public static class ConsoleHelper
    {
        public static string ReadString(string text = "Text")
        {
            Console.Write($"Enter {text}: ");
            string value = Console.ReadLine() ?? string.Empty;
            return value;
        }

        public static int ReadInteger(string text = "Number")
            => int.Parse(ReadString(text));

        public static uint ReadUInt(string text = "Number")
            => uint.Parse(ReadString(text));

        public static double ReadDouble(string text = "Number")
            => double.Parse(ReadString(text));

        public static long ReadLong(string text = "Number")
            => long.Parse(ReadString(text));

        public static ulong ReadULong(string text = "Number")
            => ulong.Parse(ReadString(text));

        public static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
                Console.WriteLine(array[i]);
        }
    }
}