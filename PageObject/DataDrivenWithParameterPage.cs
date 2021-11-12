
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using PodCheckout.Utilities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace PodCheckout.PageObject
{
    class DataDrivenWithParameterPage
    {
        public DataDrivenWithParameterPage()
        {
            driver = Hooks1.driver;
        }
        IWebDriver driver;

        //Implicit Wait
        //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);


        //Fluent Wait
        //DefaultWait<IWebDriver> defaultWait = new DefaultWait<IWebDriver>(driver);
        //fluentWait.Timeout = TimeSpan.FromSeconds(5);
        //fluentWait.PollingInterval = TimeSpan.FromMilliseconds(250);


        IWebElement SignUp => driver.FindElement(By.XPath("/html/body/div/app-header/nav/div/ul[1]/li[3]/a"));
        IWebElement Username => driver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/fieldset/fieldset[1]/input"));
        IWebElement Email => driver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/fieldset/fieldset[2]/input"));
        IWebElement Password => driver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/fieldset/fieldset[3]/input"));
        IWebElement SignUpButton => driver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/fieldset/button"));
        IWebElement NewArticle => driver.FindElement(By.XPath("/html/body/div/app-header/nav/div/ul[2]/li[2]/a"));
        IWebElement ArticleTitle => driver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/fieldset/fieldset[1]/input"));
        IWebElement ArticleAbout => driver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/fieldset/fieldset[2]/input"));
        IWebElement YourArticle => driver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/fieldset/fieldset[3]/textarea"));
        IWebElement Tags => driver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/fieldset/fieldset[4]/input"));
        IWebElement Publish => driver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/fieldset/button"));
        IWebElement SignIn => driver.FindElement(By.XPath("/html/body/div/app-header/nav/div/ul[1]/li[2]/a"));
        IWebElement EmailAddress => driver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/fieldset/fieldset[2]/input"));
        IWebElement UserPassword => driver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/fieldset/fieldset[3]/input"));
        IWebElement UserSignIn => driver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/fieldset/button"));
        IWebElement UserNewArticle => driver.FindElement(By.XPath("/html/body/div/app-header/nav/div/ul[2]/li[2]/a"));

        public void ClickOnSignUp()
        {
            SignUp.Click();
        }
        public void IEnterUsername(String UsernameText)
        {
            //Random randomGenerator = new Random();
            //int ramdomInt = randomGenerator.Next(1000);
            //Username.SendKeys(UsernameText + ramdomInt);
           Username.SendKeys(UsernameText);
        }
        public void IEnterEmail(String EmailText)
        {
            //Random randomGenerator = new Random();
            //int ramdomInt = randomGenerator.Next(1000);
            //Email.SendKeys(EmailText + ramdomInt);
            Email.SendKeys(EmailText);
        }
        public void IEnterPassword(String PasswordText)
        {
            Password.SendKeys(PasswordText);
        }
        public void IClickSignUpButton()
        {
            SignUpButton.Click();
        }
        public void NavigateToWebsite(String url)
        {
            driver.Navigate().GoToUrl(url);
        }
       

        public bool IsNewArticleDisplayed()
       {
            Thread.Sleep(5000);
            return NewArticle.Displayed;
        }
        public void IClickNewArticle()
        {
            NewArticle.Click();
        }
        public void IEnterArticleTitle(String TitleText)
        {
            ArticleTitle.SendKeys(TitleText);
        }
        public void IEnterArticleAbout(String ArticleText)
        {
            ArticleAbout.SendKeys(ArticleText);
        }
        public void IEnterWriteYourArticle(String Article)
        {
            YourArticle.SendKeys(Article);
        }
        public void IEnterTags(String TagsText)
        {
            Tags.SendKeys(TagsText);
        }
        public void IClickPublish()
        {
            Publish.Click();
        }
        public void IClickSignIn()
        {
            SignIn.Click();
        }
        public void UserEmailAddress(String EmailText)
        {
            EmailAddress.SendKeys(EmailText);
        }
        public  void UserEnterPassword(String PasswordText)
        {
            Password.SendKeys(PasswordText);
        }
        public void UserClickSignIn()
        {
            SignIn.Click();
        }
        public void UserClickNewArticle()
        {
            NewArticle.Click();
        }
    }
}
