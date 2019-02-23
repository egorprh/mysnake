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
            Point p1 = new Point(3, 2, '*');
            Point p2 = new Point(6, 4, '#');
            Point p3 = new Point(9, 2, '*');
            Point p4 = new Point(12, 10, '#');

            List < Point > pList = new List<Point>();
            pList.Add(p1);
            pList.Add(p2);
            pList.Add(p3);
            pList.Add(p4);

            foreach(Point i in pList)
            {
                i.Draw();
            }


            HorizontalLine hLine = new HorizontalLine(3, 20, 12, '+');
            hLine.Drow();

            VerticalLine vLine = new VerticalLine(3, 15, 9, '/');
            vLine.Drow();

            Console.ReadLine();
        }
    }
}
