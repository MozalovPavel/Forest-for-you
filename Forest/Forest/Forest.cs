using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forest
{
    public class Forest
    {
        public void AddMan(Point coordinate)
        {
            var reader = new Reader();
            var map = reader.ReadFromFile();
            while (map[coordinate.X, coordinate.Y].CanAdd())
            {
                map[coordinate.X, coordinate.Y] = new Man("Петя");
                break;
            }
        }
        public void Move(Point coordinate, Man man)
        {

        }
    }
}
