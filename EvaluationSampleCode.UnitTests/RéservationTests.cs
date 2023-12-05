namespace EvaluationSampleCode.UnitTests
{
    [TestClass]
    public class ReservationTests
    {
        [TestMethod]
        public void CanBeCancelledBy_UserIsAdmin_ReturnsTrue()
        {
            // Arrange
            User user = new() { IsAdmin = true };
            Reservation reservation = new(user);

            // Act
            var result = reservation.CanBeCancelledBy(user);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanBeCancelledBy_UserIsMadeBy_ReturnsTrue()
        {
            // Arrange
            User user = new();
            Reservation reservation = new(user);

            // Act
            var result = reservation.CanBeCancelledBy(user);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanBeCancelledBy_UserIsNotAdminAndNotMadeBy_ReturnsFalse()
        {
            // Arrange
            User user = new();
            User otherUser = new();
            Reservation reservation = new(otherUser);

            // Act
            var result = reservation.CanBeCancelledBy(user);

            // Assert
            Assert.IsFalse(result);
        }
    }
}