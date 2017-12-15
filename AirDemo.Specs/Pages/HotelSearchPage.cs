using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;

namespace HOTELpinSight.Pages
{
    public class HotelSearchPage : BasePage
    {
        [FindsBy(How = How.Id, Using = "ucPWP_ctl08_55218_lnkGoToBackOffice")]
        private IWebElement _backOfficeButton;

        public HotelSearchPage(IWebDriver driver) : base(driver)
        {
        }

        public void EnsurePageIsLoaded()
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementToBeClickable(_backOfficeButton));
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
