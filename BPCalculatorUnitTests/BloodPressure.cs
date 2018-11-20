using BPCalculator;
using BPCalculator.Pages;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BPCalculatorUnitTests
{
    [TestClass]
    public class BloodPressureTests
    {
        [TestMethod]
        public void BPCategory_UserHasHighBloodPressure_ReturnsTrue()
        {
            //Triple 'A' Method of Test
            //Arrange and Add
            BloodPressure bloodPressure = new BloodPressure() { Systolic = 160, Diastolic = 94 };
            BPCategory bloodPressureCategory = bloodPressure.Category;
            //Assert
            Assert.AreEqual(BPCategory.High, bloodPressureCategory);
        }
        [TestMethod]
        public void BPCategory_UserHasHighBloodPressure_ReturnsFalse()
        {
            //Triple 'A' Method of Test
            //Arrange and Add
            BloodPressure bloodPressure = new BloodPressure() { Systolic = 80, Diastolic = 58 };
            BPCategory bloodPressureCategory = bloodPressure.Category;
            //Assert
            Assert.AreNotEqual(BPCategory.High, bloodPressureCategory);
        }
        [TestMethod]
        public void BPCategory_UserHasPreHighBloodPressure_ReturnsTrue()
        {
            //Triple 'A' Method of Test
            //Arrange and Add
            BloodPressure bloodPressure = new BloodPressure() { Systolic = 122, Diastolic = 87 };
            BPCategory bloodPressureCategory = bloodPressure.Category;
            //Assert
            Assert.AreEqual(BPCategory.PreHigh, bloodPressureCategory);
        }
        [TestMethod]
        public void BPCategory_UserHasPreHighBloodPressure_ReturnsFalse()
        {
            //Triple 'A' Method of Test
            //Arrange and Add
            BloodPressure bloodPressure = new BloodPressure() { Systolic = 100, Diastolic = 75 };
            BPCategory bloodPressureCategory = bloodPressure.Category;
            //Assert
            Assert.AreNotEqual(BPCategory.PreHigh, bloodPressureCategory);
        }
        [TestMethod]
        public void BPCategory_UserHasNormalBloodPressure_ReturnsTrue()
        {
            //Triple 'A' Method of Test
            //Arrange and Add
            BloodPressure bloodPressure = new BloodPressure() { Systolic = 106, Diastolic = 73 };
            BPCategory bloodPressureCategory = bloodPressure.Category;
            //Assert
            Assert.AreEqual(BPCategory.Normal, bloodPressureCategory);
        }
        [TestMethod]
        public void BPCategory_UserHasNormalBloodPressure_ReturnsFalse()
        {
            //Triple 'A' Method of Test
            //Arrange and Add
            BloodPressure bloodPressure = new BloodPressure() { Systolic = 150, Diastolic = 84 };
            BPCategory bloodPressureCategory = bloodPressure.Category;
            //Assert
            Assert.AreNotEqual(BPCategory.Normal, bloodPressureCategory);
        }
        [TestMethod]
        public void BPCategory_UserHasLowBloodPressure_ReturnsTrue()
        {
            //Triple 'A' Method of Test
            //Arrange and Add
            BloodPressure bloodPressure = new BloodPressure() { Systolic = 76, Diastolic = 58 };
            BPCategory bloodPressureCategory = bloodPressure.Category;
            //Assert
            Assert.AreEqual(BPCategory.Low, bloodPressureCategory);
        }
        [TestMethod]
        public void BPCategory_UserHasLowBloodPressure_ReturnsFalse()
        {
            //Triple 'A' Method of Test
            //Arrange and Add
            BloodPressure bloodPressure = new BloodPressure() { Systolic = 110, Diastolic = 75 };
            BPCategory bloodPressureCategory = bloodPressure.Category;
            //Assert
            Assert.AreNotEqual(BPCategory.Low, bloodPressureCategory);
        }
        [TestMethod]
        public void BPCategory_UserHasUnknownBloodPressure_ReturnsTrue()
        {
            //Triple 'A' Method of Test
            //Arrange and Add
            BloodPressure bloodPressure = new BloodPressure() { Systolic = 86, Diastolic = 85 };
            BPCategory bloodPressureCategory = bloodPressure.Category;
            //Assert
            Assert.AreEqual(BPCategory.Unknown, bloodPressureCategory);
        }
        [TestMethod]
        public void BPCategory_IncorrectSystolicValue_ReturnsFalse()
        {
            //Triple 'A' Method of Test
            //Arrange and Add
            BloodPressure bloodPressure = new BloodPressure() { Systolic = 87, Diastolic = 200 };
            BPCategory bloodPressureCategory = bloodPressure.Category;
            //TODO How to handle incorrect Values
            Assert.IsTrue(true);
        }
    }
}
