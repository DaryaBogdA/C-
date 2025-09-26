using System;
using System.Drawing;

namespace tetris
{

    class Program
    { 
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.SetWindowSize(40, 30);
            Console.SetBufferSize(40,30);

            int x1 = 2;
            int y1 = 3;
            char c1 = '*';
            
            Point p1 = new Point();
            p1.x = x1;
            p1.y = y1;
            p1.c = c1;
            p1.Draw();

            Console.ReadLine();
        }
    }
}