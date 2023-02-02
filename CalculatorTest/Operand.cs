using System;
namespace CalculatorTest
{
	public class Operand
	{
		public Operand()
		{
		}

       
        // Returns true if 'op2' has
        // higher or same precedence as 'op1',
        // otherwise returns false.
        public static bool checkPriorityOfOprend(char op1,
                                        char op2)
        {
            if (op2 == '(' || op2 == ')')
            {
                return false;
            }
            if ((op1 == '*' || op1 == '/') &&
                (op2 == '+' || op2 == '-'))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}

