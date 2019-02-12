Feature: Registrations
	So that I can use the site
	I need to register

@mytag
Scenario: InValid Registration
	Given I navigate to the site
	When Click on register link
	And I enter firstname
	And I enter last name
	And I enter emailadd
	And I enter mobile number
	And I enter password
	And I confirm password
	And the click on signUp
	Then I not should be registered
