using OpenQA.Selenium;
using PodCheckout.Utilities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace PodCheckout.PageObject
{
    class ArgosTestingPage
    {
        public ArgosTestingPage()
        {
            driver = Hooks1.driver;
        }
        IWebDriver driver;
        IWebElement AcceptAllCookies => driver.FindElement(By.XPath("//*[@id='consent_prompt_submit']"));
        IWebElement Account => driver.FindElement(By.XPath("//*[@id='haas-v2']/div[2]/div/div[4]/a[3]/span"));
        IWebElement EmailAddress => driver.FindElement(By.XPath("//*[@id='email-address']"));
        IWebElement Password => driver.FindElement(By.XPath("//*[@id='current-password']"));
        IWebElement ArgosPage => driver.FindElement(By.XPath("//*[@id='haas-v2']/div[2]/div/div[1]/a/picture/img"));
        IWebElement SignInSecurely => driver.FindElement(By.XPath("//*[@id='main']/div/div/div/div/div/section/div[2]/div[1]/div/div/div[2]/form/button"));
        IWebElement Shop => driver.FindElement(By.XPath("//*[@id='ShopLink']"));
        IWebElement Technology => driver.FindElement(By.XPath("//*[@id='megaMenu']/li[1]/ul/ul/li[1]/a"));
        IWebElement MobilePhonesAndAccessories => driver.FindElement(By.XPath("//*[@id='findability']/div/div[7]/div/div[1]/ul/li[1]/ul/li[1]/a"));
        IWebElement SimPhoneFree => driver.FindElement(By.XPath("//*[@id='findability']/div/div[7]/div/div[1]/ul/li[1]/ul/li[1]/a"));
        IWebElement Apple => driver.FindElement(By.XPath("//*[@id='filter-brands-apple-label']/div/div/span/span"));
        IWebElement ImageWithPalmTrees => driver.FindElement(By.XPath("//*[@id='rc-imageselect']/div[2]/div[1]/div[1]"));
        IWebElement SIMFreeIPhoneSE => driver.FindElement(By.XPath("//*[@id='findability']/div/div[7]/div[1]/div[5]/div[4]/div[1]/div/div/div[1]/div[1]/a/div[2]/picture/img"));
        IWebElement ColorBlack => driver.FindElement(By.XPath("//*[@id='content']/main/div[2]/div[2]/div[1]/section[2]/section/div[10]/div/div/div/ul/li[1]/span/div"));
        IWebElement AddToTrolley => driver.FindElement(By.XPath("//*[@id='content']/main/div[2]/div[2]/div[1]/section[2]/section/div[16]/div/div[2]/button/span/span"));
        IWebElement ContinueShopping => driver.FindElement(By.XPath("//*[@id='content']/main/div[2]/div[2]/div[1]/section[2]/section/div[14]/div/div/div[1]/footer/div/div[1]/button"));

        public bool IsArgosPage { get; private set; }

        public void IClickAccount()
        {
            Thread.Sleep(5000);
            Account.Click();
        }

        public void IClickAcceptAllCookies()
        {
            AcceptAllCookies.Click();
        }


        public void IEnterEmailAddress(String EmailText)
        {
            EmailAddress.SendKeys(EmailText);
        }
        public void IEnterPassword(String PasswordText)
        {
            Thread.Sleep(5000);
            Password.SendKeys(PasswordText);
        }
        public void IClickSignInSecurely()
        {
            Thread.Sleep(3000);
            SignInSecurely.Click();
        }
        public void IClickShop()
        {
            Shop.Click();
        }
        public void IclickImageWithpalmTrees()
        {
            ImageWithPalmTrees.Click();
        }
        public void IClickTechnology()
        {
            Thread.Sleep(3000);
            Technology.Click();
        }
        public void IClickMobilePhoneAndAccessories()
        {
            Thread.Sleep(3000);
            MobilePhonesAndAccessories.Click();
        }
        public void IClickSimFreePhone()
        {
            SimPhoneFree.Click();
        }

        public void IClickApple()
        {
            Apple.Click();
        }
        public void IClickSIMFreeIPhoneSE()
        {
            SIMFreeIPhoneSE.Click();
        }
        public void IClickColorBlack()
        {
            ColorBlack.Click();
        }
        public void IClickAddTrolley()
        {
            AddToTrolley.Click();
        }

        public void IClickContinueShopping()
        {
            ContinueShopping.Click();
        }

        public void INavigateToTheWebsite(String url)
        {
            driver.Navigate().GoToUrl(url);
        }
        public bool IsArgosPageDisplayed()
        {
            Thread.Sleep(3000);
            return ArgosPage.Displayed;
        }






        }

    }
                
          
   