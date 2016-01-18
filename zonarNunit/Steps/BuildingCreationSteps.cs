using System;
using TechTalk.SpecFlow;
using zonarNunit.Steps;
using zonarNunit.Data;
using System.Collections.Generic;


namespace zonarNunit
{
    [Binding]
    public class BuildingCreationSteps : BaseSteps
    {

        private List<string> result;
        //Given


        [Given(@"I have Opened My Buildings Tab")]
        public void GivenIHaveOpenedMyBuildingsTab()
        {
            actionsAccountPages.iHaveOpenedMyBuildingsTab();
            actionsAccountPages.getOldList();

        }
        
        [Given(@"I Have Opened Project Page")]
        public void GivenIHaveOpenedProjectPage()
        {
            actionsAccountPages.mainPageWithLoginUser();
            actionsAccountPages.iHaveOpenedMyBuildingsTab();
            actionsAccountPages.iClickCreateBuildingButton();
            actionsAccountPages.iFillInFieldsOnCreateBuildingsForm(BuildingCreationsParameters.maimi);
            //actionsMenu.ProgectPageIsOpened();
            
        }


        [Given(@"I create project with Input Data")]
        public void GivenICreateProjectWithInputData()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I link to Capacity Analysis Tab")]
        public void GivenILinkToCapacityAnalysisTab()
        {
            ScenarioContext.Current.Pending();
        }

        //When
        [When(@"I Have ""(.*)""")]
        public void WhenIHave(string zoningData)
        {
            actionsAccountPages.inputZoningData(zoningData);
        }

        [When(@"I Click Create building Button")]
        public void WhenIClickCreateBuildingButton()
        {
            actionsAccountPages.iClickCreateBuildingButton();
        }
        
        [When(@"I Fill-in Fields on Create buildings form")]
        public void WhenIFill_InFieldsOnCreateBuildingsForm()
        {
            actionsAccountPages.iFillInFieldsOnCreateBuildingsForm(BuildingCreationsParameters.maimi);
        }
        
        [When(@"I Click Save Button")]
        public void WhenIClickSaveButton()
        {
            actionsProjectPage.iClickSaveButton();
        }
        
        [When(@"I Have Opened Tab Zoning Allowances")]
        public void WhenIHaveOpenedTabZoningAllowances()
        {
            actionsProjectPage.iHaveOpenedTabZoningAllowances();
        }
       
        
        [When(@"I Have Opened Tab Capacity Analysis")]
        public void WhenIHaveOpenedTabCapacityAnalysis()
        {
            actionsProjectPage.iHaveOpenedTabCapacityAnalysis();
        }
        
        [When(@"I Set Case Study Calibratuion section to Average values")]
        public void WhenISetCaseStudyCalibratuionSectionToAverageValues()
        {
            
            actionsProjectPage.iSetCaseStudyCalibratuionSectionToAverageValues("Dwelling Units", "100");
            actionsProjectPage.iSetCaseStudyCalibratuionSectionToAverageValues("Dwelling Unit Average Gross Area", "1000");
            actionsProjectPage.iSetCaseStudyCalibratuionSectionToAverageValues("Lodging Rooms", "100");
            actionsProjectPage.iSetCaseStudyCalibratuionSectionToAverageValues("Lodging Room Average Gross Area", "100");
            actionsProjectPage.iSetCaseStudyCalibratuionSectionToAverageValues("Office", "5000");
            actionsProjectPage.iSetCaseStudyCalibratuionSectionToAverageValues("Commercial", "5000");


        }

        [When(@"I link to My Building Tab")]
        public void WhenILinkToMyBuildingTab()
        {
            actionsProjectPage.iLinkToMyBuildingTab();
        }

        [When(@"I have Delete Project")]
        public void WhenIHaveDeleteProject()
        {
            actionsBase.reloadPage();
            actionsAccountPages.iHaveDeleteProject();
        }


        [When(@"I have Opened Resukt Table on Capacity Analisis Tab")]
        public void WhenIHaveOpenedResuktTableOnCapacityAnalisisTab()
        {
            actionsProjectPage.iHaveOpenedResuktTableOnCapacityAnalisisTab();
        }




        [When(@"I Set ""(.*)"" to Calibratuion section Use Program Tab")]
        public void WhenISetToCalibratuionSectionUseProgramTab(string dataUseProgram)
        {
            actionsProjectPage.iSetCaseStudyCalibratuionSectionToAverageValues("Dwelling Units", "100");
            actionsProjectPage.iSetCaseStudyCalibratuionSectionToAverageValues("Dwelling Unit Average Gross Area", "1000");
            actionsProjectPage.iSetCaseStudyCalibratuionSectionToAverageValues("Lodging Rooms", "100");
            actionsProjectPage.iSetCaseStudyCalibratuionSectionToAverageValues("Lodging Room Average Gross Area", "100");
            actionsProjectPage.iSetCaseStudyCalibratuionSectionToAverageValues("Office", "5000");
            actionsProjectPage.iSetCaseStudyCalibratuionSectionToAverageValues("Commercial", "5000");
        }


        [When(@"I have Setup Building Parameters")]
        public void WhenIHaveSetupBuildingParameters()
        {

        }

