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

        [Theory]
        [InlineData("words", "Nothing")]
        [InlineData("A fast fox.", "Nothing")]
        public void Test0B(string word1, string solution)
        {
            string outcome = prog.ReturnFixedValue(word1);
            bool value = outcome.Equals(solution);
            Assert.True(value, $"output of test is \"{outcome}\" instead of \"{solution}\".");

        }

        [Theory]
        [InlineData("A", "lazy", "frog", "A lazy frog.")]
        [InlineData("A", "fast", "fox", "A fast fox.")]
        public void Test1(string word1, string word2, string word3, string solution)
        {
            string outcome = prog.FormSentenceFromWords(word1, word2, word3);
            bool value = outcome.Equals(solution);
            Assert.True(value, $"output of test is \"{outcome}\" instead of \"{solution}\".");

        }

        [Theory]
        [InlineData("   A", "lazy", " frog", "A lazy frog.")]
        [InlineData("A", "fast ", "   fox", "A fast fox.")]
        [InlineData("A ", "lazy", " bear ", "A lazy bear.")]
        [InlineData("A", "fast ", " fox", "A fast fox.")]
        [InlineData("A speedy", "little ", " mouse", "A speedy little mouse.")]
        [InlineData("A grumpy", "Xbox ", "gamer ", "A grumpy Xbox gamer.")]
        public void Test2(string part1, string part2, string part3, string solution)
        {
            string outcome = prog.FormSentenceFromInputs(part1, part2, part3);
            bool value = outcome.Equals(solution);
            Assert.True(value, $"output of test is \"{outcome}\" instead of \"{solution}\".");
        }

        [Theory]
        [InlineData("A ", "lazy", " frog.", "A lazy frog.")]
        [InlineData("A", " fast ", "fox.", "A fast fox.")]
        [InlineData("A", " lazy ", "bear.", "A lazy bear.")]
        [InlineData("A speedy", " little", " mouse.", "A speedy little mouse.")]
        [InlineData("A grumpy", " Xbox ", "gamer.", "A grumpy Xbox gamer.")]
        public void Test3(string part1, string part2, string part3, string solution)
        {
            string outcome = prog.RepairStringsToFormSentence(part1, part2, part3);
            bool value = outcome.Equals(solution);
            Assert.True(value, $"output of test is \"{outcome}\" instead of \"{solution}\".");
        }

        [Theory]
        [InlineData("A", "lazy", "frog.", "A lazy frog.")]
        [InlineData("A", "fast", "fox.", "A fast fox.")]
        [InlineData("A", "lazy", "bear.", "A lazy bear.")]
        [InlineData("A speedy", "little", "mouse.", "A speedy little mouse.")]
        [InlineData("A grumpy", "Xbox", "gamer.", "A grumpy Xbox gamer.")]
        public void Test4(string part1, string part2, string part3, string solution)
        {
            string outcome = prog.RepairStatementsToFormSentence(part3, part2, part1);
            bool value = outcome.Equals(solution);
            Assert.True(value, $"output of test is \"{outcome}\" instead of \"{solution}\".");
        }

        [Theory]
        [InlineData("A", "lazy", "frog.", "A lazy frog.")]
        [InlineData("A", "fast ", "fox.", "A fast fox.")]
        [InlineData("A", "lazy", "bear.", "A lazy bear.")]
        [InlineData("A speedy", "little", "mouse.", "A speedy little mouse.")]
        [InlineData("A grumpy", "Xbox", "gamer.", "A grumpy Xbox gamer.")]
        public void Test5(string part1, string part2, string part3, string solution)
        {
            string outcome = prog.RepairStatementsToFormSentence2(part3, part1, part2);
            bool value = outcome.Equals(solution);
            Assert.True(value, $"output of test is \"{outcome}\" instead of \"{solution}\".");
        }

        [Theory]
        [InlineData("A", "lazy", "frog.", "  A lazy frog.")]
        [InlineData("A", "fast", "fox.", "A fast   fox.  ")]
        [InlineData("A", "lazy", "bear", "A lazy bear")]
        [InlineData("A", "speedy", "mouse.", "A speedy   mouse.")]
        [InlineData("A", "grumpy", "gamer.", "A grumpy gamer.")]
        public void Test6(string part1, string part2, string part3, string solution)
        {
            string[] result = prog.SplitSentence(solution);
            bool outcome = result[0].Equals(part1) && result[1].Equals(part2) && result[2].Equals(part3);
            Assert.True(outcome, $"expected \"{part1},{part2},{part3}\" but received: \"{result[0]},{result[1]},{result[2]}\"");
        }

    }
}
