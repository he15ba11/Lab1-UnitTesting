using CarFactoryLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactoryLibraryTest
{
    public class CarFactoryTests
    {
        [Fact]
        public void NewCar_AskForHonda_null()
        {
            // Arrange

            // Act
            Car? result = CarFactory.NewCar(CarTypes.Honda);

            // Reference Asssert
            Assert.Null(result);
        }
        [Fact]
        public void NewCar_AskForHonda_HondaObject()
        {
            // Arrange

            // Act
            Car? result = CarFactory.NewCar(CarTypes.Honda);

            // Type Assert
            Assert.IsType<Honda>(result);
            Assert.IsNotType<Honda>(result);

            Assert.IsAssignableFrom<Car>(result);
        }

        [Fact]
        public void NewCar_AskForHonda_Exception()
        {

            // Exception Assert
            Assert.Throws<NotImplementedException>(() =>
            {
                // Act
                Car? result = CarFactory.NewCar(CarTypes.KIA);
            });
            Assert.ThrowsAny<Exception>(() =>
            {
                // Act
                Car? result = CarFactory.NewCar(CarTypes.KIA);
            });

        }
    }
}
