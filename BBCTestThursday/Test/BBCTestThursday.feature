Feature: BBCPageLoad
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@BBCPageLoad
Scenario: BBC page loads
	Given I navigate to BBC
	Then I see BBC page loads
