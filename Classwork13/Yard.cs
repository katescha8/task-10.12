using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork13
{
    internal class Yard
    {
        public Building[] yard = new Building[10];
        public Building this[int index]
        {
            get { return yard[index]; }
            set { yard[index] = value; }
        }
    }
}
