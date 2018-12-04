using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wmFirstInterpolLagranzh
{
    interface IFunction
    {
       double getFunction(double x);
    }
    class FunctionSqrt : IFunction
    {
        public double getFunction(double x)
        {
            return Math.Sqrt(5 * Math.Pow(x, 2) + 2) / Math.Sqrt(3 * Math.Pow(x, 2) + 1);
        }
    }
    class FunctionSin : IFunction
    {
        public double getFunction(double x)
        {
            return Math.Sin(x);
        }
    }

    class FunctionWithoutSqrt : IFunction
    {
        public double getFunction(double x)
        {
            return Math.Sqrt(5 * Math.Pow(x, 2) + 2) / (3 * Math.Pow(x, 2) + 1);
        }
    }
}
