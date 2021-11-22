Feature: ExchangeDetails
	Print exchange details and sort the output by number of markets provided by each exchange

Scenario: Get multiple exchanges details
    Given /exchanges request
	When GET request is executed
	Then find <dataToFilter> matching <exchanges>
    And print exchange details order by <sortorder> on <field>
	Examples:
	|	exchanges				|	sortorder	|	field			|	dataToFilter	|
	|	Bitrue,Binance,WhiteBIT	|	ASC			|	numberOfMarkets	|	exchanges		|

	#exchanges: BitTrue, Whitebit.