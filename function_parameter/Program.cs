﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace function_parameter
{
    internal class Program
    {
        static double num1;
        static double num2;

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number: ");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a number: ");
            num2 = double.Parse(Console.ReadLine());
            Addition(num1, num2);
            Subtraction(num1, num2);
            Multiplication(num1, num2);
            Division(num1, num2);

            Console.ReadKey();
        }

        static void Addition(double add1, double add2)
        {
            double sum = add1 + add2;
            Console.WriteLine($" {add1} + {add2} = {sum}");
        }

        static void Subtraction(double sub1, double sub2)
        {
            double difference = sub1 - sub2;
            Console.WriteLine($" {sub1} - {sub2} = {difference}");
        }
        static void Multiplication(double fact1, double fact2)
        {
            double product = fact1 * fact2;
            Console.WriteLine($" {fact1} * {fact2} = {product}");
        }
        static void Division(double div1, double div2)
        {
            double quotient = div1 / div2;
            Console.WriteLine($" {div1} / {div2} = {quotient}");
        }
    }
}
