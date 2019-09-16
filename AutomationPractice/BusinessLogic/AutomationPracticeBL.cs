using AutomationPractice.Base;
using AutomationPractice.CommonUitls;
using AutomationPractice.PageRepository;
using System;

namespace AutomationPractice.BusinessLogic
{
    class AutomationPracticeBL : Driver
    {
        CommonMethods commnutils;
        HomePagePL hpl;
        LoginPL lpl;
        public bool CheckforhomePage() {
            commnutils = new CommonMethods();
            commnutils.Open_url("http://automationpractice.com/index.php");
            if (commnutils.Check_title("My Store"))
            {
                return true;
            }
            else {
                return false;
            }
        }
        public bool Clicksignin() {
            try {
                hpl = new HomePagePL();
                commnutils.click(hpl.Getsigninbutton());
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public bool enterCredentials(string Username,string Password)
        {
            try
            {
                lpl = new LoginPL();
                commnutils.typetext(lpl.getUsernametxtbox(), Username);
                commnutils.typetext(lpl.getPasswordtxtbox(), Password);
                return true;
            }
            catch (Exception e) {
                return false;
            }

        }

        public bool ClickLoginBtn()
        {
            try {
                commnutils.click(lpl.getLoginBtn());
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public String getErrorMsg() {

            return commnutils.gettext(lpl.getErrorMsgElement());
        }
    }
}
