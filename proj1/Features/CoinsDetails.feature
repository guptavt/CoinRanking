Feature: PrintCoinsDetails
		 In order to get coins details I want to print name, type, rank, first seen and price sorted 
		 in descending order of time that each coin was first seen

Scenario: Get multiple coins details
    Given /coins request
	When GET request is executed
	Then find <dataToFilter> matching <coins>
    And print coin details order by <sortorder> on <field>
	Examples:
	|	dataToFilter	|	coins							|	sortorder	|	field		|
	|	coins			|	Dogecoin,Solana,Bitcoin Cash	|	Descending	|	firstSeen	|