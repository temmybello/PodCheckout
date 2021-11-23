using OpenQA.Selenium;
using PodCheckout.Utilities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace PodCheckout.PageObject
{
    class AbelAndColeBasketPage
    {
        public AbelAndColeBasketPage()
        {
            driver = Hooks1.driver;
        }
        IWebDriver driver;

        IWebElement Login => driver.FindElement(By.XPath("//*[@id='my-account']/div[2]/a"));
        IWebElement LogInButton => driver.FindElement(By.XPath("//input[@class='cta-button no-arrow log-in']"));
        IWebElement AcceptCookies => driver.FindElement(By.XPath("//*[@id='ccc-notify-accept']"));
        IWebElement Email => driver.FindElement(By.XPath("//*[@id='UserName']"));
        IWebElement Password => driver.FindElement(By.XPath("//*[@id='Password']"));
        IWebElement BasketCount => driver.FindElement(By.XPath("//*[@id='BasketCount']"));
        IWebElement ProductBasket => driver.FindElement(By.XPath("//*[@class='basket-product-container']"));
        IWebElement CaratDropDown => driver.FindElement(By.XPath("/html/body/div[3]/div/div[2]/div[2]/div[5]/div[2]/div[2]/div[4]/div/div[2]/div[2]/span[3]"));
        IWebElement Carat3 => driver.FindElement(By.XPath("/html/body/div[3]/div/div[2]/div[2]/div[5]/div[2]/div[2]/div[4]/div/div[2]/div[2]/div/ul/li[3]"));
        IWebElement Continue => driver.FindElement(By.XPath("//*[@class='cta-checkout-button']"));

        public void IClickCarat3()
        {
            Thread.Sleep(5000);
            Carat3.Click();
        }
        public void IClickContinue()
        {
            Thread.Sleep(5000);
            Continue.Click();
        }
        public void IclickCaratDropDown()
        {
            Thread.Sleep(3000);
            CaratDropDown.Click();
        }

        public void IClickOnBasketCount()
        {
            Thread.Sleep(3000);
            BasketCount.Click();
        }

        public bool IsProductBasketDisplayed()
        {
            Thread.Sleep(3000);
            return ProductBasket.Displayed;
        }

        public void IClickLogin()
        {
            Login.Click();
        }

        public void UserClickLogInButton()
        {
            LogInButton.Click();
        }
        public void IEnterEmail(String EmailText)
        {
            Email.SendKeys(EmailText);
        }

        public void IEnterPassword(String PasswordText)
        {
            Password.SendKeys(PasswordText);
        }
        public void IClickAcceptCookies()
        {
            Thread.Sleep(3000);
            AcceptCookies.Click();
        }

        public void INavigateToTheWebsite(String url)
        {
            driver.Navigate().GoToUrl(url);
        }





    }
}
