Developer myDev = new Developer("Eric", "C#");
myDev.Work();
Employee myEmp = new Employee("Cappy");
myEmp.Work();

public class Employee
{
    public string Name { get; set; }

    // Base constructor
    public Employee(string name)
    {
        Name = name;
    }

    // Virtual method allowed to be rewritten
    public virtual void Work()
    {
        Console.WriteLine($"{Name} is working.");
    }
}

public class Developer : Employee
{
    public string ProgrammingLanguage { get; set; }

    // Forwarding "name" to the base Employee constructor
    public Developer(string name, string language) : base(name)
    {
        ProgrammingLanguage = language;
    }

    // Overriding the base method
    public override void Work()
    {
        // Optional: Call the base method logic first
        base.Work(); 
        
        Console.WriteLine($"{Name} is writing {ProgrammingLanguage} code.");
    }
}