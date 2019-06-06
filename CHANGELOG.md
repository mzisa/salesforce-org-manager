# Changelog
All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## [Unreleased]
- New lightning web component should allow target and target config selections

## [1.6.1] - 2019-06-06
### Changed
- Fixed bug on lightning web component creations and retrieve

## [1.6.0] - 2019-06-03
### Added
- Org metadata tree can manage all metadata types now
- Added project metadata configuration form: now you can select which metadata you want to consider in your code project
- Implemented local cache for metadata to boost performance on large ORGs: in project configuration form you can now choose to use metadata cache in your project (**recommended and enabled by default**) or not

### Changed
- Improved static resources management
- Performance optimizations
- If you want download just the executable, you can now simply grab the /Release folder content

### Removed
- DEPLOY TO SERVER functionality

## [1.5.1] - 2019-05-16
### Changed
- Code optimizations
- Fixed bug: while creating a new metadata the related root node did not set its foreground color to blue
- Fixed encoding on xml file descriptors for metadata: from UTF-8 BOM to UTF-8 (without BOM)

## [1.5.0] - 2019-05-13
### Added
- Create new lightning web component functionality
- Added WIKI page to explain how to create a new lightning web component

### Changed
- Fixed TabIndex on creation forms
- Fixed encoding on xml manifest file: from UTF-8 BOM to UTF-8 (without BOM)

## [1.4.2] - 2019-05-08
### Changed
- Added new pages to WIKI documentation
- Minor fixes

## [1.4.1] - 2019-05-07
### Changed
- Untrack of non-significant files
- Added new pages to WIKI documentation

## [1.4.0] - 2019-05-06
### Added
- The application now can generate both login.json and orgConfig.json file if they do not exist

### Changed
- Settings: Workspace path input now give the chance to select the path by browsing the local filesystem instead of write down the entire path manually
- Settings: Workspace path input now give the chance to create a new folder and select the same as workspace
- Closing the Org Tree form will get the user to the main form

### Deferred
- UPDATE PROJECT feature should warn the user whether any metadata he is going to replace on the target Org are newer then the ones on the local project (i.e. just in case the metadata were updated by someone else...) --> Every metadata update in SFDX Projects is basically a new deploy and therefore this feature would not be feasible...

## [Updated changelog] - 2019-05-06
- Updated changelog with further unreleased steps
- Added .gitignore file
- Untrack of non-significant files

## [1.3.0] - 2019-05-03
### Changed
- Added recent API number for new trigger creation
- Put masking on text input fields for both passord and security token in Settings form
- Other minor fixes

## [Added new pages to WIKI documentation] - 2019-04-30
### Added
- How to create a new lightning app
- How to create a new lightning component
- How to create a new lightning event
- How to create a new lightning interface

## [1.2.1] - 2019-04-30
### Changed
- Minor fixes in workspaces management

## [1.2.0] - 2019-04-29
### Changed
- The application now checks that every workspace exists at startup, if any or all the workspaces do not exist they are removed forever from the workspace list

### Added
- Now the user can choose whether to encrypt (or not) the org credentials of the keystore

## [1.1.1] - 2019-04-29
### Changed
- Fix on metadata creation and publication on the target ORG


## [1.1.0] - 2019-04-24
### Changed
- Creating a new metadata on the ORG  publish it on the local project contextually now

## [1.0.1] - 2019-04-24
### Changed
- Icon for DEPLOY TO SERVER functionality
- Icon for API USAGE functionality

### Removed
- DEPLOY CONNECTIONS functionality
- Execute Anonymous Apex functionality
- Last tab of main form

## [1.0.0] - 2019-04-22
### Added
- Login to a SFDC org
- Creation of a Saleforce DX project with default manifest file
- Refresh metadata index
- Update (local) project
- Select ALL org items
- Deselect ALL org items
- New Apex Class creation
- New Visualforce page creation
- New Apex Trigger creation
- New Static Resource creation
- New Lightning App creation
- New Lightning Component creation
- New Lightning Interface creation
- New Ligthning Event creation
- Execute Anonymous Apex
- View latest 50 debug logs
- View SFDC Api Usage
- Setting section
	- Add new workspace
	- Remove workspace
	- Default metadata for new project
	- Create new LOGIN GROUP
	- Delete LOGIN GROUP
	- Manage logins LOGIN GROUP
	- Create new LOGIN
	- Delete LOGIN
	- Set LOGIN as default for work session
	
