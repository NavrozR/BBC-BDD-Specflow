using FluentAssertions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBCTestThursday.Page
{
    public class BBCWeather
    {
        public IWebDriver Driver;

        public BBCWeather(IWebDriver browser) 
        {
            Driver = browser;
            PageFactory.InitElements(Driver, this);          
        }


        [FindsBy(How = How.ClassName, Using = "orb-nav-weather")]
        public IWebElement WeatherLink;

        [FindsBy(How = How.Id, Using = "ls-c-search__input-label")]
        public IWebElement Postcode;

        [FindsBy(How = How.ClassName, Using = "ls-c-search__submit")]
        public IWebElement SubmitButton;

        [FindsBy(How = How.Id, Using = "wr-location-name-id")]
        public IWebElement VerifyPage;

        //[FindsBy(How = How.CssSelector, Using = ".wr-time-slot-list__time-slots>li:nth-of-type(5)")]
        //public IWebElement Link18;

        //[FindsBy(How = How.ClassName, Using = "wr-wind-speed__value ")]
        //public IWebElement Link18Name;

        String account = "RG5";


        public void Navigate()
        {
            Driver.Navigate().GoToUrl("https://www.bbc.co.uk/");

        }
        public void ClickWeather() 
        {
            WeatherLink.Click();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
        }
        public void EnterPostcode() 
        {
            Postcode.SendKeys("RG5 3JP");
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            SubmitButton.Click();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
        }
        //public void ClickLink18() 
        //{
        //    Link18.Click();
        //    Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);

        //}

        public void VerifyLink18() 
        {
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            VerifyPage.Text.Contains(account).Should().BeTrue();
        
        }
       
    }
}
