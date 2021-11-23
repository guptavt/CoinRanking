Feature: PrintCoinsHistory		
		 In order to get coin's latest and historical details from 7 days,
		 I want to print its price and time stamp in human readable format 
		 sorted from oldest to newest 

@CoinHistory
Scenario: Print latest and historical price of coins from 7 days from oldest to newest
    Given /coins request
	When GET request is executed
	Then find <dataToFilter> matching <coins>
    Then find coins history for <duration>
	And print each coin oldest and most recent price history
	Examples:
	|	dataToFilter	|	coins						|	duration	|
	|	coins 			|	Bitcoin,Ethereum,Cardano 	|	7d			|