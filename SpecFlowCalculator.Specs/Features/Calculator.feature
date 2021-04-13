﻿Feature: Calculator
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](SpecFlowCalculator.Specs/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@mytag
Scenario: Add two numbers
	Given the first number is 50
	And the second number is 70
	When the two numbers are added
	Then the result should be 120

Scenario: Subtract two numbers
    Given the first number is 120
    And the second number is 70
    When the two numbers are subtracted
    Then the result should be 50

Scenario: Multiply two numbers
    Given the first number is 5
    And the second number is 20
    When the two numbers are multiplied
    Then the result should be 100

Scenario: Divide two numbers
    Given the first number is 50
    And the second number is 2
    When the two numbers are divided
    Then the result should be 25

Scenario: Divide two numbers (with a 0)
    Given the first number is 50
    And the second number is 0
    When the two numbers are divided (with a Zero)
    Then the result should be 0

Scenario: Add N numbers
    Given the following numbers
    | Numbers |
    | 25      |
    | 2       |
    | 10      |
    When numbers are added
    Then the result should be 37

Scenario: Substract N numbers
    Given the following numbers
    | Numbers |
    | 25      |
    | 2       |
    | 10      |
    When numbers are substracted
    Then the result should be 13

Scenario: Multiply N numbers
    Given the following numbers
    | Numbers |
    | 25      |
    | 2       |
    | 10      |
    When numbers are multiplied
    Then the result should be 500

Scenario: Divide N numbers
    Given the following numbers
    | Numbers |
    | 100     |
    | 2       |
    | 10      |
    When numbers are divided
    Then the result should be 5

Scenario: Divide N numbers (with a Zero)
    Given the following numbers
    | Numbers |
    | 0       |
    | 2       |
    | 10      |
    When numbers are divided
    Then the result should be 0