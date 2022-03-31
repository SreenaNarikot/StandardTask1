Feature: Login function test with invallid email address
	

@mytag
Scenario Outline:  Login to website using Invalid email address and valid password
	When :I navigate to the URL and click Sign In and enter invalid '<emailaddress>' and valid '<password>'
	Then : then the error message'<errormessage>' should be displayed
	Examples: 
	| emailaddress      | password   | errormessage       |
	| sreeena@yahoo.com | Amma260872 | Confirm your email |


 