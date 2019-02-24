using System.Collections.Generic;

namespace Snake
{
    class Walls
    {
        List<Figure> wallList;

        public Walls(int mapWidth, int mapHeight)
        {
            wallList = new List<Figure>();

            HorizontalLine upLine = new HorizontalLine(0, mapWidth - 3, 4, '+');
            HorizontalLine downLine = new HorizontalLine(0, mapWidth - 3, mapHeight - 2, '+');
            VerticalLine leftLine = new VerticalLine(4, mapHeight - 2, 0, '+');
            VerticalLine rightLine = new VerticalLine(4, mapHeight - 4, mapWidth - 3, '+');

            wallList.Add(upLine);
            wallList.Add(downLine);
            wallList.Add(leftLine);
            wallList.Add(rightLine);
        }

        internal bool IsHit(Figure figure)
        {
            foreach(var wall in wallList)
            {
                if (wall.IsHit(figure))
                {
                    return true;
                }
            }
            return false;
        }

        public void Draw()
        {
            foreach(var wall in wallList)
            {
                wall.Drow();
            }
        }
    }
}