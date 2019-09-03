using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTest1
{
    class Program
    {
        static void Main(string[] args)
        {

            //ChromeOptions options = new ChromeOptions();   
            //options.AddArguments("-incognito");
            //driver1 = new ChromeDriver(options);     
            IWebDriver driver1 = new ChromeDriver();
            driver1.Navigate().GoToUrl("https://pubs.payoneer.com/Error/ErrorPage.html?err=137-20190819-98983");


           
            driver1.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver1.Navigate().GoToUrl("https://payouts.sandbox.payoneer.com/partners/or.aspx?pid=Y0LwV0AQC7cY%2b5AIqsZl1g%3d%3d%20&amp;langid=1");
         
            //driver1.FindElement(By.CssSelector("body")).SendKeys(Keys.Control + "t");
            
            IWebElement firstRadioBtn = driver1.FindElement(By.Id("accountType_Company"));
            firstRadioBtn.Click();

            IWebElement companyName = driver1.FindElement(By.Name("ctl00$cphBodyContent$PersonalDetails1$txtCompanyName"));
            companyName.SendKeys("Amazon");



            // select the drop down list

            // select the drop down list
            SelectElement ss = new SelectElement(driver1.FindElement(By.Id("ctl00$cphBodyContent$PersonalDetails1$ddlBusinessOrganization")));

            ss.SelectByText("Private Coroparation");
    
            

        }
    }
}
