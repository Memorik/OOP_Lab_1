using System;

namespace Lab_1
{
    class Program
    {
        private delegate double del(int a, int b, int c);
        static void Main(string[] args)
        {
            N1();
            N2();
            n3();
        }

        static void N1()
        {
            del del = delegate (int a, int b, int c)
            {
                double result = (a + b + c) / 3;
                return result;
            };
            Console.WriteLine(del(2, 3, 4));
        }

        static void N2()
        {
            Calc calc = new Calc();
            Console.WriteLine(calc.Add(1, 3));
            Console.WriteLine(calc.Sub(4, 2));
            Console.WriteLine(calc.Div(12, 3));
            Console.WriteLine(calc.Mul(5, 5));         
        }

        static void n3()
        {
            foreach (var del in N3.arr)
            {
                Console.WriteLine(del());
            }
        }
    }
}
