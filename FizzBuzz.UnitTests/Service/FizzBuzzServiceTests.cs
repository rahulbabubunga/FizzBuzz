using FizzBuzz.Service;

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
            //Act
            var result = _sut.FetchResult(input);
            //Assert
            Assert.Equal("Fizz", result.Results[0]);
        }

        [Theory]
        [InlineData("5")]
        [InlineData("10")]
        [InlineData("20")]
        public void ItShouldReturnBuzz_IfInputIsDivisibleBy5(string input)
        {
            //Act
            var result = _sut.FetchResult(input);
            //Assert
            Assert.Equal("Buzz", result.Results[0]);
        }

        [Theory]
        [InlineData("15")]
        [InlineData("30")]
        [InlineData("45")]
        public void ItShouldReturnFizzBuzz_IfInputIsDivisibleBy5And3(string input)
        {
            //Act
            var result = _sut.FetchResult(input);
            //Assert
            Assert.Equal("FizzBuzz", result.Results[0]);
        }

        [Theory]
        [InlineData("")]
        [InlineData("A")]
        [InlineData("AB")]
        public void ItShouldReturnInvalidItem_IfInputIsEmptyStringOrAnNonNumeric(string input)
        {
            //Act
            var result = _sut.FetchResult(input);
            //Assert
            Assert.Equal("Invalid Item", result.Results[0]);
        }

        [Theory]
        [InlineData("2")]
        [InlineData("23")]
        [InlineData("16")]
        public void ItShouldReturnAptText_IfInputIsNeitherDivisibleby3Nor5(string input)
        {
            //Act
            var result = _sut.FetchResult(input);
            //Assert
            Assert.Equal($"Divided {input} by 3", result.Results[0]);
            Assert.Equal($"Divided {input} by 5", result.Results[1]);
        }

        [Fact]
        public async void ItShouldReturn_AResult_ForEachInput()
        {
            //Arrange
            var input = new List<string>() {"A","B","1","2"};
            //Act
            var result =  await _sut.FetchResults(input);
            //Assert
            Assert.Equal(4, result.Count);
        }

    }
}
