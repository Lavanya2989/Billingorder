Feature: API tests

@mytag
Scenario:Post billing order
	Given I have correct billing order
	When I send this order to API via Post request
	Then Receive response with correct http address

