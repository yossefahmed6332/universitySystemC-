# University System

A C# console application that models a university management system using object-oriented programming principles. The project is structured to reflect backend architecture patterns as a foundation for transitioning to ASP.NET Core development.

---

## Project Structure

```
UniversitySystem/
│
├── Models/
│   ├── User.cs
│   ├── Admin.cs
│   ├── Student.cs
│   ├── Teacher.cs
│   ├── Employee.cs
│   ├── Cleaner.cs
│   ├── Course.cs
│   ├── Department.cs
│   ├── Faculty.cs
│   ├── Address.cs
│   └── Location.cs
│
├── Interfaces/
│   ├── IAdminServiceOnAdmin.cs
│   ├── IAdminServiceOnStudent.cs
│   ├── IAdminServiceOnTeacher.cs
│   ├── IAdminServiceOnCourse.cs
│   ├── IAdminServiceOnDepartment.cs
│   ├── IAdminServicesOnFaculty.cs
│   ├── IAdminServiceOnCleaner.cs
│   ├── IAdminServiceOnLocation.cs
│   ├── IAdminServiceOnAddress.cs
│   ├── IStudentService.cs
│   └── ITeacherService.cs
│
└── Services/
    ├── AdminServiceOnAdmin.cs
    ├── AdminSeviceOnStudent.cs
    ├── AdminServiceOnTeacher.cs
    ├── AdminServiceOnCourse.cs
    ├── AdminServiceOnDepartment.cs
    ├── AdminServiceOnFaculty.cs
    ├── AdminServicesOnCleaner.cs
    ├── AdminServiceOnLocation.cs
    ├── AdminServiceOnAddress.cs
    ├── StudentService.cs
    └── TeacherService.cs
```

---

## Domain Model

| Class | Inherits From | Description |
|---|---|---|
| `User` | — | Abstract base for all users |
| `Admin` | `User` | Manages the system |
| `Student` | `User` | Enrolled in courses and departments |
| `Employee` | `User` | Abstract base for staff |
| `Teacher` | `Employee` | Teaches courses and grades students |
| `Cleaner` | `Employee` | Assigned to a location |
| `Course` | — | Belongs to a department |
| `Department` | — | Contains courses and teachers |
| `Faculty` | — | Contains departments |
| `Address` | — | Physical address for any user |
| `Location` | — | Campus building and floor |

---

## Entity Relationships

```
Faculty
  └── List<Department>
        ├── List<Course>
        └── List<Teacher>

Student
  ├── Department
  ├── List<Course>
  ├── List<string> Grades
  └── Address

Teacher
  ├── List<Course>
  └── Address

Cleaner
  ├── Location
  └── Address
```

---

## Services

### Admin
Full CRUD access over all entities: students, teachers, courses, departments, faculties, cleaners, locations, addresses, and other admins.

### Student
- Enroll in and drop courses
- View grades and GPA
- GPA is calculated based on letter grades weighted by credit hours

### Teacher
- Assign grades to enrolled students
- View assigned courses

---

## OOP Concepts Applied

| Concept | Application |
|---|---|
| Abstraction | `User` and `Employee` are abstract classes |
| Inheritance | `Student`, `Teacher`, `Admin`, `Cleaner` inherit from base classes |
| Encapsulation | All fields are private, exposed through properties |
| Interface Segregation | Each service has a dedicated interface |
| Separation of Concerns | Models, interfaces, and services are separated into distinct layers |

---

## Architecture Notes

The layered structure — Models, Interfaces, Services — mirrors the separation found in ASP.NET Core applications. The intent is to make the transition to a web API natural:

| Current | ASP.NET Equivalent |
|---|---|
| Static in-memory lists | Database via Entity Framework Core |
| Console output | HTTP responses from Controllers |
| Service classes | Service layer injected via Dependency Injection |
| Interfaces | Contracts used with DI container |
| Plain-text passwords | Hashed credentials |

---

## Requirements

- .NET 8 SDK or later

## Getting Started

```bash
git clone https://github.com/yossefahmed6332/universitySystemC.git
cd universitySystemC
dotnet run
```
