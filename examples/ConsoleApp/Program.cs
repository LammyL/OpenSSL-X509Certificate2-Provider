﻿using System;
using ConsoleApp452;

namespace ConsoleApp
{
    static class Program
    {
        static void Main(string[] args)
        {
            Demo.TestX509Certificate2();
            Console.WriteLine(new string('-', 80));
            Demo.TestPrivateKey();
        }
    }
}