using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tower_defense
{
    class Program
    {
        public static void Main()
        {
            Map map = new Map(8, 5);

            try
            {
                MapLocation mapLocation = new MapLocation(20, 20, map);
            }
            catch(OutOfBoundsException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (TreeHouseDefenseException)
            {
                Console.WriteLine("Unhandled TreeHouseDefenseException");
            }
            catch (Exception)
            {
                Console.WriteLine("Unhandled Exception");
            }
        }
    }
}
