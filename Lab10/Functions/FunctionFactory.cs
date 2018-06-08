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
                return SinFunction.getInstance();
            }
            if (functionName == "cos(x)")
            {
                return CosFunction.getInstance();
            }
            if (functionName == "tan(x)")
            {
                return TanFunction.getInstance();
            }
            if (functionName == "cotan(x)")
            {
                return CotanFunction.getInstance();
            }
            throw new InvalidOperationException();
        }
    }
}