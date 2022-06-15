using System;

namespace Homework_11
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Class2 class2 = new Class2();
            Class1 class1 = new Class1();;
            Program.Show(Class2.Calc(class1.Pow, 2, 5));
        }

        public static void Show(Predicatereturn predicatereturn)
        {
            bool x = predicatereturn(3);
            Console.WriteLine(x);
        }
    }
}
