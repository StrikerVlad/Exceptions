using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exp
{
    class Cls
    {
        public int x { get; set; }
        public int y { get; set; }
        public Cls()
        {
            this.x = 1;
            this.y = 5;
        }

        public Cls(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int division()
        {
            int result;
            result = this.x / this.y;
            return result;
        }
    }
}

