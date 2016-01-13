using System;
using TechTalk.SpecFlow;
using zonarNunit.Steps;

namespace zonarNunit
{
    [Binding]
    public class LoginSteps : BaseSteps
    {
        

        //Given start
        [Given(@"I have displayed emailField, passField, logInButton")]
        public void GivenIHaveDisplayedEmailFieldPassFieldLogInButton()
        {
            actionsLoginPage.uiElementsIsDisplayed();

        }

        [Given(@"I have Opened Login Page")]
        public void GivenIHaveOpenedLoginPage()
        {
            actionsLoginPage.openLoginPage();
        }


        //Method can Take Users Login according Roles
        [Given(@"I have entered Exist Login")]
        public void GivenIHaveEnteredExistLogin()
        {
            actionsLoginPage.enterLogin(loginPageData.existEmail);
        }

        //Method can Take "existPass" and "wrongPass" value
        [Given(@"I have entered Exist Password")]
        public void GivenIHaveEnteredExistPassword()
        {
            actionsLoginPage.enterPassword(loginPageData.existPass);
        }

        //Method can Take "existPass" and "wrongPass" value
        [Given(@"I have entered Wrong Password")]
        public void GivenIHaveEnteredWrongPassword()
        {
            actionsLoginPage.enterPassword(loginPageData.wrongPass);
        }
        //Given end



        //When start
        [When(@"I press Login Button")]
        public void WhenIPressLoginButton()
        {
            actionsLoginPage.clickLoginButton();
        }
        //When end


         // Then start


        [Then(@"I see Required Validation message")]
        public void ThenISeeRequiredValidationMessage()
        {
            actionsLoginPage.iSeeRequiredValidationMessage();
        }

        [Then(@"The result User see validation message")]
        public void ThenTheResultUserSeeValidationMessage()
        {
            actionsLoginPage.checkValidationWrongPasswordMassegeIsDisplayed();
        }
        // When end
        

    }
}
