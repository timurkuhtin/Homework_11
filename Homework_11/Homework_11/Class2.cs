using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_11
{
    internal class Class2
    {
        static Class1 class1 = new Class1();
        public delegate bool Res(int x);
        public static Res res = Result;
        public bool Calc(int x, int y)
        {
            return res(class1.pows(x, y));
        }
        public static bool Result(int x)
        {
            return x % 2 == 0;
        }
    }
}
