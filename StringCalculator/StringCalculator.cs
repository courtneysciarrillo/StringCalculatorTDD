namespace StringCalculator
{
    public class StringCalculator
    {
        public int Add(string input)
        {
            if (input == string.Empty)
                return 0;

            if (input.Contains(","))
            {
                return CommaSeparatedValuesSum(input);
            }

            return int.Parse(input);
        }

        private static int CommaSeparatedValuesSum(string input)
        {
            var numberStrings = input.Split(',');

            var total = 0;
            foreach (var number in numberStrings)
            {
                total = total + int.Parse(number);
            }
            return total;
        }
    }
}
