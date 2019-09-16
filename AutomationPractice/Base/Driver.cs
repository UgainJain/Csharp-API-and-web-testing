using AutomationPractice.CommonUitls;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationPractice.Base
{
    public class Driver
    {
        CommonMethods commnutils;
        public static IWebDriver driver;
        public void InvokeDriver() {
            commnutils = new CommonMethods();
            driver = new ChromeDriver();
            commnutils.Maximize();
        }
        public void Close() {
            driver.Close();
        }
    }
}
