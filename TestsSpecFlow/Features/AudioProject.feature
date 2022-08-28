Feature: AudioProject
	A file space and data structure for managing audio projects.

@mytag
Scenario: Create project defaults for new projects.
	When a new project is created
	Then the project name should be "defaultProject"