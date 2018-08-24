using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tower_defense
{
    class Exceptions
    {
        class TreeHouseDefenseExeception : Exception
        {

            public TreeHouseDefenseExeception()
            {
            }

            public TreeHouseDefenseExeception(string message) : base(message)
            {

            }
        }

        class OutOfBoundsException : TreeHouseDefenseExeception
        {
            public OutOfBoundsException()
            {
            }

            public OutOfBoundsException(string message) : base(message)
            {
            }
        }
    }
}
