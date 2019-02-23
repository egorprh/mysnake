using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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


            //HorizontalLine hLine = new HorizontalLine(3, 20, 12, '-');
            //hLine.Drow();

            VerticalLine vLine = new VerticalLine(3, 15, 9, '/');
            vLine.Drow();

            Console.ReadLine();
        }
    }
}
