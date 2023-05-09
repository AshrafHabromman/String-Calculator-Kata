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


            var seqNumbers = SplitString(numbers); 
            int summation = 0;
            int maxValueAllowed = 1000; 
            string negativeNumbers = "";

            foreach (var number in seqNumbers)
            {
                bool canParse = int.TryParse(number, out int intNumber);
                if (!canParse) continue;

                if (intNumber < 0) {
                    negativeNumbers += number+" ";
                }

                if (intNumber > maxValueAllowed) continue;

                summation += intNumber;
            }

            if (negativeNumbers.CompareTo("") != 0)
            {
                throw new ArgumentException($"Negatives not allowed: {negativeNumbers}");
            }

            return summation;
        }

        private string[] SplitString(string numbers, string delimiter = ",")
        {

            if (numbers.StartsWith("//"))
            {
                delimiter = numbers.Substring(2, 1);
                numbers = numbers.Substring(3);
            }
            numbers = numbers.Replace("\n", delimiter);

            return numbers.Split(delimiter);
        }
    }
}