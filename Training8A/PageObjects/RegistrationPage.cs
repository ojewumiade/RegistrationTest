using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training8A.Utilities;

namespace Training8A.PageObjects
{
    class RegistrationPage
    {
        public RegistrationPage()
        {
            PageFactory.InitElements(Hooks.Driver, this);
        }

        [FindsBy(How = How.LinkText, Using = "Register")]
        private IWebElement register { get; set; }

        [FindsBy(How = How.Id, Using = "first_name")]
        private IWebElement firstName { get; set; }

        [FindsBy(How = How.Id, Using = "last_name")]
        private IWebElement lastName { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#mobile")]
        private IWebElement MobileNumber { get; set; }

        [FindsBy(How = How.Id, Using = "password")]
        private IWebElement myPassword { get; set; }

        [FindsBy(How = How.Id, Using = "confirm_password")]
        private IWebElement myConfirmPassword { get; set; }

        [FindsBy(How = How.Id, Using = "email")]
        private IWebElement emailAddress { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#signup-form > div.buttons-holder.text-center > button")]
        private IWebElement signUp { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='google_cpatcha_error']")]
        private IWebElement ConfirmNotRegistered { get; set; }

        public bool ConfirmNotRegistrationMessage()
        {
            return ConfirmNotRegistered.Displayed;
        }

        public void ClickSignUP()
        {

            signUp.Click();
        }


        public void ClickOnRegister()
        {
            register.Click();
        }

        public void EnterFirstName()
        {
            firstName.SendKeys("John");
        }

        public void EnterLastName()
        {
            lastName.SendKeys("Ade");
        }

        public void EnterMobileNumber()
        {
            MobileNumber.SendKeys("07534016038");
        }


        public void EnterPassword()
        {
            myPassword.SendKeys("naijapals123");
        }

        public void EnterConfirmPassword()
        {
            myConfirmPassword.SendKeys("naijapals123");
        }

        public void EnterEmailAddress()
        {
            emailAddress.SendKeys("cjohnoje@gmail.com");
        }
    }
}
