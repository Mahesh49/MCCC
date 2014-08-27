Feature: MakeDonation
	In order to donate
	As a user
	I want to be provided multiple options

@mytag
Scenario Outline: Donation
	Given I am on Donation Page
	When I choose donation type "<Donation Type>"
	Then I should see relevent pages "<PageHeader>" 

Examples: 
| Donation Type           | PageHeader              |
| Make a regular donation | Make a donation         |
| Make a one-off donation | Make a one-off donation |