using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using PodCheckout.Utilities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace PodCheckout.PageObject
{
    class AbelShoppingLoginPage
    {
            public AbelShoppingLoginPage()
            {
                driver = Hooks1.driver;
            }
            IWebDriver driver;

            IWebElement Login => driver.FindElement(By.XPath("//*[@id='my-account']/div[2]/a"));
            IWebElement LogInButton => driver.FindElement(By.XPath("//input[@class='cta-button no-arrow log-in']"));
            IWebElement AcceptCookies => driver.FindElement(By.XPath("//*[@id='ccc-notify-accept']"));
            IWebElement Email => driver.FindElement(By.XPath("//*[@id='UserName']"));
            IWebElement Password => driver.FindElement(By.XPath("//*[@id='Password']"));
            IWebElement FruitAndVegDropDown => driver.FindElement(By.XPath("//*[@id='menu-parent']/ul/li[1]"));
            IWebElement Search => driver.FindElement(By.XPath("//*[@id='search-term']"));
            IWebElement FruitVegBoxes => driver.FindElement(By.XPath("//*[@class='push-banner']"));
            IWebElement TropicalFruit => driver.FindElement(By.XPath("//*[@id='product-list']/li[1]/div[3]/div[1]/a"));
            IWebElement  BasketIcon => driver.FindElement(By.XPath("//*[@class='icon-basket basket-quantity']"));
            IWebElement TextBoxQuatity => driver.FindElement(By.XPath("//*[@id='main-inner']/div[3]/div[1]/form/div/div[3]/div[2]"));
            IWebElement AddSignPlus => driver.FindElement(By.XPath("//*[@class='add-sign plus']"));
            IWebElement Add => driver.FindElement(By.XPath("//*[@class='add cta-button']"));
            IWebElement BasketSuccessfully => driver.FindElement(By.XPath("//*[@class='in-basket basket-quantity']"));
            IWebElement ProductBasket => driver.FindElement(By.XPath("//*[@class='basket-product-container']"));
            IWebElement Carat => driver.FindElement(By.XPath("(//*[@class='carat'])[3]"));
            IWebElement CaratNumber => driver.FindElement(By.XPath("/html/body/div[3]/div/div[2]/div[2]/div[5]/div[3]/div[2]/div[4]/div/div[2]/div[2]/div/ul/li[4]"));
            IWebElement Continue => driver.FindElement(By.XPath("//*[@class='cta-checkout-button']"));
            IWebElement BasketButton => driver.FindElement(By.XPath("//*[@id='basket-icon']/div"));
        IWebElement DropDown => driver.FindElement(By.XPath("(//*[@class='dropdown'])[2]"));
        
        
        
        public IWebElement SelectNumber { get; private set; }

        public void IClickDropDown()
        {
            DropDown.Click();
        }

        public void IClickCaratNumber()
        {
            CaratNumber.SendKeys("5");
        }
        public void IclickBasketButton()
        {
            BasketButton.Click();
        }

        public void IClickBasketIcon()
        {
            BasketIcon.Click();
        }

        public bool IConfirmBasketAddedSuccessfully()
        {
            Thread.Sleep(3000);
            return BasketSuccessfully.Displayed;
        }
       public void IclickCarat()
        {
            Thread.Sleep(3000);
            Carat.Click();
        }
        public bool IsProductBasketDisplayed()
        {
            Thread.Sleep(3000);
            return ProductBasket.Displayed;
        }
       
        public void ISelectCaratNumber()
        {
            Thread.Sleep(3000);
            SelectElement select = new SelectElement(SelectNumber);
            select.SelectByValue("3");
        }
        public void IClickContinue()
        {
            Thread.Sleep(5000);
            Continue.Click();
        }
       
        
        public void IClickAdd()
        {
            Thread.Sleep(5000);
            Add.Click();
        }

        public bool IConfirmProductBasketIsDisplayed()
        {
            return ProductBasket.Displayed;
        }
        public void IClickTextBoxQuatity()
        {
            TextBoxQuatity.Click();
        }
        public void IClickTropicalFruit()
        {
            Thread.Sleep(3000);
            TropicalFruit.Click();
        }

        public void IClickFruitVegBoxes()
        {
            Thread.Sleep(3000);
            FruitVegBoxes.Click();
        }

        public void IClickLogin()
        {
            Login.Click();
        }
        public void IClickAddSignPlus()
        {
            Thread.Sleep(5000);
            AddSignPlus.Click();
        }
        public void INavigateToTheWebsite(String url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public void IClickFruitAndVegDropDown()
        {
            FruitAndVegDropDown.Click();
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
        public bool IConfirmSearchIsDisplayed()
        {
            return Search.Displayed;
        }



























    }
}
