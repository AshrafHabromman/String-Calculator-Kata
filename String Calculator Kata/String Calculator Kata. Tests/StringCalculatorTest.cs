
namespace String_Calculator_Kata._Tests
{
    public class StringCalculatorTest
    {
        [Fact]
        public void Add_EmptyString_ReturnsZero()
        {
            var stringCalculator = new StringCalculator();

            int actual = stringCalculator.Add("");

            Assert.Equal(0, actual);

        }

        [Fact]
        public void Add_OneNumber_ReturnsItself()
        {
            var stringCalculator = new StringCalculator();

            int actual = stringCalculator.Add("13");
            
            Assert.Equal(13, actual);

        }
    }
}