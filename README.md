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
* Pre-approval of visits by residents/employees
* Visitor check-in based on pre-approval
* Visitor check-in based on instant resident approval
* Visitor check-in based on lobby personnel approval
* Visitor check-out by lobby personnel
* Reports for visitor activity analysis

# Interfaces
* Email
  * Application notifications
  * Visitor approvals by residents
* Web application
  * Dashboards
  * User management
  * Reports viewing and management
  * Visitor invite generation
  * Visitor check-in resident approval
  * Visitor check-in via lobby personnel
  * Visitor check-in via pre-approved invite
  * Visitor check-out by lobby personnel
 
# Technology stack 
* Dotnet for backend
* PostgreSQL for database in production environment 
* SQLite for database in testing environment 
* Entity Framework for ORM
* Identity framework for user authentication, authorization, session management, cookies, account management
* Cookies for session persistence in browser
* Blazor SSR for server side web page rendering
* Blazor Web assembly for in browser UI interactivity
* Controllers for API endpoints
    

