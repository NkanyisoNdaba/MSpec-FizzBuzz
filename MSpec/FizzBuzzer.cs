namespace MSpec
{
    public class FizzBuzzer
    {
        public string FizzBuzz(int number)
        {
            if (DivisibleBy3(number) && DivisibleBy5(number))
            {
                return "FizzBuzz";
            }

            if (DivisibleBy3(number))
            {
                return "Fizz";
            }

            if (DivisibleBy5(number))
            {
                return "Buzz";
            }

            return number.ToString();
        }

        private static bool DivisibleBy3(int number)
        {
            return number % 3 == 0;
        }

        private static bool DivisibleBy5(int number)
        {
            return number % 5 == 0;
        }
    }
}
