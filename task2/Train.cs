namespace task2;

public class Train : Transprot
{
    protected int vagons;
    public Train(string name, int weight, int power, int fuel, bool doesWork, int vagons) : base(name,weight,power,fuel,doesWork)
    {
        this.vagons = vagons;
    }
    public string Info()
    {
        System.Console.WriteLine(GetInfo());
        return $"Vagons: {vagons}";
    }
}
