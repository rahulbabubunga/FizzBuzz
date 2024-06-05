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

        [Fact]
        public void ItShouldReturnFizz_IfInputIsDivisibleBy3()
        {
            var result = _sut.FetchResult("3");

            Assert.Equal("Fizz", result.Results[0]);
        }

        [Fact]
        public void ItShouldReturnFizz_IfInputIsDivisibleBy5()
        {
            var result = _sut.FetchResult("5");

            Assert.Equal("Buzz", result.Results[0]);
        }

    }
}
