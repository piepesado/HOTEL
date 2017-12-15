using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirDemo.Specs.Pages
{
    public class HotelSearchPage : BasePage
    {
        [FindsBy(How = How.LinkText, Using = "Flight")]
        private IWebElement _flightLink;

        public HotelSearchPage(IWebDriver driver) : base(driver)
        {
        }

        public void EnsurePageIsLoaded()
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementToBeClickable(_flightLink));
        }

        /*
        public FlightSearchPage ClickFlightLink()
        {
            _flightLink.Click();
            return new FlightSearchPage(_driver);
        }
        */
    }
}
