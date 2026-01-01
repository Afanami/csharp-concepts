namespace CSharpConcepts.Concepts.DeepDives;

public class Collections
{
    public static void Run()
    {
        Console.WriteLine("\n=== Deep Dive: Collections ===");
        
        // List<T> - Dynamic array
        Console.WriteLine("\n1. List<T>:");
        List<string> fruits = new List<string> { "Apple", "Banana", "Cherry" };
        fruits.Add("Date");
        Console.WriteLine($"   Fruits: {string.Join(", ", fruits)}");
        Console.WriteLine($"   Count: {fruits.Count}, Capacity: {fruits.Capacity}");
        
        // Dictionary<TKey, TValue> - Key-value pairs
        Console.WriteLine("\n2. Dictionary<TKey, TValue>:");
        Dictionary<string, int> scores = new Dictionary<string, int>
        {
            { "Alice", 95 },
            { "Bob", 87 },
            { "Charlie", 92 }
        };
        Console.WriteLine($"   Bob's score: {scores["Bob"]}");
        
        // HashSet<T> - Unique elements
        Console.WriteLine("\n3. HashSet<T>:");
        HashSet<int> uniqueNumbers = new HashSet<int> { 1, 2, 3, 4, 5 };
        uniqueNumbers.Add(3); // Won't add duplicate
        Console.WriteLine($"   Unique numbers: {string.Join(", ", uniqueNumbers)}");
        
        // Queue<T> - FIFO
        Console.WriteLine("\n4. Queue<T> (FIFO):");
        Queue<string> taskQueue = new Queue<string>();
        taskQueue.Enqueue("Task 1");
        taskQueue.Enqueue("Task 2");
        taskQueue.Enqueue("Task 3");
        Console.WriteLine($"   Processing: {taskQueue.Dequeue()}");
        Console.WriteLine($"   Next: {taskQueue.Peek()}");
        
        // Stack<T> - LIFO
        Console.WriteLine("\n5. Stack<T> (LIFO):");
        Stack<string> history = new Stack<string>();
        history.Push("Page 1");
        history.Push("Page 2");
        history.Push("Page 3");
        Console.WriteLine($"   Back to: {history.Pop()}");
        Console.WriteLine($"   Current: {history.Peek()}");
    }
}
