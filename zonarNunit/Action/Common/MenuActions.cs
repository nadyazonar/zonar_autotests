using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zonarNunit.Locators;

namespace zonarNunit.Action
{
     public  class MenuActions : BaseAction
    {
        public void ProgectPageIsOpened()
        {
            waitForElementPresent(ProjectPageLocators.zoningAllowances);
            waitForElementPresent(ProjectPageLocators.capacityAnalysis);
            
        }
    }
}
