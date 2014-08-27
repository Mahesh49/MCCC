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

       [FindsBy(How = How.Id)]
       [CacheLookup]     //keeps the element in driver cache
       private IWebElement Logo;  //Id=Logo ,Webelement name could be anything

       [FindsBy(How = How.Id,Using="shopping")]
       private IWebElement Shopping;

       [FindsBy(How = How.Id)]
       private IWebElement donate;
       

       public BasePage(IWebDriver driver)
       {
           this.driver = driver;
           PageFactory.InitElements(driver, this);
       }

       
       public void NavigateToHomePage()
       {
                          
           Logo.Click();

       }

       public void GetOnlineShop()
       {
           Shopping.Click();
       }

       public void GetDonationPage()
       {
           NavigateToHomePage();
           donate.Click();
       }
   




    }
}
