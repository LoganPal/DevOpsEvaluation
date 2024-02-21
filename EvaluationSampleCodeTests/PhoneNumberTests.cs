using Microsoft.VisualStudio.TestTools.UnitTesting;
using EvaluationSampleCode;
using System;

namespace EvaluationSampleCodeTests
{
    [TestClass]
    public class PhoneNumberTests
    {
        [TestMethod]
        public void Parse_ValidPhoneNumber_ReturnsPhoneNumberObject()
        {
            // Arrange
            var validPhoneNumber = "0123456789";
            var expectedArea = "012";
            var expectedMajor = "345";
            var expectedMinor = "6789";

            // Act
            var phoneNumber = PhoneNumber.Parse(validPhoneNumber);

            // Assert
            Assert.IsNotNull(phoneNumber);
            Assert.AreEqual(expectedArea, phoneNumber.Area);
            Assert.AreEqual(expectedMajor, phoneNumber.Major);
            Assert.AreEqual(expectedMinor, phoneNumber.Minor);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Parse_BlankPhoneNumber_ThrowsArgumentException()
        {
            //Arrange
            var blankPhoneNumber = "";

            //Act
            PhoneNumber.Parse(blankPhoneNumber);

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Parse_IncorrectLengthPhoneNumber_ThrowsArgumentException()
        {
            //Arrange
            var incorrectLengthPhoneNumber = "012345678";

            //Act
            PhoneNumber.Parse(incorrectLengthPhoneNumber);

        }

        [TestMethod]
        public void ToString_ValidPhoneNumber_ReturnsFormattedString()
        {
            // Arrange
            var validPhoneNumber = "0123456789";
            var expectedFormattedString = "(012)345-6789";
            var phoneNumber = PhoneNumber.Parse(validPhoneNumber);

            // Act
            var resultString = phoneNumber.ToString();

            // Assert
            Assert.AreEqual(expectedFormattedString, resultString);
        }
    }
}
