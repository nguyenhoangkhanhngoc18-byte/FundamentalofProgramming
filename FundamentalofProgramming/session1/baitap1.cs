using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace FundamentalofProgramming.session1
{
    internal class baitap1
    {
        /*
1. to Add / Sum Two Numbers.

2. to Swap Values of Two Variables.

3. to Multiply two Floating Point Numbers

4. to convert feet to meter

5. to convert Celsius to Fahrenheit and vice versa

6. to find the Size of data types

7. to Print ASCII Value (tip: read character, print number of this char)

8. to Calculate Area of Circle

9. to Calculate Area of Square

10. to convert days to years, weeks and days
        */
        private static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //1.to Add / Sum Two Numbers.
            int a = 10 + 6;
            Console.WriteLine("10 + 6 = {0}", a);

            //2. to Swap Values of Two Variables.
            int b = 8, c = 10;
            Console.WriteLine("Trước khi hoán đổi b= {b} , c= {c}  ");
            int temp = b;
            b = c;
            c = temp;
            Console.WriteLine("Sau khi hoán đổi b= {b}, c= {c}");

            //3. to Multiply two Floating Point Numbers
            float f1 = 5.6f, f2 = 3.4f;
            float result = f1 * f2;
            Console.WriteLine("{0} x {1} = {2}", f1 , f2, result);

            //4. to convert feet to meter
            float feet = 12.0f;
            float meter = feet * 0.3048f;
            Console.WriteLine("{0} feets = {1} meters", feet, meter);

            //5.to convert Celsius to Fahrenheit and vice versa
            float celsius = 35f;
            float fahrenheit = celsius * 1.8f + 32;
            Console.WriteLine("{0} degrees C = {1} degrees F", celsius, fahrenheit);

            float fah = 100f;
            float cel = (fah - 32) / 1.8f;
            Console.WriteLine("{0} degrees F = {1} degrees C", fah, cel);

            //6. to find the Size of data types
            Console.WriteLine("--- 6. Kích thước các kiểu dữ liệu ---");
            Console.WriteLine($"size of int: {sizeof(int)} bytes");
            Console.WriteLine($"size of long long: {sizeof(long)} bytes");
            Console.WriteLine($"size of float: {sizeof(float)} bytes");
            Console.WriteLine($"size of double: {sizeof(double)} bytes");
            Console.WriteLine($"size of bool: {sizeof(bool)} bytes");
        }
    }
}
