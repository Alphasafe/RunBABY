using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Runbaby
{
    class Map
    {
        public static int c = 2;
        public static void drawBoard(){
            const char toMap = 'T';
            const char cor1 = '-';
            const char cor2 = '|';
            for ( int i = 1; i < 100;i++)
            {
                if (i != c)
                {
                    Console.SetCursorPosition(i, 10);
                    Console.Write(toMap);
                }
                else
                {
                    Console.SetCursorPosition(i, 10);
                    Console.Write(' ');
                }
            }
            Console.SetCursorPosition(0, 0);
            for (int i = 1; i < 102; i++)
            {
                Console.Write(cor1);
            }
            Console.SetCursorPosition(1,11);
            for (int i = 1; i < 101; i++)
            {
                Console.Write(cor1);
            }
            for (int i = 0; i < 12; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write(cor2);
            }
            for (int i = 0; i < 12; i++)
            {
                Console.SetCursorPosition(101, i);
                Console.Write(cor2);
            }
        }
    }
}
