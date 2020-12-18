Feature: login
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Gmail Login
	Given the url of gmail login
	When enter the email and password of user
	Then it should redirect to inbox page
	Then compose mail by clicking on compose button
	And enter the recipient and reciver address with subject and body
	When click on send button
	Then send the message to recipient


	