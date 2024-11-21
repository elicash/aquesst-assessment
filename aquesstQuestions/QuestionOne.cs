namespace aquesstQuestions
{
    public class QuestionOne
    {

        public List<int> GetEvenAndDivisibleList(float num1, float num2)
        {
            var numbers = new List<int>();
            var low = num1 > num2 ? num2 : num1;
            var high = num1 > num2 ? num1 : num2;

            var start = 2;
            while (start <= high)
            {
                var dividedNumber = start / low;
                var isEvenlyDivisible = dividedNumber % 1 == 0;

                if (isEvenlyDivisible)
                {
                    numbers.Add(start);
                }

                start = start + 2;
            }

            return numbers;
        }
    }
}
