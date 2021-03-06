﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name:");
            string userName = Console.ReadLine();

            Console.WriteLine("Hello, {0} the current time is {1}", userName, System.DateTime.Now.TimeOfDay);

            Console.WriteLine("{0}, the solution to problem 1 is {1} ", userName, getSum());
            Console.WriteLine("{0}, the solution to problem 2 is {1} ", userName, getFiboSum());
            Console.WriteLine("{0}, the solution to problem 3 is {1} ", userName, primeNum());
            Console.WriteLine("Press any key to quit.");
            Console.ReadKey();
        }

        static int getSum()
        {
            int sum = 0;
            for (int i = 0; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }

        static long getFiboSum()
        {
            int b = 1;
            int c = 2, d;
            long sum = 0;
            while (c < 4000000)
            {
                sum += c;
                d = b + (c << 0x01);
                c = d + b + c;
                b = d;
            }
            return sum;
        }

        public static long primeNum()
        {

            long n = 600851475143L;
            List <long> numbers = new List<long>();

            for (long i = 2; i <= n; i++)
            {
                if (n % i == 0)
                {
                    numbers.Add(i);
                    n = n / i;
                    i = 2;
                }
            }
            long answer = numbers.Last();
            return answer;
        }
    }
}

