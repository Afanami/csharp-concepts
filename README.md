# csharp-concepts
Deeper Dive into C# Concepts and Fundamentals

## Overview
This is a boilerplate C# console application project for learning and implementing C# concepts. You can create folders and files to implement various C# concepts and run them from the Program.cs file.

## Prerequisites
- .NET SDK 8.0 or higher

## Project Structure
```
CSharpConcepts/
├── Concepts/
│   ├── BasicTypes/         # Examples of basic data types and operations
│   ├── OOP/                # Object-Oriented Programming concepts
│   └── LINQ/               # LINQ query examples
├── Program.cs              # Main entry point - run concepts from here
└── CSharpConcepts.csproj   # Project configuration
```

## Getting Started

### Clone and Navigate
```bash
cd CSharpConcepts
```

### Build the Project
```bash
dotnet build
```

### Run the Project
```bash
dotnet run
```

## Adding New Concepts

### 1. Create a New Folder
Create a folder under `Concepts/` for your concept category:
```bash
mkdir Concepts/YourConceptName
```

### 2. Create a Class File
Create a `.cs` file in your new folder:
```csharp
namespace CSharpConcepts.Concepts.YourConceptName;

public class YourConcept
{
    public static void Run()
    {
        Console.WriteLine("\n=== Your Concept ===");
        // Your implementation here
    }
}
```

### 3. Call from Program.cs
Update `Program.cs` to run your concept:
```csharp
using CSharpConcepts.Concepts.YourConceptName;

// In the main code
YourConcept.Run();
```

## Example Concepts Included

### Basic Types - String Operations
- String concatenation
- String interpolation
- String methods (ToUpper, ToLower, Length)

### Object-Oriented Programming - Person Class
- Class definition with properties
- Constructors
- Methods

### LINQ Examples
- Filtering with Where
- Projection with Select
- Aggregation with Sum

## Tips
- Comment out concepts in `Program.cs` that you don't want to run
- Each concept should have a `Run()` method for easy execution
- Use meaningful namespaces that reflect the folder structure
- Keep concepts focused and self-contained

## License
See LICENSE file for details.
