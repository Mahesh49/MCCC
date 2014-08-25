using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;

namespace MarieCurieTests.Pages
{
    class DonatePage
    {


        
        public BasePage basepage;
        public IWebDriver driver;

        public DonatePage()
        {
            driver = WebBrowser.Current;
            basepage = new BasePage();

        }
    }
}
