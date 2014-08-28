using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using MarieCurieTests.Pages;
using OpenQA.Selenium;
using MarieCurieTests.CommonPages;
using System.Diagnostics;

namespace MarieCurieTests.StepDefinitions
{
    [Binding]
    public class AllGiven : CommonSteps
    {

        [Given(@"I enter homepage url")]
        public void GivenIEnterHomepageUrl()
        {
            homepage.NavigateToHomePage();
        }

        [Given(@"I am on OnlineShop page")]
        public void GivenIAmOnOnlineShopPage()
        {
            basepage.GetOnlineShop();
        }


        [Given(@"I am on Donation Page")]
        public void GivenIAmOnDonationPage()
        {
            basepage.GetDonationPage();
        }


        [Given(@"I am on Shop Page")]
        public void GivenIAmOnShopPage()
        {
            driver.Navigate().GoToUrl("https://www.mariecurie.org.uk/fundraising-volunteering/volunteer/ways-to-volunteer/volunteer-marie-curie-shop/search-detail/?type=shop&key=E4338&dist=10.7");

        }





    }
}
