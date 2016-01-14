using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using TechTalk.SpecFlow;
using zonarNunit.Action;
using zonarNunit.Locators;








namespace zonarNunit.Action 
{
    public class AccountPageActions : BaseAction
    {

        
        private string currentProjectName = "Test - " +  rnd();

        
        //account page logic

        public void checkOpeningAccountPage()
        {
            driver.FindElement(AccountPageLocators.logo);

        }

        public void openedAccountSettingTab()
        {
            waitForElementPresent(AccountPageLocators.accountSettings);
            //for (int second = 0; ; second++)
            //{
            //    if (second >= 60) Assert.Fail("timeout");
            //    try
            //    {
            //        if (IsElementPresent(By.XPath("//a[contains(text(),'Account Settings')]"))) break;
            //    }
            //    catch (Exception)
            //    { }
            //    Thread.Sleep(1000);
            //}
            driver.FindElement(AccountPageLocators.accountSettings).Click();
        }

        public void setNewNameOnFirstNameAndLastNameField()
        {
            driver.FindElement(By.XPath(".//*[@id='resetPasswordSection']/form/div[1]/div[1]/input"));
            driver.FindElement(By.XPath(".//*[@id='resetPasswordSection']/form/div[1]/div[2]/input"));
            driver.FindElement(By.Name("accountSettingsFirstName")).Clear();
            driver.FindElement(By.Name("accountSettingsFirstName")).SendKeys("AlexTest1");
            driver.FindElement(By.Name("accountSettingsLastName")).Clear();
            driver.FindElement(By.Name("accountSettingsLastName")).SendKeys("StesenkoTest1");

        }

        public void clickUpdateButton()
        {
            driver.FindElement(By.XPath(".//*[@id='resetPasswordSection']/form/div[6]/button[1]"));
            driver.FindElement(By.CssSelector("div.mt1.mb1 > button[type=\"submit\"]")).Click();

        }

        public void newNamesAreSaved()

        {

        }

        public void logoutQuitDriver()
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
            driver.FindElement(By.LinkText("Logout")).Click();
            
            
        }



        //Create bulding method

