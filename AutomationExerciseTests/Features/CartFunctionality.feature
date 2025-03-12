Feature: Cart Functionality

A short summary of the feature

@tag1
Scenario: Add item to cart and verify cart count increases
    Given user is logged in  
    When user adds 'Sauce Labs Backpack' to the cart  
    Then the cart icon should show '1' item

Scenario: Remove item from cart and verify cart is empty
    Given user is logged in  
    And user has added 'Sauce Labs Backpack' to the cart  
    When user removes 'Sauce Labs Backpack' from the cart  
    Then the cart page should be empty

Scenario: Verify an item is not in the cart
    Given user is logged in  
    When user adds 'Sauce Labs Backpack' to the cart  
    Then the cart page should not contain 'Sauce Labs Bike Light'

Scenario: Verify checkout process fails when cart is empty
    Given user is logged in  
    And the cart is empty  
    When user proceeds to checkout  
    Then the checkout button should be disabled
