using Xunit;

namespace FizzBuzz.Tests
{
    public class FizzBuzzTests
    {
        [Fact]
        public void NumberIsOne()
        {
            FizzBuzzClass fizzBuzz = new FizzBuzzClass();

            string result = fizzBuzz.FizzBuzz(1);

            Assert.Equal("1", result);
        }

        [Fact]
        public void NumberIsTwo()
        {
            FizzBuzzClass fizzBuzz = new FizzBuzzClass();

            string result = fizzBuzz.FizzBuzz(2);

            Assert.Equal("2", result);
        }

        [Fact]
        public void NumberIsThree()
        {
            FizzBuzzClass fizzBuzz = new FizzBuzzClass();

            string result = fizzBuzz.FizzBuzz(3);

            Assert.Equal("Fizz", result);
        }



    }
}
