Feature: InValidLogin
	In order to shop
	As a user
	I want to login into the system

@mytag
Scenario Outline: Invali Login

Given I am on OnlineShop page
When I enter invalid username "<Username>" and password "<password>"
Then I shoud see error message being displayed

Examples: 

| Username      | password |
| 123@gmail.com | asdrfd   |
| abc@gmail.com | 12345    |