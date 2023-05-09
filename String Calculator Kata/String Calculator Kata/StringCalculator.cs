namespace String_Calculator_Kata._Tests
{
    public class StringCalculator
    {
        public StringCalculator()
        {
        }

        public int Add(string numbers)
        {
            if(numbers.CompareTo("") == 0)
                return 0;

            bool isNumeric = int.TryParse(numbers, out int n);
            if (isNumeric) { return n; }

            throw new NotImplementedException();
        }
    }
}