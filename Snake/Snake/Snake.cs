using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Figure
    {
        Direction direction;

        public Snake(Point tail, int lenght, Direction _direction)
        {
            direction = _direction;
            pList = new List<Point>();//create list
            for(int i = 0; i <= lenght; i++)
            {
                Point p = new Point(tail);//copy point of tail
                p.Move(i, direction);// move to direction on i value
                pList.Add(p);// add point to list
            }
        }

        internal void Move()
        {
            Point tail = pList.First();//возвращаем первый элемент списка и засовываем его в tail 
            pList.Remove(tail);//удаляем его, т.о. змейка будет "двигаться"
            Point head = getNextPoint();//получаем знасение на которое надо прибавить голову
            pList.Add(head);// прибавляем в список голову
            //pList мы изменили, но в консоли еще отрисованы старые точки
            tail.Clear();//стираем хвост
            head.Draw();//рисуем голову
        }

        public Point getNextPoint()
        {
            Point head = pList.Last();//определяем где находится голова
            Point nextPoint = new Point(head);//создаем копию точки head
            nextPoint.Move(1, direction);//сдвиг точки по направлению дирекшион
            return nextPoint;//возвращаем значение
        }
    }
}
