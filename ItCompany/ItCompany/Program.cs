﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ItCompany
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Made by students of IA-71");
            Console.WriteLine("MELNYK MYKOLA || OLEG KARASIOV || TRUKHAN NAZARII");
            Console.WriteLine(" ");
            Console.WriteLine("\tCreating IT-COMPANY");

            Console.WriteLine();
            var company = new ITCompany();
            Console.WriteLine("Company name:" + company.Name);
            company.Name = "IT - MON";
            Console.WriteLine("Company name:" + company.Name);

            Console.ReadLine();
        }
    }
}
