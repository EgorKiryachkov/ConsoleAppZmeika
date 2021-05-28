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
            upLine.Drow();
            downLine.Drow();
            leftLine.Drow();
            rightLine.Drow();

            Point p = new Point(4, 5, '*');
            Zmeika zmeika = new Zmeika(p, 4, Direction.DOWN);
            zmeika.Drow();
            zmeika.Move();
            Thread.Sleep(300);
            zmeika.Move();
            Thread.Sleep(300);
            zmeika.Move();
            Thread.Sleep(300);
            zmeika.Move();
            Thread.Sleep(300);
            zmeika.Move();
            Thread.Sleep(300);
            zmeika.Move();
            Thread.Sleep(300);
            zmeika.Move();
            Thread.Sleep(300);
            zmeika.Move();
            Thread.Sleep(300);
            zmeika.Move();
        }
    }
}
