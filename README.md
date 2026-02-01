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
* Application should be self-hostable on-premise and on cloud
* No security vulnerabilities in the application code
* Easy to use
* Two-factor authentication
* Support OAuth 2.0 providers, Active Directory for authentication
* Auditability and reconciliation capabilities
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
 
# Technology stack 
* Dotnet web application as backend system
* PostgreSQL for database in production environment 
* SQLite for database in testing environment 
* Entity Framework for ORM
* Identity framework for user authentication, authorization, session management, cookies, account management
* Cookies for session persistence in browser
* Blazor SSR for server side web page rendering
* Blazor Web assembly for in browser UI interactivity
* Controllers for API endpoints
* XUnit for application testing
* Docker for application packaging
* GitHub actions for CI CD
    

