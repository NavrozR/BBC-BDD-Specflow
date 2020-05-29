Feature: HeaderLinks
	In order to view Header pages
	As a user
	I want to be able to click on those links 

@HeaderLinks
Scenario Outline: Check Header Page load
	Given I navigate to BBC
	When I click on <header links>
	Then I see the <header links> pages
Examples: 
| header links |
| News         |
| Sport        |
| Weather      |
| Complaint    |
| CBeebies     |
| More         |
| Food         |





