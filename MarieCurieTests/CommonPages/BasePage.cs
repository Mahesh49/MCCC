using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using MarieCurieTests.Pages;

namespace MarieCurieTests.CommonPages
{
   public class BasePage
    {

       public IWebDriver driver;
       

       public BasePage(IWebDriver driver)
       {
           this.driver = driver;
           PageFactory.InitElements(driver, this);
       }

       
       public void NavigateToHomePage()
       {
           driver.FindElement(By.XPath(".//*[@id='Logo']/a/span")).Click();
       }

       public void GetOnlineShop()
       {
           driver.FindElement(By.XPath("//a[contains(.,'Online shop')]")).Click();
       }

       public void GetDonationPage()
       {
           driver.FindElement(By.XPath("//a[contains(.,'Donate')]")).Click();
       }
   




    }
}
