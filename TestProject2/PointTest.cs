using WpfApp1;
namespace TestProject2
{
    [TestClass]
    public class PointTests
    {
        [TestMethod]
        public void Move_UpdatesCoordinatesCorrectly()
        {
            // Arrange
            Point point = new Point(2, 3);

            // Act
            point.Move(5, -2);

            // Assert
            Assert.AreEqual(7, point.X);
            Assert.AreEqual(1, point.Y);
        }

        [TestMethod]
        public void Move_ZeroDelta_NoChangeInCoordinates()
        {
            // Arrange
            Point point = new Point(2, 3);

            // Act
            point.Move(0, 0);

            // Assert
            Assert.AreEqual(2, point.X);
            Assert.AreEqual(3, point.Y);
        }


    }
}