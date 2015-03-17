using System;
using System.Collections.Generic;

namespace ReversePolishNotation
{
    /// <summary>
    ///     Evaluate the value of an arithmetic expression in Reverse Polish Notation.
    /// </summary>
    public class Program
    {
        private static void Main(string[] args)
        {
            //["2", "1", "+", "3", "*"] -> ((2 + 1) * 3) -> 9
            string[] values1 = {"2", "1", "+", "3", "*"};
            int returnValue1 = EvalulateRPN(values1);

            //["4", "13", "5", "/", "+"] -> (4 + (13 / 5)) -> 6
            string[] values2 = {"4", "13", "5", "/", "+"};
            int returnValue2 = EvalulateRPN(values2);

            Console.WriteLine(returnValue1);

            Console.WriteLine(returnValue2);
        }

        public static int EvalulateRPN(string[] tokens)
        {
            int returnValue = 0;

            string operators = "+-*/";

            var stack = new Stack<string>();

            foreach (string s in tokens)
            {
                if (!operators.Contains(s))
                {
                    stack.Push(s);
                }
                else
                {
                    int a = int.Parse(stack.Pop());
                    int b = int.Parse(stack.Pop());
                    int index = operators.IndexOf(s);

                    switch (index)
                    {
                        case 0:
                            stack.Push((a + b).ToString());
                            break;
                        case 1:
                            stack.Push((b - a).ToString());
                            break;
                        case 2:
                            stack.Push((a*b).ToString());
                            break;
                        case 3:
                            stack.Push((b/a).ToString());
                            break;
                    }
                }
            }

            returnValue = int.Parse(stack.Pop());

            return returnValue;
        }
    }
}