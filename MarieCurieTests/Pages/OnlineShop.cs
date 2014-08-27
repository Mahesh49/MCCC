using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using MarieCurieTests.CommonPages;

namespace MarieCurieTests.Pages
{
   public class OnlineShop:BasePage
    {


        

        public OnlineShop(IWebDriver driver):base(driver) { }


        public void LogIn(string username,string password)
        {
            
            driver.FindElement(By.PartialLinkText("Log in")).Click();
            driver.FindElement(By.Id("ctl00_MainContent_LoginBox_EmailTextBox")).SendKeys(username);
            driver.FindElement(By.Id("ctl00_MainContent_LoginBox_PasswordTextBox")).SendKeys(password);
            driver.FindElement(By.Id("ctl00_MainContent_LoginBox_LoginButton")).Click();

            
        }

        public string getInvaliErrorMessage()
        {

           return driver.FindElement(By.Id("ctl00_MainContent_LoginBox_ValidationMessageLabel")).Text;

        }

       

       

    }
}
