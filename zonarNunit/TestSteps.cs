using System;
using TechTalk.SpecFlow;
using zonarNunit.Action;


namespace zonarNunit
{
    [Binding]
    public class TestSteps 
    {
        BaseAction action = new BaseAction();
        [Given(@"I have string")]
        public void GivenIHaveString()
        {

            string strin = "sss";
            string value = "s";
            strin.Contains(value);
        }
        
        [Given(@"value")]
        public void GivenValue()
        {

            string strin = "sss";
            string value = "sss";
            strin.Contains(value);
        }

        [Then(@"I have comerade")]
        public void ThenIHaveComerade()
        {
            bool result = action.findCharInString("sss", "s");
        }

    }
}
