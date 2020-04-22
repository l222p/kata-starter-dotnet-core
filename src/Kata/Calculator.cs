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
            
            return int.Parse(input);
        }
    }
}