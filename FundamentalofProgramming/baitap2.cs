using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace FundamentalofProgramming
{
    internal class baitap2
    {
        private static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            //6. Multiply Three Numbers
            {
                Console.Write("Input the first number to multiply: ");
                float num1 = float.Parse(Console.ReadLine());
                Console.Write("Input the second number to multiply: ");
                float num2 = float.Parse(Console.ReadLine());
                Console.Write("Input the third number to multiply: ");
                float num3 = float.Parse(Console.ReadLine());

                float result = num1 * num2 * num3;
                Console.WriteLine($"{num1} x {num2} x {num3} = {result}");
            }

            //7. Arithmetic Operations
            {
                Console.Write("Input the first number: ");
                float n1 = float.Parse(Console.ReadLine());
                Console.Write("Input the second number: ");
                float n2 = float.Parse(Console.ReadLine());
                Console.WriteLine($"{n1} + {n2} = {n1 + n2}");

                Console.WriteLine($"{n1} - {n2} = {n1 - n2}");

                Console.WriteLine($"{n1} x {n2} = {n1 * n2}");

                Console.WriteLine($"{n1} / {n2} = {n1 / n2}");

                Console.WriteLine($"{n1} mod {n2} = {n1 % n2}");
            }

            //8. Multiplication Table

            {
                Console.Write("Enter the number: ");
                int number = int.Parse(Console.ReadLine());
                for (int i = 0; i <= 10; i++)
                {
                    Console.WriteLine($"{number} * {i} = {number * i}");
                }
            }
            //9. Average of Four Numbers
            {

                Console.Write("Input the first number: ");
                float num1 = float.Parse(Console.ReadLine());
                Console.Write("Input the second number: ");
                float num2 = float.Parse(Console.ReadLine());
                Console.Write("Input the third number: ");
                float num3 = float.Parse(Console.ReadLine());
                Console.Write("Input the fourth number: ");
                float num4 = float.Parse(Console.ReadLine());
                Console.WriteLine($"The average of {num1}, {num2}, {num3}, {num4} is {(num1 + num2 + num3 + num4) / 4} ");
            }
            //10.Specified Formula with Three Numbers
            {
                Console.Write("Enter first number: ");
                int x = int.Parse(Console.ReadLine());

                Console.Write("Enter second number: ");
                int y = int.Parse(Console.ReadLine());

                Console.Write("Enter third number: ");
                int z = int.Parse(Console.ReadLine());
                int result1 = (x + y) * z;
                int result2 = x * y + y * z;    

                Console.WriteLine($"Result of specified numbers {x}, {y} and {z}, (x+y).z is {result1} and x.y + y.z is {result2}");
            }
            //11. Print Age Message

            {
                Console.Write("Enter your age: ");
                int age = int.Parse(Console.ReadLine());
                Console.WriteLine($"You look older than {age}");
            }
            //12. Repeat Number in Rows

            {
                Console.Write("Enter a digit: ");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine("{0} {0} {0} {0}", n);
                Console.WriteLine("{0}{0}{0}{0}", n);
                Console.WriteLine("{0} {0} {0} {0}", n);
                Console.WriteLine("{0}{0}{0}{0}", n);
            }
            //13. Rectangle Pattern with Number

            {
                Console.WriteLine("\n[BÀI 13: HÌNH CHỮ NHẬT BẰNG SỐ]");
                Console.Write("Enter a number: ");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine("{0}{0}{0}", n);
                Console.WriteLine("{0} {0}", n);
                Console.WriteLine("{0} {0}", n);
                Console.WriteLine("{0} {0}", n);
                Console.WriteLine("{0}{0}{0}", n);
            }
            //14. Celsius to Kelvin and Fahrenheit

            {
                Console.Write("Enter the amount of celsius: ");
                float celsius = float.Parse(Console.ReadLine());

                float kelvin = celsius + 273;
                float fahrenheit = (celsius * 9 / 5) + 32;
                Console.WriteLine($"Kelvin = {kelvin}");
                Console.WriteLine($"Fahrenheit = {fahrenheit}");
            }

            //15.
            {
                Console.Write("Input a string: ");
                string str = Console.ReadLine();
                if (!string.IsNullOrEmpty(str))
                {
                    // Xóa ký tự ở vị trí thứ 1
                    Console.WriteLine(str.Remove(1, 1));
                    // Xóa ký tự cuối cùng
                    Console.WriteLine(str.Remove(str.Length - 1));
                    // Xóa ký tự đầu tiên (vị trí 0)
                    Console.WriteLine(str.Remove(0, 1));
                }
            }

            //16.
            {
                Console.Write("Input a string: ");
                string str = Console.ReadLine();

                Console.WriteLine("Sample Output:");
                if (str.Length <= 1)
                {
                    Console.WriteLine(str);
                }
                else
                {
                    string first = str.Substring(0, 1);
                    string last = str.Substring(str.Length - 1);
                    string middle = str.Substring(1, str.Length - 2);

                    Console.WriteLine(last + middle + first);
                }
                // 17. Add First Character to Front and Back
                {
                    Console.Write("Input a string: ");
                    string str1 = Console.ReadLine();

                    if (str1.Length >= 1)
                    {
                        string s = str.Substring(0, 1);
                        Console.WriteLine(s + str + s);
                    }
                }

                // 18. Check Positive and Negative Pair
                {
                    Console.WriteLine("Input first integer:");
                    int n1 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Input second integer:");
                    int n2 = int.Parse(Console.ReadLine());
                    bool result = (n1 < 0 && n2 > 0) || (n1 > 0 && n2 < 0);

                    Console.WriteLine("Check if one is negative and one is positive:");
                    Console.WriteLine(result);
                }

                // 19. Sum or Triple Sum of Integers
                {
                    Console.Write("Input first integer: ");
                    int n1 = int.Parse(Console.ReadLine());

                    Console.Write("Input second integer: ");
                    int n2 = int.Parse(Console.ReadLine());

                    int sum = n1 + n2;
                    if (n1 == n2)
                    {
                        Console.WriteLine(sum * 3);
                    }
                    else
                    {
                        Console.WriteLine(sum);
                    }
                }
                // 20. Absolute Difference or Double It
                {
                    Console.Write("Input first number: ");
                    int n1 = int.Parse(Console.ReadLine());
                    Console.Write("Input second number: ");
                    int n2 = int.Parse(Console.ReadLine());

                    int diff = Math.Abs(n1 - n2);

                    if (n1 > n2)
                    {
                        Console.WriteLine(diff * 2);
                    }
                    else
                    {
                        Console.WriteLine(diff);
                    }
                }

                // 21. Check for 20 or Sum Equals 20
                {
                    Console.Write("Input first integer: ");
                    int n1 = int.Parse(Console.ReadLine());
                    Console.Write("Input second integer: ");
                    int n2 = int.Parse(Console.ReadLine());

                    bool result = (n1 == 20 || n2 == 20 || (n1 + n2 == 20));
                    Console.WriteLine(result);
                }

                // 22. Check Within 20 of 100 or 200
                {
                    Console.WriteLine("Input an integer:");
                    int n = int.Parse(Console.ReadLine());

                    // Kiểm tra xem khoảng cách đến 100 hoặc 200 có <= 20 không
                    bool result = Math.Abs(n - 100) <= 20 || Math.Abs(n - 200) <= 20;
                    Console.WriteLine(result);
                }

                // 23. Convert String to Lowercase
                {
                    Console.Write("Input a string: ");
                    string str2 = Console.ReadLine();
                    Console.WriteLine(str2.ToLower());
                }

                // 24. Find Longest Word in String
                {
                    Console.Write("Input a string: ");
                    string str3 = Console.ReadLine();
                    string[] words = str3.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    string longestWord = "";
                    foreach (string word in words)
                    {
                        if (word.Length > longestWord.Length)
                        {
                            longestWord = word;
                        }
                    }
                    Console.WriteLine($"Longest word: {longestWord}");
                }

                // 25. Print Odd Numbers 1 to 99
                {
                    Console.WriteLine("Odd numbers from 1 to 99. Prints one number per line.");
                    for (int i = 1; i <= 99; i++)
                    {
                        if (i % 2 != 0)
                        {
                            Console.WriteLine(i);
                        }
                    }
                }
                // 26. Sum of First 500 Primes
                {
                    Console.WriteLine("Sum of the first 500 prime numbers:");

                    int count = 0;
                    long sum = 0;
                    int number = 2; // Số nguyên tố bắt đầu từ 2

                    while (count < 500)
                    {
                        bool isPrime = true;
                        // Kiểm tra xem 'number' có phải số nguyên tố không
                        for (int i = 2; i <= Math.Sqrt(number); i++)
                        {
                            if (number % i == 0)
                            {
                                isPrime = false;
                                break;
                            }
                        }

                        if (isPrime)
                        {
                            sum += number;
                            count++;
                        }
                        number++;
                    }

                    Console.WriteLine(sum);
                }
            }
        }

    }
    }
