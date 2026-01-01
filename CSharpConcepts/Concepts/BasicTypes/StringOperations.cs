namespace CSharpConcepts.Concepts.BasicTypes;

public class StringOperations
{
    public static void Run()
    {
        Console.WriteLine("\n=== String Operations ===");
        
        // String concatenation
        string firstName = "John";
        string lastName = "Doe";
        string fullName = firstName + " " + lastName;
        Console.WriteLine($"Full Name: {fullName}");
        
        // String interpolation
        int age = 30;
        Console.WriteLine($"Age: {age}");
        
        // String methods
        Console.WriteLine($"Uppercase: {fullName.ToUpper()}");
        Console.WriteLine($"Lowercase: {fullName.ToLower()}");
        Console.WriteLine($"Length: {fullName.Length}");
    }
}
