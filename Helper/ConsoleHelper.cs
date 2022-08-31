namespace Helper
{
    public static class ConsoleHelper
    {
        public static int ReadInteger(string text = "Number")
        {
            Console.Write($"Enter {text}: ");
            int num = int.Parse(Console.ReadLine());
            return num;
        }

        public static double ReadDouble(string text = "Number")
        {
            Console.Write($"Enter {text}: ");
            double num = double.Parse(Console.ReadLine());
            return num;
        }

        public static ulong ReadULong(string text = "Number")
        {
            Console.Write($"Enter {text}: ");
            ulong num = ulong.Parse(Console.ReadLine());
            return num;
        }

        public static string ReadString(string text = "Text")
        {
            Console.WriteLine($"Enter {text}");
            string value = Console.ReadLine();
            return value;
        }
    }
}