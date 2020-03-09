﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_playground
{
    class Item
    {
        string name;
        double price;
        int count;

        public override  string ToString()
        {
            return String.Format("name={0,-10} price={1,-5}amount={2,-5}", name, price.ToString(), count.ToString());
        }

        //--------------------construct-------
        public Item(string s, double d, int i)
        {
            name = s;
            price = d;
            count = i;
        }
        public Item()
        {
            name = "";
            price = 0;
            count = 0;
        }
        public Item(string input)
        {
            name =input.Split(' ')[0];
            price = double.Parse(input.Split(' ')[1]);
            count =int.Parse(input.Split(' ')[2]);
        }
        public Item(Item input)
        {
            name = input.name;
            price = input.price;
            count = input.count;
        }
        //------------------------------------

             
        public double TotalPrice
        {
            get
            {
                return price + count;
            }
        }
        public string NAME
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
      
    }
}
