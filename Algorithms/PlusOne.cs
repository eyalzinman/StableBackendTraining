using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public class PlusOne
    {
        public int[] Execute(int[] digits)
        {
            for (int i = digits.Length - 1; i >= 0; --i)
            {
                if (digits[i] < 9)
                {
                    ++digits[i];
                    return digits;
                }
                else
                {
                    digits[i] = 0;
                }
            }

            var result = new int[digits.Length + 1];
            result[0] = 1;

            return result;
        }
    }
}
