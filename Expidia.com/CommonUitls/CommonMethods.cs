using Expedia.com.Base;
using OpenQA.Selenium;
using System;
using System.Collections;

namespace Expedia.com.CommonUitls
{
    class CommonMethods : Driver
    {
        public void Maximize() {
            driver.Manage().Window.Maximize();
            deleteCookies();
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
        public String getvalue(IWebElement element) {
            return element.GetAttribute("value");
        }
        public void wait() {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }
        public void deleteCookies() {
            driver.Manage().Cookies.DeleteAllCookies();
        }
        public void switchWindow() {
            driver.SwitchTo().Window(windowHandle());
        }
        public String windowHandle() {
            return driver.WindowHandles[0];
        }
        public double getFare(IWebElement e) {

            String totalText = e.GetAttribute("innerHTML");
            String[] Price = totalText.Split('$');
            return double.Parse(Price[1]);
        }
        public void SwitchTabs() {
            ArrayList tabs = new ArrayList(driver.WindowHandles);
            driver.SwitchTo().Window((String)tabs[1]);

        }
        public double getFare1(IWebElement e) {
            return double.Parse(e.GetAttribute("data-exact-price"));
        }
    }
}
