using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentalofProgramming
{
    internal class baitap3
    {
        private static void Main(string[] args)
        {
            /*
             1.Write a C# Sharp program that takes two numbers as input and performs an operation (+,-,*,x,/) on them and displays the result of that operation.
2.Write a C# Sharp program to display certain values of the function x = y2 + 2y + 1 (using integer numbers for y, ranging from -5 to +5).
3.Write a C# Sharp program that takes distance and time (hours, minutes, seconds) as input and displays speed in kilometers per hour (km/h) and miles per hour (miles/h).
4.Write a C# Sharp program that takes the radius of a sphere as input and calculates and displays the surface and volume of the sphere.  V = 4/3*π*r3 
5.Write a C# Sharp program that takes a character as input and checks if it is a vowel, a digit, or any other symbol.

             */
            //---1---
            {
                Console.Write("Enter first number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter operation (+, -, *, /): ");
                char op = Convert.ToChar(Console.ReadLine());
                Console.Write("Enter second number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                switch (op)
                {
                    case '+': Console.WriteLine($"{num1} + {num2} = {num1 + num2}"); break;
                    case '-': Console.WriteLine($"{num1} - {num2} = {num1 - num2}"); break;
                    case '*':
                    case 'x': Console.WriteLine($"{num1} * {num2} = {num1 * num2}"); break;
                    case '/':
                        if (num2 != 0) Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
                        else Console.WriteLine("Cannot divide by zero.");
                        break;
                    default: Console.WriteLine("Invalid operator."); break;
                }
            }
            //---2---
            {
                Console.WriteLine("y\t x = y² + 2y + 1");
                Console.WriteLine("-----------------------");
                for (int y = -5; y <= 5; y++)
                {
                    int x = (y * y) + (2 * y) + 1;
                    Console.WriteLine($"{y}\t {x}");
                }

            }
            //---3---
            {
                Console.WriteLine("y\t x = y² + 2y + 1");
                Console.WriteLine("-----------------------");
                for (int y = -5; y <= 5; y++)
                {
                    int x = (y * y) + (2 * y) + 1;
                    Console.WriteLine($"{y}\t {x}");
                }
            }
            //---4---
            {
                Console.Write("Enter the radius of the sphere: ");
                double r = Convert.ToDouble(Console.ReadLine());

                double surfaceArea = 4 * Math.PI * Math.Pow(r, 2);
                double volume = (4.0 / 3.0) * Math.PI * Math.Pow(r, 3);

                Console.WriteLine($"Surface Area: {surfaceArea}");
                Console.WriteLine($"Volume: {volume}");
            }
            //---5---
            {
                Console.Write("Enter a character: ");
                char input = Convert.ToChar(Console.ReadLine().ToLower());

                if (char.IsDigit(input))
                {
                    Console.WriteLine("It's a digit.");
                }
                else if ("aeiou".Contains(input))
                {
                    Console.WriteLine("It's a vowel.");
                }
                else
                {
                    Console.WriteLine("It's another symbol or a consonant.");
                }
            }
        }
    }
}

