using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// створити масив  ітемів  і хз шось з ним поробити
// створити конструктор який буде считувати стрічку "назва 30 130009"
// вивести всьо шо дорожче за сер арефм цін і починається з верикої букви

namespace test_playground
{
    
    class Program
    {

        static void Main(string[] args)
        {
            int n = 5;
            Random rnd = new Random(n);

            Item[] a = new Item[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = new Item(rnd.Next(i).ToString(), rnd.NextDouble() * rnd.Next(i), rnd.Next(i));
            }

            int maxI = 0;
            double max = a[0].TotalPrice;
            for (int i = 1; i < n; i++)
            {
                if (maxI < a[i].TotalPrice)
                {
                    maxI = i;
                    max = a[i].TotalPrice;
                }
            }
            int test = 213231;
            
            

            Console.WriteLine(a[maxI].ToString());
            Console.ReadKey();
        }
    }
}
