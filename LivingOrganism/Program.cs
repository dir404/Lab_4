using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class LivingOrganism
{
    public double Energy { get; set; }
    public int Age { get; set; }
    public double Size { get; set; }

    public LivingOrganism(double energy, int age, double size)
    {
        Energy = energy;
        Age = age;
        Size = size;
    }
}

public class Animal : LivingOrganism, IPredator, IReproducible
{
    public Animal(double energy, int age, double size) : base(energy, age, size)
    {
    }

    public void Hunt(LivingOrganism target)
    {
        // Логіка полювання
        Console.WriteLine("Тварина полює на інших організмів.");
    }

    public void Reproduce()
    {
        // Логіка розмноження тварин
        Console.WriteLine("Тварина розмножується.");
    }
}

// Клас Рослина
public class Plant : LivingOrganism, IReproducible
{
    public Plant(double energy, int age, double size) : base(energy, age, size)
    {
    }

    public void Reproduce()
    {
        // Логіка розмноження рослин
        Console.WriteLine("Рослина розмножується.");
    }
}

// Клас Мікроорганізм
public class Microorganism : LivingOrganism, IReproducible
{
    public Microorganism(double energy, int age, double size) : base(energy, age, size)
    {
    }

    public void Reproduce()
    {
        // Логіка розмноження мікроорганізмів
        Console.WriteLine("Мікроорганізм розмножується.");
    }
}

// Інтерфейс для розмноження
public interface IReproducible
{
    void Reproduce();
}

// Інтерфейс для полювання
public interface IPredator
{
    void Hunt(LivingOrganism target);
}

// Клас Екосистема
public class Ecosystem
{
    private List<LivingOrganism> organisms = new List<LivingOrganism>();

    public void AddOrganism(LivingOrganism organism)
    {
        organisms.Add(organism);
    }

    public void SimulateInteraction()
    {
        // Логіка взаємодії між організмами в екосистемі
        foreach (var organism in organisms)
        {
            if (organism is IPredator)
            {
                var predator = (IPredator)organism;
                foreach (var target in organisms)
                {
                    if (target != organism)
                    {
                        predator.Hunt(target);
                    }
                }
            }

            if (organism is IReproducible)
            {
                var reproducible = (IReproducible)organism;
                reproducible.Reproduce();
            }
        }
    }
}

class Program
{
    static void Main()
    {
        var lion = new Animal(100, 5, 1.5);
        var deer = new Animal(80, 3, 1.0);
        var tree = new Plant(50, 10, 5.0);
        var bacteria = new Microorganism(30, 1, 0.01);

        var ecosystem = new Ecosystem();
        ecosystem.AddOrganism(lion);
        ecosystem.AddOrganism(deer);
        ecosystem.AddOrganism(tree);
        ecosystem.AddOrganism(bacteria);

        ecosystem.SimulateInteraction();
        Console.ReadLine();
    }
}
