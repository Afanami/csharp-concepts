namespace CSharpConcepts.Concepts.Advanced;

public class AsyncAwait
{
    public static async Task Run()
    {
        Console.WriteLine("\n=== Async/Await Pattern ===");
        
        // Simulate async operations
        Console.WriteLine("Starting async operations...");
        
        var task1 = FetchDataAsync("Data 1", 1000);
        var task2 = FetchDataAsync("Data 2", 1500);
        var task3 = FetchDataAsync("Data 3", 500);
        
        // Wait for all tasks to complete
        var results = await Task.WhenAll(task1, task2, task3);
        
        Console.WriteLine("\nAll operations completed:");
        foreach (var result in results)
        {
            Console.WriteLine($"  - {result}");
        }
    }
    
    private static async Task<string> FetchDataAsync(string name, int delayMs)
    {
        await Task.Delay(delayMs);
        return $"{name} fetched after {delayMs}ms";
    }
}
