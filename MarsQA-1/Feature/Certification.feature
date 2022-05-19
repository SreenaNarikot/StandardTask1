Feature: Certification - Creating the  Certification in the Profile page with valid credentials



Scenario Outline:1. Creating a new Certification details
Given : I am on my Profile Page
When :I Click Add new Certifications with '<certificate>' ,'<from>'.'<year>' details
Then :The Certification with '<certificate>' details will be createdsuccessfully.

Examples: 
| certificate | from | year |
| Diploma     | TPE  | 2020 |
| Graduation  | NUS  | 2019 |

Scenario Outline:2.Creating a certification with invalid or null details.
Given : I am on my Profile Page
When :I Click Add new Certifications with  invalid '<certificate>' ,'<from>'.'<year>' details
Then :The error '<message>' will be displayed.
Examples: 
| certificate | from | year | message                                                                    |
| Diploma     |      | 2020 | Please enter Certification Name, Certification From and Certification Year |

Scenario Outline: 3. Creating duplicate certification details
Given : I am on my Profile Page
When :I Click Add duplicate Certifications with '<certificate>' ,'<from>'.'<year>'.
Then :I should be able to see the '<message>'
Examples: 
| certificate | from | year |message                            | 
| Diploma     | TPE  | 2020 | This information is already exist. |

Scenario: 4.Deleting the Certification
Given : I am on my Profile Page
When : I click delete button on certification tab
Then : Certification with '<certificate>' will be deleted
Examples: 
| certificate |
| Diploma     |
 








