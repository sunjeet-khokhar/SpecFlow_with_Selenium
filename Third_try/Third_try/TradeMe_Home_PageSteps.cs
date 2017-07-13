using System;
using TechTalk.SpecFlow;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using Microsoft.VisualStudio.TestTools.UnitTesting;



namespace Third_try.Steps
{
    [Binding]
    public class TradeMe_Home_PageSteps
    {
        public IWebDriver driver;
        [Given(@"I have an internet connection and a browser")]
        public void GivenIHaveAnInternetConnectionAndABrowser()
        {
            driver = new ChromeDriver();
        }
        
        [When(@"I type TradeMe hopepage URL")]
        public void WhenITypeTradeMeHopepageURL()
        {
            driver.Url = "http://www.trademe.co.nz";
            driver.Manage().Window.Maximize();
        }
        
        [Then(@"the I should see Kevin the Kiwi logo on the homepage")]
        public void ThenTheIShouldSeeKevinTheKiwiLogoOnTheHomepage()
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(driver => driver.FindElement(By.Id("SiteHeader_SiteTabs_kevin")));
            Assert.IsTrue(driver.Title == "Buy online and sell with NZ's #1 auction & classifieds site | Trade Me");
            //Console.WriteLine(driver.Title);
            driver.Quit();
        }
    }
}
