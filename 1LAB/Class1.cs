1
2
3
4
5
6
7
8
9
10
11
12
13
14
15
16
17
18
19
20
21
22
23
24
25
26
27
28
29
30
31
32
33
34
35
36
37
38
39
40
41
42
43
44
45
46
47
48
49
50
51
52
53
54
55
56
57
58
59
60
61
62
63

	

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
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
                Console.WriteLine("x1= {0}\n x2= {1}", Math.Sqrt(x1), Math.Sqrt(x2), '-'Math.Sqrt(x1),'-' Math.Sqrt(x2));
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