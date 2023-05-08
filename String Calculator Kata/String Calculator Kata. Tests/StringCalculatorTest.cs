
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
    }
}