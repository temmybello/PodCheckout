Feature: Amazon
	In order to buy product i need to register

@mytag
Scenario: Amazon Registration
	Given I navigate to the website "https://www.amazon.co.uk/"
	And I click Account List Drop down
	And I click Create your amazon account
	And I Enter your name "Adekunle"
	And The enter email address "funbrrr@yahoo.co.uk"
	And I will enter password "gunmanr444"
	And I will re-enter password "gunmanr444"
	And I click create amazon account 
	#When the two numbers are added
	#Then the result should be 120