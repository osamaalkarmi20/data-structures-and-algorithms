
using System.Collections.Generic;

namespace data_structures_and_algorithms
{


    public class Program
    {
        static void Main(string[] args)
        {
            {
                        
                Console.WriteLine(BracketsBalanced("(dssg)")); 
                Console.WriteLine(BracketsBalanced("(dssg"));
                Console.WriteLine(BracketsBalanced("(dssg}")); 
                Console.WriteLine(BracketsBalanced("{dssg}")); 
            }

        }
    



        public static bool BracketsBalanced(string input)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char item in input)
            {
                if (item == '(' || item == '[' || item == '{')
                {
                    stack.Push(item);
                }
                else if (item == ')' || item == ']' || item == '}')
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }

                    char opening = stack.Pop();

                    if ((item == ')' && opening != '(') ||
                        (item == ']' && opening != '[') ||
                        (item == '}' && opening != '{'))
                    {
                        return false;
                    }
                }
            }

            return stack.Count == 0;
        }




    }
}


















