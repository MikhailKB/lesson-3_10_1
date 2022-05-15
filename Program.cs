using System;
using static System.Console;

namespace lesson___3_10_1
{
    internal class Program
    {
        static void Main(string[] args)  // точка входа
        {
            int m;

            m = int.Parse(ReadLine());

            if (m % 2 == 0)           
            { 
               WriteLine("число чётное"); 
            } 
            else
            { 
               WriteLine("число нечётное"); 
            }


            ReadKey();
        
        }
    }
}