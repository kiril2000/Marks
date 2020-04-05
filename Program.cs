﻿using System;

using System;
using System.Diagnostics;

namespace Marks
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            var watch = new Stopwatch();

            watch.Start();
            switch (num)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                    Console.WriteLine("Слаба оценка");
                    break;
                case 5:
                case 6:
                    Console.WriteLine("Средна оценка");
                    break;
                case 7:
                case 8:
                    Console.WriteLine("Добра оценка");
                    break;
                case 9:
                case 10:
                    Console.WriteLine("Отлична оценка");
                    break;
                default:
                    Console.WriteLine("Невалидна оценка");
                    break;
            }
            watch.Stop();

            Console.WriteLine(watch.Elapsed);
        }
    }
}
