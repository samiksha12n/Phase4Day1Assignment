Feature: Calculator
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](SpecFlowProjectDay1Assignment/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@mytag
Scenario: Add two numbers
	Given the first number is 50
	And the second number is 70
	When the two numbers are added
	Then the result should be 120
Scenario: Substract two numbers
	Given the first number is 50
	And the second number is 70
	When the two numbers are substracted
	Then the result should be 20
Scenario: Divide two numbers
	Given the first number is 20
	And the second number is 5
	When the two numbers are division
	Then the result should be 4
Scenario: Multiplication two numbers
	Given the first number is 50
	And the second number is 70
	When the two numbers are multiplication
	Then the result should be 3500