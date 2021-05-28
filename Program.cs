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
            VerticalLine vl = new VerticalLine(0, 10, 5, '%');
            Draw(vl);

            Console.CursorVisible = false; //убирает мерцание курсора
            Console.SetWindowSize(80, 25); //фикс ошибки с размером окна
            Console.SetBufferSize(80, 25);

            Point p = new Point(4, 5, '*');
            Figure fZmeika = new Zmeika(p, 4, Direction.RIGHT);
            Draw(fZmeika);
            Zmeika zmeika = (Zmeika)fZmeika;

            HorizontalLine hl = new HorizontalLine(0, 5, 6, '&');

            List<Figure> figures = new List<Figure>();
            figures.Add(fZmeika);
            figures.Add(vl);
            figures.Add(hl);

            foreach (var f in figures)
            {
                f.Draw();
            }
        }

        static void Draw(Figure figure)
        {
            figure.Draw();
        }
            while(true)
            {
                if(walls.IsHit(zmeika) || zmeika.IsHitTail())
                {
                    break;
                }
                if(zmeika.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    zmeika.Move();
                }
           
                Thread.Sleep(100);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    zmeika.HandleKey(key.Key);
                }
            }
        }
    }
}
