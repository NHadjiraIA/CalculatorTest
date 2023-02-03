# CalculatorTest

# S-expression calculator

 A command line program that acts as a simple calculator: it takes a single argument as an expression and prints out the integer result of evaluating it.
 # The solution 
           
 1. While there are still  characters to be read in the expression 
 *  Get the next sub expression.
 *  If the sub expression  is:
       * A number: push it onto the oprandsStack  stack.
       * A variable: get its value, and push into the oprandsStack stack.
       * A left parenthesis: push it onto the operatorStack.
       *  A right parenthesis:
       1. While the thing on top of the operator stack is not a left parenthesis,
             1.  We  pop the operator .
             2. We Pop two operands .
             3. We apply the operator to the operands.
             4. We push the result into the oprandsStack stack.
       2. We pop the left parenthesis from the operator stack, and remove it.
       * An operator :
        1. While the operator stack is not empty, and the top thing on the operator stack has the same   priority  as this operator,
            1. We pop the operator  .
            2. We pop two operands from oprandsStack.
            3. We evaluate  the operation.
            4. We  Push the result onto the oprandsStack stack.
        2. Push this operator  into the operator stack.
 2. While the operator stack is not empty.
                1. We pop the operator.
                2. We pop two operands from oprandsStack.
                3.  We evaluate  the operation.
                4. We push the result onto the oprandsStack stack.
 3. At this point the operator stack should be empty, and the oprandsStack stack should have only one value , which is the final result.

Example : ( + (* 4 5) (* 8 7))

 Frist step:
opratorStack
). —>      we need to pop two value and remove the current operation in opratorStack so 4*5 = 20
*
(
+
(

OprandStack 

5
4

Second step :
opratorStack 
+
(

OprandStack 
20

Third step: we continue reading of the expression  opratorStack 
) —> we calculate the result 8*7 = 56
*
(
+
(

OprandStack 
7
8
20
 
forth one step:

opratorStack 
 )—> 56+20 = 76
+
(

OprandStack 
56
20

fifth step:

opratorStack 
 (Empty)

OprandStack 
76 —> the result
# Features
# Getting started
Prerequisites:
   1.  Install the latest version of Visual Studio (the free community edition is sufficient).
   2.  install .Net(SDK) on your machine
   3. Get the code:   git clone https://github.com/NHadjiraIA/CalculatorTest
   4. open the Solution in Visual Studio to build and run.
