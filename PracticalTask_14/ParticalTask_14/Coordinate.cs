using System;
using System.Collections.Generic;
using System.Text;

namespace ParticalTask_14
{
    class Coordinate
    {
        private int x;
        private int y;
        private int z;
        public int X
        {
            get { return x; }
            set
            {
                if (value > 0) x = value;
            }
        }
        public int Y
        {
            get { return y; }
            set
            {
                if (value > 0) y = value;
            }
        }
        public int Z
        {
            get { return z; }
            set
            {
                if (value > 0) z = value;
            }
        }
        
        public Coordinate(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
    }
}
