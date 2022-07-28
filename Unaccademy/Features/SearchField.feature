Feature: SearchField

A short summary of the feature

@tag1
	#Scenario: Verifying Unaccademy Search field functionality on chrome
#Given Chrome is Launched and Unacademy application is launched
#When User clicks on Login button
#And User enters Registered Phone number "9110211917"
#Then It shows home Page
#When User click on the Search text box
#Then Search text box Should be clickable

Scenario: Verifying Unaccademy Search field Fnctionality on chrome
	Given Chrome is Launched and Unacademy application is launched
	When User clicks on Login button
	And User enters Registered Phone number "9110211917"
	Then It shows home Page
	When User click on the Search text box
	And enter the educators
	And Click on educators
   Then educators page will be display



Scenario: Verifying Unaccademy Search field Fnctionality on chromes
	Given Chrome is Launched and Unacademy application is launched
	When User clicks on Login button
	And User enters Registered Phone number "9110211917"
	Then It shows home Page
	When User click on the Search text box
	And enter the lessons
	And Click on lessons
    Then lessons page will be display



	

Scenario: Verifying Unacademy Search field Functionality of courses page on chrome
	Given Chrome is Launched and Unaccademy application is launched
	When User clicks on Login button
	And User enters Registered Phone number "9110211917"
	Then It shows home Page
	When User clicks on Search text box
	And enter the courses
	And Click on courses
	Then courses page will be display




	Scenario: Verifying Unacademy Search field functionality of educator page on Chrome
	Given Chrome is Launched and Unaccademy application is launched
	When User clicks on Login button
	And User enters Registered Phone number "9110211917"
	Then It shows home Page
	When User clicks on search text Box
	And enter the educators From karnataka
	And Click on educators From karnataka
  Then educators from Karnataka page will be display


  Scenario: Verifying Unacademy Search field Functionality of Lessons page on Chrome
	Given Chrome is Launched and Unaccademy application is launched
	When User clicks on Login button
	And User enters Registered Phone number "9110211917"
	Then It shows home Page
	When User clicks on Sarch text Box
	And enter the lessons On Antropology
	And Click on lessons On Antropology
	Then lessons on Antropolog Page will be display
