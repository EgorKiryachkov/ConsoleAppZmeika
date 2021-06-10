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

            Walls walls = new Walls(80, 25);
            walls.Draw();
            
            Point p = new Point(4, 5, '*');
            Zmeika zmeika = new Zmeika(p, 4, Direction.RIGHT);
            zmeika.Draw();

            FoodCreator foodCreator = new FoodCreator(80, 25, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();
           

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
