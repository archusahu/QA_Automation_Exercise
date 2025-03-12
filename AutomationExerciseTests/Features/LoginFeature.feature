Feature:  Login Scenarios

A short summary of the feature

@tag1
Scenario: Scenario: Successful login with valid credentials
    Given user is on the login page
    When user enters valid username and password
    And clicks on the login button
    Then user should be redirected to the products page

Scenario: Login fails with invalid credentials
    Given user is on the login page
    When user enters an invalid username and/or password
    And clicks on the login button
    Then user should see an error message "Epic sadface: Username and password do not match any user in this service"

 Scenario: Login fails when fields are empty
    Given user is on the login page
    When user does not enter a username or password
    And clicks on the login button
    Then user should see an error message "Epic sadface: Username is required"

