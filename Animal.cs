public abstract class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Animal(string name, int age)
    {
        Name = name;
        Age = age;
    }
    public abstract string MakeSound();
    public virtual void Describe()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}