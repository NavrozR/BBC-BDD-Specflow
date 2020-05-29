Feature: BBCWeather
	To find out Humidity at 18.00 O'clock for my Postcode
	

@BBCWeather
Scenario: BBC Weather for my Postcode for today
	Given I navigate to BBC
	And I click Weather
	When I enter postcode
	#And I click Time 
	Then I see Weather forecast 

	
