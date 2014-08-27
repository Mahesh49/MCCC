using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using System.Collections.ObjectModel;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using System.Globalization;

namespace MarieCurieTests.CommonPages
{
    public class CommonMethods
    {
        public IWebDriver driver;

        private readonly Random _rng = new Random();
        private const string _chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private String currentWindowHandleName;
        private String popUpWindowHandleName;

    //Generating a random string
        public string RandomString(int size)
        {
            char[] buffer = new char[size];

            for (int i = 0; i < size; i++)
            {
                buffer[i] = _chars[_rng.Next(_chars.Length)];
            }
            return new string(buffer);
        }

    //Closing popups

        protected void closePopUpWindow()
        {
            driver.SwitchTo().Window(popUpWindowHandleName).Close();
            driver.SwitchTo().Window(currentWindowHandleName);
        }

    //Get popup window
        protected IWebDriver getPopUpWindow()
        {
            currentWindowHandleName = driver.CurrentWindowHandle;
            ReadOnlyCollection<string> childWindows = driver.WindowHandles;

            foreach (String windowHandle in childWindows)
            {
                if (!windowHandle.Equals(currentWindowHandleName))
                {
                    popUpWindowHandleName = windowHandle;
                }
            }
            return driver.SwitchTo().Window(popUpWindowHandleName);
        }

        //is Text present

        public Boolean containsStaticText(String text)
        {
            Thread.Sleep(1000);
            IWebElement textElement = driver.FindElement(By.XPath(""));
            return textElement.Enabled;
        }
        //is flash image present
        public Boolean isFlashImageExist(String image)
        {
            return !driver.FindElement(By.CssSelector("." + image)).GetAttribute("style").Contains("display");
        }

        //is Image present
        public Boolean isImagePresent(string errorImage)
        {
            if (errorImage.Contains("flash-"))
            {
                return isFlashImageExist(errorImage);
            }
            ReadOnlyCollection<IWebElement> images = driver.FindElements(By.CssSelector("img"));
            foreach (IWebElement elementImages in images)
            {
                String imageSrc = elementImages.GetAttribute("src");
                if (imageSrc.Contains(errorImage))
                {
                    return true;
                }
            }
            return false;
        }

        //get all values from list

        public List<string> getAllValuesFromList(IWebElement select)
        {
            List<string> allOptions = new List<string>();
            var selectElement = new SelectElement(select);
            var options = selectElement.Options;
            foreach (IWebElement option in options)
            {
                allOptions.Add(option.Text);
            }
            return allOptions;
        }

        //Select value from list
        public void selectValueFromList(IWebElement select, string textValue)
        {
            var selectElement = new SelectElement(select);
            selectElement.SelectByText(textValue);
        }

        //Validating day/month/year values
        public static String TitleCaseString(String s)
        {
            if (s == null) return s;

            String[] words = s.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length == 0) continue;

                Char firstChar = Char.ToUpper(words[i][0]);
                String rest = "";
                if (words[i].Length > 1)
                {
                    rest = words[i].Substring(1).ToLower();
                }
                words[i] = firstChar + rest;
            }
            return String.Join(" ", words);
        }

        public bool valdateDayValue(List<string> list)
        {
            for (int i = 1; i <= 31; i++)
            {
                if (!list.Contains(i.ToString()))
                {
                    return false;
                }
            }
            return true;
        }

        public bool valdateMonthValue(List<string> list)
        {
            string[] months = CultureInfo.CurrentCulture.DateTimeFormat.AbbreviatedMonthNames;
            for (int i = 0; i < 12; i++)
            {
                if (!list.Contains(TitleCaseString(months[i])))
                {
                    return false;
                }
            }
            return true;
        }

        public bool valdateYearValue(List<string> list)
        {
            DateTime currentDate = DateTime.Now;
            int yearVal = currentDate.Year + 1;
            List<int> years = Enumerable.Range(1913, yearVal - 1913).ToList();
            for (int i = 0; i < years.Count; i++)
            {
                if (!list.Contains(years[i].ToString()))
                {
                    return false;
                }
            }
            return true;
        }

        //get value from list box

        public String getValueFromListBox(IWebElement select)
        {
            var selectElement = new SelectElement(select);
            return selectElement.SelectedOption.Text;
        }

        //Mousehover

        public void mouseHoverToHelpIcon()
        {
            IWebElement informationLabel = driver.FindElement(By.Id(""));
            Actions action = new Actions(driver);
            action.MoveToElement(informationLabel).Build().Perform();
        }






    }
}