        [When(@"I get zoningResult Maximum Lot Capacity Table data")]
        public List<string> WhenIGetZoningResultMaximumLotCapacityTableData()
        {
            result = actionsProjectPage.iGetResultFromRightTable(Data.MaximumLotCapacity.maximumLotCapacity.BuildingCreationsParametersTemplateArray);
            System.Threading.Thread.Sleep(1000);
            return result;

        }


        [When(@"I get zoningResult Result from Capasity Analisys")]
        public List<string> WhenIGetZoningResultResultFromCapasityAnalisys()
        {
            result = actionsProjectPage.iGetResultFromRightTable(Data.ResultCapacityAnalysis.resultCapacityAnalysis.ResultCapacityAnalysisArray);
            System.Threading.Thread.Sleep(1000);
            return result;
        }



        [When(@"I set ""(.*)"" Case Study Calibration")]
        public void WhenISetCaseStudyCalibration(string p0)
        {
            ScenarioContext.Current.Pending();
        }





        //Then



        [Then(@"Progect Page is opened")]
        public void ThenProgectPageIsOpened()
        {
            actionsMenu.ProgectPageIsOpened();
        }
        
        [Then(@"Values with right formats are displayed")]
        public void ThenValuesWithRightFormatsAreDisplayed()
        {
            actionsProjectPage.checkingValuesOnZoningAllowancestab(projectPageData.lotArea, projectPageData.lotAreaMask);
            actionsProjectPage.checkingValuesOnZoningAllowancestab(projectPageData.lotAreaInAcres, projectPageData.lotAreaInAcresMask);
            actionsProjectPage.checkingValuesOnZoningAllowancestab(projectPageData.dwellingUnitsPerAcre, projectPageData.dwellingUnitsPerAcreMask);
            actionsProjectPage.checkingValuesOnZoningAllowancestab(projectPageData.far, projectPageData.farMask);
            actionsProjectPage.checkingValuesOnZoningAllowancestab(projectPageData.lotCoverage, projectPageData.lotCoverageMask);
            actionsProjectPage.checkingValuesOnZoningAllowancestab(projectPageData.minOpenSpace, projectPageData.minOpenSpaceMask);
            actionsProjectPage.checkingValuesOnZoningAllowancestab(projectPageData.principalBuildingHeightMax, projectPageData.principalBuildingHeightMaxMask);
            actionsProjectPage.checkingValuesOnZoningAllowancestab(projectPageData.principalBuildingHeightMin, projectPageData.principalBuildingHeightMinMask);
            actionsProjectPage.checkingValuesOnZoningAllowancestab(projectPageData.principalTowerHeight, projectPageData.principalTowerHeightMask);
            actionsProjectPage.checkingValuesOnZoningAllowancestab(projectPageData.maximumBuiltArea, projectPageData.maximumBuiltAreaMask);
            actionsProjectPage.checkingValuesOnZoningAllowancestab(projectPageData.maxBuildingArea, projectPageData.maxBuildingAreaMask);
            actionsProjectPage.checkingValuesOnZoningAllowancestab(projectPageData.maximumBuildingFootprint, projectPageData.maximumBuildingFootprintMask);
            actionsProjectPage.checkingValuesOnZoningAllowancestab(projectPageData.maximumOfficeArea, projectPageData.maximumOfficeAreaMask);
            //actionsProjectPage.checkingValuesOnZoningAllowancestab(projectPageData.maximumOfficeHeight, projectPageData.maximumOfficeHeightMask);
            actionsProjectPage.checkingValuesOnZoningAllowancestab(projectPageData.maximumCommercialArea, projectPageData.maximumCommercialAreaMask);
            //actionsProjectPage.checkingValuesOnZoningAllowancestab(projectPageData.maximumCommercialHeight, projectPageData.maximumCommercialHeightMask);
            actionsProjectPage.checkingValuesOnZoningAllowancestab(projectPageData.maxCommercialEstablishmentArea, projectPageData.maxCommercialEstablishmentAreaMask);
            

        }

        [Then(@"Project is deleted")]
        public void ThenProjectIsDeleted()
        {

            actionsAccountPages.projectIsDeleted();
            //actions.projectIsDeleted();
        }
        
        [Then(@"Values with right formats are displayed on Tab Capacity Analysis")]
        public void ThenValuesWithRightFormatsAreDisplayedOnTabCapacityAnalysis()
        {


            actionsProjectPage.checkingValuesOnZoningAllowancestab(projectPageData.maxBuildingFootprint, projectPageData.maxBuildingFootprintMask);
            actionsProjectPage.checkingValuesOnZoningAllowancestab(projectPageData.maxBuildingFootprint, projectPageData.maxBuildingFootprintMask);
        }

        [Then(@"Project is saved")]
        public void ThenProjectIsSaved()
        {
            actionsAccountPages.projectIsSaved();
        }


       

        

        [Then(@"I compare with ""(.*)""")]
        public void ThenICompareWith(string templateData)
        {
            actionsProjectPage.iCompareWithTamplate(templateData, result);
        }

        [Then(@"I have ""(.*)"" are displayed")]
        public void ThenIHaveAreDisplayed(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I get ""(.*)"" Result Data")]
        public void ThenIGetResultData(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        //[Then(@"I compare ""(.*)"" with ""(.*)""")]
        //public void ThenICompareWith(string p0, string p1)
        //{
        //    ScenarioContext.Current.Pending();
        //}
    }
}
