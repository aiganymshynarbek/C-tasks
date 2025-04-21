class Person
{
    public string name;
    public int age;

    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public void sayHello()
    {
        Console.WriteLine("Привет " + name + ", " + age + "!");
    }

    public static void Main()
    {
        Console.WriteLine("Enter your name: ");
        string name = Console.ReadLine();
        
        Console.WriteLine("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        Person p = new Person(name, age);
        p.sayHello();
    }
}