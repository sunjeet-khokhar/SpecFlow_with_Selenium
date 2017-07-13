using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using TechTalk.SpecFlow;
using Xunit;

namespace DemoWebApp.Tests
{
    [Binding]
    public class LoanApplicationSteps
    {
        private IWebDriver _driver;

        [Given(@"I am on the loan application screen")]
        public void GivenIAmOnTheLoanApplicationScreen()
        {
            _driver = new FirefoxDriver();

            _driver.Manage().Window.Maximize();

            _driver.Navigate().GoToUrl("http://localhost:40077/Home/StartLoanApplication");
        }
        
        [Given(@"I enter a first name of Sarah")]
        public void GivenIEnterAFirstNameOfSarah()
        {
            IWebElement firstNameInput = _driver.FindElement(By.Id("FirstName"));
            firstNameInput.SendKeys("Sarah");
        }
        
        [Given(@"I enter a second name of Smith")]
        public void GivenIEnterASecondNameOfSmith()
        {
            _driver.FindElement(By.Id("LastName")).SendKeys("Smith");
        }
        
        [Given(@"I select that I have an existing loan account")]
        public void GivenISelectThatIHaveAnExistingLoanAccount()
        {
            _driver.FindElement(By.Id("Loan")).Click();
        }
        
        [Given(@"I confirm my acceptance of the terms and conditions")]
        public void GivenIConfirmMyAcceptanceOfTheTermsAndConditions()
        {
            _driver.FindElement(By.Name("TermsAcceptance")).Click();
        }
        
        [When(@"I submit my application")]
        public void WhenISubmitMyApplication()
        {
            _driver.FindElement(By.CssSelector(".btn.btn-primary")).Click();
        }
        
        [Then(@"I should see the application complete confirmation for Sarah")]
        public void ThenIShouldSeeTheApplicationCompleteConfirmationForSarah()
        {
            IWebElement confirmationNameSpan = _driver.FindElement(By.Id("firstName"));

            string confirmationName = confirmationNameSpan.Text;

            Assert.Equal("Sarah", confirmationName);
        }

        [AfterScenario]
        public void DisposeWebDriver()
        {
            _driver.Dispose();
        }
    }
}
