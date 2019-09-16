using Expedia.com.CommonUitls;
using Expidia.com.PageRepository;
using System;
using System.IO;

namespace Expidia.com.BusinessLogic
{
    class ExpediaBL
    {
        HomePage hmpage;
        TripPage trpage;
        CommonMethods commonuitils;
        private static double fare = 0.00f;
        private static String FirstStation = "Luqa, Malta (MLA)",  SecondStation = "London, England, UK (LON)", ThirdStation = "Rome, Italy (ROM)", FirstDate = "02/17/2020", SecondDate = "02/20/2020", ThirdDate = "02/24/2020", number = " ";
        public bool Verifytitle(String title) {
            commonuitils = new CommonMethods();
            return commonuitils.Check_title(title);
        }
        public bool click_flights() {
            try
            {
                hmpage = new HomePage();
                commonuitils.click(hmpage.getFlightsBtn());
                return true;
            }
            catch {
                return false;
            }
        }
        public bool clickMultiCity() {
            try
            {
                commonuitils.click(hmpage.getMultiCityLbl());
                return true;
            }
            catch {
                return false;
            }
        }
        public bool AddFlight() {
            try
            {
                commonuitils.click(hmpage.getAddFlightopt());
                return true;
            }
            catch {
                return false;
            }
        }
        public bool fillupFlightData(string FirstStation, string SecondStation, string ThirdStation, string FirstDate, string SecondDate, string ThirdDate, string number) {
            try
            {
                
                commonuitils.click(hmpage.getFirstOriginAirport());
                commonuitils.typetext(hmpage.getFirstOriginAirport(),FirstStation);
                commonuitils.click(hmpage.getFirstDestinationAirport());
                commonuitils.typetext(hmpage.getFirstDestinationAirport(), SecondStation);
                commonuitils.click(hmpage.getFirstDate());
                commonuitils.typetext(hmpage.getFirstDate(), FirstDate);
                commonuitils.click(hmpage.getTravellersvalue());
                ExpediaBL.number = number;

                for (int i = 1; i < int.Parse(number); i++)
                {
                    commonuitils.click(hmpage.getAddTravellerbtn());
                }
                commonuitils.click(hmpage.getAdultSelectorCloseBtn());
                commonuitils.click(hmpage.getSecondOriginAirport());
                commonuitils.typetext(hmpage.getSecondOriginAirport(), SecondStation);
                commonuitils.click(hmpage.getSecondDestinationAirport());
                commonuitils.typetext(hmpage.getSecondDestinationAirport(), ThirdStation);
                commonuitils.click(hmpage.getSecondDate());
                commonuitils.typetext(hmpage.getSecondDate(), SecondDate);
                commonuitils.click(hmpage.getThirdOriginAirport());
                commonuitils.typetext(hmpage.getThirdOriginAirport(), ThirdStation);
                commonuitils.click(hmpage.getThirdDestinationAirport());
                commonuitils.typetext(hmpage.getThirdDestinationAirport(), FirstStation);
                commonuitils.click(hmpage.getSecondDate());
                commonuitils.typetext(hmpage.getThirdDate(), ThirdDate);
                
                return true;
            }
            catch(Exception e){

                return false;
                throw e;
                
            }
        }
        public bool ClickSearch() {
            try
            {
                commonuitils.click(hmpage.getSearchBtn());
                return true;
            }
            catch {
                return false;
            }
        }
        public bool verifyEntry()
        {
            trpage = new TripPage();
            bool flag = true;
            flag = commonuitils.getvalue(trpage.getdepart1()).Contains(ExpediaBL.FirstStation);
           
            flag = commonuitils.getvalue(trpage.getdepart2()).Contains(ExpediaBL.SecondStation);
           
            flag = commonuitils.getvalue(trpage.getdepart3()).Contains(ExpediaBL.ThirdStation);
           
            flag = commonuitils.getvalue(trpage.getdate1()).Contains(ExpediaBL.FirstDate);
           
            flag = commonuitils.getvalue(trpage.getdate2()).Contains(ExpediaBL.SecondDate);
            
            flag = commonuitils.getvalue(trpage.getdate3()).Contains(ExpediaBL.ThirdDate);
            if (flag == true)
            {
                return true;
            }
            else return false;
        }
        public void SelectFlights() {

            commonuitils.switchWindow();
            
            commonuitils.wait();
            ExpediaBL.fare = commonuitils.getFare1(trpage.getSelectbtn());         
            commonuitils.click(trpage.getSelectbtn());
            commonuitils.wait();
            commonuitils.switchWindow();
            commonuitils.click(trpage.getSelectbtn());
            commonuitils.switchWindow();
            commonuitils.wait();
            commonuitils.click(trpage.getSelectbtn());
       
        }
        public bool verifyTotal() {
            commonuitils.wait();
            double total = ExpediaBL.fare * double.Parse(number);
            a.WriteLine(total);
            commonuitils.SwitchTabs();
            commonuitils.wait();
            
            if (total == commonuitils.getFare(trpage.getTotalFare())){
                return true;
            }
            else return false;
        }

    }
}
