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
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Drow();
            snake.Move();
            Thread.Sleep(400);
            snake.Move();
            Thread.Sleep(400);
            snake.Move();
            Thread.Sleep(400);
            snake.Move();
            Thread.Sleep(400);
            snake.Move();
            Thread.Sleep(400);
            snake.Move();
            Thread.Sleep(400);
            snake.Move();
            Thread.Sleep(400);
            snake.Move();


            Console.ReadLine();
        }
    }
}
