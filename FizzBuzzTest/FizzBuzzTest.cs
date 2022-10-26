using FizzBuzz;
using Moq;
using Xunit;

namespace FizzBuzzTest
{
    public class FizzBuzzTest
    {
        [Fact]
        public void Should_return_number_when_count_off_given_normal_number()
        {
            //Given
            FizzBuzzCount test = new FizzBuzzCount();
            int number = 1;

            //when
            string result = test.CountOff(number);

            //then
            Assert.Equal("1", result);
        }
    }
}