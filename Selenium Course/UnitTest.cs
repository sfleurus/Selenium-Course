using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Course

{
    class UnitTest
    {
        [Test]
        public void LaunchWebSite()
        {
            IWebDriver Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl("http://www.newtours.demoaut.com/mercurywelcome.php?osCsid=b2bc7c82f7ddc92fd096f39495d0e9f8");
            Driver.Manage().Window.Maximize();

        }

        [Test]
        public void CreateAccount()
        {
            IWebDriver Driver = new ChromeDriver();
            Driver.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[2]/td/table/tbody/tr/td[2]/a")).Click();
            Driver.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[2]/td[2]/input")).SendKeys("Sebastien");
            Driver.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[3]/td[2]/input")).SendKeys("Fleurus");
            Driver.FindElement(By.Name("phone")).SendKeys("Fleurus");
            Driver.FindElement(By.Name("userName")).SendKeys("Fleurus");
            IWebElement SelectDropDownCountry = Driver.FindElement(By.XPath("//select[@name='country']"));
            SelectElement Country = new SelectElement(SelectDropDownCountry);
            Country.SelectByText("FRANCE ");
            Driver.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[18]/td/input")).Click();

        }

    }


  
    

    {
    }
}

