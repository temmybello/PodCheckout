using OpenQA.Selenium;
using PodCheckout.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PodCheckout.PageObject
{
    class DataDrivenWithExamplePage
    {
        public DataDrivenWithExamplePage()
        {
            driver = Hooks1.driver;
        }
        IWebDriver driver;
        
        IWebElement Username => driver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/fieldset/fieldset[1]/input"));
        IWebElement Email => driver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/fieldset/fieldset[2]/input"));
        IWebElement Password => driver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/fieldset/fieldset[3]/input"));



        public void EnterUsername(String username)
        {
            //Random randomGenerator = new Random();
            //int ramdomInt = randomGenerator.Next(1000);
            //Username.SendKeys(UsernameText + ramdomInt);
            Username.SendKeys(username);
            //username.sendKeys(username);
        }
        public void UserEnterEmail(String email)
        {
            //Random randomGenerator = new Random();
            //int ramdomInt = randomGenerator.Next(1000);
            //Email.SendKeys(EmailText + ramdomInt);
            Email.SendKeys(email);
        }
        public void UserEnterPassword(String password)
        {
            Password.SendKeys(password);
        }

        public void NavigateToWebsite(String url)
        {
            driver.Navigate().GoToUrl(url);
        }



















    }
}

