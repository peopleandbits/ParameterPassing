using System;

namespace ConsoleApplication3
{
    public class ConsoleHelper
    {
        public static void ClearLine()
        {
            Console.SetCursorPosition(0, Console.CursorTop - 2);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, Console.CursorTop - 1);
        }
    }
}
