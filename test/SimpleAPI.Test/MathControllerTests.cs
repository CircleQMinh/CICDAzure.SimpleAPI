using SimpleAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAPI.Test
{
    public class MathControllerTests
    {
        MathController controller = new MathController();
        [Fact]
        public void MathController_AddTwoNumber_ValidInput()
        {
            //arrange
            int numberOne = 4;
            int numberTwo = 5;
            //act
            var result = controller.AddTwoNumber(numberOne, numberTwo).Value;
            //assert
            Assert.Equal(9,result);
        }

        [Fact]
        public void MathController_SubtractTwoNumber_ValidInput()
        {
            //arrange
            int numberOne = 9;
            int numberTwo = 5;
            //act
            var result = controller.SubtractTwoNumber(numberOne, numberTwo).Value;
            //assert
            Assert.Equal(4, result);
        }
    }
}
