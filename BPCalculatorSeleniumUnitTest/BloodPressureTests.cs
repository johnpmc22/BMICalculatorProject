using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using System;

namespace BPCalculatorSeleniumUnitTest
{
    /// <summary>
    /// Summary description for MySeleniumTests
    /// </summary>
    [TestClass]
    public class BloodPressureTests
    {
        private TestContext testContextInstance;
        private IWebDriver driver;
        private string appURL;


        public BloodPressureTests()
        {
        }

        [Timeout(60000)]
        [TestMethod]
        [TestCategory("Chrome")]
        public void BasicPageLoadHeaderCheck_True()
        {
            driver.Navigate().GoToUrl(appURL + "/");
            driver.FindElement(By.XPath("/html/body/div/h4")).Click();
            Assert.IsTrue(driver.Title.Contains("BP Category Calculator"), "Verified title of the page");
        }

        /*[Timeout(60000)]
        [TestMethod]
        [TestCategory("Chrome")]
        public void BasicPageLoadHeaderCheck_False()
        {
            driver.Navigate().GoToUrl(appURL + "/");
            driver.FindElement(By.XPath("//*[@id='form1']/div[1]/label")).Click();
            Assert.IsFalse(driver.Title.Contains("BPI Category Calculators"), "Verified title of the page");
        }

        [Timeout(60000)]
        [TestMethod]
        [TestCategory("Chrome")]
        public void ReturnNormalBloodPressure_True()
        {
            driver.Navigate().GoToUrl(appURL + "/");
            driver.FindElement(By.Id("BP_Systolic")).Clear();
            driver.FindElement(By.Id("BP_Systolic")).SendKeys("110");
            driver.FindElement(By.Id("BP_Diastolic")).Click();
            driver.FindElement(By.XPath("//*[@id='form1']/div[3]"));
            Assert.IsTrue(driver.FindElement(By.TagName("body")).Text.Contains("Normal Blood Pressure"));
        }

        [Timeout(60000)]
        [TestMethod]
        [TestCategory("Chrome")]
        public void ReturnNormalBloodPressure_False()
        {
            driver.Navigate().GoToUrl(appURL + "/");
            driver.FindElement(By.Id("BP_Systolic")).Clear();
            driver.FindElement(By.Id("BP_Systolic")).SendKeys("130");
            driver.FindElement(By.Id("BP_Diastolic")).Click();
            driver.FindElement(By.XPath("//*[@id='form1']/div[3]"));
            Assert.IsFalse(driver.FindElement(By.TagName("body")).Text.Contains("Normal Blood Pressure"));
        }

        [Timeout(60000)]
        [TestMethod]
        [TestCategory("Chrome")]
        public void ReturnHighBloodPressure_True()
        {
            driver.Navigate().GoToUrl(appURL + "/");
            driver.FindElement(By.Id("BP_Systolic")).Clear();
            driver.FindElement(By.Id("BP_Systolic")).SendKeys("170");
            driver.FindElement(By.Id("BP_Diastolic")).Clear();
            driver.FindElement(By.Id("BP_Diastolic")).SendKeys("95");
            driver.FindElement(By.Id("BP_Systolic")).Click();
            driver.FindElement(By.XPath("//*[@id='form1']/div[3]"));
            Assert.IsTrue(driver.FindElement(By.TagName("body")).Text.Contains("High Blood Pressure"));
        }

        [Timeout(60000)]
        [TestMethod]
        [TestCategory("Chrome")]
        public void ReturnLowBloodPressure_True()
        {
            driver.Navigate().GoToUrl(appURL + "/");
            driver.FindElement(By.Id("BP_Systolic")).Clear();
            driver.FindElement(By.Id("BP_Systolic")).SendKeys("80");
            driver.FindElement(By.Id("BP_Diastolic")).Clear();
            driver.FindElement(By.Id("BP_Diastolic")).SendKeys("60");
            driver.FindElement(By.Id("BP_Systolic")).Click();
            driver.FindElement(By.XPath("//*[@id='form1']/div[3]"));
            Assert.IsTrue(driver.FindElement(By.TagName("body")).Text.Contains("Low Blood Pressure"));
        }

        [Timeout(60000)]
        [TestMethod]
        [TestCategory("Chrome")]
        public void ReturnHighBloodPressure_False()
        {
            driver.Navigate().GoToUrl(appURL + "/");
            driver.FindElement(By.Id("BP_Systolic")).Clear();
            driver.FindElement(By.Id("BP_Systolic")).SendKeys("100");
            driver.FindElement(By.Id("BP_Diastolic")).Clear();
            driver.FindElement(By.Id("BP_Diastolic")).SendKeys("60");
            driver.FindElement(By.Id("BP_Systolic")).Click();
            driver.FindElement(By.XPath("//*[@id='form1']/div[3]"));
            Assert.IsFalse(driver.FindElement(By.TagName("body")).Text.Contains("High Blood Pressure"));
        }

        [Timeout(60000)]
        [TestMethod]
        [TestCategory("Chrome")]
        public void SystolicGreaterThanDiastolic_True()
        {
            driver.Navigate().GoToUrl(appURL + "/");
            driver.FindElement(By.Id("BP_Systolic")).Clear();
            driver.FindElement(By.Id("BP_Systolic")).SendKeys("89");
            driver.FindElement(By.Id("BP_Diastolic")).Clear();
            driver.FindElement(By.Id("BP_Diastolic")).SendKeys("95");
            driver.FindElement(By.Id("BP_Systolic")).Click();
            driver.FindElement(By.XPath("//*[@id='form1']/div[3]"));
            Assert.IsTrue(driver.FindElement(By.TagName("body")).Text.Contains("Systolic must be greater than Diastolic"));
        }

        [Timeout(60000)]
        [TestMethod]
        [TestCategory("Chrome")]
        public void SystolicGreaterThanDiastolic_False()
        {
            driver.Navigate().GoToUrl(appURL + "/");
            driver.FindElement(By.Id("BP_Systolic")).Clear();
            driver.FindElement(By.Id("BP_Systolic")).SendKeys("89");
            driver.FindElement(By.Id("BP_Diastolic")).Clear();
            driver.FindElement(By.Id("BP_Diastolic")).SendKeys("63");
            driver.FindElement(By.Id("BP_Systolic")).Click();
            driver.FindElement(By.XPath("//*[@id='form1']/div[3]"));
            Assert.IsFalse(driver.FindElement(By.TagName("body")).Text.Contains("Systolic must be greater than Diastolic"));
        }

        [Timeout(60000)]
        [TestMethod]
        [TestCategory("Chrome")]
        public void InvalidFields_True()
        {
            driver.Navigate().GoToUrl(appURL + "/");
            driver.FindElement(By.Id("BP_Systolic")).Clear();
            driver.FindElement(By.Id("BP_Diastolic")).Clear();
            driver.FindElement(By.Id("BP_Systolic")).Click();
            driver.FindElement(By.XPath("//*[@id='form1']/div[2]/span"));
            driver.FindElement(By.CssSelector("#form1 > div:nth-child(2) > span"));
            Assert.IsTrue(driver.FindElement(By.TagName("body")).Text.Contains("The value \'\' is invalid."));
        }

        [Timeout(60000)]
        [TestMethod]
        [TestCategory("Chrome")]
        public void InvalidFields_False()
        {
            driver.Navigate().GoToUrl(appURL + "/");
            driver.FindElement(By.Id("BP_Systolic")).Clear();
            driver.FindElement(By.Id("BP_Systolic")).SendKeys("89");
            driver.FindElement(By.Id("BP_Diastolic")).Clear();
            driver.FindElement(By.Id("BP_Diastolic")).SendKeys("63");
            driver.FindElement(By.Id("BP_Systolic")).Click();
            Assert.IsFalse(driver.FindElement(By.TagName("body")).Text.Contains("The value \'\' is invalid."));
        }

        [Timeout(60000)]
        [TestMethod]
        [TestCategory("Chrome")]
        public void InvalidAgeField_False()
        {
            driver.Navigate().GoToUrl(appURL + "/");
            driver.FindElement(By.Id("BP_Age")).Clear();
            driver.FindElement(By.Id("BP_Systolic")).Click();
            Assert.IsTrue(driver.FindElement(By.TagName("body")).Text.Contains("Age Must be between the ages of 1 and 120 years"));
        }

        [Timeout(60000)]
        [TestMethod]
        [TestCategory("Chrome")]
        public void ReturnLowBloodPressureBaby_True()
        {
            driver.Navigate().GoToUrl(appURL + "/");
            driver.FindElement(By.Id("BP_Systolic")).Clear();
            driver.FindElement(By.Id("BP_Systolic")).SendKeys("75");
            driver.FindElement(By.Id("BP_Diastolic")).Clear();
            driver.FindElement(By.Id("BP_Diastolic")).SendKeys("50");
            driver.FindElement(By.Id("BP_Age")).Clear();
            driver.FindElement(By.Id("BP_Age")).SendKeys("1");
            driver.FindElement(By.Id("BP_Systolic")).Click();
            driver.FindElement(By.XPath("//*[@id='form1']/div[4]"));
            Assert.IsTrue(driver.FindElement(By.TagName("body")).Text.Contains("Low Blood Pressure Baby Age Range"));
        }

        [TestMethod]
        [TestCategory("Chrome")]
        public void ReturnHighBloodPressureMidlife_True()
        {
            driver.Navigate().GoToUrl(appURL + "/");
            driver.FindElement(By.Id("BP_Systolic")).Clear();
            driver.FindElement(By.Id("BP_Systolic")).SendKeys("144");
            driver.FindElement(By.Id("BP_Diastolic")).Clear();
            driver.FindElement(By.Id("BP_Diastolic")).SendKeys("90");
            driver.FindElement(By.Id("BP_Age")).Clear();
            driver.FindElement(By.Id("BP_Age")).SendKeys("45");
            driver.FindElement(By.Id("BP_Systolic")).Click();
            driver.FindElement(By.XPath("//*[@id='form1']/div[4]"));
            Assert.IsTrue(driver.FindElement(By.TagName("body")).Text.Contains("High Blood Pressure MidLife Age Range"));
        }

        [Timeout(60000)]
        [TestMethod]
        [TestCategory("Chrome")]
        public void InvalidAge_ReturnsTrue()
        {
            driver.Navigate().GoToUrl(appURL + "/");
            driver.FindElement(By.Id("BP_Systolic")).Clear();
            driver.FindElement(By.Id("BP_Systolic")).SendKeys("120");
            driver.FindElement(By.Id("BP_Diastolic")).Clear();
            driver.FindElement(By.Id("BP_Diastolic")).SendKeys("80");
            driver.FindElement(By.Id("BP_Age")).Clear();
            driver.FindElement(By.Id("BP_Age")).SendKeys("125");
            driver.FindElement(By.Id("BP_Systolic")).Click();
            driver.FindElement(By.XPath("//*[@id='form1']/div[4]"));
            Assert.IsTrue(driver.FindElement(By.TagName("body")).Text.Contains("Invalid Age Value"));
        }

        [Timeout(60000)]
        [TestMethod]
        [TestCategory("Chrome")]
        public void InvalidAge_ReturnsFalse()
        {
            driver.Navigate().GoToUrl(appURL + "/");
            driver.FindElement(By.Id("BP_Systolic")).Clear();
            driver.FindElement(By.Id("BP_Systolic")).SendKeys("120");
            driver.FindElement(By.Id("BP_Diastolic")).Clear();
            driver.FindElement(By.Id("BP_Diastolic")).SendKeys("80");
            driver.FindElement(By.Id("BP_Age")).Clear();
            driver.FindElement(By.Id("BP_Age")).SendKeys("37");
            driver.FindElement(By.Id("BP_Systolic")).Click();
            driver.FindElement(By.XPath("//*[@id='form1']/div[4]"));
            Assert.IsFalse(driver.FindElement(By.TagName("body")).Text.Contains("Invalid Age Value"));
        }

        [TestMethod]
        [TestCategory("Chrome")]
        public void InvalidAge_ReturnsFalse_DemoTest()
        {
            driver.Navigate().GoToUrl(appURL + "/");
            driver.FindElement(By.Id("BP_Systolic")).Clear();
            driver.FindElement(By.Id("BP_Systolic")).SendKeys("120");
            driver.FindElement(By.Id("BP_Diastolic")).Clear();
            driver.FindElement(By.Id("BP_Diastolic")).SendKeys("80");
            driver.FindElement(By.Id("BP_Age")).Clear();
            driver.FindElement(By.Id("BP_Age")).SendKeys("75");
            driver.FindElement(By.Id("BP_Systolic")).Click();
            driver.FindElement(By.XPath("//*[@id='form1']/div[4]"));
            Assert.IsFalse(driver.FindElement(By.TagName("body")).Text.Contains("Invalid Age Value"));
        }*/

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        [TestInitialize()]
        public void SetupTest()
        {
            //Run Settings run locally without issue but do not run in Azzure devOps
            //appURL = TestContext.Properties["webAppUrl"].ToString();
            appURL = "https://bpcalculator20181128071159.azurewebsites.net/bloodpressure";
            string browser = "Chrome";
            switch (browser)
            {
                case "Chrome":
                    driver = new ChromeDriver(Environment.GetEnvironmentVariable("ChromeWebDriver"));
                    break;
                case "Firefox":
                    driver = new FirefoxDriver();
                    break;
                case "IE":
                    driver = new InternetExplorerDriver();
                    break;
                default:
                    driver = new ChromeDriver();
                    break;
            }

        }

        [TestCleanup()]
        public void MyTestCleanup()
        {
            driver.Quit();
        }
    }
}