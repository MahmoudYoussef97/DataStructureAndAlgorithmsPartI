using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks
{
    public class BalancedExpression
    {
        private List<char> leftBrackets = new List<char>{'(', '[', '<', '{'};
        private List<char> rightBrackets = new List<char>{')', ']', '>', '}'};
        public bool IsBalanced(string str)
        {
            if (str == null)
                throw new ArgumentNullException();

            Stack<char> stack = new Stack<char>();

            foreach (var ch in str)
            {   
                if (IsLeftBracket(ch))
                    stack.Push(ch);
                else if (IsRightBracket(ch))
                {
                    if (stack.Count == 0)
                        return false;

                    char closedBracket = stack.Pop();
                    if (!IsMatched(closedBracket, ch))
                        return false;
                }
            }

            return stack.Count > 0 ? false : true;
        }
        private bool IsLeftBracket(char ch)
        {
            return leftBrackets.Contains(ch);
        }
        private bool IsRightBracket(char ch)
        {
            return rightBrackets.Contains(ch);
        }
        private bool IsMatched(char closedBracket, char openedBracket)
        {
            if (openedBracket == ']' && closedBracket == '[')
                return true;
            if (openedBracket == ')' && closedBracket == '(')
                return true;
            if (openedBracket == '>' && closedBracket == '<')
                return true;
            if (openedBracket == '}' && closedBracket == '{')
                return true;

            return false;
        }
    }
}
