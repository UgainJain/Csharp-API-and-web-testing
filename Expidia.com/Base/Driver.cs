
using Expedia.com.CommonUitls;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expedia.com.Base
{
    public class Driver
    {
        CommonMethods commnutils;
        public static IWebDriver driver;
        public void InvokeDriver() {
            commnutils = new CommonMethods();
            driver = new ChromeDriver();
            commnutils.Maximize();
            commnutils.Open_url("https://www.expedia.com");
        }
        public void Close() {
            driver.Close();
        }
    }
}
