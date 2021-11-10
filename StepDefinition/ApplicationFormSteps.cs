using PodCheckout.PageObject;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace PodCheckout.StepDefinition
{
    [Binding]
    public class ApplicationFormSteps
    {
        ApplicationFormPage applicationformpage;
            public ApplicationFormSteps()
        {
            applicationformpage = new ApplicationFormPage();
        }
    
    
        [Given(@"I need to navigate to the website ""(.*)""")]
        public void GivenINeedToNavigateToTheWebsite(string p0)
        {
            applicationformpage.NavigateToWebsite();
        }
        [Given(@"I accept the cookies")]
        public void GivenIAcceptTheCookies()
        {
            applicationformpage.ClickOnCookies();
        }
        [Given(@"I click on Apply Now")]
        public void GivenIClickOnApplyNow()
        {
            applicationformpage.ClickOnApplyNow();
        }
        
        [Given(@"I enter firstname")]
        public void GivenIEnterFirstnName()
        {
            Thread.Sleep(3000);
            applicationformpage.IEnterFirstName();
        }
        
        [Given(@"I enter lastname")]
        public void GivenIEnterLastName()
        {
            applicationformpage.IEnterLastName();
        }
        
        [Given(@"I enter email address")]
        public void GivenIEnterEmailAddress()
        {
            applicationformpage.IEnterEmailAddress();
        }
        [Given(@"I click flag drop")]
        public void GivenIClickFlagDrop()
        {
            applicationformpage.IClickFlagDrop();
        }



        [Given(@"I enter phone")]
        public void GivenIEnterPhone()
        {
            applicationformpage.IEnterPhone();
        }
        
        [Given(@"I enter address line (.*)")]
        public void GivenIEnterAddressLine(int p0)
        {
            applicationformpage.IEnterAddressLine1();
        }
        
        [Given(@"I enter town")]
        public void GivenIEnterTown()
        {
            applicationformpage.IEnterTown();
        }
        
        [Given(@"I enter country")]
        public void GivenIEnterCountry()
        {
            applicationformpage.IEnterCountry();
        }
        
        [Given(@"I enter postcode")]
        public void GivenIEnterPostcode()
        {
            applicationformpage.IEnterPostcode();
        }
        
        [Given(@"I upload cv")]
        public void GivenIUploadCv()
        {
            applicationformpage.IClickUploadCv();
        }
        
        [Given(@"I click yes")]
        public void GivenIClickYes()
        {
            applicationformpage.IClickYes();
        }
        
        [Given(@"I select day")]
        public void GivenISelectDay()
        {
            applicationformpage.IselectDay();
        }
        
        [Given(@"I select month")]
        public void GivenISelectMonth()
        {
            applicationformpage.ISelectMonth();
        }
        
        [Given(@"I select year")]
        public void GivenISelectYear()
        {
            applicationformpage.ISelectMonth();
        }
        
        [Given(@"I enter university email address")]
        public void GivenIEnterUniversityEmailAddress()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I select where did you hear about us")]
        public void GivenISelectWhereDidYouHearAboutUs()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I click yes visa sponsorship")]
        public void GivenIClickYesVisaSponsorship()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I select level of education")]
        public void GivenISelectLevelOfEducation()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I select year of graduate")]
        public void GivenISelectYearOfGraduate()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I select internship sector preference \#(.*)")]
        public void GivenISelectInternshipSectorPreference(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I enter words")]
        public void GivenIEnterWords()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I select your university")]
        public void GivenISelectYourUniversity()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I select degree subject")]
        public void GivenISelectDegreeSubject()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I select gender")]
        public void GivenISelectGender()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I select ethnicity")]
        public void GivenISelectEthnicity()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click allow us to process your information")]
        public void WhenIClickAllowUsToProcessYourInformation()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I click submit")]
        public void ThenIClickSubmit()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
