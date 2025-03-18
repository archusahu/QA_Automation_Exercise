Feature: ApiTests

A short summary of the feature

@Api
Scenario: 01 Get All products list
	When get 'productsList'
	Then response status code should be 'OK'
	#And response should contain 'products-list-response' data
	And 'products' should be in response 'products-list-response'

@Api
Scenario: 02 POST To All Products List
	When post 'productsList'
	Then response status code should be 'OK'
	#And response content contains '405' response code
	#And response should contain message 'This request method is not supported.' 
	And response contians
		| ResponseCode | Message                               |
		| 405          | This request method is not supported. |

@Api
Scenario: 03 POST To Search Product without search_product parameter
	When post 'searchProduct'
	Then response status code should be 'OK'
	And response contians
		| ResponseCode | Message                                                           |
		| 400          | Bad request, search_product parameter is missing in POST request. |

@Api
Scenario: : 04 Get All Brands List
	When get 'brandsList'
	Then response status code should be 'OK'
	#And response should contain all 'brands-list-response' data
	And 'brands' should be in response 'brands-list-response'

@Api
Scenario: : 05 PUT To All Brands List
	When post 'brandsList'
	Then response status code should be 'OK'
	And response contians
		| ResponseCode | Message                               |
		| 405          | This request method is not supported. |

@Api
Scenario: : 06 PUT To All Brands List
	When post 'brandsList'
	Then response status code should be 'OK'
	And response contians
		| ResponseCode | Message                               |
		| 405          | This request method is not supported. |

@Api
Scenario Outline: 07 POST To Verify Login with valid details
	When post 'verifyLogin' with '<UserId>' and '<Password>'
	#When post 'searchProduct' with parameters
	#| ParameterName | ParameterValue |
	#| email         | <UserId>       |
	#| password      | <Password>     |
	Then response status code should be 'OK'
	And response contians
		| ResponseCode   | Message   |
		| <ResponseCode> | <Message> |

Examples:
	| UserId                       | Password | ResponseCode | Message         |
	| automationtest1@gmail.com    | 1234     | 200          | User exists!    |
	|                              | 1234     | 404          | User not found! |
	| automationtest1@gmail.com    |          | 404          | User not found! |
	|                              |          | 404          | User not found! |
	| automationtest-xyz@gmail.com | 1234     | 404          | User not found! |
	| automationtest-xyz           | 1234     | 404          | User not found! |
	| automationtest1@gmail.com    | }({      | 404          | User not found! |

	@Api
Scenario Outline: 08 POST To Search Product
	#When post 'searchProduct' with '<Items>'
	When post 'searchProduct' with parameters
	| ParameterName  | ParameterValue |
	| search_product | <Items>        |
	Then response status code should be 'OK'
	#And response should contain search products '<ResponseFileName>' data
	And 'products' should be in response '<ResponseFileName>'
	Examples:
	| Items  | ResponseFileName       |
	| top    | top-search-response    |
	| tshirt | tshirt-search-response |
	| jeans  | jeans-search-response  |
	





