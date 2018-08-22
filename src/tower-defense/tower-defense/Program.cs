using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tower_defense
{
    class Program
    {
        static void Main()
        {
            Map map = new Map(8, 5);

            //map.Width = 8;
            //map.Height = 5;

            int area = map.Width * map.Height;
            Console.WriteLine(area);
        }
    }
}
