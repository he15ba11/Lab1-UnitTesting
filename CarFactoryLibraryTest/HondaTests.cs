using CarFactoryLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactoryLibraryTest
{
    public class HondaTests
    {
        [Fact]
        public void IsStopped_Velocity0_true()
        {
            // Arrange
            Honda honda = new Honda();
            honda.velocity = 0;

            // Act
            bool actualResult = honda.IsStopped();

            // Boolean Assert
            Assert.True(actualResult);
        }

        [Theory]
        [InlineData(20, 10, 2)] 
        [InlineData(30, 15, 2)] 
         public void TimeToCoverDistance_ShouldCalculateCorrectTime(double distance, double hvelocity, double expectedTime)
        {
            // Arrange
            Honda honda = new Honda() { velocity = hvelocity };

            // Act
            double actualTime = honda.TimeToCoverDistance(distance);

            // Numeric Assert
            Assert.Equal(expectedTime, actualTime);
            Assert.InRange(honda.velocity, 10, 25);
        }

        [Fact]
        public void GetDirection_DirectionForward_Forward()
        {
            // Arrange
            Honda honda = new Honda() { drivingMode = DrivingMode.Forward };

            // Act
            string result = honda.GetDirection();

            // String Assert
            Assert.StartsWith("For", result);
            Assert.EndsWith("rd", result);

            Assert.Contains("wa", result);
            Assert.DoesNotContain("zx", result);

            Assert.Matches("F[a-z]{6}", result);
            Assert.DoesNotMatch("F{6}", result);
        }

        [Fact]
        public void GetMyCar_AskForRefrence_Same()
        {
            // Arrange
            Honda honda = new Honda();
            Honda t = new Honda();

            // Act
            Car result = honda.GetMyCar();

            // Reference Assert
            Assert.Same(honda, result);
            Assert.NotSame(t, result);
        }
    }
}
