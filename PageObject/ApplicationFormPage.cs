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
    class ApplicationFormPage
    {
        public ApplicationFormPage()
        {
            driver = Hooks1.driver;
        }
        IWebDriver driver;

        IWebElement Cookies => driver.FindElement(By.CssSelector("body > div.cc-window.cc-banner.cc-type-info.cc-theme-block.cc-bottom > div > a"));

        IWebElement ApplyNow => driver.FindElement(By.XPath("//a[text()='Apply Now']"));
        IWebElement FirstName => driver.FindElement(By.XPath("//*[@id='job_seeker_form_job_seeker_first_name']"));
        IWebElement LastName => driver.FindElement(By.XPath("//*[@id='job_seeker_form_job_seeker_last_name']"));
        IWebElement Emailaddress => driver.FindElement(By.XPath("//*[@id='job_seeker_form_job_seeker_email']"));
        IWebElement Flag => driver.FindElement(By.XPath("//*[@id='talent-pipeline-fieldset-details']/div/div[4]/div/div/div/div/ul/li[2]/span[1]"));
        IWebElement Phone => driver.FindElement(By.XPath(" input[type=tel]"));
        IWebElement AddressLine1 => driver.FindElement(By.XPath("//*[@id='job_seeker_form_job_seeker_address1']"));
        IWebElement AddressLine2 => driver.FindElement(By.XPath("//*[@id='job_seeker_form_job_seeker_address2']"));
        IWebElement Town => driver.FindElement(By.XPath("//*[@id='job_seeker_form_job_seeker_town']"));
        IWebElement Country => driver.FindElement(By.XPath("//*[@id='job_seeker_form_job_seeker_country']"));
        IWebElement Postcode => driver.FindElement(By.XPath("//*[@id='job_seeker_form_job_seeker_postcode']"));
        IWebElement Cv => driver.FindElement(By.XPath("//*[@id='talent-pipeline-fieldset-resume']/div/div/div/div/label"));
        IWebElement Yes => driver.FindElement(By.XPath("//*[@id='talent-pipeline-fieldset-questions']/div/div[1]/div/div[1]/div/label"));
        IWebElement Day => driver.FindElement(By.XPath("//*[@id='job_seeker_form_job_seeker_answers_attributes_1_date_answer_3i']"));
        IWebElement Month => driver.FindElement(By.XPath("//*[@id='job_seeker_form_job_seeker_answers_attributes_1_date_answer_2i']"));
        IWebElement Year => driver.FindElement(By.XPath("//*[@id='job_seeker_form_job_seeker_answers_attributes_1_date_answer_1i']"));
        IWebElement UniversityEmailAddress => driver.FindElement(By.XPath("//*[@id='job_seeker_form_job_seeker_answers_attributes_2_text_answer']"));
        IWebElement HearAboutUs => driver.FindElement(By.XPath("//*[@id='talent-pipeline-fieldset-questions']/div/div[4]/div/div/div/div[1]"));
        IWebElement VisaSponsorship => driver.FindElement(By.XPath(""));
        IWebElement LevelOfEducation => driver.FindElement(By.XPath(""));
        IWebElement SectorPreference1 => driver.FindElement(By.XPath(""));
        IWebElement SectotPreference2 => driver.FindElement(By.XPath(""));
        IWebElement SectorPreference3 => driver.FindElement(By.XPath(""));
        IWebElement Youruniversity => driver.FindElement(By.XPath(""));
        IWebElement DegreeSubject => driver.FindElement(By.XPath(""));
        IWebElement Gender => driver.FindElement(By.XPath(""));
        IWebElement Ethnicity => driver.FindElement(By.XPath(""));
        IWebElement Information => driver.FindElement(By.XPath(""));
        IWebElement Submit => driver.FindElement(By.XPath(""));

        public IWebElement SelectDay { get; private set; }
        public IWebElement SelectMonth { get; private set; }
        public IWebElement SelectYear { get; private set; }

        public void ClickOnCookies()
        {
            Cookies.Click();
            Thread.Sleep(3000);
        }
        public void ClickOnApplyNow()
        {
            //Actions actions = new Actions(driver);
            //actions.MoveToElement(ApplyNow);
            //actions.Perform();
            Thread.Sleep(5000);
            ApplyNow.Click();
        }

        public void IEnterFirstName()
        {
            //var element = FirstName;
            //Actions actions = new Actions(driver);
            //actions.MoveToElement(ApplyNow);
            //actions.Perform();
            Thread.Sleep(5000);
            FirstName.SendKeys("Oladapo");
        }

        public void IEnterLastName()
        {
            LastName.SendKeys("Mobalo");
        }

        public void IEnterEmailAddress()
        {
            Emailaddress.SendKeys("Temada3@gmail.com");
        }

        public void IClickFlagDrop()
        {
            Flag.Click();
        }

        public void IEnterPhone()
        {
            Phone.SendKeys("7865432877");
        }

        public void IEnterAddressLine1()
        {
            AddressLine1.SendKeys("Flat66");
        }
        public void IEnterAddressLine2()
        {
            AddressLine2.SendKeys("AmasonStreet");
        }
        public void IEnterCountry()
        {
            Country.SendKeys("UnitedKingdom");
        }
        public void IEnterTown()
        {
            Town.SendKeys("agarlda");
        }
        public void IEnterPostcode()
        {
            Postcode.SendKeys("Sw16ds");
        }

        public void IUploadCv()
        {
            Cv.Click();
        }

        public void IClickYes()
        {
            Yes.Click();
        }

        public void IselectDay()
        {
            SelectElement select = new SelectElement(Day);
            select.SelectByValue("2");
        }
        public void ISelectMonth()
        {
            SelectElement select = new SelectElement(Month);
            select.SelectByValue("4");
        }
        public void ISelectYear()
        {
            SelectElement select = new SelectElement(Year);
            select.SelectByValue("2025");
        }
        public void IEnterPoscode()
        {
            Postcode.SendKeys("We32ade");
        }
             
        public void IClickUploadCv()
        {
            Cv.Click();
        }
        public void NavigateToWebsite()
        {
            driver.Navigate().GoToUrl("https://10kbi.pinpointhq.com/register-your-interest/new");
        }
       public void IEnterUniversityEmailAddress()
        {
            UniversityEmailAddress.SendKeys("jameadw@gmail.com");
        }
       




    }





}
