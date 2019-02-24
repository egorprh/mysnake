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

            HorizontalLine upLine = new HorizontalLine(0, 78, 0, '-');
            HorizontalLine downLine = new HorizontalLine(0, 78, 23, '-');
            VerticalLine leftLine = new VerticalLine(0, 23, 0, '+');
            VerticalLine rightLine = new VerticalLine(0, 23, 78, '+');
            upLine.Drow();
            downLine.Drow();
            leftLine.Drow();
            rightLine.Drow();

            //Drawing the Snake
            Point p = new Point(4, 4, '*');
            Snake snake = new Snake(p, 3, Direction.RIGHT);
            snake.Drow();

            while (true)//создаем бесконечный цикл
            {
                if (Console.KeyAvailable)//проверяем нажата ли какая либо клавиша
                {
                    ConsoleKeyInfo key = Console.ReadKey();//считываем нажатую клавишу
                    snake.HandleKey(key.Key);//обработка нажатия
                }
                   
                    Thread.Sleep(100);// делаем задержку
                    snake.Move();//двигаем змейку
                    //если ничего не нажато или нажаты Не стрелки, то змейка продолжает двигаться в "предыдущем" направлении
            }

            Console.ReadLine();
        }
    }
}
