using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_playground
{
    class TermoCup : Cup
    {
        int TimeOfHotnes;
        public TermoCup(string name = "null", double price = 0, int count = 0, ushort material = 1, int colour = 0xFFFFFF, int TimeOfHotnes = 0) : base(name, price, count)
        {
            this.TimeOfHotnes = TimeOfHotnes;
        }
    }
}
