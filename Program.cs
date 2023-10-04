public abstract class Worker
{
    public string Name { get; set; }
    public string Position { get; set; }
    public int WorkDay { get; set; }

    public Worker(string name)
    {
        this.Name = name;
    }
    public Worker()
    {

    }

    public void Call()
    {

    }
    public void WriteCode()
    {

    }
    public void Relax()
    {

    }
    public abstract void FillWorkDay();

}

public class Developer : Worker
{
 
    public Developer(string name): base(name)
    {
        Position = "Розробник";
    }
    public override void FillWorkDay()
    {
        WriteCode();
        Call();
        Relax();
        WriteCode();
    }

}

public class Manager : Worker
{
    private Random random;
    public Manager(string name): base(name)
    {
        Position = "Manager";
    }
    public override void FillWorkDay()
    {
        random = new Random();
        int range_1 = random.Next(1, 11);
        int range_2 = random.Next(1, 6);
        for (int i = 0; i < range_1; i++)
        {
            Call();
        }
        Relax();
        for (int i = 0; i < range_2; i++)
        {
            Call();
        }

    }
}

public class Team
{
    private List<Worker> workers;
    private string commandName;
    public Team(string name)
    {
        commandName = name;
        workers = new List<Worker>();
    }
    public void AddWorker(Worker worker)
    {
        workers.Add(worker);
    }
    public void ShowCommandInfo()
    {
        Console.WriteLine(commandName);
        foreach (var worker in workers)
        {
            Console.WriteLine("Name of worker: " + worker.Name);
        }
    }

    public void ShowDetailCommandInfo()
    {
        Console.WriteLine(commandName);
        foreach (var worker in workers)
        {
            Console.WriteLine("<" + worker.Name + ">" + " " + "<" + worker.Position + ">" + " " + "<" + worker.WorkDay + ">");
        }
    }

}
class Program
{
    public static void Main(string[] args)
    {
        Developer dev1 = new Developer("Artem");
        Developer dev2 = new Developer("Sasha");
        Manager manager = new Manager("Anton");
        Team team = new Team("FirstTeam");
        team.AddWorker(dev1);
        team.AddWorker(dev2);
        team.AddWorker(manager);
        team.ShowCommandInfo();

    }
}