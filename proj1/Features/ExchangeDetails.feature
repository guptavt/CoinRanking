Feature: PrintExchangeDetails
		 In order to get exchange details I want to print name, number of markets, volume and rank sorted 
		 in ascending order of number of markets served by each exchange

Scenario: Get multiple exchanges details
    Given /exchanges request
	When GET request is executed
	Then find <dataToFilter> matching <exchanges>
    And print exchange details order by <sortorder> on <field>
	Examples:
	|	dataToFilter	|	exchanges				|	sortorder	|	field			|
	|	exchanges		|	Bitrue,Binance,WhiteBIT	|	Ascending	|	numberOfMarkets	|