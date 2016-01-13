using System;
using OpenQA.Selenium;
using zonarNunit.Action;
using zonarNunit.Locators;





namespace zonarNunit.ActionsLoginPage
{
    public class LoginPageActions : BaseAction
    {

        //login page action

        public void uiElementsIsDisplayed()
        {       
            driver.Manage().Timeouts().SetPageLoadTimeout(new TimeSpan(0, 0, 20));
            driver.FindElement(LoginLocators.emailField);
            driver.FindElement(LoginLocators.passwordField);
            driver.FindElement(LoginLocators.loginButton);
            
        }

        public void checkValidationWrongPasswordMassegeIsDisplayed()
        {
            driver.FindElement(LoginLocators.wrongPassValidationMeassege);
        }

        public void iSeeRequiredValidationMessage()
        {
            driver.FindElement(LoginLocators.requiredValidationEmailField);
            driver.FindElement(LoginLocators.requiredValidationPasswordField);
        }


        public void openLoginPage()
        {
            driver.Navigate().GoToUrl(baseUrl);
        }

        public void enterLogin(string login)
        {
            //Method can Take Users Login according Roles
            driver.FindElement(LoginLocators.emailField).SendKeys(login);
        }

        
        public void enterPassword(string pass)
        {
            //Method can Take "existPass" and "wrongPass" value
            driver.FindElement(LoginLocators.passwordField).SendKeys(pass);
        }

        public void clickLoginButton()
        {
            driver.FindElement(LoginLocators.loginButton).Click();
        }
    }
}
