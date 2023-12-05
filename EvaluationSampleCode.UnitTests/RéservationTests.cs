using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EvaluationSampleCode.UnitTests
{
    [TestClass]
    public class ReservationTests
    {
        [TestMethod]
        public void CanBeCancelledBy_UserIsAdmin_ReturnsTrue()
        {
            // Arrange
            var user = new User { IsAdmin = true };
            var reservation = new Reservation(user);

            // Act
            var result = reservation.CanBeCancelledBy(user);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanBeCancelledBy_UserIsMadeBy_ReturnsTrue()
        {
            // Arrange
            var user = new User();
            var reservation = new Reservation(user);

            // Act
            var result = reservation.CanBeCancelledBy(user);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanBeCancelledBy_UserIsNotAdminAndNotMadeBy_ReturnsFalse()
        {
            // Arrange
            var user = new User();
            var otherUser = new User();
            var reservation = new Reservation(otherUser);

            // Act
            var result = reservation.CanBeCancelledBy(user);

            // Assert
            Assert.IsFalse(result);
        }
    }
}