        public void iHaveOpenedMyBuildingsTab()
        {
            driver.Manage().Timeouts().SetPageLoadTimeout(new TimeSpan(0, 0, 20));
            for (int second = 0; ; second++)
            {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(By.LinkText("My Buildings"))) break;
                }
                catch (Exception)
                { }
                Thread.Sleep(1000);
            }

            driver.FindElement(By.LinkText("My Buildings")).Click();

        }

        public int getOldList()
        {
           

            IList<IWebElement> oldList = getListByLocator(AccountPageLocators.label);
            int countOldList = oldList.Count;
            return countOldList;
        }

        public void iClickCreateBuildingButton()
        {
            waitForElementPresent(AccountPageLocators.createBuildingButton);
            waitForElementPresent(AccountPageLocators.myAccount);
            driver.FindElement(AccountPageLocators.createBuildingButton).Click();

        }
        
        public void iFillInFieldsOnCreateBuildingsForm(Data.BuildingCreationsParameters inputParameters)
        {
            // Input parameters are stored in Data.BuildingCreationsParameters

            Thread.Sleep(1000);
            waitForElementPresent(AccountPageLocators.popUpWindow);
            waitForElementPresent(AccountPageLocators.width);
            waitForElementPresent(AccountPageLocators.depth);


            // set Lot parameter
            Console.Write("     set Lot parameter - start");
            driver.FindElement(AccountPageLocators.width).SendKeys(inputParameters.Width);
            driver.FindElement(AccountPageLocators.depth).SendKeys(inputParameters.Depth);

            // set zone
            Console.Write("     set zone - start");
            waitForElementPresent(AccountPageLocators.zoningCode);


            ////driver.FindElement(By.XPath(".//*[@id='launchAppContent']/div[3]/form/div[2]/select/option[3]")).Click();
            ////ICollection<IWebElement> labels = driver.FindElements(By.TagName("option"));
            ////foreach ( IWebElement label in labels)
            ////{
            ////    if ( label.Text.Equals("Zoning Code*"))
            ////    {
            ////        var parent = label.FindElement(By.XPath(".."));
                    

            ////        ICollection<IWebElement> selectes = parent.FindElements(By.TagName(".ng-touched.ng-dirty.ng-valid-parse.ng-valid.ng-valid-required"));

            ////        foreach (IWebElement select in selectes)
            ////        {
            ////            ICollection<IWebElement> options = select.FindElements(By.TagName("option"));
            ////            foreach ( IWebElement option in options)
            ////            {
            ////                if (option.Text.Equals("Miami Base code"))
            ////                {
            ////                    option.Click();
            ////                }
            ////            }

            ////        }
            ////    }
            ////}
            

            selectFromDropDown(AccountPageLocators.zoningCode, inputParameters.ZoningCode);


            // set sub-zone and Type
            Console.Write("     set sub-zone and Type - start");
            waitForElementPresent(AccountPageLocators.zoneT6);
            new SelectElement(driver.FindElement((AccountPageLocators.zone))).SelectByText(inputParameters.Zone);

            waitForElementPresent(AccountPageLocators.subzone36b);
            waitForElementPresent(AccountPageLocators.type);



            waitForElementPresent(AccountPageLocators.subzone36b);
            waitForElementPresent(AccountPageLocators.type);
            new SelectElement(driver.FindElement((AccountPageLocators.subZone))).SelectByText(inputParameters.SubZone);
            new SelectElement(driver.FindElement((AccountPageLocators.type))).SelectByText(inputParameters.Type);

            // set name 
            Console.Write("     set Name - start");
            waitForElementPresent(AccountPageLocators.name);
            driver.FindElement(AccountPageLocators.name).Clear();
            driver.FindElement(AccountPageLocators.name).SendKeys(currentProjectName);

            // click on Createbutton
            Console.Write("     click on Createbutton - start");
            waitForElementPresent(AccountPageLocators.createButtonOnPopUp);
            driver.FindElement(AccountPageLocators.createButtonOnPopUp).Click();

            // waiting for load page
            driver.Manage().Timeouts().SetPageLoadTimeout(new TimeSpan(0, 0, 40));
            waitForElementPresent(MenuLocarors.myAccount);
            Thread.Sleep(1000);
        }

        public void projectIsSaved()
        {


            

            driver.Manage().Timeouts().SetPageLoadTimeout(new TimeSpan(0, 0, 40));
            IList<IWebElement> labels = driver.FindElements(By.CssSelector(".ng-binding"));
            var newList = labels;


            
        }

        public void iHaveDeleteProject()
        {
            //ICollection<IWebElement> divs = driver.FindElements(By.CssSelector("div"));
            //foreach (IWebElement div in divs)
            //{
            //    var labels = div.FindElements(By.TagName("label"));
            //    //ICollection<IWebElement> labels = driver.FindElements(By.TagName("label"));
            //    foreach (IWebElement lable in labels)
            //    {
            //        if (lable.Text.Equals("Test1"))
            //        {
            //            //e.FindElement(By.XPath(".."));
            //            ICollection<IWebElement> links = driver.FindElements(By.CssSelector(".action-btn.no-border"));
            //            foreach (IWebElement link in links)
            //            {
            //                if (link.Text.Equals("Delete"))
            //                {

            //                    link.Click();

            //                }
            //            } 
            //        }

            //    }
            //}
            //waitForElementPresent(By.XPath(".//*[@id='deleteProjectModal']/div[1]"));
            //driver.FindElement(By.XPath(".//*[@id='deleteProjectModal']/div[3]/a[1]")).Click();
            waitUntilElementPresent(AccountPageLocators.projectCardBuildingTab);


            ICollection<IWebElement> labels = driver.FindElements(By.TagName("label"));
            foreach (IWebElement lable in labels)
            { 
                if (lable.Text.Contains(currentProjectName))
                {

                    var parent = lable.FindElement(By.XPath(".."));
                    var delete = parent.FindElement(AccountPageLocators.deleteLinkBuildingTab);
                    delete.Click();
                    waitUntilElementPresent((AccountPageLocators.deleteBuildingPopUpTitle));
                    break;
                }
            }

            Console.Write("Deleting is started");
            Thread.Sleep(1000);
            waitUntilElementPresent(AccountPageLocators.deleteButtonOnPopUp);
            driver.FindElement(AccountPageLocators.deleteButtonOnPopUp).Click();
        }

        public void iHaveDeleteAllTestBuilding()
        {
            Action.AccountPageActions aa = new Action.AccountPageActions();
            aa.mainPageWithLoginUser();
            System.Threading.Thread.Sleep(2000);
            aa.iHaveOpenedMyBuildingsTab();

            waitUntilElementPresent(AccountPageLocators.projectCardBuildingTab);


            ICollection<IWebElement> labels = driver.FindElements(By.TagName("label"));
            foreach (IWebElement lable in labels)
            {
                if (lable.Text.Contains("Test"))
                {

                    var parent = lable.FindElement(By.XPath(".."));
                    var delete = parent.FindElement(AccountPageLocators.deleteLinkBuildingTab);
                    delete.Click();
                    waitUntilElementPresent((AccountPageLocators.deleteBuildingPopUpTitle));
                    break;
                }
            }

            Console.Write("Deleting is started");
            Thread.Sleep(1000);
            waitUntilElementPresent(AccountPageLocators.deleteButtonOnPopUp);
            Thread.Sleep(1000);
            driver.FindElement(AccountPageLocators.deleteButtonOnPopUp).Click();
           

        }

        public void projectIsDeleted()
        {
            reloadPage();
            iHaveOpenedMyBuildingsTab();
            IList<IWebElement> newList = getListByLocator(AccountPageLocators.label);
            int count = newList.Count;
            int countOld = getOldList();
            Assert.AreEqual(countOld , newList.Count);
            Thread.Sleep(1000);

        }

        static string rnd()
        {
            byte[] c = new byte[1]; //Объявляем массив байтов размером 1 элемента *FIXED*
            Random rand = new Random();//Создаем экземпляр класса Random
            Thread.Sleep(20);//Останавливаем главный поток на 20 милисекунд
            rand.NextBytes(c);//Генерируем случайное число
            string name = c[0].ToString();
            return name;//Возвращаем первый элемент массива
        }

        public void inputZoningData(string inputData)
        {
            if (inputData == "Maimi")
            {
                iFillInFieldsOnCreateBuildingsForm(zonarNunit.Data.BuildingCreationsParameters.maimi);

            }
            else
            {if (inputData == "Maimi1")
                {
                    iFillInFieldsOnCreateBuildingsForm(zonarNunit.Data.BuildingCreationsParameters.maimi1);
                }
            }
        }


    }
}


