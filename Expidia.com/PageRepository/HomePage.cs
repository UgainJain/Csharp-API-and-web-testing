using Expedia.com.Base;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expidia.com.PageRepository
{
    class HomePage :Driver
    {
        public IWebElement getFlightsBtn() {
            return driver.FindElement(By.Id("tab-flight-tab-hp"));
        }
        public IWebElement getMultiCityLbl() {
            return driver.FindElement(By.Id("flight-type-multi-dest-label-hp-flight"));
        }
        public IWebElement getAddFlightopt() {
            return driver.FindElement(By.Id("add-flight-leg-hp-flight"));
        }
        public IWebElement getFirstOriginAirport() {
            return driver.FindElement(By.Id("flight-origin-hp-flight"));
        }
        public IWebElement getFirstDestinationAirport() {
            return driver.FindElement(By.Id("flight-destination-hp-flight"));
        }
        public IWebElement getSecondOriginAirport()
        {
            return driver.FindElement(By.Id("flight-2-origin-hp-flight"));
        }
        public IWebElement getSecondDestinationAirport()
        {
            return driver.FindElement(By.Id("flight-2-destination-hp-flight"));
        }
        public IWebElement getThirdOriginAirport()
        {
            return driver.FindElement(By.Id("flight-3-origin-hp-flight"));
        }
        public IWebElement getThirdDestinationAirport()
        {
            return driver.FindElement(By.Id("flight-3-destination-hp-flight"));
        }
        public IWebElement getFirstDate() {
            return driver.FindElement(By.Id("flight-departing-single-hp-flight"));
        }
        public IWebElement getSecondDate() {
            return driver.FindElement(By.Id("flight-2-departing-hp-flight"));
        }
        public IWebElement getThirdDate() {
            return driver.FindElement(By.Id("flight-3-departing-hp-flight")); 
        }
        public IWebElement getTravellersvalue() {
            return driver.FindElement(By.Id("traveler-selector-hp-flight"));
        }    
        public IWebElement getSearchBtn(){
            return driver.FindElement(By.XPath("//form[@id = 'gcw-flights-form-hp-flight']//button[@type='submit']"));
        }
        public IWebElement getAddTravellerbtn() {
            return driver.FindElement(By.XPath("(//button[@class='uitk-step-input-button uitk-step-input-plus'])[1]"));
        }
        public IWebElement getAdultSelectorCloseBtn() {
            return driver.FindElement(By.XPath("//div[@id='traveler-selector-hp-flight']//button[@class ='close btn-text']"));
        }
    }
}
