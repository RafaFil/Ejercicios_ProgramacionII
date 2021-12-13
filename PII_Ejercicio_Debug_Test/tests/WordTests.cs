using NUnit.Framework;

namespace WordsPhrases.Tests
{
    [TestFixture]
    public class WordTests
    {
        [Test]
        public void TestWord()
        {
            const string expected = "Test";
            Word word = new Word(expected);
            Assert.AreEqual(expected, word.Text);
        }

        [Test]
        public void TestText()
        {
            const string expected = "Test";
            Word word = new Word("Other");
            word.Text = expected;
            Assert.AreEqual(expected, word.Text);
        }

        [Test]
        public void TestSpaces()
        {
            const string expected = "Test";
            string test = $" {expected} ";
            Word word = new Word(test);
            Assert.AreEqual(expected, word.Text);
        }
    }
}
