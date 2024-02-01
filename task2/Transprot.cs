namespace task2;

public class Transprot
{
    protected string name;
    protected int weight;
    protected int power;
    protected int fuel;
    protected bool doesWork;
    protected bool IsWorking;
    public Transprot(string name, int weight, int power, int fuel, bool doesWork)
    {
        this.name = name;
        this.weight = weight;
        this.fuel = fuel;
        this.power = power;
        this.doesWork = doesWork;
    }
    public void AddFuel(int extrafuel)
    {
        fuel += extrafuel;
    }
    public void Start()
    {
        IsWorking = true;
    }
    public void Stop()
    {
        IsWorking = false;
    }
    public string GetInfo()
    {
        return $"Name: {name}\nPower: {power}\nWeight: {weight}\nDoes work: {doesWork}";
    }
}
