﻿using System;

namespace ArraysLists
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string [5];
            names[0] = Console.ReadLine();
            names[1] = Console.ReadLine();
            names[2] = Console.ReadLine();
            names[3] = Console.ReadLine();
            names[4] = Console.ReadLine();

             foreach (string s in names){
                 Console.WriteLine("Hello " + s);
                 
             }

          
        } 
    }
}
