using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApplicationCSharp
{
    public class Calculate
    {
        public int Addition(int x1, int x2)
        {
            return x1+x2;
        }
        public int Subtraction(int x1, int x2)
        {
            return x1-x2;
        }
        public int Multiply(int x1, int x2)
        {
            return x1*x2;
        }
        public double Division(int x1, int x2)
        {
            return x1/x2;
        }
    }
}