﻿using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Старых Федор ИУ5-35б";
            double a;
            double b;
            double c;
            if (args.Length == 3)
            {
                Console.WriteLine("Ввод ");
                try
                {
                    a = Double.Parse(args[0]);
                    b = Double.Parse(args[1]);
                    c = Double.Parse(args[2]);
                }
                catch
                {
                    Console.WriteLine("Коэффициент должен быть числом. Повторите ввод. ");
                    a = ReadDouble("Коэффициент а: ");
                    b = ReadDouble("Коэффициент b: ");
                    c = ReadDouble("Коэффициент c: ");
                }
            }
            else
            {
                a = ReadDouble("Коэффициент a: ");
                b = ReadDouble("Коэффициент b: ");
                c = ReadDouble("Коэффициент c: ");
            }
            if (a == 0 && b != 0)//проверка на корень из минус числа добавлена
            {
                double root = (-1 * c) / b;
                if (root > 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Корни: " + Math.Sqrt(root) + " и -" + Math.Sqrt(root));
                }
                if(root == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Корень: " + Math.Sqrt(root));
                }
                if(root < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Корни отсутствуют");
                }
                Console.ResetColor();
            }
            else if (a != 0)
            {
                double d = Math.Pow(b, 2) - 4 * a * c;
                Console.WriteLine("Дискриминант: " + d);
                if (d > 0)
                {
                    double root_1 = (-1 * b + Math.Sqrt(d)) / (2 * a);
                    double root_2 = (-1 * b - Math.Sqrt(d)) / (2 * a);
                    Console.ForegroundColor = ConsoleColor.Green;
                    if (root_1 >= 0)
                    {
                        Console.WriteLine("Корень 1: " + Math.Sqrt(root_1));
                        Console.WriteLine("Корень 2: " + -1 * Math.Sqrt(root_1));
                    }
                    if (root_2 >= 0)
                    {
                        Console.WriteLine("Корень 3: " + Math.Sqrt(root_2));
                        Console.WriteLine("Корень 4: " + -1 * Math.Sqrt(root_2));
                    }
                }
                else if (d == 0)
                {
                    double root = (b + Math.Sqrt(d)) / (2 * a);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Корень " + Math.Sqrt(root));
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Корни отсутствуют");
                }
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("a и b = 0");
            }
            Console.ReadLine();
        }
        static double ReadDouble(string consoleMessage)
        {
            string resultString;
            double resultDouble;
            bool point;
            do
            {
                Console.Write(consoleMessage);
                resultString = Console.ReadLine();
                if (!(point = double.TryParse(resultString, out resultDouble)))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Коэффициент должен быть числом. Повторите ввод.");
                    Console.ResetColor();
                }
            }
            while (!point);
            return resultDouble;
        }
    }
}