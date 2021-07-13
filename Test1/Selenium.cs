using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace Test1
{
    [TestFixture]
    class Selenium
    {
        private ChromeDriver _driver;
        [SetUp]
        public void SetUp()
        {
            _driver = new ChromeDriver();
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Close();
            _driver.Quit();
        }
        [Test]
        public void Test()
        {
            //_driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            _driver.Navigate().GoToUrl("https://regression.surpass-preview.com/secureassess/htmldelivery/?isFake=true");
            var inputKeycode = _driver.FindElement(By.Id("keycode-text"));
            var okButton = _driver.FindElement(By.Id("okay"));

            //Wait input field for keycode
            Assert.IsTrue(inputKeycode.Displayed);

            //Enter keycode
            inputKeycode.SendKeys("AUTO0002");

            // Wait Ok button and click on it
            Assert.IsTrue(okButton.Enabled);
            okButton.Click();

            //Wait confirm dialog and click on confirm button
            //var confirmButton = _driver.FindElement(By.CssSelector("#confirm.btn.btn-secondary"));
            var confirmButton = WaitElement(By.CssSelector("#confirm.btn.btn-secondary"));
            confirmButton.Click();

            //Wait and Click on I accept these terms checkbox
            var termsAcceptedCheckbox = WaitElement(By.Id("termsAcceptedCheckbox"));
            Actions actions = new Actions(_driver);
            actions.MoveToElement(termsAcceptedCheckbox).Click().Build().Perform();

            //Wait continue button and click on it
            var continueButton = WaitElement(By.CssSelector("#agree-to-terms-form > div.btn-div > button:nth-child(2)"));
            continueButton.Click();

            var contentArea = WaitElement(By.Id("main-content"));
            Assert.IsTrue(contentArea.Enabled);

            //Wait start exam button and click on it
            var startExamButton = WaitElement(By.Id("startExamButton"));
            Thread.Sleep(2000);
            startExamButton.Click();


            //Wait finish exam button and click on it
            var finishExamButton = _driver.FindElement(By.Id("finishExamButton"));
            Assert.IsTrue(finishExamButton.Displayed);
            Assert.IsTrue(finishExamButton.Enabled);

            Thread.Sleep(1000);

            finishExamButton.Click();

            Thread.Sleep(500);

            //Finish exam
            var modalDialog = WaitElement(By.XPath("/html/body/div[1]/div"));
            Assert.IsTrue(modalDialog.Displayed);

            var finishButton = WaitElement(By.Id("details-incorrect"));
            finishButton.Click();

            var secondFinishButton = _driver.FindElement(By.Id("details-return"));
            secondFinishButton.Click();

            var resultWindow = WaitElement(By.XPath("/html/body/div[1]/div/div/div/div[2]"));
            Thread.Sleep(1000);

        }

        private IWebElement WaitElement(By elementLocator)
        {
            return new WebDriverWait(_driver, TimeSpan.FromSeconds(10))
                .Until(ExpectedConditions.ElementExists(elementLocator));
        }
    }
}
