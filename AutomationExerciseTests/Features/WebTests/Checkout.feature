Feature: Checkout

A short summary of the feature

@Web
Scenario: Successfully complete checkout process
    Given user is on Signup/Login page 
    And user enters 'automationtest1@gmail.com' and '1234' in loginPage    
    And select Blue Top item to view product details on HomePage 
    And click on Add to cart on product details page and selects view cart from the popup     
    When click Proceed to Checkout on cart page
    And click on Place Order on checkout page  
    And enter card details and click Pay and Confirm Order on payment page
    Then 'Congratulations! Your order has been confirmed!' message is displayed in payment confirmation page




