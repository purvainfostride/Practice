Feature: Checking functionality of LoginPage the Application

A short summary of the feature

#@validcredentials
Scenario: Checking Login functionality with the valid login credentials
	Given user is on Login page
	When user enters username and password in the textfield
	And user clicks on the Login button
	Then user is on Homepage

Scenario: Checking the functionality of Side Menu button
	Given user is on Homepage
	When user click on Side Menu button
	And It displays the side menu 



