Feature: Product Feature

A short summary of the feature

@tag1
Scenario: Verify cart does not allow adding negative quantity
    Given user is logged in  
    When user tries to add '-1' quantity of 'Sauce Labs Backpack'  
    Then the system should not allow it and should display an error message