using AutomationPractice.Base;
using AutomationPractice.BusinessLogic;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace AutomationPractice.SteoDef
{
    [Binding]
    public class AutomationPracticeSteps
    {
        AutomationPracticeBL apbl;
        [Given(@"user is  on the Home page")]
        public void GivenUserIsOnTheHomePage()
        {
            apbl = new AutomationPracticeBL();
            Assert.IsTrue(apbl.CheckforhomePage());
        }

        [When(@"user clicks on SignIn button")]
        public void WhenUserClicksOnSignInButton()
        {
            Assert.IsTrue(apbl.Clicksignin());
        }

        [When(@"user enters (.*) and (.*)")]
        public void WhenUserEntersAnd(string p0, string p1)
        {
            Assert.IsTrue(apbl.enterCredentials(p0, p1));
        }
        [When(@"user click LogIn button")]
        public void WhenUserClickLogInButton()
        {
            Assert.IsTrue(apbl.ClickLoginBtn());
        }

        [Then(@"user should see (.*)")]
        public void ThenUserShouldSee(string p0)
        {
            Assert.AreEqual(p0, apbl.getErrorMsg()); 
        }
    }
}
