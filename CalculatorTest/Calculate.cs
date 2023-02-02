using System;
using System.Text;

namespace Calculator
{
	public class Calculate
	{
		public Calculate()
		{
		}

        public static int operationResult(string expression)
        {
            char[] subExpression = expression.ToCharArray();

            // Stack for operands: 'oprandsStack'
            Stack<int> oprandsStack = new Stack<int>();

            // Stack for Operators: 'Operators'
            Stack<char> Operators = new Stack<char>();

            for (int i = 0; i < subExpression.Length; i++)
            {
                // Current subExpression is a space
                if (subExpression[i] == ' ')
                {
                    continue;
                }

                // if the subExpression is a operand, push it to stack for operand
                if (subExpression[i] >= '0' && subExpression[i] <= '9')
                {
                    StringBuilder sbuf = new StringBuilder();

                     
                    while (i < subExpression.Length &&
                            subExpression[i] >= '0' &&
                                subExpression[i] <= '9')
                    {
                        sbuf.Append(subExpression[i++]);
                    }
                    oprandsStack.Push(int.Parse(sbuf.ToString()));
 
                     i--;
                }

                // Current subExpression is an opening brace
                // push it to 'Operators'
                else if (subExpression[i] == '(')
                {
                    Operators.Push(subExpression[i]);
                }

                // We find closing brace.
                // calculate what we have between brace
                else if (subExpression[i] == ')')
                {
                    while (Operators.Peek() != '(')
                    {

                        oprandsStack.Push(Operator.operation(Operators.Pop(),
                                            oprandsStack.Pop(),
                                            oprandsStack.Pop()));
                         
                    }
                    Operators.Pop();
                }

                // Current subExpression is an operator.
                else if (Operator.findOperator(subExpression[i]))
                {

                    // While top of 'Operators' has same or greater priority to current subExpression, which is an operator.
                    // Apply operator on top of the stack 'Operators' to two top elements in oprandsStack stack and push the result to operands
                    while (Operators.Count > 0 &&
                            Operand.checkPriorityOfOprend(subExpression[i],
                                        Operators.Peek()))
                    {
                        oprandsStack.Push(Operator.operation(Operators.Pop(),
                                        oprandsStack.Pop(),
                                        oprandsStack.Pop()));
                    }

                    // Push current subExpression to 'Operators'.
                    Operators.Push(subExpression[i]);
                }
            }

            // do the evaluation to the reste of the operends
            while (Operators.Count > 0)
            {
                oprandsStack.Push(Operator.operation(Operators.Pop(),
                                oprandsStack.Pop(),
                                oprandsStack.Pop()));
            }
 
            //pop the result in operands and  return it
            return oprandsStack.Pop();
        }


    }
}

