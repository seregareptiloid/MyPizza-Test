


Scenario: Select pizza category
		Given a web browser is at mypizza home page
		When user clicks on 40 cm pizza category
		Then 40 cm pizza page should be open
	
Scenario: Open pizza constructor
		Given an Italian pizza product is on the page
		When user clicks on that product
		Then pizza constructor pop-up should appear

Scenario: Construct pizza
		Given "add to cart" button is on the page
		When user selects "no green vegetable" check box
		And adds product to cart
		Then constructor pop-up should disappear
		And Italian pizza should appear at cart section

Scenario: Quick addition
		Given 40 cm pizza category page is opened
		When user clicks addition arrows of two different products
		Then Product names appear at cart section

Scenario: Go to cart page
		Given checkout button is on the page
		When user clicks checkout button
		Then Cart page should be opened
