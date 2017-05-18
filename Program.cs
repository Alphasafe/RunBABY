using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Runbaby
{
    public class Program
    {

        static string toWrite = "*";
        public static void Main(string[] args)
        {
            Display.startlogo();
            Display.menu();
            var key = Console.ReadKey();
            switch (key.Key)
            {
                case ConsoleKey.D1:
                    Console.Clear();
                    run();
                    break;
                case ConsoleKey.D2:
                    Console.Clear();
                    Console.SetCursorPosition(50, 15);
                    string text = System.IO.File.ReadAllText(@"d:\\Hangamjiin buteelt\\lab1\\Runbaby\\text.txt");
                    Console.ReadKey();
                    break;
                case ConsoleKey.D3:
                    Console.Clear();
                    break;
                default:
                    break;
            }

        }
        public static void run()
        {
            int x = 1, y = 9;
            int xx = x, yy = y;
            int speed = 500;
            Score score = new Score(0);
            Random rnd = new Random();
            int rand = 0;
            int rand1 = 0;
            int rand2 = 0;
            rand = rnd.Next(70, 80);
            rand1 = rnd.Next(80, 90);
            rand2 = rnd.Next(90, 100);
            Map.drawBoard();
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    var command = Console.ReadKey().Key;

                    switch (command)
                    {
                        case ConsoleKey.DownArrow:
                            if (y < 9)
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
                score.plus();
                Display.draw("Score : " + score.get(), 105, 3, ConsoleColor.Blue);
                Clear(xx, yy);
                Write(x, y);
                xx = x;
                yy = y;
                if (Map.c > 0) Map.c--;
                else Map.c = rand;
                if (Map.b > 0) Map.a--;
                else Map.b = rand1;
                if (Map.a > 0) Map.b--;
                else Map.a = rand2;
                Map.drawBoard();
                if (speed > 0)
                {
                    speed--;
                }
                Display.draw("Speed : " + (500 - speed), 105, 2, ConsoleColor.Red);
                string lines = "High Score : " + score.get() + "\r\n";
                System.IO.StreamWriter file = new System.IO.StreamWriter("d:\\Hangamjiin buteelt\\lab1\\Runbaby\\text.txt");
                file.WriteLine(lines);
                file.Close();
                Thread.Sleep(speed);

            }
        }
        public static void close()
        {

        }
        public static void Write(int x = 5, int y = 5)
        {
            try
            {
                if (x >= 0 && y >= 0) // 0-based
                {
                    Console.CursorVisible = false;
                    Display.draw(toWrite, x, y, ConsoleColor.Green);
                }
            }
            catch (Exception)
            {
            }
        }
        public static void Clear(int x, int y) 
        {
            /*int x = 1, y = 9;
            int x1 = 5, y1 = 5;
            const char toWrite = '*';
            */
            Console.SetCursorPosition(x, y);
            Console.Write(" ");
            /*Console.SetCursorPosition(x, y);
            Write(toWrite, x, y);
            x1 = x;
            y1 = y;*/
        }
    }
}
