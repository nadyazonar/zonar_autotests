using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.PageObjects;

namespace zonarNunit.Locators
{
    public class LoginLocators
    {
        //login page fields and button
        public static By emailField = By.XPath("//input[@id='signinEmail']");
        public static By passwordField = By.XPath("//input[@id='signinPass']");
        public static By loginButton = By.XPath(@"id(""loginButton"")");
        public static By wrongPassValidationMeassege = By.XPath(".//*[@id='invalidEmailOrPassValidation']");
        public static By requiredValidationEmailField = By.XPath(".//*[@id='signinDataContainer']/form/div[1]/div/span/span[1]");
        public static By requiredValidationPasswordField =By.XPath( ".//*[@id='signinDataContainer']/form/div[2]/div/span/span[1]");
        public static By rememberMeCheckBox = By.XPath( ".//*[@id='signinDataContainer']/form/div[3]/div[1]/div/label");
        public static By forgotYourPasswordLink = By.XPath(".//*[@id='signinForgotPass']");
        public static By singUpLink = By.XPath(".//*[@id='registerButton']");
        public static By logoutButton = By.XPath("html/body/header/div/nav/section/ul/li[2]/ul/li[9]/a");

       

    }



}
