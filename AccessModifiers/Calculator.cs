using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    internal class Calculator
    {
        internal int Add(int x, int y)
        {
            return x + y; 
        }
    }

    public class MathOperations
    {
        Calculator calculator = new Calculator();        

        public int Add(int x, int y)
        {
            return calculator.Add(x, y);
        }
    }
}
