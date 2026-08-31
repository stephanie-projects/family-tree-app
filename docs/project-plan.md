Family Tree Management Application
Project Overview
The Family Tree Management Application is a full-stack web application designed to make creating, maintaining, and expanding a family tree simple.
Users will be able to add family members, define relationships between people, edit existing information, and gradually add additional attributes as their family history grows.
The project will initially focus on building a clean and extensible data model and user experience. Future versions may include cloud hosting, authentication, document and photo storage, visualization of family relationships, and AI-assisted family history features.
Why I Am Building This
The goal of this project is to strengthen my experience with modern full-stack development while building a practical application that can continue growing over time.
The project will provide hands-on experience with:
•	C# and ASP.NET Core
•	REST API development
•	React and TypeScript
•	Relational database design
•	MySQL
•	Entity Framework Core
•	Object-oriented application architecture
•	CRUD operations
•	API validation
•	Authentication and authorization
•	Cloud deployment with Azure or AWS
•	Automated testing
•	CI/CD
•	AI-assisted software development
Initial Technology Stack
Frontend
React
TypeScript
HTML/CSS
Backend
C#
ASP.NET Core Web API
Database
MySQL
Database Access
Entity Framework Core
Development Tools
Git
GitHub
Visual Studio or VS Code
Swagger / OpenAPI
Postman
Future Infrastructure
Azure or AWS
High-Level Architecture
React Frontend
↓
ASP.NET Core REST API
↓
Service / Business Logic Layer
↓
Entity Framework Core
↓
MySQL Database
The frontend should never communicate directly with the database. All requests will go through the C# API.
MVP — Version 1
The first version should stay intentionally small.
A user should be able to:
1.	Create a family member.
2.	View family members.
3.	View an individual family member.
4.	Edit a family member.
5.	Delete a family member.
6.	Connect two people through a family relationship.
7.	View the relationships associated with a person.
Initial Family Member Attributes
First Name
Middle Name
Last Name
Maiden Name
Date of Birth
Date of Death
Birthplace
Gender
Biography / Notes
Not every field will be required.
The database and application should be designed so additional attributes can be added later without requiring a major rewrite.
Relationship Types
The initial system should support relationships such as:
Parent
Child
Spouse
The system should store relationships between people rather than storing fields such as MotherId and FatherId directly on every person.
This will make the model easier to extend later for situations including:
Adoptive parents
Step parents
Multiple marriages
Guardians
Unknown parents
Other relationship types
Initial Database Concept
FamilyMember
Id
FirstName
MiddleName
LastName
MaidenName
DateOfBirth
DateOfDeath
BirthPlace
Gender
Biography
CreatedDate
UpdatedDate
Relationship
Id
PersonId
RelatedPersonId
RelationshipType
CreatedDate
Example:
PersonId: Stephanie
RelatedPersonId: Parent A
RelationshipType: Parent
The exact relationship model may change after experimenting with the application.
Initial API Endpoints
Family Members
GET /api/familymembers
Returns all family members.
GET /api/familymembers/{id}
Returns one family member.
POST /api/familymembers
Creates a family member.
PUT /api/familymembers/{id}
Updates a family member.
DELETE /api/familymembers/{id}
Deletes a family member.
Relationships
GET /api/familymembers/{id}/relationships
Returns relationships for a family member.
POST /api/relationships
Creates a relationship.
PUT /api/relationships/{id}
Updates a relationship.
DELETE /api/relationships/{id}
Removes a relationship.
Initial Frontend Pages
Home / Dashboard
Basic introduction and summary of the family tree.
Family Members
List or searchable table of people currently stored.
Add Family Member
Form used to create a new family member.
Family Member Profile
Displays personal information and relationships.
Edit Family Member
Allows information to be updated.
A graphical tree visualization can be added after the basic CRUD functionality works.
Development Phases
Phase 1 — Project Foundation
Create GitHub repository.
Create ASP.NET Core Web API.
Create React + TypeScript frontend.
Create MySQL database.
Connect ASP.NET Core to MySQL through Entity Framework Core.
Configure Swagger.
Create initial project documentation.
Phase 2 — Family Member CRUD
Create FamilyMember entity.
Create DTOs.
Create API endpoints.
Add validation.
Test endpoints through Swagger/Postman.
Build React family-member list.
Build create/edit forms.
Connect React to the API.
Phase 3 — Family Relationships
Create relationship database model.
Create relationship endpoints.
Add parents, children, and spouses.
Display relationships on individual profiles.
Add validation to prevent invalid relationships.
Phase 4 — User Experience
Search family members.
Filter or sort records.
Improve forms.
Add loading/error states.
Improve responsive design.
Create a simple family tree visualization.
Phase 5 — Authentication
Add user accounts.
Implement authentication.
Protect API endpoints.
Allow users to maintain separate family trees.
Add authorization rules.
Phase 6 — Cloud Deployment
Deploy the React application.
Deploy the ASP.NET Core API.
Move MySQL to a managed database.
Store application secrets securely.
Configure application logging.
Possible platforms:
Azure App Service
Azure Database for MySQL
or
AWS Elastic Beanstalk / ECS / App Runner
Amazon RDS for MySQL
Phase 7 — Engineering Improvements
Unit tests.
Integration tests.
Logging.
Centralized exception handling.
CI/CD pipeline.
Docker containers.
Performance monitoring.
Database indexing.
Pagination.
Phase 8 — Advanced Family History Features
Photos.
Documents.
Sources and citations.
Addresses.
Occupations.
Education.
Military history.
Important life events.
Multiple family trees.
Family-tree sharing.
Import/export.
GEDCOM support.
Possible AI Features
AI should be added after the basic application architecture works rather than being the foundation of the application.
Possible features include:
Biography Assistant
Transform structured family information into a readable biography.
Historical Document Extraction
Upload an obituary or family document and have AI suggest:
Names
Birth dates
Death dates
Locations
Relationships
The user would review the extracted information before it is saved.
Relationship Assistant
Allow users to enter information conversationally, such as:
"James Smith is Robert Smith's father and married Mary Johnson in 1974."
The AI could convert the statement into proposed people, relationships, and attributes for user approval.
Family History Search Assistant
Allow questions such as:
"Who are all of my relatives who lived in Texas?"
or
"Which family members were born before 1950?"
AI could translate the question into application/database queries.
Portfolio Goals
When completed, this project should demonstrate that I can:
Design a relational database.
Build a REST API using ASP.NET Core.
Develop reusable C# services and application logic.
Use DTOs and validation.
Use Entity Framework Core.
Build a React/TypeScript frontend.
Integrate frontend and backend applications.
Design CRUD workflows.
Model complex relationships.
Write automated tests.
Deploy an application to the cloud.
Use Git and CI/CD.
Implement authentication and authorization.
Integrate AI into an existing software system.
Development Philosophy
The project will be developed incrementally.
The first goal is not to build the perfect family-tree application.
The first goal is to create a small working system with a clean architecture.
Features will be added only after the previous version is functional and understandable.
Each major feature should result in a usable Git commit and, when appropriate, a GitHub issue documenting the change.

