Feature: Roles
	We have restrictions for different roles
		tab. calibration			user management				 edit base codes
basic		  0                          0                              0
pro           1                          0                              0
admin         1                          1                              1
editor        1                          1                              1


@Roles @Smoke
Scenario: BasicRolePermissionsUserManagement
 Given I have Opened Login Page
 And I have entered Exist Basic Login
 And I have entered Exist Basic Password
 When I press Login Button
 Then The result Account Page is Opened
 And I don't see User Management Tab 
 
 @Roles @Smoke 
Scenario: BasicRolePermissionsCalibration
 Given I have Opened Login Page
 And I have entered Exist Basic Login
 And I have entered Exist Basic Password
 When I press Login Button
 Then The result Account Page is Opened
 When I have Open My Buildings Tab
 And I open Existed Building
 Then I don't see Calibration Tab

 @Roles @Smoke
Scenario: BasicRolePermissionsBaseCodes
 Given I have Opened Login Page
 And I have entered Exist Basic Login
 And I have entered Exist Basic Password
 When I press Login Button
 Then The result Account Page is Opened
 When I Have Open Base Codes Tab
 Then Clone Button is absent
 And Clone to Custon Codes Button is absent
 And Check-boxes on Base Codes Tab is absent
 
 @Roles @Smoke
Scenario: ProRolePermissionsUserManagement
 Given I have Opened Login Page
 And I have entered Exist Pro Login
 And I have entered Exist Pro Password
 When I press Login Button
 Then The result Account Page is Opened
 And I don't see User Management Tab 
 
 @Roles @Smoke 
Scenario: ProRolePermissionsCalibration
 Given I have Opened Login Page
 And I have entered Exist Pro Login
 And I have entered Exist Pro Password
 When I press Login Button
 Then The result Account Page is Opened
 When I have Open My Buildings Tab
 And I open Existed Building
 And I open Calibration Tab
 Then I have Opened Calibration Tab

 @Roles @Smoke
Scenario: ProRolePermissionsBaseCodes
 Given I have Opened Login Page
 And I have entered Exist Pro Login
 And I have entered Exist Pro Password
 When I press Login Button
 Then The result Account Page is Opened
 When I Have Open Base Codes Tab
 Then Clone Button is absent
 And Clone to Custon Codes Button is absent
 And Check-boxes on Base Codes Tab is absent

 @Roles @Smoke
Scenario: AdminRolePermissionsUserManagement
 Given I have Opened Login Page
 And I have entered Exist Admin Login
 And I have entered Exist Admin Password
 When I press Login Button
 Then The result Account Page is Opened
 When I open User Management Tab 
 Then I have opened User Management Tab 
 
 @Roles @Smoke 
Scenario: AdminRolePermissionsCalibration
 Given I have Opened Login Page
 And I have entered Exist Admin Login
 And I have entered Exist Admin Password
 When I press Login Button
 Then The result Account Page is Opened
 When I have Open My Buildings Tab
 And I open Existed Building
 And I open Calibration Tab
 Then I have Opened Calibration Tab

 @Roles @Smoke
Scenario: AdminRolePermissionsBaseCodes
 Given I have Opened Login Page
 And I have entered Exist Admin Login
 And I have entered Exist Admin Password
 When I press Login Button
 Then The result Account Page is Opened
 When I Have Open Base Codes Tab
 Then Clone Button is present
 And Clone to Custon Codes Button is present
 And Check-boxes on Base Codes Tab is present

 @Roles @Smoke
Scenario: EditorRolePermissionsUserManagement
 Given I have Opened Login Page
 And I have entered Exist Editor Login
 And I have entered Exist Editor Password
 When I press Login Button
 Then The result Account Page is Opened
 When I open User Management Tab 
 Then I have opened User Management Tab 
 
 @Roles @Smoke 
Scenario: EditorRolePermissionsCalibration
 Given I have Opened Login Page
 And I have entered Exist Editor Login
 And I have entered Exist Editor Password
 When I press Login Button
 Then The result Account Page is Opened
 When I have Open My Buildings Tab
 And I open Existed Building
 And I open Calibration Tab
 Then I have Opened Calibration Tab

 @Roles @Smoke
Scenario: EditorRolePermissionsBaseCodes
 Given I have Opened Login Page
    And I have entered Exist Editor Login
 And I have entered Exist Editor Password
 When I press Login Button
 Then The result Account Page is Opened
 When I Have Open Base Codes Tab
 Then Clone Button is present
 And Clone to Custon Codes Button is present
 And Check-boxes on Base Codes Tab is present