using System;
using TechTalk.SpecFlow;
using BBCTestThursday.Page;
using BBCTestThursday.Test;
using OpenQA.Selenium;
using BBC_Test.Base;

namespace BBCTestThursday
{
    [Binding]
    [Scope(Tag = "HeaderLinks")]
    public class HeaderLinksSteps: SetUp
    {
        public IWebDriver Browser;
        public HeaderLinks header;

        [Given(@"I navigate to BBC")]
        public void GivenINavigateToBBC()
        {
            Browser = Driver;
            header = new HeaderLinks(Browser);
            header.Navigate();
        }
        
        [When(@"I click on (.*)")]
        public void WhenIClickOnNews(string link)
        {
            header.ClickHeaderLinks(link);
        }
        
        [Then(@"I see the (.*) pages")]
        public void ThenISeeTheNewsPages(string link)
        {
            header.VerifyHeaderLinks(link);
        }
    }
}
