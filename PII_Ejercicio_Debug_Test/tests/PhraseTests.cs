using NUnit.Framework;

namespace WordsPhrases.Tests
{
    public class PhraseTests
    {
        [Test]
        public void TestAddRemoveWord()
        {
            Phrase phrase = new Phrase();
            Word word = new Word("Test");
            phrase.AddWord(word);
            phrase.RemoveWord(word);
        }

        [Test]
        public void TestGetPhrase()
        {
            const string text1 = "text1";
            const string text2 = "text2";
            const string expected = "text1 text2";
            Phrase phrase = new Phrase();
            Word word1 = new Word(text1);
            Word word2 = new Word(text2);
            phrase.AddWord(word1);
            phrase.AddWord(word2);
            string actual = phrase.GetPhrase();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestSpaces()
        {
            const string text1 = " text1 ";
            const string text2 = " text2 ";
            const string expected = "text1 text2";
            Phrase phrase = new Phrase();
            Word word1 = new Word(text1);
            Word word2 = new Word(text2);
            phrase.AddWord(word1);
            phrase.AddWord(word2);
            string actual = phrase.GetPhrase();
            Assert.AreEqual(expected, actual);
        }
    }
}