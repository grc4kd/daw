Feature: AudioProject
	A file space and data structure for managing audio projects.

Scenario: Create project defaults for new projects.
	When a new project is created
	Then the project name should be "defaultProject"
	
Scenario: Create a project and change it's name.
	Given a new project is created
	When the project name is changed to "project eagle"
	Then the project name should be "project eagle"