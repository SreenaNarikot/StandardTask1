Feature: Skills - As a seller I am trying to the CRUD operations on the skills




Scenario Outline: 1.Creating a new Skills details
	Given : I am on my Profile Page
	When :I click new skills with valid '<skill>' and '<level>' details
	Then :The '<skill>' details with will be created successfully  .
Examples:
| skill    | level    |
| Graphics | Beginner |
| Python   | Expert   |

Scenario Outline:2. Updating the skills created
Given : I am on my Profile Page
When  : I Click Update on skills tab with valid '<skill>' and '<level>' details
Then :   skill must be  updated with new '<skill>' deatils.
Examples: 
| skill   | level        |
| slenium | Intermediate |
| Java    | Expert       |

Scenario: 3.Deleting the Skills
Given : I am on my Profile Page
When : I click delete button on skills tab
Then : Skills will be deleted







