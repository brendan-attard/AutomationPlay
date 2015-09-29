using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFirst
{
    class Program
    {


        static void Main(string[] args)
        {
             
        }

        [SetUp]
        public void Initialize()
        {
            PropertiesCollection.driver = new ChromeDriver();

            //Create the ref for browser
            //Nav to Google page
            PropertiesCollection.driver.Navigate().GoToUrl("http://executeautomation.com/demosite/Login.html");
            Console.WriteLine("Opened URL");

        }

        [Test]
        public void ExecuteTest()
        {

            ExcelLib.PopulateInCollection(@"U:\Data.xlsx");
            
            //Login to App

            LoginPageObject pageLogin = new LoginPageObject();
            EAPageObject pageEA = pageLogin.Login(ExcelLib.ReadData(1, "UserName"), ExcelLib.ReadData(1, "Password"));

            pageEA.FillUserForm(ExcelLib.ReadData(1, "MiddleName"), ExcelLib.ReadData(1, "FirstName"), ExcelLib.ReadData(1, "MiddleName"));

            //page.txtInitial.SendKeys("executeautomation");

            //page.btnSave.Click();
            
            //Title
            //SeleniumSetMethods.SelectDropDown("TitleId", "Mr.", PropertyType.Id);

            //SeleniumSetMethods.EnterText("Initial", "executeautomation", PropertyType.Name);

            //Console.WriteLine("The value from my title is: " + SeleniumGetMethods.GetTextFromDDL("TitleId", PropertyType.Id));

            //Console.WriteLine("The value from my Initial is: " + SeleniumGetMethods.GetText("Initial", PropertyType.Name));

            //SeleniumSetMethods.Click("Save", PropertyType.Name);

        }

        [TearDown]
        public void CleanUp()
        {
            PropertiesCollection.driver.Close();
            Console.WriteLine("Closed the browser");
        }

        

    }
}
