using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Runbaby
{
    public class Program
    {
        public static void Main(string[] args)
        {
            const char toWrite ='*';

            int x = 1, y = 9;
            int x1= 5, y1= 5;
            Write(toWrite);
            Map.drawBoard();
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    var command = Console.ReadKey().Key;

                    switch (command)
                    {
                        case ConsoleKey.DownArrow:
                            if(y < 9)
                            {
                                y++;
                            }
                            break;
                        case ConsoleKey.UpArrow:
                            if (y > 2)
                            {
                                y -= 2;
                            }  
                            break;
                    }
                }
                if (y < 9)
                {
                    y++;
                }
                if (x < 15)
                {
                    x++;
                }
                Console.SetCursorPosition(x1, y1);
                Console.Write(" ");
                Console.SetCursorPosition(x, y);
                Write(toWrite, x, y);
                x1 = x;
                y1 = y;
                if (Map.c > 0)
                {
                    Map.c--;
                }
                else
                {
                    Map.c = 99;
                }
                Map.drawBoard();
                Thread.Sleep(100);
            }
        }
        
        public static void Write(char toWrite, int x = 5, int y = 5)
        {
            try
            {
                if (x >= 0 && y >= 0) // 0-based
                {
                    Console.SetCursorPosition(x, y);
                    Console.CursorVisible = false;
                    Console.Write(toWrite);
                }
            }
            catch (Exception)
            {
            }
        }
    }
}
