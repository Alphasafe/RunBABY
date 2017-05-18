using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Runbaby
{
    class Display
    {
        public static void startlogo()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n");
            Console.WriteLine("        \t\t       |-----------------------|");
            Console.WriteLine("        \t\t       | RRRRR       BBBBBBB   |");
            Console.WriteLine("        \t\t       | R     R     B      B  |");
            Console.WriteLine("        \t\t       | R     R     B      B  |");
            Console.WriteLine("        \t\t       | R   R       BBBBBBB   |");
            Console.WriteLine("        \t\t       | R R         B      B  |");
            Console.WriteLine("        \t\t       | R   R       B      B  |");
            Console.WriteLine("        \t\t       | R     R     BBBBBBB   |");
            Console.WriteLine("        \t\t       |-----------------------|");
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n");
            Console.WriteLine("                       \t           G A M I N G");
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("                    \t          R U N  B A B Y");
            Console.ReadKey();
            Console.Clear();
        }
        public static void menu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(32, 8);
            Console.Write("1-Тоглож эхлэх");
            Console.SetCursorPosition(32, 10);
            Console.Write("2-HighScore харах");
            Console.SetCursorPosition(32, 12);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("3-Гарах");
        }
        public static void draw(string c, int x, int y, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.SetCursorPosition(x, y);
            Console.Write(c);
        }
    }
}
