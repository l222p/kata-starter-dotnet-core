using System;
using System.Linq;

namespace Kata.Spec
{
    public class Calculator
    {
        public int Add(string input = "")
        {
            var delimiter = ",";
            if (input == "")
            {
                return 0;
            }
            //;  \n1;2
            if (input.Contains("//"))
            {
                delimiter = input.Split('\n')[0].Split("//")[1];
                var values = input.Split('\n')[1];
                input = values;
            }

            var result = input.Split(new string[]{",","\n", delimiter}, StringSplitOptions.None).Select(int.Parse);
            
            return result.Sum();
        }
    }
}