using aquesstQuestions;

namespace aquesstQuestionsTests
{
    public class QuestionOneTests
    {
        [Fact]
        public void SeventeenAndFour_ReturnsFourEightTwelveSixteen()
        {
            var questions = new QuestionOne();
            var expectedAnswer = new List<int> { 4, 8, 12, 16 };

            var answer = questions.GetEvenAndDivisibleList(17, 4);

            Assert.Equal(expectedAnswer, answer);
        }

        [Fact]
        public void TwentyOneAndSeven_ReturnsFourteen()
        {
            var questions = new QuestionOne();
            var expectedAnswer = new List<int> { 14 };

            var answer = questions.GetEvenAndDivisibleList(21, 7);

            Assert.Equal(expectedAnswer, answer);
        }

        [Fact]
        public void FiveAndTwenty_ReturnsTenTwenty()
        {
            var questions = new QuestionOne();
            var expectedAnswer = new List<int> { 10, 20 };

            var answer = questions.GetEvenAndDivisibleList(5, 20);

            Assert.Equal(expectedAnswer, answer);
        }

        [Fact]
        public void ThreeAndTen_ReturnsSix()
        {
            var questions = new QuestionOne();
            var expectedAnswer = new List<int> { 6 };

            var answer = questions.GetEvenAndDivisibleList(3, 10);

            Assert.Equal(expectedAnswer, answer);
        }

        [Fact]
        public void TwoAndTwo_ReturnsTwo()
        {
            var questions = new QuestionOne();
            var expectedAnswer = new List<int> { 2 };

            var answer = questions.GetEvenAndDivisibleList(2, 2);

            Assert.Equal(expectedAnswer, answer);
        }

        [Fact]
        public void OneAndOne_ReturnsNothing()
        {
            var questions = new QuestionOne();
            var expectedAnswer = new List<int> {  };

            var answer = questions.GetEvenAndDivisibleList(1, 1);

            Assert.Equal(expectedAnswer, answer);
        }
    }
}