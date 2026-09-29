
public class Fish : Animal, ISwimmable
{
    public Fish(string name, int age) : base(name, age)
    {
    }
    public override string MakeSound()
    {
        return "Blub!";
    }
    public void Swim()
    {
        Console.WriteLine($"{Name} swim");
    }
}