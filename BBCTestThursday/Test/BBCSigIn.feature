Feature: BBCSignIn
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@BBCSignIn
Scenario: Sign in to BBC
	Given I navigate to BBC
	And I click signin
	When I login with valid user details
	Then I see login is successful
