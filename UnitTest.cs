using Xunit;

namespace Exercise.Tests
{
    public class UnitTest1
    {
        private Exercise.Writer prog;
        public UnitTest1()
        {
            prog = new Writer();
        }

        [Theory]
        [InlineData("A", "A")]
        [InlineData("A ", "A ")]
        [InlineData("A magic little string.", "A magic little string.")]
        public void Test0(string word1, string solution)
        {
            string outcome = prog.FeedbackWhatYouGet(word1);
            bool value = outcome.Equals(solution);
            Assert.True(value, $"output of test is \"{outcome}\" instead of \"{solution}\".");

        }


    }
}
