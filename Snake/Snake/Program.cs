using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);

            Walls walls = new Walls(80, 25);
            walls.Draw();

            //Drawing the Snake
            Point p = new Point(4, 10, '*');
            Snake snake = new Snake(p, 3, Direction.RIGHT);
            snake.Drow();

            //генерируем еду
            FoodCreator foodCreator = new FoodCreator(80, 26, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();


            while (true)//создаем бесконечный цикл
            {
                if (walls.IsHit(snake) || snake.IsHitTail())
                {
                    break;
                }

                if (snake.Eat(food))//если съела то появляется новая точка
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }

                Thread.Sleep(70);// делаем задержку

                if (Console.KeyAvailable)//проверяем нажата ли какая либо клавиша
                {
                    ConsoleKeyInfo key = Console.ReadKey();//считываем нажатую клавишу
                    snake.HandleKey(key.Key);//обработка нажатия
                }
                //если ничего не нажато или нажаты Не стрелки, то змейка продолжает двигаться в "предыдущем" направлении
            }
        }
    }
}
