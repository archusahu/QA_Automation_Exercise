@Web
Feature:  Login Scenarios

A short summary of the feature


Scenario: 01) Successful login with valid credentials
    Given user is on Signup/Login page 
    When user enters 'automationtest1@gmail.com' and '1234' in loginPage    
    Then dashboard page is display with 'Logged in as automationtest1@gmail.com'   

Scenario: 02) Login fails with invalid credentials
    Given user is on Signup/Login page    
    When user enters 'automationtest1@gmail.com' and '12345' in loginPage    
    Then login page shows error message 'Your email or password is incorrect!' is visible  
   

Scenario: 03) Login fails when fields are empty
    Given user is on Signup/Login page 
   When user enters '' and '12345' in loginPage     
    Then login page shows error message 'Please fill in this field'

