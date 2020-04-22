using System;
using System.Linq;

namespace Kata.Spec
{
    public class Calculator
    {
        public int Add(string input = "")
        {
            
            if (input == "")
            {
                return 0;
            }

            var result = input.Split(new string[]{",","\n"}, StringSplitOptions.None).Select(int.Parse);
            
            return result.Sum();
        }
    }
}