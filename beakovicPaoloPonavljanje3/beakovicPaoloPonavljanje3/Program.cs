﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beakovicPaoloPonavljanje3
{
    class Program
    {
        static void Main(string[] args)
        {
            int broj = Convert.ToInt32(Console.ReadLine());
            if (broj % 4 == 0 && broj % 6 == 0) Console.WriteLine("Broj je dijeljiv sa 4 i sa 6");
            else if (broj % 4 == 0) Console.WriteLine("Broj je dijeljiv sa 4 ");
            else if (broj % 6 == 0) Console.WriteLine("Broj je dijeljiv sa 6 ");
            else if (broj % 4 != 0 && broj % 6 != 0) Console.WriteLine("Broj nije dijeljiv sa 4 ni sa 6 ");

            Console.ReadKey();

        }
    }
}
