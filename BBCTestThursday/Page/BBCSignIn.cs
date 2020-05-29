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
  
        public class BBCSignIn
        {

            public IWebDriver Driver;
            public BBCSignIn(IWebDriver browser)
            {
                Driver = browser;
                PageFactory.InitElements(Driver, this);
            }

            [FindsBy(How = How.Id, Using = "idcta-link")]
            public IWebElement SigninLink;

            [FindsBy(How = How.Id, Using = "user-identifier-input")]
            public IWebElement Username;

            [FindsBy(How = How.Id, Using = "password-input")]
            public IWebElement Password;

            [FindsBy(How = How.Id, Using = "submit-button")]
            public IWebElement SubmitButton;

            [FindsBy(How = How.Id, Using = "idcta-username")]
            public IWebElement SigninName;

            string account = "Nav";

            public void Navigate() 
            {
                Driver.Navigate().GoToUrl("https://www.bbc.co.uk/");
            }

            public void ClickSignIn() 
            {
                SigninLink.Click();
                Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            }

            public void UserDetails() 
            {
                Username.SendKeys("navrozrashyani@gmail.com");
                Password.SendKeys("Pa55word");
                SubmitButton.Click();
                Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            }

            public void VerifyLogin() 
            {

                SigninName.Text.Contains(account).Should().BeTrue();
            
            }
        }
    
}
