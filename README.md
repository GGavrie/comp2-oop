# USF Library Management System

In this competition, you will collaboratively develop a USF Library Management System in groups. The system will manage books, students, and staff, supporting basic operations such as borrowing, returning, and displaying information about books and patrons.

## Objectives

- Apply Object-Oriented Programming (OOP) concepts like inheritance and encapsulation.
- Use GitHub for version control and code collaboration.

## System Overview

### Classes to Create

- **Person**: Base class with `Name`, `Email`, and `ID` properties.
- **Student**: Inherits from `Person`; adds `Major` and `GraduationYear` properties.
- **Staff**: Inherits from `Person`; adds `Position` and `Department` properties.
- **Book**: Includes properties for `Title`, `Author`, `ISBN`, `AvailableCopies`, and a method to borrow books.
- **Library**: Manages collections of books and patrons; provides `DisplayBooks` and `DisplayPatrons` methods.

### Functionality to Implement

- Add new books and patrons.
- Borrow and return books.
- Display library information, including book and patron details.
- Perform validation checks (e.g., verify book availability).

### Objects to Create in Main

#### Books

- `Book("The Art of Data Strategy", "Liam Reynolds", "ISBN111", 4)`
- `Book("Business Insights with AI", "Olivia Carter", "ISBN222", 3)`
- `Book("Analytics in Action", "Nathan Brooks", "ISBN333", 6)`

#### Students

- `Student("Akhil", "akhil@usf.edu", "S001", "Business Analytics", 2026)`
- `Student("Sandeep", "sandeep@usf.edu", "S002", "Information Systems", 2025)`

#### Staff

- `Staff("Grandon Gill", "grandon@usf.edu", "ST001", "Librarian", "Library Services")`

### Scenario/Tasks

*For the scope of this competition, implement a simple borrow books scenario (optionally extend as desired):*

1. **Borrow Books:**
   - Sandeep borrows “Business Insights with AI”.
   - Akhil borrows “Analytics in Action”.

2. **Update and Display:**
   - Update `AvailableCopies` after borrowing.
   - Display initial state of books (before borrowing).
   - Display patrons in the library.
   - Display borrowing actions.
   - Display books after borrowing.

## Sample Reference Output

```
Books in Library:
Title: The Art of Data Strategy, Author: Liam Reynolds, Available Copies: 4
Title: Business Insights with AI, Author: Olivia Carter, Available Copies: 3
Title: Analytics in Action, Author: Nathan Brooks, Available Copies: 6

Patrons in Library:
Name: Akhil, ID: S001
Name: Sandeep, ID: S002
Name: Grandon Gill, ID: ST001

Borrowing Books...
Sandeep borrowed 'Business Insights with AI'
Akhil borrowed 'Analytics in Action'

Books after borrowing:
Books in Library:
Title: The Art of Data Strategy, Author: Liam Reynolds, Available Copies: 4
Title: Business Insights with AI, Author: Olivia Carter, Available Copies: 2
Title: Analytics in Action, Author: Nathan Brooks, Available Copies: 5
```

---

## Run the Application

```bash
dotnet run --project comp2.csproj
```

## Project Files

- `comp2.cs` - Program entry point and sample scenario implementation
- `Library.cs` - Contains library logic (books, patrons, borrowing)
- `Book.cs` - Defines the book class and related logic
- `Person.cs` - Base class for all patrons
- `Student.cs` - Student class (inherits from Person)
- `Staff.cs` - Staff class (inherits from Person)
