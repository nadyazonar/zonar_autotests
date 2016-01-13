using System;
using TechTalk.SpecFlow;
using zonarNunit.Steps;


namespace zonarNunit
{
    [Binding]
    public class AccountAccountSettingsSteps : BaseSteps
    {

        //Given start
        [Given(@"I Have Main Page With Login User")]
        public void GivenIHaveMainPageWithLoginUser()
        {
            actionsAccountPages.mainPageWithLoginUser();
        }

        [Given(@"I have opened Account Setting Tab")]
        public void GivenIHaveOpenedAccountSettingTab()
        {
            actionsAccountPages.openedAccountSettingTab();
        }
        // Given end


        // When start
        [When(@"I set new Name on First name and Last name field")]
        public void WhenISetNewNameOnFirstNameAndLastNameField()
        {
            actionsAccountPages.setNewNameOnFirstNameAndLastNameField();
        }
        
        [When(@"Click Update button")]
        public void WhenClickUpdateButton()
        {
            actionsAccountPages.clickUpdateButton();
        }
        
        [When(@"Reload page")]
        public void WhenReloadPage()
        {
            actionsBase.reloadPage();
        }
        // When end


        // Then start
        [Then(@"new Names are saved")]
        public void ThenNewNamesAreSaved()
        {
            actionsAccountPages.newNamesAreSaved();
        }

        [Then(@"The result Account Page is Opened")]
        public void ThenTheResultAccountPageIsOpened()
        {
            
        }

        [Then(@"I see my name in a conner")]
        public void ThenISeeMyNameInAConner()
        {
            actionsAccountPages.logoutQuitDriver();
        }

        [Then(@"Quite Driver")]
        public void ThenQuiteDriver()
        {
            actionsAccountPages.logoutQuitDriver();
        }
        // Then end
    }
}
