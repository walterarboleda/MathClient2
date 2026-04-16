using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathClient2.MathService;


namespace MathClient2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            MathService.MathServiceSoapClient myMathService = new MathService.MathServiceSoapClient();
            Console.Write("2 + 4 = {0}", myMathService.Add(2, 4));
            Console.Write("20 / 2 = {0}", myMathService.Divide(20, 2));
            Console.Write("2 * 2 = {0}", myMathService.Multiply(2, 2));
            Console.Write("20 - 2 = {0}", myMathService.Subtract(20, 2));

        }

    }
}
