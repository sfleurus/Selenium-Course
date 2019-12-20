using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Course
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl("https://www.prolifics-testing.com/");
            Driver.Manage().Window.Maximize();
            //Page load time
            Driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);
            //Implicite Wait
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10)

            Driver.Navigate().Back();
            Driver.Navigate().Forward();
            string Title = Driver.Title;
            String URL = Driver.Url;
            // Driver.Close();
            // Driver.Quit();
            // Driver.FindElement(By.Name("_nkw")).SendKeys("Adidas");
            // Driver.FindElement(By.Id("gh-btn")).Click();

            //(//a[@href='/training'])[1]
            //ul[@class='main-nav-list']/li[1]/a
            //spam[text]='More'

            //Driver.FindElement(By.ClassName("site-header__more-text")).Click();
            //int NavList = Driver.FindElements(By.CssSelector("main-nav-list")).Count;
            String ListMain1 = "Functional Testing";
            String ListMain2 = "Performance Testing";
            String ListMain3 = "Consultancy";
            String ListMain4 = "Training;";
            // bool MainList = Driver.FindElement(By.XPath("//ul[@class = 'main-nav-list'] / li[1] / a")).Displayed;


            int[] interray = new int[4];
            interray[0] = 100;
            interray[1] = 200;
            interray[2] = 300;
            for (int i = 0; i < interray.Length - 1; i++)
            {
                Console.WriteLine(interray[i]);
            }
            System.Threading.Thread.Sleep(5000);

            List<string> Dinosaurs = new List<string>();
            Dinosaurs.Add("Seb");
            Dinosaurs.Add("Mahesh");

            for (int r = 0; r <= Dinosaurs.Count - 1; r++)
            {
                Console.WriteLine(Dinosaurs[r]);
                Console.WriteLine(Dinosaurs[r].Length);
            }

            IWebElement ele = Driver.FindElement(By.XPath("//ul[@class='main-nav-list']/li[1]/a"));
            test.Click();

            IReadOnlyCollection<IWebElement> elements = Driver.FindElements(By.XPath("//ul[@class='main-nav-list']/li[1]/a"));

            foreach (IWebElement eles in elements)
            {

                string text = eles.Text;
                Console.WriteLine("Text is" + text);

            }
            System.Threading.Thread.Sleep(5000);

            //Select Drop Down

            Driver.FindElement(By.XPath("//a[text()='REGISTER']")).Click();
            IWebElement SelectDropDown = Driver.FindElement(By.XPath("//select[@name='country']"));
            SelectElement d = new SelectElement(SelectDropDown);
            d.SelectByText("FRANCE ");

            //Hover over a text
            IWebElement Link1 = Driver.FindElement(By.XPath("(//a[test()='Electronics'])[2]"));
            IWebElement Link2 = Driver.FindElement(By.XPath("//a[test()='News']"));
            //Explicite Wait
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementToBeClickable(Link1));

            Actions Act = new Actions(Driver);
            Act.MoveToElement(Link1).Build().Perform();
            //Drag and Drop
            Act.DragAndDrop(Link1, Link2).Build().Perform();
        }
    }
    }

}
