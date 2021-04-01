using System;

namespace Lab_1
{
    public delegate int delegates();

    public static class Ran
    {
        public static int random()
        {
            Random r = new Random();
            return r.Next(50);
        }
    }
    public class N3
    {
        public static delegates[]  arr = new delegates[]
        {
            new delegates(Ran.random),
            new delegates(Ran.random),
            new delegates(Ran.random)
        };
    }
}