﻿namespace Helper
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
            int num = int.Parse(Console.ReadLine());
            return num;
        }
    }
}