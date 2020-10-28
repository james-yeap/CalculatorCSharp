using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
    public interface ICalculator
    {
        public int Add(int Value1, int Value2);
        public int Subtract(int Value1, int Value2);
        public int Multiply(int Value1, int Value2);
        public double Divide(int Value1, int Value2);
        public string Percentage(int Value1, int Value2);


    }
}
