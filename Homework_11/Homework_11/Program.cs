using System;

namespace Homework_11
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Program program = new Program();
            Class1 class1 = new Class1();
            Class2 class2 = new Class2();
            program.Show(class2.Calc(2, 5));
        }

        public void Show(bool x)
        {
            if (x)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
