using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_playground
{
    sealed class Maagnets : Item
    {
        enum Materials:ushort
            {
                metal,
                ceramic,
                glass
            }
        Materials material;
        string style;
        public Maagnets(string input) : base(input)
        {
            var splitedInput = input.Replace(" ", "").Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries).ToList();
            material = (Materials)int.Parse(splitedInput[3]);
            style =splitedInput[4];
        }
    }
}
