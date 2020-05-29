using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using FluentAssertions;

namespace BBC_Test.Pages
{
    

    public class BBCPageLoad
    {

        public IWebDriver Driver;

        public BBCPageLoad(IWebDriver browser)
        {

            Driver = browser;
            PageFactory.InitElements(Driver, this);

        }


        public void NavigateBBC()
        {
            Driver.Navigate().GoToUrl("https://www.bbc.co.uk/");
        }

        [FindsBy(How = How.ClassName, Using = "hp-banner__text")]
        public IWebElement WelcomeMessage;

        String Welcome = "Welcome to the BBC";

        public void CheckMessage()
        {

            WelcomeMessage.Text.Contains(Welcome).Should().BeTrue();
        }

    }
}