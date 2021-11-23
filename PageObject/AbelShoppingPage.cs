using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using PodCheckout.Utilities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace PodCheckout.PageObject
{
    class AbelShoppingPage
    {
        public AbelShoppingPage()
        {
            driver = Hooks1.driver;
        }
        IWebDriver driver;
        
        IWebElement AcceptCookies => driver.FindElement(By.XPath("//*[@id='ccc-notify-accept']"));
        IWebElement SignUp => driver.FindElement(By.XPath("//*[@id='my-account']/div[3]/a"));
        IWebElement Postcode => driver.FindElement(By.XPath("//*[@id='postcode-checker-input']"));
        IWebElement FindAddress => driver.FindElement(By.XPath("//*[@id='postcode-checker']/form/label/div/button"));
        IWebElement Continue => driver.FindElement(By.XPath("//*[@id='postcode-checker']/div/button"));
        IWebElement Address => driver.FindElement(By.XPath("//*[@id='postcode-checker']/div[1]/label/select"));
        IWebElement Continue2 => driver.FindElement(By.XPath("//*[@id='delivery-date-confirmation']/div/button"));
        IWebElement Neither => driver.FindElement(By.XPath("//*[@id='household-dietary-requirements']/fragment/fragment/fragment[3]/label/span"));
        IWebElement NextStep => driver.FindElement(By.XPath("//*[@id='household-dietary-requirements']/div/button"));
        IWebElement Password => driver.FindElement(By.XPath("//*[@id='Password']"));
        IWebElement YesIn => driver.FindElement(By.XPath("/html/body/div[7]/div/div/div/section/section[2]/fragment[1]/form/fragment[1]/fragment/fragment[1]/label/span"));
        IWebElement SignUpAndContinue => driver.FindElement(By.XPath("//*[@class='signup-screen__button-wrapper create-account']"));
        IWebElement Email => driver.FindElement(By.XPath("//*[@id='Email']"));
        IWebElement HearAboutUs => driver.FindElement(By.XPath("/html/body/div[7]/div/div/div/section/section[2]/fragment[1]/form/div/label/select"));
        IWebElement AllYouNeedIsLess => driver.FindElement(By.XPath("//*[@id='prospect-home-page']/section/section[2]/div[2]/h1"));
        IWebElement StartShopping => driver.FindElement(By.XPath("//*[@class='push-banner']"));
       
       


        public object PickAddress { get; private set; }
        public bool IsAllYouNeedIsLess { get; private set; }

        public void IClickAcceptCookies()
        {
            Thread.Sleep(3000);
            AcceptCookies.Click();
        }

        public void IClickSignUp()
        {
            SignUp.Click();
        }

        public void IEnterPostCode(String PostcodeText)
        {
            Thread.Sleep(3000);
            Postcode.SendKeys(PostcodeText);
        }

        public void IClickFindAddress()
        {
            FindAddress.Click();
        }

        public void ISelectAddress()
        {
            Thread.Sleep(5000);
            SelectElement select = new SelectElement(Address);
            select.SelectByText("Flat 88, Blackthorn Court, 60 Hall Road, London");
            Address.Click();
            
        }

        public void IClickContinue()
        {
            Thread.Sleep(3000);
            Continue.Click();
        }

        public void IClickContinue2()
        {
            Thread.Sleep(5000);
            Continue2.Click();
        }

        public void IClickNeither()
        {
            Thread.Sleep(3000);
            Neither.Click();

        }

        public void IclickNextStep()
        {
            NextStep.Click();
        }

        public void IClickYesIn()
        {
            YesIn.Click();
        }

        public void IEnterEmail(String EmailText)
        {
            Email.SendKeys(EmailText);
        }

        public void IEnterPassword(String PasswordText)
        {
            Password.SendKeys(PasswordText);
        }

        public void IClickSignUpAndContinue()
        {
            Thread.Sleep(5000);
            //IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            //js.ExecuteScript("window.scrollBy(0,350)", "");
            SignUpAndContinue.Click();
        }
       
        public void IClickStartShopping()
        { 
            StartShopping.Click();
        }
       

        public void ISelectHearAboutUs()
        {
            SelectElement select = new SelectElement(HearAboutUs);
            select.SelectByText("Internet");
        }

        public void INavigateToTheWebsite(String url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public bool IConfirmAllYouNeedIsLessDisplayed()
        {
            return AllYouNeedIsLess.Displayed;
        }

        public bool IConfirmStartShoppingIsDisplayed()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0,350)", "");
            Thread.Sleep(5000);
            return StartShopping.Displayed;
        }

        
        

        




        }
           



    }










