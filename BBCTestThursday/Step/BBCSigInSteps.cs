using BBC_Test.Base;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using BBC_Test.Pages;
using BBCTestThursday.Page;


namespace BBCTestThursday
{
    [Binding]
    [Scope(Tag ="BBCSignIn")]
    public class BBCSigInSteps : SetUp
    {

        public IWebDriver Browser;
        public BBCSignIn signin;

        [Given(@"I navigate to BBC")]
        public void GivenINavigateToBBC()
        {
            Browser = Driver;
            signin = new BBCSignIn(Browser);
            Browser.Navigate().GoToUrl("https://www.bbc.co.uk/");
        }
        
        [Given(@"I click signin")]
        public void GivenIClickSignin()
        {
            signin.ClickSignIn();
            
        }
        
        [When(@"I login with valid user details")]
        public void WhenILoginWithValidUserDetails()
        {
            signin.UserDetails();
        }
        
        [Then(@"I see login is successful")]
        public void ThenISeeLoginIsSuccessful()
        {
            signin.VerifyLogin();
        }
    }
}
