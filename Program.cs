﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProjectPi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Fibonachi(int n)
            {
                if (n == 0 || n == 1) return n;

                return Fibonachi(n - 1) + Fibonachi(n - 2);
            }

            fib4 = Fibonachi(4);
            int fib5 = Fibonachi(5);
            int fib6 = Fibonachi(6);

            Console.WriteLine($"4 число Фибоначчи = {fib4}");
            Console.WriteLine($"5 число Фибоначчи = {fib5}");
            Console.WriteLine($"6 число Фибоначчи = {fib6}");
        }
    }
}
