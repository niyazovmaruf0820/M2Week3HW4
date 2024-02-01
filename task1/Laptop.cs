namespace task1;

public class Laptop : Computer
{
    private int weight;
    public Laptop(int ram, int storage, string keyboard, int weight) : base(ram,storage,keyboard)
    {
        this.weight = weight;
    }
    public void WeightChek()
    {
        System.Console.WriteLine($"This laptop's weight is {weight}kg");
    }   
}
