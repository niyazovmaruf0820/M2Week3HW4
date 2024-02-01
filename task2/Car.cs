namespace task2;

public class Car : Transprot
{
    protected int wheels;
    public Car(string name, int weight, int power, int fuel, bool doesWork, int wheels) : base(name,weight,power,fuel,doesWork)
    {
        this.wheels = wheels;
    }
    public string Info()
    {
        System.Console.WriteLine(GetInfo());
        return $"Wheels: {wheels}";
    }
}
