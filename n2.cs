using System;

namespace Lab_1
{
    public delegate double del(int x, int y);


    public class Calc
    {
       public del Add = (a,b)=>a+b;
        public del Sub = (a, b) => a - b;
        public del Mul = (a, b) => a * b;

        public del Div = (a, b) =>
        {
            if (b != 0)
            {
                return a/b;
            }
            else
            {
                Console.WriteLine("Error");
                return 0;
            }
        };
    }
}