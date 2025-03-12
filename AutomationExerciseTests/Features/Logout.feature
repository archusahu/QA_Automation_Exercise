Feature: Logout

A short summary of the feature

@tag1
Scenario: Verify user can logout successfully
    Given user is logged in  
    When user clicks on the menu  
    And selects "Logout"  
    Then user should be redirected to the login page
