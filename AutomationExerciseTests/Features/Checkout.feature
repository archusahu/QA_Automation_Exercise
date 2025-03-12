Feature: Checkout

A short summary of the feature

@tag1
Scenario: Successfully complete checkout process
    Given user is logged in  
    And user has added items to the cart  
    When user proceeds to checkout  
    And enters valid shipping information  
    And clicks on "Finish"  
    Then user should see a confirmation message "Thank you for your order!"

Scenario: Checkout fails when required fields are missing
    Given user is logged in  
    And user has added items to the cart  
    When user proceeds to checkout  
    And leaves the shipping information fields empty  
    Then user should see an error message "Error: First Name is required"


