using Xunit;

namespace FizzBuzzer.Lib.Tests
{
    public class FizzBuzzerTests
    {
        [Theory]
        [InlineData(1)]
        [InlineData(2)] 
        [InlineData(4)] 
        [InlineData(7)] 
        [InlineData(8)] 
        [InlineData(11)] 
        [InlineData(13)] 
        [InlineData(14)] 
        [InlineData(16)] 
        public void FizzBuzz_WhenInput_ReturnsInput(int input)
        {
            var output = FizzBuzzer.GetValue(input);
            Assert.Equal(output, input.ToString());
        }

        [Theory] 
        [InlineData(3)]
        [InlineData(6)]
        [InlineData(9)]
        [InlineData(12)]
        [InlineData(18)]
        public void FizzBuzz_WhenDiv3_ReturnsFizzr(int input)
        {
            var output = FizzBuzzer.GetValue(input);
            Assert.Equal(output, "Fizz");
        }

        [Theory]
        [InlineData(5)] 
        [InlineData(10)] 
        [InlineData(20)] 
        [InlineData(35)] 
        public void FizzBuzz_WhenDiv5_ReturnsBuzzr(int input)
        {
            var output = FizzBuzzer.GetValue(input);
            Assert.Equal(output, "Buzz");
        }
        
        [Theory]
        [InlineData(15)]
        [InlineData(30)]
        [InlineData(45)]
        public void FizzBuzz_WhenDiv3And5_ReturnsFizzBuzz(int input)
        {
            var output = FizzBuzzer.GetValue(input);
            Assert.Equal(output, "FizzBuzz");
        }
    }
}