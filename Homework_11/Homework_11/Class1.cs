using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_11
{    
    internal class Class1
    {   
        public Action<bool> ShowPow;
        public int Pow(int x, int y)
        {
            return x * y;
        }
    }
}
