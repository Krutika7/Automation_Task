Feature: PracticeProject
  Automating practice form

@login
Scenario Outline: Login into the website
    Given navigate to website URL
	When Click on My Account
    And Enter UserName <email>, Password <password> 
	When Click on Login Button
	Then "Krutikasardar07" should display
	@source:Data.xlsx
	Examples: 
	     |email|password|

@OrderOneProduct
Scenario: Order one Product
    When Click on Shop,add one product in your cart and go to cart
    And Click on proceed to checkout and fill the required details
    When Scroll down,select COD and click on place Order
    Then "Thankyou,your order has been received" will display
