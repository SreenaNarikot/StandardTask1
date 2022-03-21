Feature:Creating the Education in the Profile page with valid credentials Education



Scenario:  Creating a new Education details
	Given : I am on my Profile Page
	When : I Click Add new Education with '<Country>' ,'<University>','<Title>','<Degree>', '<Graduation Year>' details
	Then : The Education details '<Country>' ,'<University>','<Title>','<Degree>', '<Graduation Year>'will be created successfully.


	Examples: 
	| Country   | University | Title  | Degree          | Graduation Year |
	| Singapore | NUS        | B.Tech | ComputerScience | 2020            |
	| India     | LBS        | B.Sc   | Mathematics     | 2018            |