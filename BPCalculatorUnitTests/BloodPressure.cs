using BPCalculator;
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
        public void TestAgeRanges_Baby_ReturnsTrue()
        {
            //Triple 'A' Method of Test
            //Arrange and Add
            BloodPressure bloodPressure = new BloodPressure();
            string result = bloodPressure.getAgeRange(1);
            Assert.AreEqual(result, "baby");
        }
        [TestMethod]
        public void TestAgeRanges_Toddler_ReturnsTrue()
        {
            //Triple 'A' Method of Test
            //Arrange and Add
            BloodPressure bloodPressure = new BloodPressure();
            string result = bloodPressure.getAgeRange(3);
            Assert.AreEqual(result, "toddler");
        }
        [TestMethod]
        public void TestAgeRanges_Child_ReturnsTrue()
        {
            //Triple 'A' Method of Test
            //Arrange and Add
            BloodPressure bloodPressure = new BloodPressure();
            string result = bloodPressure.getAgeRange(7);
            Assert.AreEqual(result, "child");
        }
        [TestMethod]
        public void TestAgeRanges_Teen_ReturnsTrue()
        {
            //Triple 'A' Method of Test
            //Arrange and Add
            BloodPressure bloodPressure = new BloodPressure();
            string result = bloodPressure.getAgeRange(16);
            Assert.AreEqual(result, "teen");
        }
        [TestMethod]
        public void TestAgeRanges_Adult_ReturnsTrue()
        {
            //Triple 'A' Method of Test
            //Arrange and Add
            BloodPressure bloodPressure = new BloodPressure();
            string result = bloodPressure.getAgeRange(23);
            Assert.AreEqual(result, "adult");
        }
        [TestMethod]
        public void TestAgeRanges_MidLife_ReturnsTrue()
        {
            //Triple 'A' Method of Test
            //Arrange and Add
            BloodPressure bloodPressure = new BloodPressure();
            string result = bloodPressure.getAgeRange(40);
            Assert.AreEqual(result, "midlife");
        }
        [TestMethod]
        public void TestAgeRanges_Senior_ReturnsTrue()
        {
            //Triple 'A' Method of Test
            //Arrange and Add
            BloodPressure bloodPressure = new BloodPressure();
            string result = bloodPressure.getAgeRange(64);
            Assert.AreEqual(result, "senior");
        }
        [TestMethod]
        public void BPCategory_Baby_HasLowBloodPressure_ReturnsTrue()
        {
            //Triple 'A' Method of Test
            //Arrange and Add
            BloodPressure bloodPressure = new BloodPressure() { Systolic = 75, Diastolic = 50, Age = 1 };
            BPCategory bloodPressureCategory = bloodPressure.Category;
            //Assert
            Assert.AreEqual(BPCategory.LowBaby, bloodPressureCategory);
        }
        [TestMethod]
        public void BPCategory_Child_HasLowBloodPressure_ReturnsFalse()
        {
            //Triple 'A' Method of Test
            //Arrange and Add
            BloodPressure bloodPressure = new BloodPressure() { Systolic = 80, Diastolic = 55, Age = 2 };
            BPCategory bloodPressureCategory = bloodPressure.Category;
            //Assert
            Assert.AreNotEqual(BPCategory.LowChild, bloodPressureCategory);
        }
        [TestMethod]
        public void BPCategory_Teen_HasLowBloodPressure_ReturnsFalse()
        {
            //Triple 'A' Method of Test
            //Arrange and Add
            BloodPressure bloodPressure = new BloodPressure() { Systolic = 105, Diastolic = 73, Age = 16 };
            BPCategory bloodPressureCategory = bloodPressure.Category;
            //Assert // There is a conflict as Teens low blood pressure is Normal in other charts
            Assert.AreNotEqual(BPCategory.LowTeen, bloodPressureCategory);
        }
        [TestMethod]
        public void BPCategory_Adult_HasLowBloodPressure_ReturnsFalse()
        {
            //Triple 'A' Method of Test
            //Arrange and Add
            BloodPressure bloodPressure = new BloodPressure() { Systolic = 111, Diastolic = 78, Age = 35 };
            BPCategory bloodPressureCategory = bloodPressure.Category;
            //Assert // There is a conflict as Adults low blood pressure is Normal in other charts
            Assert.AreNotEqual(BPCategory.LowAdult, bloodPressureCategory);
        }
        [TestMethod]
        public void BPCategory_Adult_HasLowBloodPressure_ReturnsTrue()
        {
            //Triple 'A' Method of Test
            //Arrange and Add
            BloodPressure bloodPressure = new BloodPressure() { Systolic = 111, Diastolic = 78, Age = 35 };
            BPCategory bloodPressureCategory = bloodPressure.Category;
            //Assert // There is a conflict as Adults low blood pressure is Normal in other charts, so will return normal
            Assert.AreEqual(BPCategory.Normal, bloodPressureCategory);
        }
        [TestMethod]
        public void BPCategory_MidLife_HasNormalBloodPressure_ReturnsFalse()
        {
            //Triple 'A' Method of Test
            //Arrange and Add
            BloodPressure bloodPressure = new BloodPressure() { Systolic = 125, Diastolic = 83, Age = 41 };
            BPCategory bloodPressureCategory = bloodPressure.Category;
            //Assert // Another conflict as Midlife Normal, fits into the Pre High so should return False
            Assert.AreNotEqual(BPCategory.NormalMidLife, bloodPressureCategory);
        }
        [TestMethod]
        public void BPCategory_Adult_HasLowBloodPressure_Direct_ReturnsTrue()
        {
            //Triple 'A' Method of Test
            //Arrange and Add
            BloodPressure bloodPressure = new BloodPressure();
            BPCategory category = bloodPressure.getLowResult(110, 77, "adult");
            //Assert // Return true when the category are hit with age range
            Assert.AreEqual(category, BPCategory.LowAdult);
        }

        [TestMethod]
        public void BPCategory_MidLife_HasNormalBloodPressure_ReturnsTrue()
        {
            //Triple 'A' Method of Test
            //Arrange and Add
            BloodPressure bloodPressure = new BloodPressure();
            BPCategory category = bloodPressure.getNormalResult(125, 83, "midlife");
            //Assert // Return true when the category are hit with age range
            Assert.AreEqual(category, BPCategory.NormalMidLife);
        }

        [TestMethod]
        public void BPCategory_Baby_HasNormalBloodPressure_ReturnsTrue()
        {
            //Triple 'A' Method of Test
            //Arrange and Add
            BloodPressure bloodPressure = new BloodPressure();
            BPCategory category = bloodPressure.getNormalResult(90, 60, "baby");
            //Assert // Return true when the category are hit with age range
            Assert.AreEqual(category, BPCategory.NormalBaby);
        }

        [TestMethod]
        public void BPCategory_Senior_HasHighBloodPressure_ReturnsTrue()
        {
            //Triple 'A' Method of Test
            //Arrange and Add
            BloodPressure bloodPressure = new BloodPressure();
            BPCategory category = bloodPressure.getHighResult(147, 91, "senior");
            //Assert // Return true when the category are hit with age range
            Assert.AreEqual(category, BPCategory.HighSenior);
        }

        [TestMethod]
        public void BPCategory_Adult_HasHighBloodPressure_ReturnsTrue()
        {
            //Triple 'A' Method of Test
            //Arrange and Add
            BloodPressure bloodPressure = new BloodPressure();
            BPCategory category = bloodPressure.getHighResult(134, 84, "adult");
            //Assert // Return true when the category are hit with age range
            Assert.AreEqual(category, BPCategory.HighAdult);
        }
    }
}
