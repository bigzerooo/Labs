using System;
using System.Collections.Generic;
using System.Text;

namespace _3
{
    delegate int OperationEventHandler(int first, int second);
    class PrimitiveCalculator
    {
        public PrimitiveCalculator()
        {
            operation = Operations.Addition;            
        }
        public void ChangeStrategy(char @operator)
        {
            operation = null;
            switch (@operator)
            {
                case '+':
                    operation += Operations.Addition;
                    break;
                case '-':
                    operation += Operations.Substraction;
                    break;
                case '*':
                    operation += Operations.Multiplication;
                    break;
                case '/':
                    operation += Operations.Division;
                    break;
                default:
                    operation += Operations.Addition;
                    break;
            }
        }
        public int PerformCalculation(int firstOperand,int secondOperand)
        {
            return operation(firstOperand, secondOperand);
        }
        OperationEventHandler operation;

    }
}
