using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Submarine
{
    public class Position
    { 
        public int Horizontal;
        public int Depth;
        public int Product => Horizontal * Depth;
    }
}
