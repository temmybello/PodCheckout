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
        IWebElement AcceptCookies => driver.FindElement(By.XPath("//*[@id='sp-cc-accept']"));
        IWebElement yourName => driver.FindElement(By.XPath("//input[@name='customerName']"));
        IWebElement Email => driver.FindElement(By.XPath("//*[@id='ap_email']"));
        IWebElement Password => driver.FindElement(By.XPath("//*[@id='ap_password']"));
        IWebElement ReEnterPassword => driver.FindElement(By.XPath("//*[@id='ap_password_check']"));
        IWebElement UserAmazonAccount => driver.FindElement(By.XPath("//*[@id='continue']"));
        IWebElement AmazonCoUk => driver.FindElement(By.XPath("//*[@id='nav-logo-sprites']"));
        IWebElement HelloSignIn => driver.FindElement(By.XPath("//*[@id='nav-link-accountList-nav-line-1']"));
        IWebElement AllDropDown => driver.FindElement(By.XPath("//*[@id='nav-hamburger-menu']"));
        IWebElement SignIn => driver.FindElement(By.XPath("//*[@id='nav-signin-tooltip']/a/span"));
        IWebElement UserEmail => driver.FindElement(By.XPath("//*[@id='ap_email']"));
        IWebElement Continue => driver.FindElement(By.XPath("//*[@id='continue']"));
        IWebElement SignInPassword => driver.FindElement(By.XPath("//*[@id='ap_password']"));
        IWebElement UserSignIn => driver.FindElement(By.XPath("//*[@id='signInSubmit']"));
        IWebElement SignedIn => driver.FindElement(By.XPath("//*[@id='authportal-main-section']/div[2]/div/div/div/form/div/div[2]/div/div/label/div/label"));
        IWebElement BestSellers => driver.FindElement(By.XPath("//*[@id='hmenu-content']/ul[1]/li[2]/a"));
        public void IClickAccountDropDown()
        {
            AccountDropDown.Click();
        }
        public void IClickCreateAmazonAccount()
        {
            CreateAmazonAccount.Click();
        }
        public void IClickAceeptCookies()
        {
            Thread.Sleep(3000);
            AcceptCookies.Click();
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
        public bool IsAmazonCoUkDisplayed()
        {
            return AmazonCoUk.Displayed;
        }
        public void IClickAllDropDown()
        {
            AllDropDown.Click();
        }
        public void IClickHelloSignIn()
        {
            HelloSignIn.Click();
        }
        public void IClickSignIn()
        {
            Thread.Sleep(5000);
            SignIn.Click();
        }
        public void IEnterUserEmail(String EmailText)
        {
            UserEmail.SendKeys(EmailText);
        }
        public void IClickContinue()
        {
            Thread.Sleep(3000);
            Continue.Click();
        }
        public void IEnterSignInPassword(String PasswordText)
        {
            Thread.Sleep(5000);
            SignInPassword.SendKeys(PasswordText);
        }
        public void IClickUserSignIn()
        {
            UserSignIn.Click();
        }
        public void IClickSignedIn()
        {
            SignedIn.Click();
        }
        public void IClickBestSellers()
        {
            BestSellers.Click();
        }
        public void INavigateToTheWebsite(String url)
        {
            driver.Navigate().GoToUrl(url);
        }

    }
}
