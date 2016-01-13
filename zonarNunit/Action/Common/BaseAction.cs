using TechTalk.SpecFlow;
using NUnit.Framework;

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;


using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.IO;
using System.Collections.Generic;
using zonarNunit.Action;
using zonarNunit.Locators;
using zonarNunit.Data;



namespace zonarNunit.Action
{
    public class BaseAction
    {
        // base Url and webDriver connecting
        protected static IWebDriver driver;
        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

        


        //protected string baseUrl = @"http://demo-zonar.gridics.com/";
        //protected string baseUrl = (@" https://dev1-zonar.gridics.com/");
        protected string baseUrl = @"http://st1-zonar.gridics.com/";
        //protected string baseUrl = @"http://st1.zonar.gridics.com/";
       

        // creating an instances of the classes
        protected LoginLocators locatorsLogin = new LoginLocators();
        protected LoginData dataLoginPage = new LoginData();
        protected AccountPageData dataAccountPage = new AccountPageData();

        //Building parameters
        


        protected AccountPageLocators locatorsAccount = new zonarNunit.Locators.AccountPageLocators();
        protected ProjectPageLocators locarorsBuildingCreation = new ProjectPageLocators();
        

        // Common Method 
        public void mainPageWithLoginUser()
        {
            driver.Navigate().GoToUrl(baseUrl);
            System.Threading.Thread.Sleep(3000);

            if ( driver.Title == "My Express Application") 
            {
                

                driver.FindElement(LoginLocators.emailField).SendKeys(dataLoginPage.existEmail);
                driver.FindElement(LoginLocators.passwordField).SendKeys(dataLoginPage.existPass);
                driver.FindElement(LoginLocators.loginButton).Click();
                driver.Manage().Timeouts().SetPageLoadTimeout(new TimeSpan(0, 0, 20));
            }
            else
            {
                driver.Navigate().GoToUrl(baseUrl);
            }
        }



        public bool findCharInString(string strin, string value)
            {
                string str = strin;
                bool result = str.Contains(value);
                return result;
            }


        //additional method
        public static bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }


        public void waitUntilElementPresent(By locator)
        {
            IWebElement myDynamicElement = wait.Until
                ( (d) => { return d.FindElement(locator); } );
        }
            
        public void waitForElementPresent(By locator)
        {
            for (int second = 0; ; second++)
            {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(locator)) break;
                }
                catch (Exception)
                { }
                Thread.Sleep(1500);
            }  
        }

        public void selectFromDropDown(By locators, string listsName)
        {
            new SelectElement(driver.FindElement((AccountPageLocators.zoningCode))).SelectByText(listsName);

        }

        public bool compareWithMask(string Source, string Mask)
        {
            char[] strSource = new char[Source.Length + 1];
            char[] strMask = new char[Mask.Length + 1];

            Source.CopyTo(0, strSource, 0, Source.Length);
            Mask.CopyTo(0, strMask, 0, Mask.Length);

            int SourceIndex = 0;
            int MaskIndex = 0;

            for (; SourceIndex < strSource.Length && strMask[MaskIndex] != '*'; MaskIndex++, SourceIndex++)
                if (strMask[MaskIndex] != strSource[SourceIndex] && strMask[MaskIndex] != '?')

                    return false;

            int pSourceIndex = 0;
            int pMaskIndex = 0;

            for (;;)
            {
                if (strSource[SourceIndex] == 0)
                {
                    while (strMask[MaskIndex] == '*')
                        MaskIndex++;
                    return strMask[MaskIndex] == 0 ? true : false;
                }
                if (strMask[MaskIndex] == '*')
                {
                    if (strMask[++MaskIndex] == 0)
                        return true;
                    pMaskIndex = MaskIndex;
                    pSourceIndex = SourceIndex + 1;
                    continue;
                }
                if (strMask[MaskIndex] == strSource[SourceIndex] || strMask[MaskIndex] == '?')
                {
                    MaskIndex++;
                    SourceIndex++;
                    continue;
                }
                MaskIndex = pMaskIndex; SourceIndex = pSourceIndex++;
            }
        }

        public void reloadPage()
        {
            driver.Navigate().Refresh();
        }

        public  IList<IWebElement> getListByLocator(By locator)
        {
            List<IWebElement> list = new List<IWebElement>();
            ICollection<IWebElement> labels = driver.FindElements(locator);
            foreach (IWebElement lable in labels)
            {
                list.Add(lable);
            }
            return list;
        }


        public static void setBuildingParametersOnCapacityTab(string nameParameter, string value)
        {
            IWebElement parent = null;
            IWebElement parent1 = null;
            IWebElement inputField;


            Console.Write("start setting" + nameParameter);
            IList<IWebElement> labels = driver.FindElements(By.CssSelector("label.ng-binding"));
            foreach (IWebElement label in labels)
            {
               
                if (label.Text.Contains(nameParameter))
                {
                    //System.Threading.Thread.Sleep(2000);
                    parent1 = label.FindElement(By.XPath(".."));
                    parent = parent1.FindElement(By.XPath(".."));
                }


            }
 
            parent.FindElement(By.XPath("div/div[2]/label")).Click();
            inputField = parent.FindElement(By.XPath("div/div[2]/input"));
            inputField.Clear();
            inputField.SendKeys(value);

         

        }
       



                 
            


        public static void logout()
        {
            for (int second = 0; ; second++)
            {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(By.LinkText("Logout"))) break;
                }
                catch (Exception)
                { }
                Thread.Sleep(1000);
            }

        }





    }

}
