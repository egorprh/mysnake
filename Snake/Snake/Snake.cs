using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Figure
    {
        public Snake(Point tail, int lenght, Direction direction)
        {
            pList = new List<Point>();//create list
            for(int i = 0; i <= lenght; i++)
            {
                Point p = new Point(tail);//copy point of tail
                p.Move(i, direction);// move to direction on i value
                pList.Add(p);// add point to list
            }
        }
    }
}
