namespace CSharpConcepts.Concepts.OOP;

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
    
    public void Introduce()
    {
        Console.WriteLine($"Hi, I'm {Name} and I'm {Age} years old.");
    }
    
    public static void Run()
    {
        Console.WriteLine("\n=== Object-Oriented Programming ===");
        
        Person person1 = new Person("Alice", 25);
        Person person2 = new Person("Bob", 32);
        
        person1.Introduce();
        person2.Introduce();
    }
}
