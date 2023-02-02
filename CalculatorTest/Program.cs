using System;
using CalculatorTest;


namespace CalculatorTest // Note: actual namespace depends on the project name.
{


    using System.Collections.Generic;
    using System.Reflection.PortableExecutable;
    using System.Text;

    class CalculatorTest
    {

        internal class Program
        {

            static void Main(string[] args)
            {
                Console.WriteLine("***************************************** ");
                Console.WriteLine("*********S-expression calculator********* ");
                Console.WriteLine("***************************************** ");
                Console.WriteLine("entre your expression: ");
                try
                {

                    string expr = Console.ReadLine();
                    int result = Calculator.Calculate.operationResult (expr);
                    Console.WriteLine(result);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
               

            }

        }
    }
}