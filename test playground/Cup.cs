using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_playground
{
    class Cup : Item
    {
        protected enum Materials : ushort
        {
            wood = 0,
            ceramic = 1,
            metal = 2,
            glass = 3,
            
        }
        public int Colour
            {get;}

        protected Materials material;
        protected int colour;// should get  #123456 html hash

        public Cup(string name="null", double price=0, int count=0, ushort material=1, int colour=0xFFFFFF):base(name,price,count)
        {
            this.material=(Materials)material;
            while (colour / 0x10/*кількість розрядів числа*/ > 6)
            {
                colour =colour >> 1;// зсув на 1 біт в ліво
            }
        }
        public Cup(string input):base(input)
        {
            var splitedInput = input.Replace(" ", "").Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries).ToList();
            material = (Materials)int.Parse(splitedInput[3]);
            colour = int.Parse(splitedInput[4]);
        }

        public virtual string FancyOuput()
        {
            return base.FancyOutput() + string.Format("Material={0,-10} colour={1,-5}", material, colour.ToString());
        }
    }
}
