namespace CSharpConcepts.Concepts.LINQ;

public class LinqExamples
{
    public static void Run()
    {
        Console.WriteLine("\n=== LINQ Examples ===");
        
        // Create a list of numbers
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        
        // Filter even numbers
        var evenNumbers = numbers.Where(n => n % 2 == 0);
        Console.WriteLine($"Even numbers: {string.Join(", ", evenNumbers)}");
        
        // Select squares
        var squares = numbers.Select(n => n * n);
        Console.WriteLine($"Squares: {string.Join(", ", squares)}");
        
        // Find sum
        int sum = numbers.Sum();
        Console.WriteLine($"Sum: {sum}");
    }
}
