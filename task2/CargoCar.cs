namespace task2;

public class CargoCar : Car
{
    private int ton;
    public CargoCar(string name, int weight, int power, int fuel, bool doesWork, int wheels, int ton) : base(name,weight,power,fuel,doesWork,wheels)
    {
        this.ton = ton;
    }
    public string MoreInfo()
    {
        System.Console.WriteLine(Info());
        return $"Ton: {ton}";
    }
}
