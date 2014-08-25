using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;

namespace MarieCurieTests.Pages
{
   public class OnlineShop
    {


        public BasePage basepage;
        public IWebDriver driver;

        public OnlineShop()
        {
            driver = WebBrowser.Current;
            basepage = new BasePage();

        }

       

       

    }
}
