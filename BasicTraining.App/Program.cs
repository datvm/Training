﻿using System;
using System.Threading;
using System.Threading.Tasks;

namespace BasicTraining.App
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }

        public static int DoSomething()
        {
            Thread.Sleep(1000);
            return 1;
        }

    }
}