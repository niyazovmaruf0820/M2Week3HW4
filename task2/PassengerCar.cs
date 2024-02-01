namespace task2;

public class PassengerCar : Car
{
    private int mileage;
    public PassengerCar(string name, int weight, int power, int fuel, bool doesWork, int wheels, int mileage) : base(name,weight,power,fuel,doesWork,wheels)
    {
        this.mileage = mileage;
    }
    public string MoreInfo()
    {
        System.Console.WriteLine(Info());
        return $"Mileage: {mileage}";
    }
}
