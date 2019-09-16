using AutomationPractice.Base;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationPractice.PageRepository
{
    class LoginPL : Driver
    {
        public IWebElement getUsernametxtbox() {
            return driver.FindElement(By.Name("email"));
        }
        public IWebElement getPasswordtxtbox() {
            return driver.FindElement(By.Name("passwd"));
        }
        public IWebElement getLoginBtn() {
            return driver.FindElement(By.Name("SubmitLogin"));
        }
        public IWebElement getErrorMsgElement() {
            return driver.FindElement(By.XPath("//*[@id='center_column']/div[1]/ol/li"));
        }
    }
}
