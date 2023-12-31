namespace EvaluationSampleCode.UnitTests
{
    [TestClass]
    public class HtmlFormatHelperTests
    {
        [TestMethod]
        // Arrange
        [DataRow("Hello World", "<b>Hello World</b>")]
        public void GetBoldFormat_ContentString_ReturnsBoldFormattedContentString(string content, string expectedContent)
        {
            // Arrange
            HtmlFormatHelper helper = new();

            // Act
            string result = helper.GetBoldFormat(content);

            // Assert
            Assert.AreEqual(expectedContent, result);
        }

        [TestMethod]
        // Arrange
        [DataRow("Hello World", "<i>Hello World</i>")]
        public void GetItalicFormat_ContentString_ShouldReturnItalicFormattedContentString(string content, string expectedContent)
        {
            // Arrange
            HtmlFormatHelper helper = new();

            // Act
            string result = helper.GetItalicFormat(content);

            // Assert
            Assert.AreEqual(expectedContent, result);
        }

        [TestMethod]
        // Arrange
        [DataRow(new string[] { "Item 1", "Item 2", "Item 3" }, "<ul><li>Item 1</li><li>Item 2</li><li>Item 3</li></ul>")]
        public void GetFormattedListElements_ListOfItems_ShouldReturnsFormattedListOfItems(string[] list, string expectedList)
        {
            // Arrange
            HtmlFormatHelper helper = new();

            // Act
            List<string> listItems = new(list);
            string result = helper.GetFormattedListElements(listItems);

            // Assert
            Assert.AreEqual(expectedList, result);
        }
    }
}