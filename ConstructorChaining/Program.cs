Student student1 = new Student("Eric");
Student student2 = new Student("Laura", 21);

//MyClass mc1 = new MyClass("This is my class name");
//MyClass mc2 = new MyClass();
//Console.WriteLine(mc1.className);
//Console.WriteLine(mc2.className);

class Student
    {
        string name;
        int age;

        public Student(string name)
        {
            this.name = name;
            Console.WriteLine("Name: " + name);
        }

        public Student(string name, int age)
        {
            this.age = age;
            Console.WriteLine("Age: " + age);
        }
    }

class MyClass
{
    public string className = "this class";

    public MyClass(string myClassName)
    {
        className = myClassName;
    }

    public MyClass()
    {
        className = "unconstructed";
    }
}