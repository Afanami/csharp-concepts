namespace CSharpConcepts.Concepts.DeepDives;

public class ExceptionHandling
{
    public static void Run()
    {
        Console.WriteLine("\n=== Deep Dive: Exception Handling ===");
        
        // Basic try-catch
        Console.WriteLine("\n1. Basic Try-Catch:");
        try
        {
            int[] numbers = { 1, 2, 3 };
            Console.WriteLine($"   Accessing index 5: {numbers[5]}");
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine($"   Caught: {ex.GetType().Name}");
        }
        
        // Multiple catch blocks
        Console.WriteLine("\n2. Multiple Catch Blocks:");
        try
        {
            string? text = null;
            Console.WriteLine($"   Length: {text!.Length}");
        }
        catch (NullReferenceException ex)
        {
            Console.WriteLine($"   Caught NullReferenceException: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"   Caught general exception: {ex.Message}");
        }
        
        // Finally block
        Console.WriteLine("\n3. Finally Block:");
        try
        {
            Console.WriteLine("   Executing try block...");
            int result = Divide(10, 2);
            Console.WriteLine($"   Result: {result}");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("   Cannot divide by zero!");
        }
        finally
        {
            Console.WriteLine("   Finally block always executes");
        }
        
        // Custom exception
        Console.WriteLine("\n4. Custom Exception:");
        try
        {
            ValidateAge(-5);
        }
        catch (InvalidAgeException ex)
        {
            Console.WriteLine($"   Custom exception caught: {ex.Message}");
        }
    }
    
    private static int Divide(int a, int b) => a / b;
    
    private static void ValidateAge(int age)
    {
        if (age < 0)
            throw new InvalidAgeException($"Age cannot be negative: {age}");
    }
}

public class InvalidAgeException : Exception
{
    public InvalidAgeException(string message) : base(message) { }
}
