Feature: Creating the shareskill in the Profile page with valid data



Scenario Outline: 1.Creating a new ShareSkill details
	Given : I am on my Profile Page
	When  : I click new shareskill with valid '<title>','<Description>','<Category>','<Subcategory>','<Tags>','<Service Type>','<Location Type>','<Startdate>','<Enddate>',  '<Selectday>','<Starttime>','<Endtime>','<Skill Trade>','<Skill-Exchange>','<Active>' details
	Then : details will be created successfully with '<message>'

Examples: 
          | title    | Description                    | Category           | Subcategory | Tags     | Service Type         | Location Type | Startdate  | Enddate    | Selectday | Starttime | Endtime  | Skill Trade    | Skill-Exchange | Active | message                            |
          | Selenium | This is a course for Beginners | Programming & Tech | QA          | Testing  | One-off service      | On-site       | 12/11/2022 | 12/12/2022 | Mon       | 15:00:00  | 16:00:00 | Skill-Exchange | Skill-Exchange | Hidden | Service Listing Added successfully |
          | SQL      | Introduction to SQL            | Programming & Tech | Databases   | database | Hourly basis service | Online        | 12/10/2022 | 12/10/2022 | mon       | 15:00:00  | 16:00:00 | Skill-Exchange | Skill-Exchange | Hidden | Service Listing Added successfully |

Scenario Outline: 2.Creating a Shareskill without mandatory details
Given : I am on my Profile Page
When : I click Save sharekill with out mandatory details for '<title>','<Description>','<Category>','<Subcategory>','<Tags>','<Service Type>','<Location Type>','<Startdate>','<Enddate>',  '<Selectday>','<Starttime>','<Endtime>','<Skill Trade>','<Skill-Exchange>','<Active>'
Then : I should get the '<errormessage>' displayed.
Examples: 
| title | Description                    | Category           | Subcategory | Tags | Service Type | Location Type | Startdate | Enddate | Selectday | Starttime | Endtime | Skill Trade | Skill-Exchange | Active | errormessage                        |
|       |                                | Programming & Tech | QA          |      |              |               |           |         |           |           |         |             |                |        | Please complete the form correctly. |
| Java  | This is a course for Beginners | Programming & Tech | Databases   |      |              |               |           |         |           |           |         |             |                |        | Please complete the form correctly. |






         