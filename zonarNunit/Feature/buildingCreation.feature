﻿Feature: buildingCreation
	In this feature 
	We can create building
	We see all needed information
	We can check result Table on both Tab(Zoning Allowance, Capacity Analisys) 

@Smoke @buildingCreation @Stable

Scenario: Creation Building (save delete project)
 Given I Have Main Page With Login User
 And I have Opened My Buildings Tab
 When I Click Create building Button
 And I Fill-in Fields on Create buildings form
 Then Progect Page is opened
 When I Click Save Button
 And I link to My Building Tab
 Then Project is saved 
 When I have Delete Project
 Then Project is deleted
 And  I see my name in a conner
 



@Smoke @buildingCreation  @Stable
Scenario: Check Format values on Zoning Allowances tab
 Given I Have Opened Project Page
 When I Have Opened Tab Zoning Allowances
 Then Values with right formats are displayed 
 When I link to My Building Tab
 And I have Delete Project
 Then Project is deleted
 And  I see my name in a conner


@Smoke @buildingCreation @Stable
Scenario: Check Format values on Capacity Analysis tab
 Given I Have Opened Project Page
 When I Have Opened Tab Capacity Analysis
 And I Set Case Study Calibratuion section to Average values
 And I have Opened Resukt Table on Capacity Analisis Tab 
 And I Click Save Button
 Then Values with right formats are displayed on Tab Capacity Analysis
 When I link to My Building Tab
 And I have Delete Project
 Then Project is deleted
 And  I see my name in a conner


 @buildingCreation @Stable
 Scenario Outline: Basic calculation test
 Given I Have Main Page With Login User
 And I have Opened My Buildings Tab
 When I Click Create building Button
 And I Have "<zoningData>"
 Then Progect Page is opened
 When I Click Save Button
 And I have Setup Building Parameters
 And I get zoningResult Maximum Lot Capacity Table data
 Then I compare with "<templateData>"

 Examples: 
 | zoningData	| templateData  |
 | Maimi		| templateMaimi |
 | Maimi1		| templateMaimi |


 @buildingCreation 
 Scenario Outline: Capacity Analysis Basic calculation
 Given I Have Main Page With Login User
 And I Have "<zoningData>"
 And I create project with "<zoningData>"
 And I link to Capacity Analysis Tab
 Then I have "<activeNotifications>" are displayed
 When I set "<capacityData>" Case Study Calibration
 Then I get "<capacityResult>" Result Data
 And I compare "<capacityResult>" with "<capacityTemplate>"


 Examples:  
 | capacityData  | activeNotifications		| capaCityData		| capacityResult | capacityTemplate |
 | MaimiCapacity | activeNotificationsMaimi |maimiCapacityData	| result         | MaimiTemplate    |






