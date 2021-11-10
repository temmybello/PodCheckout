using OpenQA.Selenium;
using PodCheckout.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PodCheckout.PageObject
{
    class DataDrivenWithParameterFormPage
    {
       public DataDrivenWithParameterFormPage()
        {
            driver = Hooks1.driver;
        }

        IWebDriver driver;

        IWebElement NewArticle => driver.FindElement(By.CssSelector("body > div > app-header > nav > div > ul:nth-child(3) > li:nth-child(2) > a"));
        IWebElement ArticleTitle => driver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/fieldset/fieldset[1]/input"));
        IWebElement ArticleAbout => driver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/fieldset/fieldset[2]/input"));
        IWebElement YourArticle => driver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/fieldset/fieldset[3]/textarea"));
        IWebElement Tags => driver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/fieldset/fieldset[4]/input"));
        IWebElement Publish => driver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/fieldset/button"));
        IWebElement SignIn => driver.FindElement(By.XPath("/html/body/div/app-header/nav/div/ul[1]/li[2]/a"));
        IWebElement EmailAddress => driver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/fieldset/fieldset[2]/input"));
        IWebElement UserPassword => driver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/fieldset/fieldset[3]/input"));
        

        public void IClickSignIn()
        {
            SignIn.Click();
        }
        public void UserEmailAddress(String EmailText)
        {
            EmailAddress.SendKeys(EmailText);
        }
        public void UserEnterPassword(String PasswordText)
        {
           UserPassword.SendKeys(PasswordText);
        }
        public void UserClickSignIn()
        {
            SignIn.Click();
        }
        public void UserClickNewArticle()
        {
            NewArticle.Click();
        }
        public void NavigateToWebsite(String url)
        {
            driver.Navigate().GoToUrl(url);
        }





    }
}
