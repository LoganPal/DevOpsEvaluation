using Microsoft.VisualStudio.TestTools.UnitTesting;
using EvaluationSampleCode;
using System.Collections.Generic;

namespace EvaluationSampleCodeTests
{
    [TestClass]
    public class HtmlFormatHelperTests
    {
        private HtmlFormatHelper _htmlFormatHelper;

        [TestInitialize]
        public void Setup()
        {
            _htmlFormatHelper = new HtmlFormatHelper();
        }

        [TestMethod]
        public void GetStrongFormat_GivenContent_ReturnsContentInStrongTags()
        {
            // Arrange
            var content = "test";
            var expected = "<strong>test</strong>";

            // Act
            var result = _htmlFormatHelper.GetStrongFormat(content);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetItalicFormat_GivenContent_ReturnsContentInItalicTags()
        {
            // Arrange
            var content = "test";
            var expected = "<i>test</i>";

            // Act
            var result = _htmlFormatHelper.GetItalicFormat(content);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetFormattedListElements_GivenListOfStrings_ReturnsStringsInListFormat()
        {
            // Arrange
            List<string> contents = new List<string> { "Item 1", "Item 2", "Item 3" };
            var expected = "<ul><li>Item 1</li><li>Item 2</li><li>Item 3</li></ul>";

            // Act
            var result = _htmlFormatHelper.GetFormattedListElements(contents);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}
