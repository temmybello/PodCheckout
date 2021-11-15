Feature: Amazon
	In order to buy product i need to register

@mytag
Scenario: Amazon Registration
	Given I navigate to the website "https://www.amazon.co.uk/"
	And I click Account List Drop down
	#And I click accept cookies 
	And I click Create your amazon account
	And I Enter your name "Adekunle john"
	And The enter email address "funbrrr45@yahoo.co.uk"
	And I will enter password "gunmanr444"
	When I will re-enter password "gunmanr444"
	Then I click create amazon account
	#And I confirm amazon.co.uk is displayed
	#And I click all drop down
	#And I Click best sellers
	#When the two numbers are added
	#Then the result should be 120






@mytag
Scenario: Amazon Signin
    Given I navigate to the website "https://www.amazon.co.uk/"
	#And I click Account List Drop down
	And I click accept cookies 
	And I click hello sign in
	#And I click sign in 
	And User enter email "temitopeorepo@yahoo.co.uk"
	And User click continue
	And The user enter sign in password "Seyitope2014"
	And User click sign in 
	And I confirm amazon.co.uk is displayed
	
	#And I click keep me signed in 
	

