Feature: ApiTests

A short summary of the feature

@Api
Scenario: 01 Get All products list
	When get all products list
	Then response status code should be 'OK'
	And response should contain 'products-list-response' data

@Api
Scenario: 02 POST To All Products List
	When post all products list
	Then response status code should be 'OK'
	#And response content contains '405' response code
	#And response should contain message 'This request method is not supported.' 
	And response contians
	| ResponseCode | Message                               |
	| 405          | This request method is not supported. |
