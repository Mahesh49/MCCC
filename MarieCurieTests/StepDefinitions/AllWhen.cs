using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace MarieCurieTests.StepDefinitions
{
    [Binding]
    public class AllWhen:CommonSteps
    {

        
        [When(@"I enter invalid username ""(.*)"" and password ""(.*)""")]
        public void WhenIEnterInvalidUsernameAndPassword(string p0, string p1)
        {
            
            onlineshop.LogIn(p0,p1);
        }


        [When(@"I choose donation type ""(.*)""")]
        public void WhenIChooseDonationType(string p0)
        {
            if (p0 == "Make a regular donation")
            {
                donatepage.MakeRegularDonation();
            }
            else
                donatepage.MakeOneoffDonation();
        }




    }
}
