
public class Duck : Animal, IFlyable, ISwimmable
{
    public Duck(string name, int age) : base(name, age)
    {
    }

    public override string MakeSound()
    {
        return "Quack!";
    }

    public void Fly()
    {
        Console.WriteLine($"{Name} fly");
    }

    public void Swim()
    {
        Console.WriteLine($"{Name} swim");
    }
}