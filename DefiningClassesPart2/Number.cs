using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPart2
{
    internal abstract class Number
    {
        private double num;
        public Number()
        {
            
        }
        public double Num
        {
          get{ return num; }
          set{ num = value;  }
        }
        public static Number operator+ (Number a, Number b)
        {
            return a + b;
        }
        public double Add(Number x, Number y)
        {
            return x.Num + y.Num;
        }
    }
}
