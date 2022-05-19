Feature:Education - Creating the Education in the Profile page with valid credentials Education



Scenario:  Creating a new Education details
	Given : I am on my Profile Page
	When : I Click Add new Education with '<Country>' ,'<University>','<Title>','<Degree>', '<Graduation Year>' details
	Then : The Education details will be created successfully with '<message>' displayed.


	Examples: 
	| Country   | University | Title  | Degree          | Graduation Year | message                  |
	| Singapore | NUS        | B.Tech | ComputerScience | 2020            | Education has been added |
	| India     | LBS        | B.Sc   | Mathematics     | 2018            | Education has been added |

