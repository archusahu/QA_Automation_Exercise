@Web
Feature: Product Sorting

A short summary of the feature

Scenario: Verify items are sorted when sort is 'Price (low to high)'
    Given user is logged in  
    When user selects 'Price (low to high)' from the sorting dropdown  
    Then items on the product page should be sorted in ascending order of price

Scenario: Verify items are sorted when sort is 'Price (high to low)'
    Given user is logged in  
    When user selects 'Price (high to low)' from the sorting dropdown  
    Then items on the product page should be sorted in descending order of price

Scenario: Verify items are sorted when sort is 'Name (A to Z)'
    Given user is logged in  
    When user selects 'Name (A to Z)' from the sorting dropdown  
    Then items on the product page should be sorted in ascending order of name

Scenario: Verify items are sorted when sort is 'Name (Z to A)'
    Given user is logged in  
    When user selects 'Name (Z to A)' from the sorting dropdown  
    Then items on the product page should be sorted in descending order of name


