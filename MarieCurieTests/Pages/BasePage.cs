using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;

namespace MarieCurieTests.Pages
{
   public class BasePage
    {

       static IWebDriver driver = WebBrowser.Current;

       public void getHomePage()
       {

           driver.Navigate().GoToUrl("http://www.mariecurie.org.uk/");
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
