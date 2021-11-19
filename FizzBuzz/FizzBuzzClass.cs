using System;

namespace FizzBuzz
{
    public class FizzBuzzClass
    {
        public string FizzBuzz(int num)
        {
            switch (num)
            {
                case 3:
                    return "Fizz";
                case 5:
                    return "Buzz";
                default:
                    return num.ToString();
            }

        }
    }
}
