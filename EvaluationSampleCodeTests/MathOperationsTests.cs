using EvaluationSampleCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationSampleCodeTests
{
    [TestClass]
    public class MathOperationsTests
    {
        private MathOperations _mathOperations;

        [TestInitialize]
        public void Init() 
        {
            _mathOperations = new MathOperations();
        }

        [TestMethod]
        [DataRow(10, 2, 8)]
        [DataRow(30, 30, 0)]
        [DataRow(15, 12, 3)]
        public void Substract_WithCorrectExpectation_returnExpectedResult(int numberOne, int numberTwo, int expectedResult)
        {
            var actualResult = _mathOperations.Subtract(numberOne, numberTwo);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        [DataRow(56, 4, 44)] 
        [DataRow(24, 7, 63)] 
        [DataRow(54, 12, 9)] 
        public void Subtract_WithNotCorrectExpectation_returnExpectedResult(int numberOne, int numberTwo, int wrongExpectedResult)
        {
            var actualResult = _mathOperations.Subtract(numberOne, numberTwo);

            Assert.AreNotEqual(wrongExpectedResult, actualResult); 
        }

        [TestMethod]
        [DataRow(24, 87, true)] 
        [DataRow(100, 150, true)] 
        public void Subtract_SecondNumberShouldBeGreater(int numberOne, int numberTwo, bool expectedResult)
        {
            var secondNumberGreater = numberTwo > numberOne;

            Assert.AreEqual(expectedResult, secondNumberGreater);
        }
        [TestMethod]
        public void GetColorFromOddsNumber_ReturnsRed_WhenNumberIsEven()
        {
            var number = 2; //Nombre Pair
            var expected = "Red";

            var result = _mathOperations.GetColorFromOddsNumber(number);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetColorFromOddsNumber_ReturnsBlue_WhenNumberIsOdd()
        {
            var number = 3; //Nombre Impair
            var expected = "Blue";

            var result = _mathOperations.GetColorFromOddsNumber(number);

            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Limit argument can't be negative")]
        public void GetColorFromOddsNumber_ThrowsArgumentException_WhenNumberIsNegative()
        {
            var number = -1; //Nombre Négatif
        
            _mathOperations.GetColorFromOddsNumber(number);

        }
    }
}
