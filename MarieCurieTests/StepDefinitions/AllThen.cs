using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using MarieCurieTests.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MarieCurieTests.StepDefinitions
{
    [Binding]
    public class AllThen
    {

        public HomePage homepage;
        public AllThen()
        {
            homepage = new HomePage();

        }

        [Then(@"I should see Homepage")]
        public void ThenIShouldSeeHomepage()
        {
            Assert.AreEqual("Marie Curie Cancer Care", homepage.getHomePageTitle());
        }



       

    }
}
