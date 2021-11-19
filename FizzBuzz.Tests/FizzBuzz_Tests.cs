using System;
using Xunit;
using FizzBuzz;

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
    }
}
