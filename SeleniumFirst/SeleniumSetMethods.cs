using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFirst
{
    public static class SeleniumSetMethods
    {
        //Enter Text Method
        public static void EnterText(this IWebElement element, String value)
        {
            element.SendKeys(value);
        }

        public static void Clicks(this IWebElement element)
        {
            element.Click();
        }

        public static void SelectDropDown(this IWebElement element, String value)
        {
            new SelectElement(element).SelectByText(value);

        }
    }
}
