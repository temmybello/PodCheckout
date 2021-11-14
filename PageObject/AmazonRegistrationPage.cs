using OpenQA.Selenium;
using PodCheckout.Utilities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace PodCheckout.PageObject
{
    class AmazonRegistrationPage
    {
        public AmazonRegistrationPage()
        {
            driver = Hooks1.driver;
        }
        IWebDriver driver;
        IWebElement AccountDropDown => driver.FindElement(By.XPath("//*[@id='nav-link-accountList']/span/span"));
        IWebElement CreateAmazonAccount => driver.FindElement(By.XPath("//*[@id='createAccountSubmit']"));
        IWebElement yourName => driver.FindElement(By.XPath("//input[@name='customerName']"));
        IWebElement Email => driver.FindElement(By.XPath("//*[@id='ap_email']"));
        IWebElement Password => driver.FindElement(By.XPath("//*[@id='ap_password']"));
        IWebElement ReEnterPassword => driver.FindElement(By.XPath("//*[@id='ap_password_check']"));
        IWebElement UserAmazonAccount => driver.FindElement(By.XPath("//*[@id='continue']"));

        public void IClickAccountDropDown()
        {
            AccountDropDown.Click();
        }
        public void IClickCreateAmazonAccount()
        {
            CreateAmazonAccount.Click();
        }
        
        public void IEnterYourName(String NameText)
        {
            yourName.SendKeys(NameText); 
        }
        public void IEnterEmail(String EmailText)
        {
            Email.SendKeys(EmailText);
        }
        public void IEnterPassword(String PasswordText)
        {
            Password.SendKeys(PasswordText);
        }

        public void IReEnterPassword(String RePasswordText)
        {
            ReEnterPassword.SendKeys(RePasswordText);
        }
        public void IClickUserAmazonAccount()
        {
            UserAmazonAccount.Click();
        }
        public void INavigateToTheWebsite(String url)
        {
            driver.Navigate().GoToUrl(url);
        }

    }
}
