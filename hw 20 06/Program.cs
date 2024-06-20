using System;
using System.Threading;

namespace smaylik
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 5;
            int maxX = Console.WindowWidth - 1;
            int maxY = Console.WindowHeight - 1;

            Console.CursorVisible = false; 
            Console.SetCursorPosition(x, y);
            Console.Write("@");

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo k = Console.ReadKey(true);
                    Console.SetCursorPosition(x, y);
                    Console.Write(" ");

                    if (k.Key == ConsoleKey.LeftArrow && x > 0)
                    {
                        x--;
                    }
                    else if (k.Key == ConsoleKey.RightArrow && x < maxX)
                    {
                        x++;
                    }
                    else if (k.Key == ConsoleKey.UpArrow && y > 0)
                    {
                        y--;
                    }
                    else if (k.Key == ConsoleKey.DownArrow && y < maxY)
                    {
                        y++;
                    }
                    Console.SetCursorPosition(x, y);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("xD");
                }

                Thread.Sleep(15);
            }
        }
    }
}
