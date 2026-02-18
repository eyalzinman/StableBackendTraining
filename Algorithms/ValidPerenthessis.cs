using System;
using System.Collections.Generic;

public class ValidParentheses
{
    public bool IsValid(string s)
    {
        Stack<char> stack = new Stack<char>();
        Dictionary<char, char> map = new Dictionary<char, char>()
        {
            { '(', ')' },
            { '{', '}' },
            { '[', ']' }
        };

        foreach (char c in s)
        {
            if (c == '(' || c == '{' || c == '[')
            {
                stack.Push(c);
            }
            else // closing
            {
                if (stack.Count == 0)
                    return false;

                char open = stack.Pop();
                if (map[open] != c)
                    return false;
            }
        }

        return stack.Count == 0;
    }
}
