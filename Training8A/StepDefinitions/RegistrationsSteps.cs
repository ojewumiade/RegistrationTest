using System;
using TechTalk.SpecFlow;
using Training8A.PageObjects;
using Training8A.Utilities;

namespace Training8A.StepDefinitions
{
    [Binding]
    public class RegistrationsSteps
    {
        RegistrationPage registration;

        public RegistrationsSteps()
        {
            registration = new RegistrationPage();
        }

        [Given(@"I navigate to the site")]
        public void GivenINavigateToTheSite()
        {
            Hooks.Driver.Navigate().GoToUrl("http://www.giftrete.com");
            Hooks.Driver.Manage().Window.Maximize();
        }
        
        [When(@"Click on register link")]
        public void WhenClickOnRegisterLink()
        {
            registration.ClickOnRegister();
        }
        
        [When(@"I enter firstname")]
        public void WhenIEnterFirstname()
        {
            registration.EnterFirstName();
        }
        
        [When(@"I enter last name")]
        public void WhenIEnterLastName()
        {
            registration.EnterLastName();
        }

        [When(@"I enter emailadd")]
        public void WhenIEnterEmailadd()
        {
            registration.EnterEmailAddress();
        }



        [When(@"I enter mobile number")]
        public void WhenIEnterMobileNumber()
        {
            registration.EnterMobileNumber();
        }
        
        [When(@"I enter password")]
        public void WhenIEnterPassword()
        {
            registration.EnterPassword();
        }
        
        [When(@"I confirm password")]
        public void WhenIConfirmPassword()
        {
            registration.EnterConfirmPassword();
        }
        
        [When(@"the click on signUp")]
        public void WhenTheClickOnSignUp()
        {
            registration.ClickSignUP();
        }

        [Then(@"I not should be registered")]
        public void ThenINotShouldBeRegistered()
        {
            registration.ConfirmNotRegistrationMessage();
        }

    }
}
