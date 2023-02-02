using System;
using System.Linq.Expressions;
using System.Text;

namespace CalculatorTest
{
    
    public class Operator
	{
		public Operator()
		{
		}
        // check if the operator is in my  array of opperators 
        public static bool findOperator( char c)
        {
            char[] array = { '+', '*', '/', '-' };
            if (array.Contains(c))
            {
                return true;
            }
            return false;

        }
     
        
        // calculate the result for each operator and return it.
        public static int operation(char op,
                                int operand1, int operand2)
        {
            switch (op)
            {
                case '+':
                    return operand1 + operand2;
                case '-':
                    return operand2 - operand1;
                case '*':
                    if (operand1 == 0 || operand2 == 0)
                    {
                        return 0;
                    }
                    
                    return operand1 * operand2;
                case '/':
                    if (operand1 == 0)
                    {
                        
                        Console.WriteLine("\"We cannot divide by zero\" ");

                    }
                    return operand2 / operand1;
            }
            return 0;
        }
    }
}

