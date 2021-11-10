Feature: ApplicationJob
	In order for me to apply for the job
	I need to send the information


@mytag
Scenario: ApplyInternship
	Given I need to navigate to the website "https://10kbi.pinpointhq.com/register-your-interest/new"
	And I accept the cookies
	#And I click on Apply Now
	And I enter firstname
	And I enter lastname
	And I enter email address
	#And I click flag drop
	#And I enter phone 
	And I enter address line 1
	And I enter address line 2
	And I enter town
	And I enter country
	And I enter postcode
	And I upload cv
	And I click yes
	And I select day
	And I select month
	And I select year 
	And I enter university email address
	And I select where did you hear about us
	And I click yes visa sponsorship 
	And I select level of education
	And I select year of graduate
	And I select internship sector preference #1
	And I enter words 
	And I select internship sector preference #2
	And I select internship sector preference #3
	And I select your university
	And I select degree subject
	And I select gender
	And I select ethnicity
    When I click allow us to process your information
	Then I click submit