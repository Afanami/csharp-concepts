namespace CSharpConcepts.Concepts.Advanced;

public class Delegates
{
    // Define delegate types
    public delegate int MathOperation(int a, int b);
    public delegate void NotificationHandler(string message);
    
    public static void Run()
    {
        Console.WriteLine("\n=== Delegates and Events ===");
        
        // Using delegates
        MathOperation add = Add;
        MathOperation multiply = Multiply;
        
        Console.WriteLine($"Add: 5 + 3 = {add(5, 3)}");
        Console.WriteLine($"Multiply: 5 * 3 = {multiply(5, 3)}");
        
        // Multicast delegate
        NotificationHandler notifier = LogToConsole;
        notifier += LogToDebug;
        
        Console.WriteLine("\nSending notification:");
        notifier("System started successfully");
        
        // Using Func and Action
        Func<int, int, int> subtract = (a, b) => a - b;
        Action<string> print = msg => Console.WriteLine($"Message: {msg}");
        
        Console.WriteLine($"\nFunc delegate: 10 - 4 = {subtract(10, 4)}");
        print("Using Action delegate");
    }
    
    private static int Add(int a, int b) => a + b;
    private static int Multiply(int a, int b) => a * b;
    private static void LogToConsole(string msg) => Console.WriteLine($"[Console] {msg}");
    private static void LogToDebug(string msg) => Console.WriteLine($"[Debug] {msg}");
}
