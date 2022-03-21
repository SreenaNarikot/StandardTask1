Feature: Creating the  Certification in the Profile page with valid credentials



Scenario Outline: Creating a new Certification details
Given : I am on my Profile Page
When :I Click Add new Certifications with '<certificate>' ,'<from>'.'<year>' details
Then :The Certification with '<certificate>' ,'<from>'.'<year>' details will be createdsuccessfully.

Examples: 
| certificate | from | year |
| Diploma     | TPE  | 2020 |
| Graduation  | NUS  | 2019 |




