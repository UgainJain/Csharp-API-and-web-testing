using AutomationPractice.Base;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationPractice.PageRepository
{
    class HomePagePL : Driver
    {
        public IWebElement Getsigninbutton() {
            return driver.FindElement(By.XPath("//a[@class ='login']"));
        }
    }
}
