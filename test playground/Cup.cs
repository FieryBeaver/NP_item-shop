using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_playground
{
    class Cup : Item
    {
        enum materials : ushort
        {
            ceramic,
            metal,
            glass
        }

        ushort material;
        int colour=0xFFFFFF;// should get  #123456 html hash
        public Cup(string name="null", double price=0, int count=0, ushort material=1, int colour=0xFFFFFF):base(name,price,count)
        {
            this.material = material;
            while (colour / 0x10/*кількість розрядів числа*/ > 6)
            {
                colour =colour >> 1;// зсув на 1 біт в ліво
            }
        }
            
    }
}
