

@mytag
Scenario: Add two numbers
	Given https://mypizza.kg/ is opened
	When Pizzas are selected
	And  Cart is opened
	Then All fields should be filled
	And Screenshot should be taken