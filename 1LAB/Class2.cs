using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication39
{
    class Program
    {
        static void Main(string[] args)
        {
            //ax^2+bx+с
            //D=b^2-4ac
            double a, b, c;
            Console.WriteLine("Введите a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите b: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите c: ");
            c = Convert.ToDouble(Console.ReadLine());
            Reshenie myclass = new Reshenie(a, b, c);


        }
    }
    class Reshenie
    {
        private double a;
        private double b;
        private double c;
        private double D;
        private double x1;
        private double x2;
        public Reshenie(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public void raschet()
        {
            D = Math.Pow(b, 2) - 4 * a * c;
            if (D > 0 || D == 0)
            {
                x1 = (-b + Math.Sqrt(D)) / (2 * a);
                x2 = (-b - Math.Sqrt(D)) / (2 * a);
                Console.WriteLine("x1= {0}\n x2= {1}", Math.Sqrt(x1), Math.Sqrt(x2));
                Console.ReadKey();

            }

            else
            {
                Console.WriteLine("Действительных корней нет");
                Console.ReadKey();
            }

        }
  
      
    } 
}
