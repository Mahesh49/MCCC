using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace MarieCurieTests.StepDefinitions
{
    [Binding]
    public class SharedSteps : CommonSteps
    {


        [AfterScenario]
        public void CloseBrowser()
        {

            driver.Close();

        }
    }
}
