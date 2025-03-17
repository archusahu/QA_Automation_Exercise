Feature: ApiTests

A short summary of the feature

@Api
Scenario: 01 Get All products list
	When get all products list
	Then response should be 'OK'
	And response should contain 'products-list-response' data
