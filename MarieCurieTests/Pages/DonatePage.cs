using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using MarieCurieTests.CommonPages;
using OpenQA.Selenium.Support.PageObjects;

namespace MarieCurieTests.Pages
{
    public class DonatePage:BasePage
    {

        public DonatePage(IWebDriver driver) : base(driver) { }

        [FindsBy(How = How.XPath,Using=".//*[@id='ContentAreaWithSubMenu']/div[3]/div[1]/div/div[2]/div[1]/a[1]")]
        private IWebElement RegularDonation;


        public void MakeRegularDonation()
        {
            //driver.FindElement(By.XPath(".//*[@id='ContentAreaWithSubMenu']/div[3]/div[1]/div/div[2]/div[1]/a[1]")).Click();
            RegularDonation.Click();
        }

        public void MakeOneoffDonation()
        {

            driver.FindElement(By.XPath(".//*[@id='ContentAreaWithSubMenu']/div[3]/div[1]/div/div[2]/div[1]/a[2]")).Click();
        }

        public string getDonationText()
        {
            return driver.FindElement(By.XPath(".//*[@id='Layout1Right']/div[1]/h1/span")).Text;
        }

        
        

        
    }
}
