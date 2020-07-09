Feature: Registration
	In order to use Propertyrete website
	I will need to register

@tag
Scenario: Valid Registration
	Given I navigate to "https://www.propertyrete.com/account/authentication"
	When I click on register
	And I enter my First Name "Property"
	And I enter my Last Name "Test"
	And I enter my Email Address "propertytest164@gmail.com"
	And I click on dropdown to select country code
	And I select Country
	And I enter my Mobile "07436578606"
	And I enter my Password "PassTest!34"
	And I re enter my Password "PassTest!34"
	And I click on Sign up
#Then I should receive a success message "Thank you for signing up! Please check your mail or mobile to activate your account.Check spam folder for message if not received in your inbox"
	Then I should receive a success message
	
	
	
