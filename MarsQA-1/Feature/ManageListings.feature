Feature: ManageListings- As a user I would like to manage  ManageListings

A short summary of the feature

Scenario Outline:1.Listing all the ShareSkillcreated under ManageListing
Given : I am on my Profilepage
When : When i create new shareskill with valid '<title>','<Description>','<Category>','<Subcategory>','<Tags>','<Service Type>','<Location Type>','<Startdate>','<Enddate>',  '<Selectday>','<Starttime>','<Endtime>','<Skill Trade>','<Skill-Exchange>','<Active>' details
When : I Click managelistings tab
Then : I should be able to see the shareskill listings with '<title>'
Examples: 
          | title   | Description                    | Category           | Subcategory | Tags     | Service Type         | Location Type | Startdate | Enddate    | Selectday | Starttime | Endtime  | Skill Trade    | Skill-Exchange | Active |
          | C         | This is a course for Beginners | Programming & Tech | Other         | programming  | One-off service      | On-site       | 12/9/2022 | 12/10/2022  | Mon       | 15:00:00  | 16:00:00 | Skill-Exchange | Skill-Exchange | Hidden |

Scenario Outline: 2.Editing the ShareSkill under manage listings
Given : I am on my Profilepage 
When I Click editbut ton of a skillshare listing
Then :I should be able to to change from title to new '<newtitle>'

Examples: 
 | newtitle |
 | SQL   |

Scenario Outline: 3.Deleting the ShareSkill under manageshareskill
Given : I am on my Profilepage
When : I click delete button under shareskills which has '<title>' as title
Then : ShareSkill with the '<title>' must be deleted successfully

Examples: 
| title |
| SQL |

Scenario Outline: 4. No listing under Managelistings
Given : I am on my Profilepage
When : I Click managelistings 
Then : I should be able to see the the message '<message>'
Examples: 
| message                               |
| You do not have any service listings! |

