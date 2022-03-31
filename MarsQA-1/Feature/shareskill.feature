Feature: Creating the shareskill in the Profile page with valid data



Scenario Outline: 1.Creating a new ShareSkill details
	Given : I am on my Profile Page
	When  : I click new shareskill with valid '<title>','<Description>','<Category>','<Subcategory>','<Tags>','<Service Type>','<Location Type>','<Startdate>','<Enddate>',  '<Selectday>','<Starttime>','<Endtime>','<Skill Trade>','<Skill-Exchange>','<Active>' details
	Then : details will be created successfully with '<title>'

Examples: 
          | title    | Description                    | Category           | Subcategory | Tags     | Service Type         | Location Type | Startdate | Enddate    | Selectday | Starttime | Endtime  | Skill Trade    | Skill-Exchange | Active |
          | Selenium | This is a course for Beginners | Programming & Tech | QA          | Testing  | One-off service      | On-site       | 12/4/2022 | 12/5/2022  | Mon       | 15:00:00  | 16:00:00 | Skill-Exchange | Skill-Exchange | Hidden |
          | SQL      | Introduction to SQL            | Programming & Tech | Databases   | database | Hourly basis service | Online        | 12/9/2022 | 12/10/2022 | mon       | 15:00:00  | 16:00:00 | Skill-Exchange | Skill-Exchange | Hidden |

Scenario Outline: 2.Creating a Shareskill without mandatory details
Given : I am on my Profile Page
When : I click Save sharekill with out mandatory details for '<title>','<Description>','<Category>','<Subcategory>','<Tags>','<Service Type>','<Location Type>','<Startdate>','<Enddate>',  '<Selectday>','<Starttime>','<Endtime>','<Skill Trade>','<Skill-Exchange>','<Active>'
Then : I should get the '<errormessage>' displayed.
Examples: 
| title | Description                    | Category           | Subcategory | Tags | Service Type | Location Type | Startdate | Enddate | Selectday | Starttime | Endtime | Skill Trade | Skill-Exchange | Active | errormessage                        |
|       |                                | Programming & Tech | QA          |      |              |               |           |         |           |           |         |             |                |        | Please complete the form correctly. |
| Java  | This is a course for Beginners | Programming & Tech | Databases   |      |              |               |           |         |           |           |         |             |                |        | Please complete the form correctly. |


Scenario:3.Listing all the ShareSkillcreated under ManageListing
Given : I am on my Profile Page
When : I Click managelistings tab
Then : I should be able to see all the shareskill listings

Scenario Outline: 4.Editing the ShareSkill under manage listings
Given : I am on my Profile Page
When I Click editbutton of a skillshare listing
Then :I should be able to to change from '<title>' to new '<newtitle>'

Examples: 
| title | newtitle |
| Selenium   | MySQL    |

Scenario Outline: 5.Deleting the ShareSkill under manageshareskill
Given : I am on my Profile Page
When : I click delete button under shareskills which has '<title>' as title
Then : ShareSkill with the '<title>' must be deleted successfully

Examples: 
| title |
| SQL |




         