Feature: CoinsHistory
	Get coin's latest and historical price from 7 days

   # bitcoin id is 1
   #Ethereum id ia 2
   #Cardano id is 9

   Scenario: Get 7 day history for multiple coins
    Given /coins request
	When GET request is executed
	Then find <dataToFilter> matching <coins>
    Then find coins history for <duration>
	And print each coin oldest and most recent history
	Examples:
	|	coins						|	sortorder	|	duration	|	dataToFilter	|
	|	Bitcoin,Ethereum,Cardano	|	DSC			|	7d			|	coins			|