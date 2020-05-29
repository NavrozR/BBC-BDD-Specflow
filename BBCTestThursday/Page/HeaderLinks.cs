using FluentAssertions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using OpenQA.Selenium.Support.Events;
using System.Drawing;
using System.Drawing.Design;

namespace BBCTestThursday.Page
{
    public class HeaderLinks
    {
        public IWebDriver Driver;
        

        public HeaderLinks(IWebDriver browser)
        {
            Driver = browser;
            PageFactory.InitElements(Driver, this);
        }

        [FindsBy(How = How.ClassName, Using = "orb-nav-news")]
        public IWebElement NewsLink;

        [FindsBy(How = How.ClassName, Using = "orb-nav-sport")]
        public IWebElement SportsLink;

        [FindsBy(How = How.ClassName, Using = "orb-nav-weather")]
        public IWebElement WeatherLink;

        [FindsBy(How = How.LinkText, Using = "Complaints")]
        public IWebElement ComplaintLink;

        [FindsBy(How = How.CssSelector, Using = "#orb-aside > div > div > ul > li.orb-nav-cbeebies > a")]
        public IWebElement CBeebiesLink;

        [FindsBy(How = How.CssSelector, Using = "#orb-nav-more > a")]
        public IWebElement MoreLink;

        [FindsBy(How = How.LinkText, Using = "Food")]
        public IWebElement FoodLink;
           
        //[FindsBy(How = How.ClassName, Using = "main-menu__item main-menu__item--primary main-menu__item--recipes main-menu__item--focus")]
        //public IWebElement RecipesLink;

        string NewsUrl = "https://www.bbc.co.uk/news";
        string SportsUrl = "https://www.bbc.co.uk/sport";
        string WeatherUrl = "https://www.bbc.co.uk/weather";
        string ComplaintUrl = "https://www.bbc.co.uk/contact/complaints";
        string CBeebiesUrl = "https://www.bbc.co.uk/cbeebies";
        string MoreText = "More";
        string Foodurl = "https://www.bbc.co.uk/food";
        //string Recipesurl = "https://www.bbc.co.uk/food/recipes";


        public void Navigate() 
        {
            Driver.Navigate().GoToUrl("https://www.bbc.co.uk/");
        }

        public void ClickHeaderLinks(string link) 
        {
            switch (link) 
            {
                case "News":
                    NewsLink.Click();
                    Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
                    break;
                case "Sport":
                    SportsLink.Click();
                    Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
                    break;
                case "Weather":
                    WeatherLink.Click();
                    Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
                    break;
                case "Complaint":
                    Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
                    IJavaScriptExecutor ComplaintObject = Driver as IJavaScriptExecutor;
                    //js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight)");
                    //js.ExecuteScript("window.scrollBy(0,200000);");
                    ComplaintObject.ExecuteScript("arguments[0].scrollIntoView();", ComplaintLink);
                    ComplaintLink.Click();
                    Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
                    break;
                case "CBeebies":
                    Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
                    IJavaScriptExecutor CBeebiesObject = Driver as IJavaScriptExecutor;
                    CBeebiesObject.ExecuteScript("arguments[0].scrollIntoView();", CBeebiesLink);
                    CBeebiesLink.Click();
                    Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
                    break;
                case "More":
                    MoreLink.Click();
                    Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
                    break;
                case "Food":
                    MoreLink.Click();
                    Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
                    FoodLink.Click();
                    Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
                    ((ITakesScreenshot)Driver).GetScreenshot().SaveAsFile("D://FoodHome.png", ScreenshotImageFormat.Png);
                    //FoodHomePage.SaveAsFile("D:\\sample.png",System.Drawing.Imaging.ImageFormat);
                    //var FoodLink = new SelectElement(MoreLink);
                    //FoodLink.SelectByText("Food");
                    //RecipesLink.Click();
                    // Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                    break;
                default: Console.WriteLine("Wrong Link");
                    break;
            }

        }

        public void VerifyHeaderLinks(string link) 
        {

            switch (link)
            {
                case "News":
                    Driver.Url.Contains(NewsUrl);
                    Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
                    break;
                case "Sport":
                    Driver.Url.Contains(SportsUrl);
                    Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
                    break;
                case "Weather":
                    Driver.Url.Contains(WeatherUrl);
                    Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
                    break;
                case "Complaint":
                    Driver.Url.Contains(ComplaintUrl);
                    Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
                    break;
                case "CBeebies":
                    Driver.Url.Contains(CBeebiesUrl);
                    Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
                    break;
                case "More":
                    MoreLink.Text.Contains(MoreText).Should().BeTrue();
                    Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
                    break;
                case "Food":
                    Driver.Url.Contains(Foodurl);
                    Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
                    break;
                default:
                    Console.WriteLine("Wrong Link");
                    break;
            }

        }

    }
}
