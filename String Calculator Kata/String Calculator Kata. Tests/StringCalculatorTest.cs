
namespace String_Calculator_Kata._Tests
{
    public class StringCalculatorTest
    {
        private StringCalculator _stringCalculator;

        public StringCalculatorTest()
        {
            _stringCalculator = new StringCalculator();
        }

        [Fact]
        public void Add_EmptyString_ReturnsZero()
        {
            int actual = _stringCalculator.Add("");
            int expected = 0;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Add_OneNumber_ReturnsItself()
        {
            int actual = _stringCalculator.Add("1");
            int expected = 1;

            Assert.Equal(expected, actual);

        }

        [Fact]
        public void Add_TwoNumber_ReturnsSummation()
        {
            int actual = _stringCalculator.Add("1,2");
            int expected = 3;

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("1,1,1", 3)]
        [InlineData("1,2,3", 6)]
        public void Add_MoreThanTwoNumbers_ReturnsSummation(string numbers, int summation)
        {
            int actual = _stringCalculator.Add(numbers);
            int expected = summation;

            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData("1\n1,1", 3)]
        [InlineData("1,2\n3", 6)]
        public void Add_MoreNumbersWithNewLines_ReturnsSummation(string numbers, int summation)
        {
            int actual = _stringCalculator.Add(numbers);
            int expected = summation;

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("//;\n1;2", 3)]
        [InlineData("//;\n1;2;3", 6)]
        public void Add_NumbersWithDifferentDelimiters_ReturnsSummation(string numbers, int summation)
        {
            int actual = _stringCalculator.Add(numbers);
            int expected = summation;

            Assert.Equal(expected, actual);
        }
    }
}