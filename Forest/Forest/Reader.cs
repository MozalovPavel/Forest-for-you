using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Forest
{
    class Reader
    {
        public Dictionary<char,AbstractCell> DictReader = new Dictionary<char,AbstractCell> 
        {
            {'0', new Road("Road")},
            {'1', new Tree("Forest")}, 
            {'K', new Trap("Trap")},
            {'L', new Live("Live")},
            {'H', new Man("Man")}
        };
        public AbstractCell[,] ReadFromFile()
        {
            var mapStr = File.ReadAllLines("Map.txt");
            var mapChar = new char[mapStr[0].Length];
            var mapAbstrCell = new AbstractCell[mapStr.Length, mapStr[0].Length];
            for (int i = 0; i < mapStr.Length; i++)
            {
                var str = mapStr[i];
                for (int j = 0; j < mapStr[i].Length; j++)
                {
                    mapAbstrCell[i,j]= DictReader[str[j]];
                }
            }
            return mapAbstrCell;
        }
    }
}
