using Lab10.Interfaces;
using System;

namespace Lab10.Functions
{
    static class FunctionFactory
    {
        internal static ITrigonometricFunction Create(string functionName)
        {
            if (functionName == "sin(x)")
            {
                return new SinFunction();
            }
            if (functionName == "cos(x)")
            {
                return new CosFunction();
            }
            if (functionName == "tan(x)")
            {
                return new TanFunction();
            }
            if (functionName == "cotan(x)")
            {
                return new CotanFunction();
            }
            throw new InvalidOperationException();
        }
    }
}