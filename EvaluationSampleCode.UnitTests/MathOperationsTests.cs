namespace EvaluationSampleCode.UnitTests
{
    [TestClass]
    public class MathOperationsTests
    {
        [TestMethod]
        // Arrange
        [DataRow(5, 10, 15)]
        public void Add_NumberOneSumByNumberTwo_ReturnsCorrectResult(int numberOne, int numberTwo, int expectedSum)
        {
            // Arrange
            MathOperations mathOperations = new();

            // Act
            int actualSum = mathOperations.Add(numberOne, numberTwo);

            // Assert
            Assert.AreEqual(expectedSum, actualSum);
        }

        [TestMethod]
        // Arrange
        [DataRow(5, 10, 0.5f)]
        public void Divide_NumberOneDivideByNumberTwo_ReturnsCorrectResult(int numberOne, int numberTwo, float expectedQuotient)
        {
            // Arrange
            MathOperations mathOperations = new();

            // Act
            float actualQuotient = mathOperations.Divide(numberOne, numberTwo);

            // Assert
            Assert.AreEqual(expectedQuotient, actualQuotient);
        }

        [TestMethod]
        // Arrange
        [DataRow(10)]
        public void Divide_NumberDivideBy0_ReturnsArgumentException(int number)
        {
            // Arrange
            MathOperations mathOperations = new();

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => mathOperations.Divide(number, 0));
        }

        [TestMethod]
        // Arrange
        [DataRow(10, new int[] { 1, 3, 5, 7, 9 })]
        public void GetOddNumbers_LimitIs10_ReturnsCorrectOddNumbers(int limit, int[] expectedOddNumbers)
        {
            // Arrange
            MathOperations mathOperations = new();

            // Act
            var actualOddNumbers = mathOperations.GetOddNumbers(limit);

            // Assert
            CollectionAssert.AreEqual(expectedOddNumbers, actualOddNumbers.ToList());
        }

        [TestMethod]
        // Arrange
        [DataRow(-10)]
        public void GetOddNumbers_LimitIsNegative_ReturnsArgumentException(int limit)
        {
            // Arrange
            MathOperations mathOperations = new();

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => mathOperations.GetOddNumbers(limit));
        }
    }
}