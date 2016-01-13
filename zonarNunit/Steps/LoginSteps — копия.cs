using System;
using TechTalk.SpecFlow;

namespace zonarNunit.Steps
{
    [Binding]
    public class LoginSteps
    {
        zonarNunit.Action.Action action = new zonarNunit.Action.Action();
        zonarNunit.Data.LoginData data = new zonarNunit.Data.LoginData();
        zonarNunit.Locators.LoginLocators locators = new zonarNunit.Locators.LoginLocators();

        [Given(@"I have Opened Login Page")]
        public void GivenIHaveOpenedLoginPage()
        {
            action.openLoginPage();

        }
        
        //Entering data
        [Given(@"I have entered Login")]
        public void GivenIHaveEnteredLogin()
        {
            action.enterLogin();
        }
        
        [Given(@"I have entered Password")]
        public void GivenIHaveEnteredPassword()
        {
            action.enterPassword(data.existPass);
        }
        
        [Given(@"I have entered Wrong Password")]
        public void GivenIHaveEnteredWrongPassword()
        {
            action.enterPassword(data.wrongPass);
        }
        

        //Clicking buttons
        [When(@"I press Login Button")]
        public void WhenIPressLoginButton()
        {
            action.clickLoginButton();
        }
        

        // Checking Elements on page
        [Then(@"The result Account Page is Opened")]
        public void ThenTheResultAccountPageIsOpened()
        {
            action.checkOpeningAccountPage();
        }
        
        [Then(@"I see my name in a conner")]
        public void ThenISeeMyNameInAConner()
        {
            action.logoutQuitDriver();
        }


        //validation checks
        [Then(@"The result User see validation message")]
        public void ThenTheResultUserSeeValidationMessage()
        {
            action.checkValidationWrongPasswordMassegeIsDisplayed();
        }
    }
}
