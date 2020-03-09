using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_playground
{
    class Glasses:Cup
    {
     
        
            string shape;
            
            

    public Glasses(string name = "null", double price = 0, int count = 0, ushort material = 2, int colour = 0xFFFFFF, string shape = "beer") : base(name, price, count, material, colour)
        {
            this.shape = shape;   
            this.material = Materials.glass;
            this.colour = 0xFFFFFF; 

             
        }
    }
}
