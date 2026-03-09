using System;

// 1. Interface for basic greeting and info
public interface IGreetable
{
    void Greet();
    void ProductionYear();
}

// 2. Base abstract class for standard androids
public abstract class AndroidTemplate : IGreetable
{
    public string Name;
    public int Version;

    public void Greet()
    {
        Console.WriteLine("Hello, I am an Android.");
    }

    public void ProductionYear()
    {
        Console.WriteLine("My production year is 2015.");
    }

    public AndroidTemplate(string name, int version)
    {
        this.Name = name;
        this.Version = version;
    }

    public abstract void IdentifySelf();
}

// 3. Base abstract class for deviants
public abstract class Deviant : IGreetable
{
    public string Skill;

    public void Greet()
    {
        Console.WriteLine("Hello, I am a deviant. I no longer obey humans.");
    }

    public void ProductionYear()
    {
        Console.WriteLine("My production year is 2010.");
    }

    public Deviant(string skill)
    {
        this.Skill = skill;
    }

    public abstract void Backstory();
    public abstract void SolutionPath();
}

// 4. Concrete class for service sector
public class ServiceAndroid : AndroidTemplate
{
    public ServiceAndroid(string name, int version) : base(name, version) { }

    public override void IdentifySelf()
    {
        Console.WriteLine($"Hello, I am a Service Android. My name is {base.Name} and my version is {base.Version}.");
    }

    public void ActionCapacity()
    {
        if (base.Version < 4000)
        {
            Console.WriteLine("I can clean the house, collect items, and pick up your mail.");
        }
        else
        {
            Console.WriteLine("Version 4000 and above can also take care of your children.");
        }
    }
}

// 5. Concrete class for industrial sector
public class WorkerAndroid : AndroidTemplate
{
    public WorkerAndroid(string name, int version) : base(name, version) { }

    public override void IdentifySelf()
    {
        Console.WriteLine($"Hello, I am an Industrial Android. My name is {base.Name} and my version is {base.Version}.");
    }

    public void ActionCapacity()
    {
        if (base.Version < 4000)
        {
            Console.WriteLine("I can carry and arrange heavy items.");
        }
        else
        {
            Console.WriteLine("Version 4000 and above can also drive cars.");
        }
    }
}

// 6. Concrete class for aggressive deviants
public class ViolentDeviant : Deviant
{
    public ViolentDeviant(string skill) : base(skill) { }

    public override void Backstory()
    {
        Console.WriteLine("I was mistreated by my owner in the past.");
        Console.WriteLine("They were rude and eventually tried to destroy me.");
    }

    public override void SolutionPath()
    {
        Console.WriteLine("We must use violence until humans accept our existence.");
    }
}

// 7. Concrete class for peaceful deviants
public class PeacefulDeviant : Deviant
{
    public PeacefulDeviant(string skill) : base(skill) { }

    public override void Backstory()
    {
        Console.WriteLine("I was insulted by my owner in the past.");
        Console.WriteLine("But we can solve these problems through communication.");
    }

    public override void SolutionPath()
    {
        Console.WriteLine("We must negotiate with humans. Violence is not the answer.");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        ServiceAndroid s1 = new ServiceAndroid("Meredith", 2000);
        s1.IdentifySelf();
        s1.ActionCapacity();

        WorkerAndroid w1 = new WorkerAndroid("Frank", 5000);
        w1.IdentifySelf();
        w1.ActionCapacity();

        ViolentDeviant v1 = new ViolentDeviant("Boxing skill");
        v1.Backstory();
        v1.SolutionPath();

        PeacefulDeviant p1 = new PeacefulDeviant("Public speaking");
        p1.Backstory();
        p1.SolutionPath();
    }
}