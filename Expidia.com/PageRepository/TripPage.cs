using Expedia.com.Base;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expidia.com.PageRepository
{
    class TripPage:Driver
    {
        public IWebElement getSelectbtn(){
            return driver.FindElement(By.XPath("//ul[@id='flightModuleList']//li[1]//button"));
        }
        public IWebElement getPrice() {
            return driver.FindElement(By.XPath("//ul[@id='flightModuleList']//li[1]//span[@class = 'full-bold no-wrap']"));
        }
        public IWebElement getdepart1() {
            return driver.FindElement(By.Id("departure-airport-1"));
        }
        public IWebElement getarrival1()
        {
            return driver.FindElement(By.Id("arrival-airport-1"));
        }
        public IWebElement getdepart2()
        {
            return driver.FindElement(By.Id("departure-airport-2"));
        }
        public IWebElement getarrival2()
        {
            return driver.FindElement(By.Id("arrival-airport-2"));
        }
        public IWebElement getdepart3()
        {
            return driver.FindElement(By.Id("departure-airport-3"));
        }
        public IWebElement getarrival3()
        {
            return driver.FindElement(By.Id("arrival-airport-3"));
        }
        public IWebElement getdate1()
        {
            return driver.FindElement(By.Id("departure-date-1"));
        }
        public IWebElement getdate2()
        {
            return driver.FindElement(By.Id("departure-date-1"));
        }
        public IWebElement getdate3()
        {
            return driver.FindElement(By.Id("departure-date-3"));
        }
        public IWebElement getTotalFare() {
            return driver.FindElement(By.XPath("(//div//span[@class = 'tripTotalPrice hidden'])[1]"));
        }
    }
}
