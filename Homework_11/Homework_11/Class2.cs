using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_11
{
    public delegate int Powdel(int x, int y);
    public delegate bool Predicatereturn(int x);
    internal class Class2
    {        
        public static int res;
        public static Predicatereturn Calc(Powdel Pow,int x, int y)
        {
            Predicatereturn result = Result;
            res = Pow(x, y);
            return result;
        }
        public static bool Result(int x)
        {
            return res % x == 0;
        }

    }
}
