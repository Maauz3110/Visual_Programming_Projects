using System;

public enum Department
{
    ComputerScience,
    ElectricalEngineering,
    MechanicalEngineering,
    CivilEngineering
}

public class Person
{
    public string Name { get; set; }

    // No-argument constructor
    public Person()
    {
        Name = null;
    }

    // Multi-argument constructor
    public Person(string name)
    {
        Name = name;
    }
}

public class Student : Person
{
    public string RegNo { get; set; }
    public int Age { get; set; }
    public Department Program { get; set; }

    // No-argument constructor
    public Student() : base()
    {
        RegNo = null;
        Age = 0;
        Program = Department.ComputerScience; // Default department
    }

    // Multi-argument constructor
    public Student(string name, string regNo, int age, Department program) : base(name)
    {
        RegNo = regNo;
        Age = age;
        Program = program;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Testing the no-argument constructor
        Student student1 = new Student();
        Console.WriteLine($"Name: {student1.Name}, RegNo: {student1.RegNo}, Age: {student1.Age}, Program: {student1.Program}");

        // Testing the multi-argument constructor
        Student student2 = new Student("John Doe", "12345", 20, Department.ElectricalEngineering);
        Console.WriteLine($"Name: {student2.Name}, RegNo: {student2.RegNo}, Age: {student2.Age}, Program: {student2.Program}");
    }
}
