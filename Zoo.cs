

public class Zoo
{
    private List<Animal> Animals = new List<Animal>();

    public void AddAnimal(Animal a)
    {
        Animals.Add(a);
    }
    public void PerformActivities()
    {
        foreach (var animal in Animals)
        {
            Console.WriteLine($"{animal.Name}: {animal.MakeSound()}");
            if (animal is IFlyable flyable)
            {
                flyable.Fly();
            }

            if (animal is ISwimmable swimmable)
            {
                swimmable.Swim();
            }

            if (animal is not IFlyable && animal is not ISwimmable)
            {
                Console.WriteLine($"{animal.Name} Just walking");
            }

            Console.WriteLine();
        }
    }
    public void PrintCapabilityReport()
    {
        List<string> onlyFlying = new List<string>();
        List<string> onlySwimming = new List<string>();
        List<string> flyingAndSwimming = new List<string>();
        List<string> neither = new List<string>();
        foreach (var animal in Animals)
        {
            bool canFly = animal is IFlyable;
            bool canSwim = animal is ISwimmable;
            if (canFly && canSwim)
            {
                flyingAndSwimming.Add(animal.Name);
            }
            else if (canFly)
            {
                onlyFlying.Add(animal.Name);
            }
            else if (canSwim)
            {
                onlySwimming.Add(animal.Name);
            }
            else
            {
                neither.Add(animal.Name);
            }
        }
        Console.WriteLine("=== Capability Report ===");
        Console.WriteLine("Cna fly:");
        Console.WriteLine(string.Join(", ", onlyFlying));
        Console.WriteLine("Can swim:");
        Console.WriteLine(string.Join(", ", onlySwimming));
        Console.WriteLine("Can fly and swim:");
        Console.WriteLine(string.Join(", ", flyingAndSwimming));
        Console.WriteLine("Can't fly and swim:");
        Console.WriteLine(string.Join(", ", neither));
    }

}
