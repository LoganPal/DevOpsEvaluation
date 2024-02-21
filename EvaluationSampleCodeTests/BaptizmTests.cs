using Microsoft.VisualStudio.TestTools.UnitTesting;
using EvaluationSampleCode;

namespace EvaluationSampleCodeTests
{
    [TestClass]
    public class BaptizmTests
    {
        [TestMethod]
        public void CanBeBaptizedBy_WithPriest_ReturnsTrue()
        {
            // Arrange
            var priest = new ClergyMember { IsPriest = true };
            var baptizm = new Baptizm(priest);

            // Act
            var result = baptizm.CanBeBaptizedBy(priest);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanBeBaptizedBy_WithPope_ReturnsTrue()
        {
            // Arrange
            var pope = new ClergyMember { IsPope = true };
            var baptizm = new Baptizm(pope);

            // Act
            var result = baptizm.CanBeBaptizedBy(pope);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanBeBaptizedBy_WithNonClergyMember_ReturnsFalse()
        {
            // Arrange
            var nonClergyMember = new ClergyMember { IsPriest = false, IsPope = false };
            var baptizm = new Baptizm(nonClergyMember);

            // Act
            var result = baptizm.CanBeBaptizedBy(nonClergyMember);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CanBeTeachedBy_WithSameClergyMember_ReturnsTrue()
        {
            // Arrange
            var clergyMember = new ClergyMember { IsPriest = true };
            var baptizm = new Baptizm(clergyMember);

            // Act
            var result = baptizm.CanBeTeachedBy(clergyMember);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanBeTeachedBy_WithDifferentClergyMember_ReturnsFalse()
        {
            // Arrange
            var clergyMember = new ClergyMember { IsPriest = true };
            var differentClergyMember = new ClergyMember { IsPriest = true };
            var baptizm = new Baptizm(clergyMember);

            // Act
            var result = baptizm.CanBeTeachedBy(differentClergyMember);

            // Assert
            Assert.IsFalse(result);
        }
    }
}
