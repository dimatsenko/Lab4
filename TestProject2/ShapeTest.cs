using Microsoft.VisualStudio.TestPlatform.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1;

namespace TestProject2
{
    [TestClass]
    public class ShapeTests
    {
       
            [TestMethod]
            public void Resize_IncreasesSideLength()
            {
                // Arrange
                Quadrilateral quadrilateral = new Quadrilateral(0, 0, 5);

                // Act
                quadrilateral.Resize(2);

                // Assert
                Assert.AreEqual(10, quadrilateral.SideLength);
            }

            [TestMethod]
            public void Resize_DecreasesSideLength()
            {
                // Arrange
                Quadrilateral quadrilateral = new Quadrilateral(0, 0, 6);

                // Act
                quadrilateral.Resize(0.5);

                // Assert
                Assert.AreEqual(3, quadrilateral.SideLength);
            }

            [TestMethod]
            public void Rotate_UpdatesRotationAngle()
            {
                // Arrange
                Quadrilateral quadrilateral = new Quadrilateral(0, 0, 5);

                // Act
                quadrilateral.Rotate(90);

                // Assert
                Assert.AreEqual(90, quadrilateral.RotationAngle);
            }

        public void Quadrilateral_Draw_ReturnsExpectedString()
        {
            // Arrange
            Quadrilateral quadrilateral = new Quadrilateral(0, 0, 5);

            // Act
            string result = CaptureConsoleOutput(() => quadrilateral.Draw());

            // Assert
            Assert.AreEqual("Drawing a quadrilateral.", result);
        }

        [TestMethod]
        public void Pentagon_Resize_IncreasesSideLength()
        {
            // Arrange
            Pentagon pentagon = new Pentagon(0, 0, 5);

            // Act
            pentagon.Resize(2);

            // Assert
            Assert.AreEqual(10, pentagon.SideLength);
        }

        [TestMethod]
        public void Pentagon_Resize_DecreasesSideLength()
        {
            // Arrange
            Pentagon pentagon = new Pentagon(0, 0, 6);

            // Act
            pentagon.Resize(0.5);

            // Assert
            Assert.AreEqual(3, pentagon.SideLength);
        }

        [TestMethod]
        public void Pentagon_Rotate_UpdatesRotationAngle()
        {
            // Arrange
            Pentagon pentagon = new Pentagon(0, 0, 5);

            // Act
            pentagon.Rotate(90);

            // Assert
            Assert.AreEqual(90, pentagon.RotationAngle);
        }

        [TestMethod]
        public void Pentagon_Draw_ReturnsExpectedString()
        {
            // Arrange
            Pentagon pentagon = new Pentagon(0, 0, 5);

            // Act
            string result = CaptureConsoleOutput(() => pentagon.Draw());

            // Assert
            Assert.AreEqual("Drawing a pentagon.", result);
        }

        [TestMethod]
        public void Hexagon_Resize_IncreasesSideLength()
        {
            // Arrange
            Hexagon hexagon = new Hexagon(0, 0, 5);

            // Act
            hexagon.Resize(2);

            // Assert
            Assert.AreEqual(10, hexagon.SideLength);
        }

        [TestMethod]
        public void Hexagon_Resize_DecreasesSideLength()
        {
            // Arrange
            Hexagon hexagon = new Hexagon(0, 0, 6);

            // Act
            hexagon.Resize(0.5);

            // Assert
            Assert.AreEqual(3, hexagon.SideLength);
        }

        [TestMethod]
        public void Hexagon_Rotate_UpdatesRotationAngle()
        {
            // Arrange
            Hexagon hexagon = new Hexagon(0, 0, 5);

            // Act
            hexagon.Rotate(90);

            // Assert
            Assert.AreEqual(90, hexagon.RotationAngle);
        }

        [TestMethod]
        public void Hexagon_Draw_ReturnsExpectedString()
        {
            // Arrange
            Hexagon hexagon = new Hexagon(0, 0, 5);

            // Act
            string result = CaptureConsoleOutput(() => hexagon.Draw());

            // Assert
            Assert.AreEqual("Drawing a hexagon.", result);
        }

        // Helper method to capture console output during the test
        private string CaptureConsoleOutput(Action action)
        {
            // Save the current console output
            TextWriter originalConsoleOut = Console.Out;
            StringWriter stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            try
            {
                // Perform the action that writes to the console
                action.Invoke();
                // Return the captured output as a string
                return stringWriter.ToString().Trim();
            }
            finally
            {
                // Restore the original console output
                Console.SetOut(originalConsoleOut);
                stringWriter.Dispose();
            }
        }
    }


}
