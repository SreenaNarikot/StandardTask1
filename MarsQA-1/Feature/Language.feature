Feature: Creating the Language in the Profile page with valid credentials



Scenario Outline: 1.Creating a new Language details
	Given : I am on my Profile Page
	When  : I click new language with valid '<language>' and '<level>' details
	Then : The Language details with '<language>' and '<level>' will be created successfully.


Examples: 
          | language | level  |
          | English  | Basic  |
          | French   | Fluent |

Scenario Outline: 2.Reading the record created for Language
Given : I am on my Profile Page
Then : '<count>' Records must have been created successfully
Examples: 
| count |
| 2     |



Scenario Outline: 3.Editing languges that has been created
Given : I am on my Profile Page
When :I click update the record with  new '<language>' and '<level>'
Then : the Record should have been edited successfully with  '<language>' and '<level>' .
Examples: 
| language | level  |
| Hindi     | Fluent |
| Spanish   | Basic  |

Scenario Outline: 4.Reading the language that has been edited
Given : I am on my Profile Page
Then : the record is updated with new details '<language>' ,'<level>'.
Examples: 
| language | level  |
| Spanish  | Basic  |

Scenario Outline: 5.Deleting a record from the languagetab
Given : I am on my Profile Page
When : I click delete button
Then : The record '<language>'will be deleted
Examples: 
| language |
| spanish  |

