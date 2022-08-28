Feature: AudioProject
	A file space and data structure for managing audio projects.

Scenario: Create project defaults for new projects.
	When a new project is created
	Then the project name should be "defaultProject"
	
Scenario: Create a project and change its name.
	Given a new project is created
	When the project name is changed to "project eagle"
	Then the project name should be "project eagle"
	
Scenario: Create a project and change its website address.
	Given a new project is created
	When the project website is changed to "https://www.kumc.edu/project-eagle.html"
	Then the project website should be "https://www.kumc.edu/project-eagle.html"
