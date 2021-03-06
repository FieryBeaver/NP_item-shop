﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;



namespace test_playground
{
    
    class Program
    {
        static void PrintArr(object[] a)
        {
            for (int i = 0; i < a.Length; i++)
                Console.WriteLine($" {a[i].ToString()} /n");
        }


        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("input.txt");



            Item[] a = new Item[40];
            

            int iteraTRATRATRAtor = 0;
            while (!sr.EndOfStream)
            {
                string inputString = sr.ReadLine();

                switch   (inputString.Substring(0,4).ToUpper())
                {
                    case "MAGN":

                        
                        a[iteraTRATRATRAtor] = new Maagnets(inputString.Remove(0,4));
                        break;
                    case "TCUP":
                        a[iteraTRATRATRAtor] = new TermoCup(inputString.Remove(0, 4));
                        break;
                    case "NCUP":
                        a[iteraTRATRATRAtor] = new Cup(inputString.Remove(0, 4));
                         break;
                    case "GLAS":
                        a[iteraTRATRATRAtor] = new Glasses(inputString.Remove(0, 4));
                        break;
                    default:
                        a[iteraTRATRATRAtor] = new Item(inputString.Remove(0, 4));
                        break;

                }
                iteraTRATRATRAtor++;
            }


            List<Item> term = new List<Item>() ;
            
            for (int i=0;i<a.Length;i++)
            {
                if (a[i] is TermoCup) term.Add(a[i]);
                    
            }
            Console.WriteLine(term.ToString());


            double redSum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] is Cup & (((Cup)a[i]).Colour <0xFFFFFE |((Cup)a[i]).Colour > 0xAA0000  ))
                {
                    redSum += a[i].Price;
                }

            }

        }
    }
}
