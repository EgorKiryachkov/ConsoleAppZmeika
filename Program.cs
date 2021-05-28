using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleAppZmeika
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false; //убирает мерцание курсора
            Console.SetWindowSize(80, 25); //фикс ошибки с размером окна
            Console.SetBufferSize(80, 25);
            HorizontalLine upLine = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine downLine = new HorizontalLine(0, 78, 24, '+');
            VerticalLine leftLine = new VerticalLine(0, 24, 0, '+');
            VerticalLine rightLine = new VerticalLine(0, 24, 78, '+');
            upLine.Draw();
            downLine.Draw();
            leftLine.Draw();
            rightLine.Draw();

            Point p = new Point(4, 5, '*');
            Zmeika zmeika = new Zmeika(p, 4, Direction.RIGHT);
            zmeika.Draw();

            while(true)
            {
                if(Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    zmeika.HandleKey(key.Key);
                }
                Thread.Sleep(100);
                zmeika.Move();
            }
        }
    }
}
