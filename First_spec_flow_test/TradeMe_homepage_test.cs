using System;
using TechTalk.SpecFlow;
using NUnit;


namespace SpecFlow_Demo
{
    [Binding]
    public class TradeMe_homepage_test
    {
        [Given(@"I have an internet conection and a browseer")]
        public void GivenIHaveAnInternetConectionAndABrowseer()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I land on the Trademe home page")]
        public void WhenILandOnTheTrademeHomePage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should see the TradeMe logo i\.e\. Kevin the Kiwi")]
        public void ThenIShouldSeeTheTradeMeLogoI_E_KevinTheKiwi()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
