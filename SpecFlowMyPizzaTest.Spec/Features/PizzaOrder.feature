
Feature: MyPizza ordering website e2e test


Scenario: Go to cart page
		Given pizza category is on the page
		When user order products
		And user opens Cart Page
		And fields are filled
		And screenshot is made
		Then Cart page should be opened
