using AutomationPractice.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace AutomationPractice
{
    [Binding]
    public sealed class HooksAutomation: Driver
    {

        [BeforeScenario]
        public void BeforeFeature()
        {
            InvokeDriver();
        }

        [AfterScenario]
        public void AfterFeature()
        {
            driver.Quit();
        }
    }
}
