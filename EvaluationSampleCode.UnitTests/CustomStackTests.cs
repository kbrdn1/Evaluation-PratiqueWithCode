namespace EvaluationSampleCode.UnitTests
{
    [TestClass]
    public class CustomStackTests
    {
        [TestMethod]
        public void Count_EmptyStack_ReturnsZero()
        {
            // Arrange
            CustomStack stack = new();

            // Act
            int count = stack.Count();

            // Assert
            Assert.AreEqual(0, count);
        }

        [TestMethod]
        [DataRow(10, 1)]
        public void Push_AddsValueToStack(int value, int expectedCount)
        {
            // Arrange
            CustomStack stack = new();

            // Act
            stack.Push(value);

            // Assert
            Assert.AreEqual(expectedCount, stack.Count());
        }

        [TestMethod]
        public void Pop_EmptyStack_ThrowsException()
        {
            // Arrange
            CustomStack stack = new();

            // Act & Assert
            Assert.ThrowsException<CustomStack.StackCantBeEmptyException>(() => stack.Pop());
        }

        [TestMethod]
        [DataRow(10, 20, 30, 2)]
        public void Pop_NonEmptyStack_ReturnsLastValueAndRemovesIt(int firstValue, int secondValue, int thirdValue, int expectedCount)
        {
            // Arrange
            CustomStack stack = new();
            stack.Push(firstValue);
            stack.Push(secondValue);
            stack.Push(thirdValue);

            // Act
            int value = stack.Pop();

            // Assert
            Assert.AreEqual(thirdValue, value);
            Assert.AreEqual(expectedCount, stack.Count());
        }
    }
}