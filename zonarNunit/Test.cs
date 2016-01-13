using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

using OpenQA.Selenium.Support.UI;

namespace SeleniumTests
{
    [TestFixture]
    public class Untitled2 : zonarNunit.Action.BaseAction
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;

        [SetUp]
        public void SetupTest()
        {
            driver = new ChromeDriver(@"D:\tool\");
           
            verificationErrors = new StringBuilder();
        }


        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }

        [Test]
        public void TheUntitled2Test()
        {
            IsElementPresent(By.XPath(".//*[@id='SiteLoginControl']/div/div/table/tbody/tr[2]/td/input"));
            driver.Navigate().GoToUrl("http://rc.itechcraft.com/Arctrieval/siteLogin.aspx");
            driver.FindElement(By.XPath(".//*[@id='SiteLoginControl']/div/div/table/tbody/tr[2]/td/input")).SendKeys("admin");
            driver.FindElement(By.XPath(".//*[@id='SiteLoginControl']/div/div/table/tbody/tr[4]/td/input")).SendKeys("Qwerty1!");
            driver.FindElement(By.XPath(".//*[@id='SiteLoginControl']/div/div/div[3]/a/span/span")).Click();
            

        }
        

        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }

        private string CloseAlertAndGetItsText()
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert)
                {
                    alert.Accept();
                }
                else {
                    alert.Dismiss();
                }
                return alertText;
            }
            finally
            {
                acceptNextAlert = true;
            }
        }
    }
}
