using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_11
{
    internal class Class1
    {
        public delegate void Deleg(bool x);
        public delegate int Pows(int x, int y);
        public Pows pows = Pow;
        public static int Pow(int x, int y)
        {
            return x * y;
        }
    }
}
