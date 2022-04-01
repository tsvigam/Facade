using System;
//Patterns Template Method and Facade

class FacadeBreadMaker
{
    private Mixer mixer;
    private Raiser raiser;
    private Baker baker;

    public FacadeBreadMaker()
    {
        mixer = new Mixer();
        raiser = new Raiser();
        baker = new Baker();
    }
    public void BasicWhiteBread()
    {
        Console.WriteLine("-------------------------");
        Console.WriteLine("Program Basic White Bread");
        int sumTime = 0;
        raiser.SetTime(20);
        sumTime += 20;
        raiser.Run();
        mixer.SetTime(15);
        sumTime += 10;
        mixer.Run();
        raiser.SetTime(30);
        sumTime += 30;
        raiser.Run();
        baker.SetTime(40);
        sumTime += 40;
        baker.Run();
        Console.WriteLine("-------------------------");
        Console.WriteLine("Sum time is " + sumTime);
    }
    public void BasicWhiteDought()
    {
        Console.WriteLine("-------------------------");
        Console.WriteLine("Program Basic White Dought");
        int sumTime = 0;
        raiser.SetTime(20);
        sumTime += 20;
        raiser.Run();
        mixer.SetTime(15);
        sumTime += 15;
        mixer.Run();
        raiser.SetTime(30);
        sumTime += 30;
        raiser.Run();
        Console.WriteLine("-------------------------");
        Console.WriteLine("Sum time is " + sumTime);
    }
}
abstract class Subsystem
{
    protected int Time { get; set; } = 40;

    public void SetTime(int t)
    {
        Time = t;
    }

    public void Run()
    {
        Console.WriteLine("{0} dought {1} minutes", Info(), Time);
    }
    public abstract string Info();
}

class Mixer : Subsystem
{
    public override string Info()
    {
        return "Mix ";
    }
}

class Raiser : Subsystem
{
    public override string Info()
    {
        return "Raise ";
    }
}

class Baker : Subsystem
{
    public override string Info()
    {
        return "Bake ";
    }
}

class Program
{
    static void Main(string[] args)
    {
        FacadeBreadMaker Panasonik = new FacadeBreadMaker();
        Panasonik.BasicWhiteBread();
        Panasonik.BasicWhiteDought();
    }
}

