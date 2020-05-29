using BBC_Test.Base;
using BBCTestThursday.Page;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;





namespace BBCTestThursday
{
    [Binding]
    [Scope(Tag ="BBCWeather")]
    public class BBCWeatherSteps:SetUp
    {

        public IWebDriver Browser;
        public BBCWeather weather;

        [Given(@"I navigate to BBC")]
        public void GivenINavigateToBBC()
        {
            Browser = Driver;
            weather = new BBCWeather(Browser);
            Browser.Navigate().GoToUrl("https://www.bbc.co.uk/");
        }

        [Given(@"I click Weather")]
        public void GivenIClickWeather()
        {
            weather.ClickWeather();
        }
        
        [When(@"I enter postcode")]
        public void WhenIEnterPostcode() 
        {
            weather.EnterPostcode();

        }

        [When(@"I click Time")]
        //public void WhenIClick()
        //{
        //    humidity.ClickLink18();
        //}

        [Then(@"I see Weather forecast")]
        public void ThenISeeWeatherForecast() 
        {
            weather.VerifyLink18();
        }

                              
    }
}
