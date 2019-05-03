# Changelog
All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## [Unreleased]
- Fix DEPLOY TO SERVER functionality
- Implement local cache for metadata to boost performance on large ORGs
- Create new ligthtning web component functionality
- Give the chance to navigate back to the main form from the org tree form

## Added new pages to WIKI documentation - 2019-04-30
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
	