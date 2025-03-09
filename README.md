# Family Tree MVP

## Overview
Family Tree is a private, collaborative web application designed to help family members build and share a comprehensive family history. The initial MVP will focus on core functionalities such as adding, viewing, and managing family members and their relationships. Future enhancements will include GEDCOM integration, advanced visualizations, authentication, and eventually cloud deployment.

## Table of Contents
- [Project Description](#project-description)
- [Features](#features)
- [Tech Stack](#tech-stack)
- [Architecture and Data Model](#architecture-and-data-model)
- [Setup and Deployment](#setup-and-deployment)
- [Roadmap and Future Enhancements](#roadmap-and-future-enhancements)

## Project Description
The purpose of this project is to create a private tool that allows family members to collaboratively build a family tree. The MVP will focus on:
- Managing family member data (basic CRUD operations).
- Representing relationships using a self-referencing data model.
- Providing a simple and responsive UI for data entry and visualization.

While the MVP is designed for local deployment, future enhancements will extend the functionality and integrate cloud services to broaden accessibility.

## Features

### MVP Features
- **CRUD Operations:** Create, read, update, and delete family member records.
- **Basic Relationship Management:** Capture simple parent-child relationships using a self-referencing data model.
- **List View Visualization:** Display family members in a simple list and/or hierarchical structure.
- **Local Deployment:** Run the application locally without cloud integration.

### Future Enhancements
- **GEDCOM Support:** Import and export genealogical data using the GEDCOM standard.
- **Cloud Integration:** Deploy the application on cloud platforms (e.g., Azure, AWS) to enhance accessibility and scalability.
- **Enhanced UI/UX:** Implement interactive tree views, search functionality, and filtering options.
- **Authentication & Security:** Introduce user authentication and role-based access control.
- **Complex Relationship Handling:** Support for additional relationship types (stepfamilies, adoptions, etc.).

## Tech Stack

- **Backend:**
  - **.NET 9** – Leveraging the latest .NET framework for improved performance and language features.
  - **ASP.NET Core Web API** – For creating RESTful endpoints.
  - **Entity Framework Core** – To manage data access and ORM capabilities.

- **Frontend:**
  - **Blazor (Server/WebAssembly)** – For building interactive web pages using .NET.
  - **CSS Frameworks** – Such as Bootstrap or Tailwind CSS for responsive design.

- **Database:**
  - **SQL Server** (or SQLite for development purposes) – For storing family tree data.

- **Development Tools:**
  - **Visual Studio / Visual Studio Code** – For code development.
  - **Git** – For version control and collaboration.

## Architecture and Data Model

### Architecture
The application follows a client-server model:
- **Backend:** A .NET 9 Web API handles data operations and serves as the data source for the application.
- **Frontend:** A Blazor application consumes the API to display data and manage user interactions.

### Data Model
The core entity is the `FamilyMember`, which represents an individual in the family tree.

**FamilyMember Entity:**
- **Id:** Unique identifier.
- **FirstName / LastName:** Basic personal details.
- **DateOfBirth:** Optional birth date.
- **ParentId:** A foreign key that references another `FamilyMember` to create a parent-child relationship.
- **Children:** A collection of child `FamilyMember` records (self-referencing relationship).

## Setup and Deployment

### Prerequisites
- [.NET 9 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)
- SQL Server or SQLite (for local development)
- Visual Studio / Visual Studio Code
- Git

D:\repos\FamilyTree\
├── FamilyTree.sln
├── FamilyTree.API\
│   └── (API project files)
└── FamilyTree.Web\
    └── (Blazor project files)

![image](https://github.com/user-attachments/assets/44fe3ee2-fe36-4783-b14a-3e876bb6a17f)


## Roadmap and Future Enhancements 

### Phase 1 (MVP)
Develop core backend API with CRUD operations for family member data.
Build a basic Blazor frontend to add and display family members.
Deploy locally for testing and validation.

### Phase 2 (Feature Enhancements)
Implement GEDCOM import/export functionality for data interoperability.
Enhance the UI with interactive and visually appealing family tree views.
Introduce user authentication and role-based permissions.

### Phase 3 (Cloud Integration)
Transition to cloud deployment (e.g., Azure App Service) for broader accessibility.
Optimize application performance and scalability in the cloud environment.

### Phase 4 (Advanced Features)
Expand support for complex family relationships and additional relationship types.
Integrate historical data, document uploads, and other genealogical resources.
