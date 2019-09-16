using NUnit.Framework;
using Reqres.Business_Logic;
using RestSharp;
using System;
using TechTalk.SpecFlow;

namespace Reqres.StepDef
{
    [Binding]
    public class RegistrationSteps
    {
        RegistrationBusinessLogic Reg; 
        
        [When(@"I register a new User with '(.*)' Username and '(.*)' Password")]
        public void WhenIRegisterANewUserWithUsernameAndPassword(string p0, string p1)
        {
            Reg = new RegistrationBusinessLogic();
            Assert.IsTrue(Reg.invoke());
            Assert.IsTrue(Reg.generate_request("register", "Post"));
            Assert.IsTrue(Reg.Provide_parameter(p0, p1));

        }
        
        [Then(@"registration is sucessfull")]
        public void ThenRegistrationIsSucessfull()
        {
            Assert.IsTrue(Reg.try_register());
            
        }
        
        [Then(@"token is generated")]
        public void ThenTokenIsGenerated()
        {
            Assert.IsTrue(Reg.check_for_token());

        }
        
        [Then(@"registration is not sucessfull")]
        public void ThenRegistrationIsNotSucessfull()
        {
            Assert.IsFalse(Reg.try_register());
            
        }
        [When(@"user sends a requests on '(.*)'")]
        public void WhenUserSendsARequestsOn(string p0)
        {
            Reg = new RegistrationBusinessLogic();
            Assert.IsTrue(Reg.invoke());
            Assert.IsTrue(Reg.generate_request(p0, "Get"));
        }

        [Then(@"user gets list of users")]
        public void ThenUserGetsListOfUsers()
        {
            Assert.IsTrue(Reg.get_response());
        }

    }
}
