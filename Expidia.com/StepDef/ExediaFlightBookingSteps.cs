using Expidia.com.BusinessLogic;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace Expidia.com.StepDef
{
    [Binding]
    public class ExediaFlightBookingSteps
    {
        ExpediaBL exbl;
        [Given(@"I am on flight booking page")]
        public void GivenIAmOnFlightBookingPage()
        {
            exbl = new ExpediaBL();
            Assert.IsTrue(exbl.Verifytitle("Expedia Travel: Search Hotels, Cheap Flights, Car Rentals & Vacations"));
        }
        
        [Given(@"Click user clicks on Flight section")]
        public void GivenClickUserClicksOnFlightSection()
        {
            Assert.IsTrue(exbl.click_flights());
        }
        
        [When(@"I select multi-select")]
        public void WhenISelectMulti_Select()
        {
            Assert.IsTrue(exbl.clickMultiCity());
        }
        
        [Then(@"click on Add another flight")]
        public void ThenClickOnAddAnotherFlight()
        {
            Assert.IsTrue(exbl.AddFlight());
        }

        [Then(@"Search for flights between different airports (.*),(.*),(.*) on dates (.*),(.*),(.*)  for (.*)  adults")]
        public void ThenSearchForFlightsBetweenDifferentAirportsOnDatesForAdults(string FirstStation, string SecondStation, string ThirdStation, string FirstDate, string SecondDate, string ThirdDate, string number)
        {
            Assert.IsTrue(exbl.fillupFlightData(FirstStation,SecondStation,ThirdStation,FirstDate,SecondDate,ThirdDate,number));
        }


        [Then(@"click on Search option")]
        public void ThenClickOnSearchOption()
        {
            Assert.IsTrue(exbl.ClickSearch());
        }

        [Then(@"verify tht the data entered is correct")]
        public void ThenVerifythtTheDataEnteredIsCorrect()
        {
            Assert.IsTrue(exbl.verifyEntry());
        }


        [Then(@"select First flight")]
        public void ThenSelectFirstFlight()
        {
            exbl.SelectFlights();
        }
        
        [Then(@"Total Price must be equal to (.*) multiplied fare of single person")]
        public void ThenTotalPriceMustBeEqualToMultipliedFareOfSinglePerson(string number)
        {
            Assert.IsTrue(exbl.verifyTotal());
        }
    }
}
