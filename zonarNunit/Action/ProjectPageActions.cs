using System;
using OpenQA.Selenium;
using zonarNunit.Action;
using zonarNunit.Locators;
using System.Collections.Generic;
using NUnit.Framework;



namespace zonarNunit.ActionsLoginPage
{
    public class ProjectPageActions : BaseAction
    {

        public void iClickSaveButton()
        {
            
            waitForElementPresent(ProjectPageLocators.saveButton);
            driver.FindElement(ProjectPageLocators.saveButton).Click();
        }

        public void iLinkToMyBuildingTab()
        {
            driver.Navigate().GoToUrl(baseUrl + @"account/MyBuildings");
            driver.Manage().Timeouts().SetPageLoadTimeout(new TimeSpan(0, 0, 40));
        }

        public void ProgectPageIsOpened()
        {
            waitForElementPresent(ProjectPageLocators.zoningAllowances);
            waitForElementPresent(ProjectPageLocators.capacityAnalysis);
            waitForElementPresent(ProjectPageLocators.calibration);
        }

        public void CalibrationTabIsAvailable()
        {
            waitForElementPresent(ProjectPageLocators.calibration);
            driver.FindElement(ProjectPageLocators.calibration).Click();
        }

        public void CalibrationTabIsNotAvailable()
        {
            Assert.AreEqual(false, isElementPresent(ProjectPageLocators.calibration));
        }

        public void CalibrationTabIsOpened()
        {
            waitForElementPresent(ProjectPageLocators.calibrationContainer);
            waitForElementPresent(ProjectPageLocators.calibrationModules);
            waitForElementPresent(ProjectPageLocators.calibrationComponents);
            waitForElementPresent(ProjectPageLocators.calibrationZones);
            waitForElementPresent(ProjectPageLocators.calibrationUses);
            driver.FindElement(ProjectPageLocators.calibrationContainer).Click();
            driver.FindElement(ProjectPageLocators.calibrationModules).Click();
            driver.FindElement(ProjectPageLocators.calibrationComponents).Click();
            driver.FindElement(ProjectPageLocators.calibrationZones).Click();
            driver.FindElement(ProjectPageLocators.calibrationUses).Click();
        }



        public void iHaveOpenedTabCapacityAnalysis()
        {
            driver.FindElement(ProjectPageLocators.capacityAnalysis).Click();
            waitForElementPresent(ProjectPageLocators.parkingTab);
            waitForElementPresent(ProjectPageLocators.useProgramTab);
            // add checking please

            System.Threading.Thread.Sleep(1000);
            driver.FindElement(ProjectPageLocators.useProgramTab).Click();

        }

        public void iHaveOpenedTabZoningAllowances()
        {
            var tabList = new List<string>();
            var tabListTamplate = new List<string>();

            tabListTamplate.Add("Lot Information");
            tabListTamplate.Add("Location Variables");
            tabListTamplate.Add("Additional Options");


            System.Threading.Thread.Sleep(2000);

            ICollection<IWebElement> tabs = driver.FindElements(By.ClassName("accordian-title"));
            foreach (IWebElement tab in tabs)
            {

                if (tab.Text.Equals("Lot Information"))
                {
                    var text = tab.Text;
                    tabList.Add(text);

                }
                else
                {
                    if (tab.Text.Equals("Location Variables"))
                    {
                        var text = tab.Text;
                        tabList.Add(text);
                    }
                    else
                    {
                        if (tab.Text.Equals("Additional Options"))
                        {
                            var text = tab.Text;
                            tabList.Add(text);
                        }
                    }


                }
                

            }
            Assert.AreEqual(tabListTamplate, tabList);
        }

        public void iHaveOpenedResuktTableOnCapacityAnalisisTab()
        {
            waitForElementPresent(ProjectPageLocators.resultTableCapacityTab);
            driver.FindElement(ProjectPageLocators.resultTableCapacityTab).Click();
        }

        public void iSetCaseStudyCalibratuionSectionToAverageValues(string settingName, string value)
        {

            setBuildingParametersOnCapacityTab(settingName, value );

        }

        public void getBuildingParameters()
        {

        }

        public List<string> iGetResultFromRightTable(string[] resultTable)
        {
            System.Threading.Thread.Sleep(1000);
            //zonarNunit.Data.MaximumLotCapacity maximumLotCapacity = new zonarNunit.Data.MaximumLotCapacity("Lot Area Net", "Lot Area Acres", "Residential Density", "DU Allowed", "FAR",
            //    "Lot Coverage", "Min Open Space", "Principal Building Max Height", "Principal Building Min Height", "Principal Tower Height", "Max Built Area", "Max Building Area");


            var result = new List<string>();
            string[] BuildingCreationsParametersTemplateArray = new string[20];

            int i = 0;
            foreach (string parameter in resultTable)
            {

                IList<IWebElement> items = driver.FindElements(By.CssSelector(".item"));
                foreach (IWebElement item in items)
                {


                    if (item.Text.Contains(parameter))
                    {

                        IWebElement nameItem = item.FindElement(By.CssSelector(".des-left.ng-binding"));
                        var name = nameItem.Text;
                        IWebElement valueItem = item.FindElement(By.CssSelector(".price.right.ng-binding"));
                        var value = valueItem.Text;


                        result.Add(value);

                        Console.Write("                 " + name + "   -   " + result[i] + "\r\n");
                        i += 1;
                        break;

                    }

                }

            }

            return result; 
        }

        public  void checkingValuesOnZoningAllowancestab(string itemName, string mask)
        {
            ICollection<IWebElement> items = driver.FindElements(ProjectPageLocators.itemCssSelector);
            foreach (IWebElement item in items)
            {
                if (item.Text.Equals(itemName))
                {
                    Console.Write("                  " + itemName + " - Start ");
                    var parent = item.FindElement(By.XPath(".."));
                    var getValue = parent.FindElement(ProjectPageLocators.itemValueCssSelector);
                    string result = getValue.Text;
                    Assert.AreEqual(true, compareWithMask(result, mask));
                    Console.Write("                  " + itemName + " - Done ");
                    break;
                }
            }
        }

        public void iCompareWithTamplate(string inputData, List<string> result)
        {

            if (inputData == "templateMaimi")
            {
                Assert.AreEqual(zonarNunit.Data.MaximumLotCapacity.maimi.BuildingCreationsParametersTemplateArray, result);


            }
            else
            {
                if (inputData == "templateMaimi1")
                {

                    Assert.AreEqual(zonarNunit.Data.MaximumLotCapacity.maimi1.BuildingCreationsParametersTemplateArray, result);
                    
                }
                else
                {
                    if (inputData == "templateMaimiCapacityAnalisys")
                    {
                        Assert.AreEqual(zonarNunit.Data.ResultCapacityAnalysis.maimi.ResultCapacityAnalysisArray, result);
                        Console.Write(result);
                        Console.Write(zonarNunit.Data.ResultCapacityAnalysis.maimi.ResultCapacityAnalysisArray);
                    }
                }
            }   


        }


    }
}
