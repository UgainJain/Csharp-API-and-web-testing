using AutomationPractice.Base;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationPractice.CommonUitls
{
    class CommonMethods : Driver
    {
        public void Maximize() {
            driver.Manage().Window.Maximize();
        }
        public void Open_url(String url) {
            driver.Url = url;
            driver.Navigate();
        }
        public bool Check_title(String title) {
            return title.Equals(driver.Title);
        }
        public void click(IWebElement element) {
            element.Click();
        }
        public void typetext(IWebElement element, string value) {
            element.SendKeys(value);
        }
        public String gettext(IWebElement element) {
            return element.GetAttribute("innerHTML");
        }
    }
}
