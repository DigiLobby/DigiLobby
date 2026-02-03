# BlissLobby
Visitor Management System for office spaces. Can also be used for residential spaces

# Actors
* SuperAdmin
* ClusterAdmin
* Resident / Employee
* Visitor
* Lobby Personnel

# Functional requirements
* User/actor authentication
* Pre-approval of visits by residents
* Visitor check-in based on pre-approval
* Visitor check-in based on instant resident approval
* Visitor check-in based on lobby personnel approval
* Visitor check-out by lobby personnel
* Reports for visitor activity analysis

# Non-functional requirements
* Self-hostable on-premise and on cloud
* No security vulnerabilities in the source code, frameworks, platforms used
* Encrypt data at rest and in-transit
* Source code based on Clean architecture and SOLID principles
* No sensitive data like api keys, passwords to be checked into source control
* Easy to use
* Encourage two-factor authentication
* Permissions/Privileges provided to User/Actor roles should follow principle of least privilege
* Support OAuth 2.0 providers, Active Directory for authentication
* Auditability and reconciliation capabilities. Logs should contain user identifiers and device identifiers wherever possible.
* Data Security
  * Notify resident if his visitor information is viewed by other application users
  * Option to purge visit data after 180 days
  * Show only resident name to other users to avoid exposure of personal information
  * Option to store only visitor face image/biometric data hash to avoid storing PII
  * Option for application admin (data security officer) to remove visitor's personal information and visit information
  * Option to take vistor consent (via physical signature or email) to store PII data and visit data
  * GDPR compliance
* Observability (dashboards and alarms) for application health and performance
* Support horizontal scalability (provide options for distributed cache)
* Support multi-tenancy after the application is matured for single tenant setup

# Interfaces
* Email
  * Application activity notifications
  * Visitor approvals notifications
  * User account management notifications
* Web application
  * Dashboards
  * Notifications
  * Approvals
  * User management
  * Reports viewing and management
  * Visitor invite CRUD
  * Visitor check-in resident approval
  * Visitor check-in via lobby personnel
  * Visitor check-in via pre-approved invite
  * Visitor check-out by lobby personnel
 
# UI screens

## User management
* User login page
* Users CRUD pages

## Invite management
* Invite generation page
* Invite listing page
* Invite editing page
* Invite cancellation page
* Invite checked-in success display page
 
# Technology stack 
* Dotnet web application as backend system
* HTTP as application communication protocol
* PostgreSQL for database in production environment 
* SQLite for database in testing environment 
* Entity Framework for ORM
* Identity framework for user authentication, authorization, session management, cookies, account management
* Cookies for session persistence in browser
* Blazor SSR for server side web page rendering
* Blazor Web assembly for in browser UI interactivity
* Controllers for API endpoints
* Mediatr for application commands and queries handling
* Fluent validation for request validation
* XUnit for application testing
* Docker for application packaging
* GitHub actions for CI CD

# TODOs
* Define the entities and relationships
* Define the logical data model for entities
* Define UI screens
* Define project scope exclusions to avoid scope creep
* Define application processes as user stories
* Define how to store notifications for efficient querying and also define retention plan
* Mention usage of blazor datatables to render paginated lists 
