using System;
using System.Text;

namespace CalculatorTest
{
	public class Calculate
	{
		public Calculate()
		{
		}

        public static int operationResult(string expression)
        {
            char[] subExpression = expression.ToCharArray();

            // Stack for operands: 'values'
            Stack<int> values = new Stack<int>();

            // Stack for Operators: 'Operators'
            Stack<char> Operators = new Stack<char>();

            for (int i = 0; i < subExpression.Length; i++)
            {
                // Current token is a space
                if (subExpression[i] == ' ')
                {
                    continue;
                }

                // if the token is a operand, push it to stack for operand
                if (subExpression[i] >= '0' && subExpression[i] <= '9')
                {
                    StringBuilder sbuf = new StringBuilder();

                     
                    while (i < subExpression.Length &&
                            subExpression[i] >= '0' &&
                                subExpression[i] <= '9')
                    {
                        sbuf.Append(subExpression[i++]);
                    }
                    values.Push(int.Parse(sbuf.ToString()));
 
                    i--;
                }

                // Current token is an opening brace
                // push it to 'Operators'
                else if (subExpression[i] == '(')
                {
                    Operators.Push(subExpression[i]);
                }

                // Closing brace encountered,
                // solve entire brace
                else if (subExpression[i] == ')')
                {
                    while (Operators.Peek() != '(')
                    {
                         
                            values.Push(Operator.operation(Operators.Pop(),
                                            values.Pop(),
                                            values.Pop()));
                         
                    }
                    Operators.Pop();
                }

                // Current token is an operator.


                else if (Operator.findOperator(subExpression[i]))
                {

                    // While top of 'Operators' has same or greater priority to current token, which is an operator.
                    // Apply operator on top of 'Operators' to two top elements in values stack and push the result to operands
                    while (Operators.Count > 0 &&
                            Operand.checkPriorityOfOprend(subExpression[i],
                                        Operators.Peek()))
                    {
                        values.Push(Operator.operation(Operators.Pop(),
                                        values.Pop(),
                                        values.Pop()));
                    }

                    // Push current token to 'Operators'.
                    Operators.Push(subExpression[i]);
                }
            }

            // Entire expression has been
            // parsed at this point, apply remaining
            // ops to remaining values
            while (Operators.Count > 0)
            {
                values.Push(Operator.operation(Operators.Pop(),
                                values.Pop(),
                                values.Pop()));
            }
 
            //pop the result in operands and  return it
            return values.Pop();
        }


    }
}

