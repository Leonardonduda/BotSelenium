using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotSelenium
{
    internal class AutomationWeb
    {
        public IWebDriver driver;

        public AutomationWeb() 
       {
            driver = new ChromeDriver();
       }
        public string TestWeb() 
        {
            driver.Navigate().GoToUrl("https://www.google.com");

            driver.FindElement(By.Name("q")).SendKeys("Hello World");

            driver.FindElement(By.XPath("/html/body/div[1]/div[3]/form/div[1]/div[1]/div[4]/center/input[1]")).Click();

            var text = driver.FindElement(By.XPath("//*[@id=\"rso\"]/div[3]/div/div/div[3]/div")).Text;

            return text;


        }
    }
}
