using FizzBuzz.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.UnitTests.Service
{
    public class FizzBuzzServiceTests
    {
        private readonly FizzBuzzService _sut;

        public FizzBuzzServiceTests()
        {
            _sut = new FizzBuzzService();
        }

        [Theory]
        [InlineData("3")]
        [InlineData("6")]
        [InlineData("9")]
        public void ItShouldReturnFizz_IfInputIsDivisibleBy3(string input)
        {
            var result = _sut.FetchResult(input);

            Assert.Equal("Fizz", result.Results[0]);
        }

        [Theory]
        [InlineData("5")]
        [InlineData("10")]
        [InlineData("20")]
        public void ItShouldReturnBuzz_IfInputIsDivisibleBy5(string input)
        {
            var result = _sut.FetchResult(input);

            Assert.Equal("Buzz", result.Results[0]);
        }

    }
}
