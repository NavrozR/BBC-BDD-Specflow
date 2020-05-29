using BBC_Test.Pages;
using BBC_Test.Base;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using OpenQA.Selenium;




namespace BBC_Test.Steps
{
    [Binding]
    [Scope(Tag = "BBCPageLoad")]
    public class BBCPageLoadSteps : SetUp
    {
        public IWebDriver Browser;
        public BBCPageLoad pageload;

        [Given(@"I navigate to BBC")]
        public void GivenINavigateToBBC()
        {
            Browser = Driver;
            pageload = new BBCPageLoad(Browser);
            pageload.NavigateBBC();
        }

        [Then(@"I see BBC page loads")]
        public void ThenISeeBBCPageLoads()
        {
            pageload.CheckMessage();
        }



    }
}
