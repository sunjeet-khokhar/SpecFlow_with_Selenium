Feature: TradeMe_home_page
	In order to validate that TradeMe homepage has opened succesfully
	As a internet user
	I want to be provided a confirmation that I have succesfully opened the TradeMe homepage

@mytag
Scenario: Open_home_page
	Given I have an internet connection and a browser
	When I type TradeMe hopepage URL
	Then the I should see Kevin the Kiwi logo on the homepage
