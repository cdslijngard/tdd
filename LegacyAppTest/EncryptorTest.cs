using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LegacyApp;

namespace LegacyAppTest
{
    [TestClass]
    public class EncryptorTest
    {
        [TestCategory("EncryptorTests"), TestMethod()]
        public void GetWords_HappyCase()
        {
            // Arrange
            String sentence = "this is a sentence";
            Encryptor encryptor = new Encryptor();

            // Act
            String[] words = encryptor.GetWords(sentence);

            // Assert
            Assert.IsNotNull(words);
            Assert.IsTrue(words.Length == 4);
        }

        [TestCategory("EncryptorTests"), TestMethod()]
        public void CryptSentence_HappyCase()
        {
            // Arrange
            String sentence = "abcdefg";
            Encryptor encryptor = new Encryptor();

            // Act
            String words = encryptor.CryptSentence(sentence);

            // Assert
            Assert.IsNotNull(words);
            Assert.AreEqual("cdefghi", words);
        }

        [TestCategory("EncryptorTests"), TestMethod()]
        public void CryptWord_HappyCase()
        {
            // Arrange
            String sentence = "abcdefg";
            Encryptor encryptor = new Encryptor();

            // Act
            String words = encryptor.CryptWord(sentence);

            // Assert
            Assert.IsNotNull(words);
            Assert.AreEqual("cdefghi", words);
        }

        [TestCategory("EncryptorTests"), TestMethod()]
        public void CryptWord_Overload_HappyCase()
        {
            // Arrange
            String sentence = "abcdefg";
            Encryptor encryptor = new Encryptor();

            // Act
            String words = encryptor.CryptWord(sentence, "abc");

            // Assert
            Assert.IsNotNull(words);
            Assert.AreEqual("System.Char[]", words);
        }

        [TestCategory("EncryptorTests"), TestMethod()]
        public void CryptWord_SadCase()
        {
            // Arrange
            String sentence = "abcde fg";
            Encryptor encryptor = new Encryptor();

            // Assert
            Assert.ThrowsException<ArgumentException>(() => encryptor.CryptWord(sentence));
        }

        [TestCategory("EncryptorTests"), TestMethod()]
        public void CryptWordToNumbers_HappyCase()
        {
            // Arrange
            String sentence = "kekistan";
            Encryptor encryptor = new Encryptor();

            // Act
            string cryptSentence = encryptor.CryptWordToNumbers(sentence);

            // Assert
            Assert.IsNotNull(cryptSentence);
            Assert.AreEqual("10910310910711711899112", cryptSentence);
        }

        [TestCategory("EncryptorTests"), TestMethod()]
        public void PrintWords_HappyCase() {
            // Arrange
            String sentence = "kekistan";
            Encryptor encryptor = new Encryptor();

            // Act
            encryptor.PrintWords(sentence);

            // Assert
            Assert.

        }

    }
}
