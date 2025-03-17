Feature: Logout

A short summary of the feature

@Web
Scenario: Verify user can logout successfully
    Given user is on Signup/Login page 
    And user enters 'username' and 'password' in loginPage 
    When user clicks on Logout from the menu       
    Then user should be redirected to the 'Automation Exercise - Signup / Login' page.
